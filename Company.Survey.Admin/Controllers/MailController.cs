using Company.Survey.Admin.Models.Mail;
using Company.Survey.Core.Data;
using Company.Survey.Core.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

/// <summary>
/// src: https://dejanstojanovic.net/aspnet/2018/june/sending-email-in-aspnet-core-using-smtpclient-and-dependency-injection/
/// </summary>
[Authorize]
public class MailController : Controller
{
    private readonly CoreContext _context;
    private readonly SmtpClient _smtp;
    public MailController(CoreContext coreContext, SmtpClient smtpClient)
    {
        _context = coreContext;
        _smtp = smtpClient;
    }

    [HttpPost]
    public async Task<IActionResult> Send([FromBody] EmailSurveyToClient emailSurveyToClient)
    {
        var clientTask = _context.Clients.Where(e => e.Email == emailSurveyToClient.Email).FirstOrDefaultAsync();
        var surveyTask = _context.Surveys.Where(e => e.Id == emailSurveyToClient.SurveyId).FirstOrDefaultAsync();
        await Task.WhenAll(clientTask, surveyTask);
        var client = await clientTask;
        var survey = await surveyTask;

        var clientSurvey = new ClientSurveys
        {
            Client = client,
            Survey = survey,
            ClientSurveyKey = Guid.NewGuid()
        };

        await _context.ClientSurveys.AddAsync(clientSurvey);
        await _context.SaveChangesAsync();

        try
        {
            // TODO: add environment var for email
            await _smtp.SendMailAsync(
                new MailMessage(
                    from: "system@companysurvey.com",
                    to: clientSurvey.Client.Email,
                    subject: "New Questionnaire!",
                    body: $"Hello {clientSurvey.Client.FirstName} {clientSurvey.Client.LastName}, please complete the following survey: <a href='https://localhost:44331/{clientSurvey.Client.Email}/{clientSurvey.ClientSurveyKey}' target='_blank'>{clientSurvey.Survey.Title}<a/>"
                )
            );
        }
        catch (Exception ex)
        {
            throw;
        }


        return Ok();
    }

    protected override void Dispose(bool disposing)
    {
        _smtp.Dispose();
        base.Dispose(disposing);
    }

}