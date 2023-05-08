using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSchedular.Domain.Entities
{
    public class MailMessage : BaseEntity
    {
        public string ToMail { get; set; }
        public string Message { get; set; }
    }
}
