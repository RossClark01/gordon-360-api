﻿using System.Web.Http;
using Gordon360.Models;
using Gordon360.Services;
using Gordon360.Repositories;
using Gordon360.Models.ViewModels;
using Gordon360.AuthorizationFilters;
using Gordon360.Static.Names;
using System;
using Gordon360.Exceptions.ExceptionFilters;
using Gordon360.Exceptions.CustomExceptions;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;

namespace Gordon360.Controllers.Api
{
    [RoutePrefix("api/schedule")]
    [CustomExceptionFilter]
    [Authorize]
    public class ScheduleController : ApiController
    {
        private IUnitOfWork _unitOfWork;

        //declare services we are going to use.
        private IAccountService _accountService;
        private IRoleCheckingService _roleCheckingService;
        private IScheduleControlService _scheduleControlService;

        private IScheduleService _scheduleService;


        public ScheduleController()
        {
            _unitOfWork = new UnitOfWork();
            _scheduleService = new ScheduleService(_unitOfWork);
            _accountService = new AccountService(_unitOfWork);
            _roleCheckingService = new RoleCheckingService(_unitOfWork);
        }

        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        /// <summary>
        ///  Gets all schedule objects for a user
        /// </summary>
        /// <returns>A IEnumerable of schedule objects</returns>
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            var authenticatedUser = this.ActionContext.RequestContext.Principal as ClaimsPrincipal;
            var username = authenticatedUser.Claims.FirstOrDefault(x => x.Type == "user_name").Value;

            var role = _roleCheckingService.getCollegeRole(username);
            var id = _accountService.GetAccountByUsername(username).GordonID;


            if (role=="student"){
                var result = _scheduleService.GetScheduleStudent(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }

            else if (role=="facstaff"){
                var result = _scheduleService.GetScheduleFaculty(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            return NotFound();
           
        }

        /// <summary>
        ///  Gets all schedule objects for a user
        /// </summary>
        /// <returns>A IEnumerable of schedule objects</returns>
        [HttpGet]
        [Route("{username}")]
        public IHttpActionResult Get(string username)
        {
            //probably needs privacy stuff like ProfilesController and service
            //get token data from context, username is the username of current logged in person

            var role = _roleCheckingService.getCollegeRole(username);
            object _scheduleResult = null;

            var authenticatedUser = this.ActionContext.RequestContext.Principal as ClaimsPrincipal;

            object scheduleResult = null;

            var id = _accountService.GetAccountByUsername(username).GordonID;
            // Getting student schedule
            if (role == "student")
            {
                _scheduleResult = _scheduleService.GetScheduleStudent(id);
                 scheduleResult = _scheduleResult;

            }

            // Getting faculty / staff schedule
            else if (role == "facstaff")
            {
                _scheduleResult = _scheduleService.GetScheduleFaculty(id);
                 scheduleResult = _scheduleResult;
            }
            
            if (scheduleResult == null)
            {
                return NotFound();
            }

            return Ok(scheduleResult);
        }
    }
}
