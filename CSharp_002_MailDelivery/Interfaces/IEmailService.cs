using CSharp_002_MailDelivery.Entities;

namespace CSharp_002_MailDelivery
{
    interface IEmailService
    {
        bool SendEmail(EmailContent emailContent);
    }
}
