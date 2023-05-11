using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSchedular.Domain.Common;

namespace MailSchedular.Domain.Entities
{
    public class MailEvent : BaseEntity
    {
        public string ToMail { get; set; }
        public string Message { get; set; }
    }
}
