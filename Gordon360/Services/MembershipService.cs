﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gordon360.Models;
using Gordon360.Models.ViewModels;
using Gordon360.Repositories;
using Gordon360.Services.ComplexQueries;
using System.Data.SqlClient;
using System.Data;

namespace Gordon360.Services
{
    /// <summary>
    /// Service Class that facilitates data transactions between the MembershipsController and the Membership database model.
    /// </summary>
    public class MembershipService : IMembershipService
    {
        private IUnitOfWork _unitOfWork;

        public MembershipService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Adds a new Membership record to storage. Since we can't establish foreign key constraints and relationships on the database side,
        /// we do it here by using the membershipIsValid() method.
        /// </summary>
        /// <param name="membership">The membership to be added</param>
        /// <returns>The newly added Membership object</returns>
        public MEMBERSHIP Add(MEMBERSHIP membership)
        {
            // membershipIsValid() returns a boolean value.
            var isValidMembership = membershipIsValid(membership);
            
            if(!isValidMembership)
            {
                return null;
            }

            // The Add() method returns the added membership.
            var payload = _unitOfWork.MembershipRepository.Add(membership);
            _unitOfWork.Save();

            return payload;

        }

        /// <summary>
        /// Delete the membership whose id is specified by the parameter.
        /// </summary>
        /// <param name="id">The membership id</param>
        /// <returns>The membership that was just deleted</returns>
        public MEMBERSHIP Delete(int id)
        {
            var result = _unitOfWork.MembershipRepository.GetById(id);
            if (result == null)
            {
                // Controller checks for nulls and returns NotFound() when it sees one returned by a service.
                return null;
            }
            result = _unitOfWork.MembershipRepository.Delete(result);

            _unitOfWork.Save();

            return result;
        }

        /// <summary>
        /// Fetch the membership whose id is specified by the parameter
        /// </summary>
        /// <param name="id">The membership id</param>
        /// <returns>MembershipViewModel if found, null if not found</returns>
        public MembershipViewModel Get(int id)
        {
            var query = _unitOfWork.MembershipRepository.GetById(id);
            if (query == null)
            {
                return null;
            }

            var idParam = new SqlParameter("@MEMBERSHIP_ID", id);
            var result = RawSqlQuery<MembershipViewModel>.query("MEMBERSHIPS_PER_MEMBERSHIP_ID @MEMBERSHIP_ID", idParam).FirstOrDefault();

            if (result == null)
            {
                return null;
            }
            // Getting rid of database-inherited whitespace
            result.ActivityCode = result.ActivityCode.Trim();
            result.ActivityDescription = result.ActivityDescription.Trim();
            result.SessionCode = result.SessionCode.Trim();
            result.SessionDescription = result.SessionDescription.Trim();
            result.IDNumber = result.IDNumber;
            result.FirstName = result.FirstName.Trim();
            result.LastName = result.LastName.Trim();
            result.Email = result.Email.Trim();
            result.Participation = result.Participation.Trim();
            result.ParticipationDescription = result.ParticipationDescription.Trim();

            return result;
        }

        /// <summary>
        /// Fetches all membership records from storage.
        /// </summary>
        /// <returns>MembershipViewModel IEnumerable. If no records were found, an empty IEnumerable is returned.</returns>
        public IEnumerable<MembershipViewModel> GetAll()
        {

            var result = RawSqlQuery<MembershipViewModel>.query("ALL_MEMBERSHIPS");
            // Trimming database generated whitespace ._.
            var trimmedResult = result.Select(x =>
            {
                var trim = x;
                trim.ActivityCode = x.ActivityCode.Trim();
                trim.ActivityDescription = x.ActivityDescription.Trim();
                trim.SessionCode = x.SessionCode.Trim();
                trim.SessionDescription = x.SessionDescription.Trim();
                trim.IDNumber = x.IDNumber;
                trim.FirstName = x.FirstName.Trim();
                trim.LastName = x.LastName.Trim();
                trim.Email = x.Email.Trim();
                trim.Participation = x.Participation.Trim();
                trim.ParticipationDescription = x.ParticipationDescription.Trim();
                return trim;
            });
            return trimmedResult.OrderByDescending(x => x.StartDate);
        }

        /// <summary>
        /// Fetches the leaders of the activity whose activity code is specified by the parameter.
        /// </summary>
        /// <param name="id">The activity code.</param>
        /// <returns>MembershipViewModel IEnumerable. If no records were found, an empty IEnumerable is returned.</returns>
        public IEnumerable<MembershipViewModel> GetLeaderMembershipsForActivity(string id)
        {
            var idParam = new SqlParameter("@ACT_CDE", id);
            var result = RawSqlQuery<MembershipViewModel>.query("LEADER_MEMBERSHIPS_PER_ACT_CDE @ACT_CDE", idParam);

            // Getting rid of whitespace inherited from the database .__.
            var trimmedResult = result.Select(x =>
            {
                var trim = x;
                trim.ActivityCode = x.ActivityCode.Trim();
                trim.ActivityDescription = x.ActivityDescription.Trim();
                trim.SessionCode = x.SessionCode.Trim();
                trim.SessionDescription = x.SessionDescription.Trim();
                trim.IDNumber = x.IDNumber;
                trim.FirstName = x.FirstName.Trim();
                trim.LastName = x.LastName.Trim();
                trim.Email = x.Email.Trim();
                trim.Participation = x.Participation.Trim();
                trim.ParticipationDescription = x.ParticipationDescription.Trim();
                return trim;
            });
            
            return trimmedResult;
        }

        /// <summary>
        /// Fetches the memberships associated with the activity whose code is specified by the parameter.
        /// </summary>
        /// <param name="id">The activity code.</param>
        /// <returns>MembershipViewModel IEnumerable. If no records were found, an empty IEnumerable is returned.</returns>
        public IEnumerable<MembershipViewModel> GetMembershipsForActivity(string id)
        {
            var idParam = new SqlParameter("@ACT_CDE", id);
            var result = RawSqlQuery<MembershipViewModel>.query("MEMBERSHIPS_PER_ACT_CDE @ACT_CDE", idParam);
            var trimmedResult = result.Select(x =>
            {
                var trim = x;
                trim.ActivityCode = x.ActivityCode.Trim();
                trim.ActivityDescription = x.ActivityDescription.Trim();
                trim.SessionCode = x.SessionCode.Trim();
                trim.SessionDescription = x.SessionDescription.Trim();
                trim.IDNumber = x.IDNumber;
                trim.FirstName = x.FirstName.Trim();
                trim.LastName = x.LastName.Trim();
                trim.Email = x.Email.Trim();
                trim.Participation = x.Participation.Trim();
                trim.ParticipationDescription = x.ParticipationDescription.Trim();
                return trim;
            });
            return trimmedResult.OrderByDescending(x => x.StartDate);
        }

        /// <summary>
        /// Fetches all the membership information linked to the student whose id appears as a parameter.
        /// </summary>
        /// <param name="id">The student id.</param>
        /// <returns>A MembershipViewModel IEnumerable. If nothing is found, an empty IEnumberable is returned.</returns>
        public IEnumerable<MembershipViewModel> GetMembershipsForStudent(string id)
        {
            var studentExists = _unitOfWork.StudentRepository.Where(x => x.student_id.Trim() == id).Count() > 0;
            if (!studentExists)
            {
                return null;
            }

            var idParam = new SqlParameter("@STUDENT_ID", id);
            var result = RawSqlQuery<MembershipViewModel>.query("MEMBERSHIPS_PER_STUDENT_ID @STUDENT_ID", idParam);

            // The Views that were given to were defined as char(n) instead of varchar(n)
            // They return with whitespace padding which messes up comparisons later on.
            // I'm using the IEnumerable Select method here to help get rid of that.
            var trimmedResult = result.Select(x =>
            {
                var trim = x;
                trim.ActivityCode = x.ActivityCode.Trim();
                trim.ActivityDescription = x.ActivityDescription.Trim();
                trim.SessionCode = x.SessionCode.Trim();
                trim.SessionDescription = x.SessionDescription.Trim();
                trim.Participation = x.Participation.Trim();
                trim.ParticipationDescription = x.ParticipationDescription.Trim();
                trim.FirstName = x.FirstName.Trim();
                trim.LastName = x.LastName.Trim();
                trim.Email = x.Email.Trim();
                trim.IDNumber = x.IDNumber;
                return trim;
            });

            return trimmedResult.OrderByDescending(x => x.StartDate);
        }

        /// <summary>
        /// Updates the membership whose id is given as the first parameter to the contents of the second parameter.
        /// </summary>
        /// <param name="id">The membership id.</param>
        /// <param name="membership">The updated membership.</param>
        /// <returns>The newly modified membership.</returns>
        public MEMBERSHIP Update(int id, MEMBERSHIP membership)
        {
            var original = _unitOfWork.MembershipRepository.GetById(id);
            if (original == null)
            {
                return null;
            }

            var isValidMembership = membershipIsValid(membership);

            if(!isValidMembership)
            {
                return null;
            }

            // One can only update certain fields within a membrship
            original.BEGIN_DTE = membership.BEGIN_DTE;
            original.COMMENT_TXT = membership.COMMENT_TXT;
            original.END_DTE = membership.END_DTE;
            original.PART_CDE = membership.PART_CDE;
            original.SESS_CDE = membership.SESS_CDE;

            _unitOfWork.Save();

            return original;

        }

        /// <summary>
        /// Helper method to check for the validity of a membership.
        /// </summary>
        /// <param name="membership">The membership to validate</param>
        /// <returns>True if the membership is valid. False if it isn't</returns>
        private bool membershipIsValid(MEMBERSHIP membership)
        {
            var personExists = _unitOfWork.AccountRepository.Where(x => x.gordon_id.Trim() == membership.ID_NUM.ToString()).Count() > 0;
            var participationExists = _unitOfWork.ParticipationRepository.Where(x => x.PART_CDE.Trim() == membership.PART_CDE).Count() > 0;
            var sessionExists = _unitOfWork.SessionRepository.Where(x => x.SESS_CDE.Trim() == membership.SESS_CDE).Count() > 0;
            var activityExists = _unitOfWork.ActivityRepository.Where(x => x.ACT_CDE.Trim() == membership.ACT_CDE).Count() > 0;

            if (!personExists || !participationExists || !sessionExists || !activityExists)
            {
                return false;
            }

            var activitiesThisSession = RawSqlQuery<ACT_CLUB_DEF>.query("ACTIVE_CLUBS_PER_SESS_ID @SESS_CDE", new SqlParameter("SESS_CDE", SqlDbType.VarChar) { Value = membership.SESS_CDE });

            bool offered = false;
            foreach (var activityResult in activitiesThisSession)
            {
                if (activityResult.ACT_CDE.Trim() == membership.ACT_CDE)
                {
                    offered = true;
                }
            }

            if (!offered)
            {
                return false;
            }
            return true;
        }

    }
}