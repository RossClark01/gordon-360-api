﻿using Gordon360.Authorization;
using Gordon360.Enums;
using Gordon360.Models.CCT;
using Gordon360.Models.ViewModels;
using Gordon360.Services;
using Gordon360.Static.Names;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gordon360.Controllers;

[Route("api/[controller]")]
public class MembershipsController(IMembershipService membershipService) : GordonControllerBase
{

    /// <summary>
    /// Get all the memberships associated with a given activity
    /// </summary>
    /// <param name="involvementCode">Optional involvementCode filter</param>
    /// <param name="username">Optional username filter</param>
    /// <param name="sessionCode">Optional session code for which session memberships should be retrieved. Defaults to current session. Use "*" for all sessions.</param>
    /// <param name="participationTypes">Optional list of participation types that should be retrieved. Defaults to all participation types.</param>
    /// <returns>An IEnumerable of the matching MembershipViews</returns>
    [HttpGet]
    [StateYourBusiness(operation = Operation.READ_PARTIAL, resource = Resource.MEMBERSHIP)]
    public ActionResult<IEnumerable<MembershipView>> GetMemberships(string? involvementCode = null, string? username = null, string? sessionCode = null, [FromQuery] List<string>? participationTypes = null)
    {
        var authenticatedUserUsername = AuthUtils.GetUsername(User);
        var viewerGroups = AuthUtils.GetGroups(User);

        var memberships = membershipService.GetMemberships(
            activityCode: involvementCode,
            username: username,
            sessionCode: sessionCode,
            participationTypes: participationTypes);

        // Only user, siteAdmin and Police can see all the user's memberships.
        if (
            (username is null || username != authenticatedUserUsername)
            && !(viewerGroups.Contains(AuthGroup.SiteAdmin) || viewerGroups.Contains(AuthGroup.Police))
            )
        {
            memberships = membershipService.RemovePrivateMemberships(memberships, authenticatedUserUsername);
        }

        return Ok(memberships);
    }

    /// <summary>
    /// Gets the number of memberships matching the specified filters
    /// </summary>
    /// <param name="activityCode">Optional activityCode filter</param>
    /// <param name="username">Optional username filter</param>
    /// <param name="sessionCode">Optional session code for which session memberships should be retrieved. Defaults to current session. Use "*" for all sessions.</param>
    /// <param name="participationTypes">Optional list of participation types that should be retrieved. Defaults to all participation types.</param>
    /// <returns>The number of followers of the activity</returns>
    [HttpGet]
    [Route("count")]
    [StateYourBusiness(operation = Operation.READ_ONE, resource = Resource.MEMBERSHIP)]
    public ActionResult<int> GetMembershipCount(string? activityCode = null, string? username = null, string? sessionCode = null, [FromQuery] List<string>? participationTypes = null)
    {
        var result = membershipService
            .GetMemberships(
                activityCode: activityCode,
                username: username,
                sessionCode: sessionCode,
                participationTypes: participationTypes)
            .Count();


        return Ok(result);
    }

    /// <summary>Create a new membership item to be added to database</summary>
    /// <param name="membershipUpload">The membership item containing all required and relevant information</param>
    /// <returns>The newly created membership as a MembershipView object</returns>
    /// <remarks>Posts a new membership to the server to be added into the database</remarks>
    [HttpPost]
    [Route("", Name = "Memberships")]
    [StateYourBusiness(operation = Operation.ADD, resource = Resource.MEMBERSHIP)]
    public async Task<ActionResult<MembershipView>> PostAsync([FromBody] MembershipUploadViewModel membershipUpload)
    {
        var result = await membershipService.AddAsync(membershipUpload);

        if (result == null)
        {
            return BadRequest();
        }

        return Created("memberships", result);

    }

    /// <summary>Update an existing membership item</summary>
    /// <param name="membershipID">The membership id of whichever one is to be changed</param>
    /// <param name="membership">The content within the membership that is to be changed and what it will change to</param>
    /// <remarks>Calls the server to make a call and update the database with the changed information</remarks>
    /// <returns>The updated membership as a MembershipView object</returns>
    [HttpPut]
    [Route("{membershipID}")]
    [StateYourBusiness(operation = Operation.UPDATE, resource = Resource.MEMBERSHIP)]
    public async Task<ActionResult<MembershipView>> PutAsync(int membershipID, [FromBody] MembershipUploadViewModel membership)
    {
        var result = await membershipService.UpdateAsync(membershipID, membership);

        return Ok(result);
    }

    /// <summary>Update an existing membership item to be a group admin or not</summary>
    /// <param name="membershipID">The content within the membership that is to be changed</param>
    /// <param name="isGroupAdmin">The new value of GroupAdmin</param>
    /// <remarks>Calls the server to make a call and update the database with the changed information</remarks>
    /// <returns>The updated membership as a MembershipView object</returns>
    [HttpPut]
    [Route("{membershipID}/group-admin")]
    [StateYourBusiness(operation = Operation.UPDATE, resource = Resource.MEMBERSHIP)]
    public async Task<ActionResult<MembershipView>> SetGroupAdminAsync(int membershipID, [FromBody] bool isGroupAdmin)
    {
        var result = await membershipService.SetGroupAdminAsync(membershipID, isGroupAdmin);

        return Ok(result);
    }

    /// <summary>Update an existing membership item to be private or not</summary>
    /// <param name="membershipID">The membership to set the privacy of</param>
    /// <param name="isPrivate">The new value of Privacy for the membership</param>
    /// <remarks>Calls the server to make a call and update the database with the changed information</remarks>
    /// <returns>The updated membership as a MembershipView object</returns>
    [HttpPut]
    [Route("{membershipID}/privacy")]
    [StateYourBusiness(operation = Operation.UPDATE, resource = Resource.MEMBERSHIP_PRIVACY)]
    public async Task<ActionResult<MembershipView>> SetPrivacyAsync(int membershipID, [FromBody] bool isPrivate)
    {

        var updatedMembership = await membershipService.SetPrivacyAsync(membershipID, isPrivate);
        return Ok(updatedMembership);
    }

    /// <summary>Delete an existing membership</summary>
    /// <param name="membershipID">The identifier for the membership to be deleted</param>
    /// <remarks>Calls the server to make a call and remove the given membership from the database</remarks>
    /// <returns>The deleted membership as a MembershipView object</returns>
    [HttpDelete]
    [Route("{membershipID}")]
    [StateYourBusiness(operation = Operation.DELETE, resource = Resource.MEMBERSHIP)]
    public ActionResult<MembershipView> Delete(int membershipID)
    {
        var result = membershipService.Delete(membershipID);

        return Ok(result);
    }
}
