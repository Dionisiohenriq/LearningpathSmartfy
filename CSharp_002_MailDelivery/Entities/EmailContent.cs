using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace CSharp_002_MailDelivery.Entities
{
    public class EmailEntity
    {
        public string Subject { get; set; }
        public string Message { get; set; }
        public string MailTo { get; set; }
    }
}
