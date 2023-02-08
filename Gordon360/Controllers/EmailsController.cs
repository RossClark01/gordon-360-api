﻿using Gordon360.Authorization;
using Gordon360.Enums;
using Gordon360.Models.CCT.Context;
using Gordon360.Models.ViewModels;
using Gordon360.Services;
using Gordon360.Static.Names;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Gordon360.Services.MembershipService;

namespace Gordon360.Controllers
{
    [Route("api/[controller]")]
    public class EmailsController : GordonControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailsController(CCTContext context, IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpGet]
        [Route("activity/{activityCode}")]
        [StateYourBusiness(operation = Operation.READ_PARTIAL, resource = Resource.EMAILS_BY_ACTIVITY)]
        public async Task<ActionResult<IEnumerable<EmailViewModel>>> GetEmailsForActivityAsync(string activityCode, string? sessionCode, string? participationType)
        {
            var participation = participationType.Parse(); 
            var result = await _emailService.GetEmailsForActivityAsync(activityCode, sessionCode, participation);

            if (result == null)
            {
                NotFound();
            }
            return Ok(result);

        }

        [HttpPut]
        [Route("")]
        public ActionResult SendEmails([FromBody] EmailContentViewModel email)
        {
            var to_emails = email.ToAddress.Split(',');
            _emailService.SendEmails(to_emails, email.FromAddress, email.Subject, email.Content, email.Password);
            return Ok();
        }

        [HttpPut]
        [Route("activity/{id}/session/{session}")]
        [StateYourBusiness(operation = Operation.READ_PARTIAL, resource = Resource.EMAILS_BY_ACTIVITY)]
        public async Task<ActionResult> SendEmailToActivityAsync(string id, string session, [FromBody] EmailContentViewModel email)
        {
            await _emailService.SendEmailToActivityAsync(id, session, email.FromAddress, email.Subject, email.Content, email.Password);

            return Ok();

        }
    }
}
