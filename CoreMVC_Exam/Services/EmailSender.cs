﻿using Microsoft.AspNetCore.Identity.UI.Services;

namespace CoreMVC_Exam.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }
    }
}
