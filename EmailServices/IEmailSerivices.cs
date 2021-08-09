using System;
using System.Collections.Generic;
using System.Text;

namespace EmailServices
{
   public interface IEmailSerivices
    {
        void Send(string from, string to, string subject, string html);
    }
}
