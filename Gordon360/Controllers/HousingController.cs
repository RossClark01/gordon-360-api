using Gordon360.Authorization;
using Gordon360.Enums;
using Gordon360.Models.CCT;
using Gordon360.Models.CCT.Context;
using Gordon360.Models.ViewModels;
using Gordon360.Services;
using Gordon360.Static.Methods;
using Gordon360.Static.Names;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;
using System.Collections.Generic;

namespace Gordon360.Controllers;

[Route("api/[controller]")]
public class HousingController(CCTContext context, IProfileService profileService, IHousingService housingService) : GordonControllerBase
{

    /// <summary>
    /// Delete an application (and consequently all rows that reference it)
    /// </summary>
    /// <param name="applicationID"> The id of the application to remove </param>
    /// <returns></returns>
    [HttpDelete]
    [Route("apartment/applications/{applicationID}")]
    [StateYourBusiness(operation = Operation.DELETE, resource = Resource.HOUSING)]
    public ActionResult<bool> DeleteApplication(int applicationID)
    {
        bool result = housingService.DeleteApplication(applicationID);
        return Ok(result);
    }


    /// <summary>
    /// Get a list of the apartment-style halls
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("halls/apartments")]
    public ActionResult<string[]> GetApartmentHalls()
    {
        var result = housingService.GetAllApartmentHalls();
        if (result != null)
        {
            return Ok(result);
        }
        else
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Get a list of the traditional halls
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("halls/traditionals")]
    public ActionResult<string[]> GetTraditionalHalls()
    {
        var result = housingService.GetAllTraditionalHalls();
        if (result != null)
        {
            return Ok(result);
        }
        else
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Get apartment application ID number of currently logged in user if that user is on an existing application
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("apartment")]
    public ActionResult<int?> GetApplicationID()
    {
        var authenticatedUserUsername = AuthUtils.GetUsername(User);

        string sessionID = Helpers.GetCurrentSession(context);

        int? result = housingService.GetApplicationID(authenticatedUserUsername, sessionID);
        if (result != null)
        {
            return Ok(result);
        }
        else
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Get apartment application ID number for a user if that user is on an existing application
    /// </summary>
    /// <param name="username">username of the profile info</param>
    /// <returns></returns>
    [HttpGet]
    [Route("apartment/{username}")]
    public ActionResult<int?> GetUserApplicationID(string username)
    {
        string sessionID = Helpers.GetCurrentSession(context);

        int? result = housingService.GetApplicationID(username, sessionID);
        if (result != null)
        {
            return Ok(result);
        }
        else
        {
            return NotFound();
        }
    }

    /// <summary>
    /// save application
    /// </summary>
    /// <returns>Returns the application ID number if all the queries succeeded</returns>
    [HttpPost]
    [Route("apartment/applications")]
    [StateYourBusiness(operation = Operation.ADD, resource = Resource.HOUSING)]
    public ActionResult<int> SaveApplication([FromBody] ApartmentApplicationViewModel applicationDetails)
    {
        string sessionID = Helpers.GetCurrentSession(context);

        string editorUsername = applicationDetails.EditorProfile?.AD_Username ?? applicationDetails.EditorUsername;

        var apartmentApplicants = applicationDetails.Applicants;
        foreach (ApartmentApplicantViewModel applicant in apartmentApplicants)
        {
            if (applicant.Profile == null)
            {
                applicant.Profile = profileService.GetStudentProfileByUsername(applicant.Username);
            }
        }

        int result = housingService.SaveApplication(sessionID, editorUsername, apartmentApplicants, applicationDetails.ApartmentChoices);

        return Created("Status of application saving: ", result);
    }

    /// <summary>
    /// update existing application (Differentiated by HttpPut instead of HttpPost)
    /// </summary>
    /// <returns>Returns the application ID number if all the queries succeeded</returns>
    [HttpPut]
    [Route("apartment/applications/{applicationID}")]
    [StateYourBusiness(operation = Operation.UPDATE, resource = Resource.HOUSING)]
    public ActionResult<int> EditApplication(int applicationID, [FromBody] ApartmentApplicationViewModel applicationDetails)
    {
        var authenticatedUserUsername = AuthUtils.GetUsername(User);

        string sessionID = Helpers.GetCurrentSession(context);

        string newEditorUsername = applicationDetails.EditorProfile?.AD_Username ?? applicationDetails.EditorUsername;

        var newApartmentApplicants = applicationDetails.Applicants;
        foreach (ApartmentApplicantViewModel applicant in newApartmentApplicants)
        {
            if (applicant.Profile == null)
            {
                applicant.Profile = profileService.GetStudentProfileByUsername(applicant.Username);
            }
        }

        int result = housingService.EditApplication(authenticatedUserUsername, sessionID, applicationID, newEditorUsername, newApartmentApplicants, applicationDetails.ApartmentChoices);

        return Created("Status of application saving: ", result);
    }

    /// <summary>
    /// change the editor (i.e. primary applicant) of the application
    /// </summary>
    /// <returns>The result of changing the editor</returns>
    [HttpPut]
    [Route("apartment/applications/{applicationID}/editor")]
    public ActionResult<bool> ChangeEditor(int applicationID, [FromBody] ApartmentApplicationViewModel applicationDetails)
    {
        //get token data from context, username is the username of current logged in person
        var authenticatedUserUsername = AuthUtils.GetUsername(User);

        string newEditorUsername = applicationDetails.EditorProfile?.AD_Username ?? applicationDetails.EditorUsername;

        bool result = housingService.ChangeApplicationEditor(authenticatedUserUsername, applicationID, newEditorUsername);

        return Ok(result);
    }

    /// <summary>
    /// change the date an application was submitted
    /// (changes it from null the first time they submit)
    /// </summary>
    /// <returns>The result of changing the date submitted</returns>
    [HttpPut]
    [Route("apartment/applications/{applicationID}/submit")]
    [StateYourBusiness(operation = Operation.UPDATE, resource = Resource.HOUSING)]
    public ActionResult<bool> ChangeApplicationDateSubmitted(int applicationID)
    {
        bool result = housingService.ChangeApplicationDateSubmitted(applicationID);
        return Ok(result);
    }

    /// <summary>Get apartment application info for a given application ID number</summary>
    /// <param name="applicationID">application ID number of the apartment application</param>
    /// <returns>Object of type ApartmentAppViewModel</returns>
    [HttpGet]
    [Route("apartment/applications/{applicationID}")]
    [StateYourBusiness(operation = Operation.READ_ONE, resource = Resource.HOUSING)]
    public ActionResult<ApartmentApplicationViewModel> GetApartmentApplication(int applicationID)
    {
        //get token data from context, username is the username of current logged in person
        var authenticatedUserUsername = AuthUtils.GetUsername(User);
        var authGroups = AuthUtils.GetGroups(User);

        var isHousingAdmin = housingService.CheckIfHousingAdmin(authenticatedUserUsername);
        bool isAdmin = authGroups.Contains(AuthGroup.SiteAdmin) || isHousingAdmin;

        ApartmentApplicationViewModel result = housingService.GetApartmentApplication(applicationID, isAdmin);
        if (result != null)
        {
            return Ok(result);
        }
        else
        {
            return NotFound();
        }
    }

    /// <summary>Get apartment application info for all applications if the current user is a housing admin</summary>
    /// <returns>Object of type ApartmentApplicationViewModel</returns>
    [HttpGet]
    [Route("admin/apartment/applications/")]
    [StateYourBusiness(operation = Operation.READ_ALL, resource = Resource.HOUSING)]
    public ActionResult<ApartmentApplicationViewModel[]> GetAllApartmentApplication()
    {
        //get token data from context, username is the username of current logged in person
        var authenticatedUserIdString = User.FindFirst(ClaimTypes.NameIdentifier).Value;

        
        ApartmentApplicationViewModel[] result = housingService.GetAllApartmentApplication();
        if (result != null)
        {
            return Ok(result);
        }
        else
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update roommate information
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    [Route("lottery/roommate/{application_id}")]
    public async Task<ActionResult> UpdateRoommate(string application_id, string[] emailList)
    {
        var username = AuthUtils.GetUsername(User);
        await housingService.UpdateRoommateAsync(username, application_id, emailList);
        return Ok();
    }

    /// <summary>
    /// Update preferred hall information
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    [Route("lottery/hall/{application_id}")]
    public ActionResult UpdatePreferredHall(string application_id, string[] hallList)
    {
        var username = AuthUtils.GetUsername(User);
        housingService.UpdateHall(username, application_id, hallList);
        return Ok();
    }

    /// <summary>
    /// Update preference information
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    [Route("lottery/preference/{application_id}")]
    public ActionResult UpdatePreference(string application_id, string[] preferenceList)
    {
        var username = AuthUtils.GetUsername(User);
        housingService.UpdatePreference(username, application_id, preferenceList);
        return Ok();
    }

    /// <summary>
    /// Update due date of housing application
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    [Route("lottery/due_date/{dueDate}")]
    public async Task<ActionResult> UpdateDueDateAsync(string dueDate)
    {
        var viewerGroups = AuthUtils.GetGroups(User);
        if (!viewerGroups.Contains(AuthGroup.HousingAdmin))
        {
            return Unauthorized();
        }
        await housingService.UpdateDueDateAsync(dueDate);
        return Ok();
    }

    /// <summary>
    /// Remove "myself" from the current application
    /// </summary>
    /// <returns></returns>
    [HttpDelete]
    [Route("lottery/remove_user")]
    public ActionResult<bool> RemoveUser()
    {
        var username = AuthUtils.GetUsername(User);
        bool result = housingService.RemoveUser(username);
        return Ok(result);
    }

    /// <summary>
    /// Get an array of preferences
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("lottery/preference")]
    public ActionResult<Preference[]> GetAllPreference()
    {
        var viewerGroups = AuthUtils.GetGroups(User);
        if (!viewerGroups.Contains(AuthGroup.HousingAdmin))
        {
            return Unauthorized();
        }

        var result = housingService.GetAllPreference();
        return Ok(result);
    }

    /// <summary>
    /// Get the preferences of a particular user
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("lottery/user_preference/")]
    public ActionResult<Preference[]> GetUserPreference()
    {
        var username = AuthUtils.GetUsername(User);
        var result = housingService.GetUserPreference(username);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }

    /// <summary>
    /// Get an array of preferred halls
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("lottery/preferred_hall")]
    public ActionResult<PreferredHall[]> GetAllPreferredHall()
    {
        var viewerGroups = AuthUtils.GetGroups(User);
        if (!viewerGroups.Contains(AuthGroup.HousingAdmin))
        {
            return Unauthorized();
        }

        var result = housingService.GetAllPreferredHall();
        return Ok(result);
    }

    /// <summary>
    /// Get the preferred halls of a particular user
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("lottery/user_preferred_hall/")]
    public ActionResult<Preference[]> GetUserPreferredHall()
    {
        var username = AuthUtils.GetUsername(User);
        var result = housingService.GetUserPreferredHall(username);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }

    /// <summary>
    /// Get an array of applicant
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("lottery/applicant")]
    public ActionResult<Applicant[]> GetAllApplicant()
    {
        var viewerGroups = AuthUtils.GetGroups(User);
        if (!viewerGroups.Contains(AuthGroup.HousingAdmin))
        {
            return Unauthorized();
        }

        var result = housingService.GetAllApplicant();
        return Ok(result);
    }

    /// <summary>
    /// Get the roommates of a particular user
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("lottery/user_roommate/")]
    public ActionResult<Applicant[]> GetUserRoommate()
    {
        var username = AuthUtils.GetUsername(User);
        var result = housingService.GetUserRoommate(username);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }

    /// <summary>
    /// Get an array of school years
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("lottery/school_year")]
    public ActionResult<Year[]> GetAllSchoolYear()
    {
        var viewerGroups = AuthUtils.GetGroups(User);
        if (!viewerGroups.Contains(AuthGroup.HousingAdmin))
        {
            return Unauthorized();
        }

        var result = housingService.GetAllSchoolYear();
        return Ok(result);
    }

    /// <summary>
    /// Get due date of housing application
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("lottery/due_date/")]
    public ActionResult<string> GetDueDate()
    {
        var result = housingService.GetDueDate();
        return Ok(result);
    }
}
