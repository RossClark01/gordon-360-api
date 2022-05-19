﻿using Gordon360.Models.CCT.Context;
using Gordon360.Services;
using Gordon360.Static.Methods;
using Gordon360.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Gordon360.Controllers
{
    [Route("api/[controller]")]
    public class DiningController : GordonControllerBase
    {
        public readonly IDiningService _diningService;
        private readonly IAccountService _accountService;
        private const string FACSTAFF_MEALPLAN_ID = "7295";
        public DiningController(IConfiguration config, CCTContext context)
        {
            _diningService = new DiningService(context, config);
            _accountService = new AccountService(context);
        }

        /// <summary>
        ///  Gets information about student's dining plan and balance
        /// </summary>
        /// <returns>A DiningInfo object</returns>
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<string>> GetAsync()
        {
            var currentSession = await Helpers.GetCurrentSessionAsync();
            var authenticatedUsername = AuthUtils.GetUsername(User);
            var authenticatedUserId = int.Parse(_accountService.GetAccountByUsername(authenticatedUsername)?.GordonID);
            var diningInfo = _diningService.GetDiningPlanInfo(authenticatedUserId, currentSession.SessionCode);

            if (diningInfo == null)
            {
                return NotFound();
            }
            if (diningInfo.ChoiceDescription == "None")
            {
                var diningBalance = _diningService.GetBalance(authenticatedUserId, FACSTAFF_MEALPLAN_ID);
                if (diningBalance == null)
                {
                    return NotFound();
                }
                return Ok(diningBalance);
            }
            else
            {
                return Ok(diningInfo);
            }

        }
    }
}
