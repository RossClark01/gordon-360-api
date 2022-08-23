﻿using Gordon360.Authorization;
using Gordon360.Models.CCT;
using Gordon360.Models.CCT.Context;
using Gordon360.Models.ViewModels;
using Gordon360.Services;
using Gordon360.Static.Names;
using Gordon360.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Gordon360.Controllers
{
    [Route("api/[controller]")]
    public class ProfilesController : GordonControllerBase
    {
        private readonly IProfileService _profileService;
        private readonly IAccountService _accountService;
        private readonly IConfiguration _config;

        public ProfilesController(IProfileService profileService, IAccountService accountService, IConfiguration config)
        {
            _profileService = profileService;
            _accountService = accountService;
            _config = config;
        }

        /// <summary>Get profile info of currently logged in user</summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public ActionResult<ProfileViewModel?> Get()
        {
            var authenticatedUserUsername = AuthUtils.GetUsername(User);

            var student = _profileService.GetStudentProfileByUsername(authenticatedUserUsername);
            var faculty = _profileService.GetFacultyStaffProfileByUsername(authenticatedUserUsername);
            var alumni = _profileService.GetAlumniProfileByUsername(authenticatedUserUsername);
            var customInfo = _profileService.GetCustomUserInfo(authenticatedUserUsername);

            if (student is null && alumni is null && faculty is null)
            {
                return Ok(null);
            }

            var profile = _profileService.ComposeProfile(student, alumni, faculty, customInfo);

            return Ok(profile);
        }

        /// <summary>Get public profile info for a user</summary>
        /// <param name="username">username of the profile info</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{username}")]
        public ActionResult<ProfileViewModel?> GetUserProfile(string username)
        {
            var viewerGroups = AuthUtils.GetGroups(User);

            var _student = _profileService.GetStudentProfileByUsername(username);
            var _faculty = _profileService.GetFacultyStaffProfileByUsername(username);
            var _alumni = _profileService.GetAlumniProfileByUsername(username);
            var _customInfo = _profileService.GetCustomUserInfo(username);

            object? student = null;
            object? faculty = null;
            object? alumni = null;

            if (viewerGroups.Contains(AuthGroup.SiteAdmin) || viewerGroups.Contains(AuthGroup.Police))
            {
                student = _student;
                faculty = _faculty;
                alumni = _alumni;
            }
            else if (viewerGroups.Contains(AuthGroup.FacStaff))
            {
                student = _student;
                faculty = _faculty == null ? null : (PublicFacultyStaffProfileViewModel)_faculty;
                alumni = _alumni == null ? null : (PublicAlumniProfileViewModel)_alumni;
            }
            else if (viewerGroups.Contains(AuthGroup.Student))
            {
                student = _student == null ? null : (PublicStudentProfileViewModel)_student;
                faculty = _faculty == null ? null : (PublicFacultyStaffProfileViewModel)_faculty;
                alumni = null;  //student can't see alumini
            }

            if (student is null && alumni is null && faculty is null)
            {
                return Ok(null);
            }

            var profile = _profileService.ComposeProfile(student, alumni, faculty, _customInfo);

            return Ok(profile);
        }

        ///<summary>Get the advisor(s) of a particular student</summary>
        /// <returns>
        /// All advisors of the given student.  For each advisor,
        /// provides first name, last name, and username.
        /// </returns>
        [HttpGet]
        [Route("Advisors/{username}")]
        public async Task<ActionResult<IEnumerable<AdvisorViewModel>>> GetAdvisorsAsync(string username)
        {
            var advisors = await _profileService.GetAdvisorsAsync(username);

            return Ok(advisors);
        }

        /// <summary> Gets the clifton strengths of a particular user </summary>
        /// <param name="username"> The username for which to retrieve info </param>
        /// <returns> Clifton strengths of the given user. </returns>
        [HttpGet]
        [Route("clifton/{username}")]
        [StateYourBusiness(operation = Operation.READ_ONE, resource = Resource.PROFILE)]
        public ActionResult<string[]> GetCliftonStrengths_DEPRECATED(string username)
        {
            var id = _accountService.GetAccountByUsername(username).GordonID;
            var strengths = _profileService.GetCliftonStrengths(int.Parse(id));

            return Ok(strengths?.Themes ?? Array.Empty<string>());
        }


        /// <summary> Gets the clifton strengths of a particular user </summary>
        /// <param name="username"> The username for which to retrieve info </param>
        /// <returns> Clifton strengths of the given user. </returns>
        [HttpGet]
        [Route("{username}/clifton")]
        [StateYourBusiness(operation = Operation.READ_ONE, resource = Resource.PROFILE)]
        public ActionResult<CliftonStrengthsViewModel?> GetCliftonStrengths(string username)
        {
            var id = _accountService.GetAccountByUsername(username).GordonID;
            var strengths = _profileService.GetCliftonStrengths(int.Parse(id));

            return Ok(strengths);
        }

        /// <summary>Toggle privacy of the current user's Clifton Strengths</summary>
        /// <returns>New privacy value</returns>
        [HttpGet]
        [Route("clifton/privacy")]
        [StateYourBusiness(operation = Operation.UPDATE, resource = Resource.PROFILE)]
        public async Task<ActionResult<bool>> ToggleCliftonStrengthsPrivacyAsync()
        {
            var username = AuthUtils.GetUsername(User);
            var id = _accountService.GetAccountByUsername(username).GordonID;
            var privacy = await _profileService.ToggleCliftonStrengthsPrivacyAsync(int.Parse(id));

            return Ok(privacy);
        }

        /// <summary> Gets the emergency contact information of a particular user </summary>
        /// <param name="username"> The username for which to retrieve info </param>
        /// <returns> Emergency contact information of the given user. </returns>
        [HttpGet]
        [Route("emergency-contact/{username}")]
        [StateYourBusiness(operation = Operation.READ_ONE, resource = Resource.EMERGENCY_CONTACT)]
        public ActionResult<EmergencyContactViewModel> GetEmergencyContact(string username)
        {
            try
            {
                var emrg = _profileService.GetEmergencyContact(username);
                return Ok(emrg);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return NotFound();
            }
        }

        /// <summary>Gets the mailbox information of currently logged in user</summary>
        /// <returns></returns>
        [HttpGet]
        [Route("mailbox-combination")]
        public ActionResult<MailboxViewModel> GetMailInfo()
        {
            var username = AuthUtils.GetUsername(User);

            var result = _profileService.GetMailboxCombination(username);
            return Ok(result);
        }

        /// <summary>Gets the date of birth of the current logged-in user</summary>
        /// <returns></returns>
        [HttpGet]
        [Route("birthdate")]
        public ActionResult<DateTime> GetBirthdate()
        {
            var username = AuthUtils.GetUsername(User);

            var result = _profileService.GetBirthdate(username);
            return Ok(result);
        }

        /// <summary>Get the profile image of currently logged in user</summary>
        /// <returns></returns>
        [HttpGet]
        [Route("image")]
        public async Task<ActionResult<JObject>> GetMyImgAsync()
        {
            var username = AuthUtils.GetUsername(User);
            var photoModel = await _profileService.GetPhotoPathAsync(username);
            JObject result = new JObject();

            if (photoModel == null) //There is no preferred or ID image
            {
                var unapprovedFileName = username + "_" + _accountService.GetAccountByUsername(username).account_id;
                var unapprovedFilePath = _config["DEFAULT_ID_SUBMISSION_PATH"];
                string extension = "";
                foreach (var file in Directory.GetFiles(unapprovedFilePath, unapprovedFileName + ".*"))
                {
                    extension = Path.GetExtension(file);
                }
                string unapproved_img = await GetProfileImageOrDefault(unapprovedFilePath + unapprovedFileName + extension);
                result.Add("def", unapproved_img);
                return Ok(result);
            }

            string prefImgPath = _config["PREFERRED_IMAGE_PATH"] + photoModel.Pref_Img_Name;

            if (string.IsNullOrEmpty(photoModel.Pref_Img_Name) || !System.IO.File.Exists(prefImgPath)) //check file existence for prefferred image.
            {
                var defaultImgPath = _config["DEFAULT_IMAGE_PATH"] + photoModel.Img_Name;
                result.Add("def", await GetProfileImageOrDefault(defaultImgPath));
                return Ok(result);
            }
            else
            {
                result.Add("pref", await GetProfileImageOrDefault(prefImgPath));
                return Ok(result);
            }
        }

        /// <summary>Get the profile image of the given user</summary>
        /// <returns>The profile image(s) that the authenticated user is allowed to see, if any</returns>
        [HttpGet]
        [Route("image/{username}")]
        public async Task<ActionResult<JObject>> GetImgAsync(string username)
        {
            var photoInfo = await _profileService.GetPhotoPathAsync(username);
            JObject result = new JObject();

            //return default image if no photo info found for this user.
            if (photoInfo == null)
            {
                result.Add("def", await ImageUtils.DownloadImageFromURL(_config["DEFAULT_PROFILE_IMAGE_PATH"]));
                return Ok(result);
            }

            var preferredImagePath = string.IsNullOrEmpty(photoInfo.Pref_Img_Name) ? null : _config["PREFERRED_IMAGE_PATH"] + photoInfo.Pref_Img_Name;
            var defaultImagePath = _config["DEFAULT_IMAGE_PATH"] + photoInfo.Img_Name;

            var viewerGroups = AuthUtils.GetGroups(User);
            if (viewerGroups.Contains(AuthGroup.FacStaff))
            {
                if (preferredImagePath is not null && System.IO.File.Exists(preferredImagePath))
                {
                    result.Add("pref", await GetProfileImageOrDefault(preferredImagePath));
                }
                result.Add("def", await GetProfileImageOrDefault(defaultImagePath));
                return Ok(result);

            }
            else
            if (viewerGroups.Contains(AuthGroup.Student))
            {
                if (_accountService.GetAccountByUsername(username).show_pic == 1)
                {
                    if (preferredImagePath is not null && System.IO.File.Exists(preferredImagePath))
                    {
                        result.Add("pref", await GetProfileImageOrDefault(preferredImagePath));
                    }
                    else
                    {
                        result.Add("def", await GetProfileImageOrDefault(defaultImagePath));
                    }
                }
                else
                {
                    result.Add("def", await ImageUtils.DownloadImageFromURL(_config["DEFAULT_PROFILE_IMAGE_PATH"]));
                }
                return Ok(result);
            }
            else
            {
                return Ok();
            }
        }

        /// <summary>
        /// Set an image for profile
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("image")]
        public async Task<ActionResult> PostImageAsync([FromForm] IFormFile image)
        {
            var username = AuthUtils.GetUsername(User);
            var account = _accountService.GetAccountByUsername(username);
            var pathInfo = await _profileService.GetPhotoPathAsync(username);

            if (pathInfo == null) // can't upload image if there is no record for this user in the database
                return NotFound("No photo record was found for this user.");

            var (extension, _) = ImageUtils.GetImageFormat(image);
            var fileName = $"{account.Barcode}.{extension}";

            // If there is an old photo that won't get overwritten, delete the old photo
            if (pathInfo.Pref_Img_Name is string oldName
                && oldName != fileName
                && pathInfo.Pref_Img_Path is string oldPath
                && Path.Combine(oldPath, oldName) is string oldFile
                && System.IO.File.Exists(oldFile))
            {
                System.IO.File.Delete(oldFile);
            }

            var filePath = Path.Combine(_config["PREFERRED_IMAGE_PATH"], fileName);

            ImageUtils.UploadImageAsync(filePath, image);

            await _profileService.UpdateProfileImageAsync(username, _config["DATABASE_IMAGE_PATH"], fileName);

            return Ok();
        }

        /// <summary>
        /// Set an IDimage for a user
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("IDimage")]
        public async Task<ActionResult> PostIDImageAsync([FromForm] IFormFile image)
        {
            if (image.Length < 3000)
            {
                return BadRequest("The ID image was lost in transit. Resubmission should attempt automatically.");
            }

            var username = AuthUtils.GetUsername(User);
            var root = _config["DEFAULT_ID_SUBMISSION_PATH"];
            var account = _accountService.GetAccountByUsername(username);

            //delete old image file if it exists.
            DirectoryInfo di = new DirectoryInfo(root);
            foreach (FileInfo file in di.GetFiles($"{username}_{account.account_id}.*"))
            {
                file.Delete();
            }

            var (extension, _) = ImageUtils.GetImageFormat(image);
            var fileName = $"{username}_{account.account_id}.{extension}";
            var filePath = Path.Combine(root, fileName);

            using var stream = System.IO.File.Create(filePath);
            await image.CopyToAsync(stream);

            return Ok();
        }

        /// <summary>
        /// Reset the profile Image
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("image/reset")]
        public async Task<ActionResult> ResetImage()
        {
            var authenticatedUserUsername = AuthUtils.GetUsername(User);
            var photoInfo = await _profileService.GetPhotoPathAsync(authenticatedUserUsername);

            if (!string.IsNullOrEmpty(photoInfo?.Pref_Img_Name))
            {
                System.IO.File.Delete(Path.Combine(_config["PREFERRED_IMAGE_PATH"], photoInfo.Pref_Img_Name));
            }

            await _profileService.UpdateProfileImageAsync(authenticatedUserUsername, null, null);
            return Ok();
        }

        /// <summary>
        /// Update the profile social media links
        /// </summary>
        /// <param name="type">The type of social media</param>
        /// <param name="path">The path of the links</param>
        /// <returns></returns>
        [HttpPut]
        [Route("{type}")]
        public async Task<ActionResult> UpdateLinkAsync(string type, CUSTOM_PROFILE path)
        {
            var authenticatedUserUsername = AuthUtils.GetUsername(User);

            await _profileService.UpdateProfileLinkAsync(authenticatedUserUsername, type, path);

            return Ok();
        }

        /// <summary>
        /// Update mobile phone number
        /// </summary>
        /// <param name="value">phoneNumber</param>
        /// <returns></returns>
        [HttpPut]
        [Route("mobile_phone_number/{value}")]
        public async Task<ActionResult<StudentProfileViewModel>> UpdateMobilePhoneNumber(string value)
        {
            var username = AuthUtils.GetUsername(User);
            var result = await _profileService.UpdateMobilePhoneNumberAsync(username, value);

            return Ok(result);
        }

        /// <summary>
        /// Update privacy of mobile phone number
        /// </summary>
        /// <param name="value">Y or N</param>
        /// <returns></returns>
        [HttpPut]
        [Route("mobile_privacy/{value}")]
        public async Task<ActionResult> UpdateMobilePrivacyAsync(string value)
        {
            var authenticatedUserUsername = AuthUtils.GetUsername(User);
            await _profileService.UpdateMobilePrivacyAsync(authenticatedUserUsername, value);

            return Ok();
        }

        /// <summary>
        /// Update privacy of profile image
        /// </summary>
        /// <param name="value">Y or N</param>
        /// <returns></returns>
        [HttpPut]
        [Route("image_privacy/{value}")]
        public async Task<ActionResult> UpdateImagePrivacyAsync(string value)
        {
            var authenticatedUserUsername = AuthUtils.GetUsername(User);
            await _profileService.UpdateImagePrivacyAsync(authenticatedUserUsername, value);

            return Ok();
        }
        /// <summary>
        /// Posts fields into CCT.dbo.Information_Change_Request 
        /// Sends Alumni Profile Update Email to "devrequest@gordon.edu"
        /// </summary>
        /// <param name="updatedFields">Object with Field's Name and Field's Value, unused Field's Label</param>
        /// <returns></returns>
        [HttpPost]
        [Route("update")]
        public async Task<ActionResult> RequestUpdate(ProfileFieldViewModel[] updatedFields)
        {
            var authenticatedUserUsername = AuthUtils.GetUsername(User);
            await _profileService.InformationChangeRequest(authenticatedUserUsername, updatedFields);
            return Ok();
        }



        /// <summary>
        /// Gets the profile image at the given path or, if that file does not exist, the 360 default profile image
        /// </summary>
        /// <remarks>
        /// Note that the 360 default profile image is different from a user's default image.
        /// A given user's default image is simply their approved ID photo.
        /// The 360 default profile image, on the other hand, is a stock image of Scottie Lion.
        /// Hence, the 360 default profile image is only used when no other image exists (or should be displayed) for a user.
        /// </remarks>
        /// <param name="imagePath">Path to the profile image to load</param>
        /// <returns></returns>
        private async Task<string> GetProfileImageOrDefault(string imagePath)
        {
            try
            {
                // User's profile images (both preferred and default) are stored in the GO site's filesystem.
                // Hence, we access them via the network file share, the same way we would access a local file
                return ImageUtils.RetrieveImageFromPath(imagePath);
            }
            catch (FileNotFoundException)
            {
                // The 360 default profile image path is a URL, so we have to download it over an HTTP connection
                return await ImageUtils.DownloadImageFromURL(_config["DEFAULT_PROFILE_IMAGE_PATH"]);
            }
        }
    }
}
