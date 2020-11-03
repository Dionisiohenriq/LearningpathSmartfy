using System.Collections.Generic;
using CSharp_002_MailDelivery.Entities;

namespace CSharp_002_MailDelivery
{
    interface IEmailService
    {
        bool SendEmail(EmailEntity emailContent);

        bool SendEmails(EmailEntity emailContent,List<string> emailsList);


    }
}
