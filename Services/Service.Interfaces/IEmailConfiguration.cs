using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Services.Service.Interfaces
{
    interface IEmailConfiguration
    {
        string SmtpServer { get; set; }
        int SmtpPort { get; }
        string SmtpUsername { get; set; }
        string SmtpPassword { get; set; }
        string AppEmailFrom { get; }
        string EmailName { get; }
    }
}
