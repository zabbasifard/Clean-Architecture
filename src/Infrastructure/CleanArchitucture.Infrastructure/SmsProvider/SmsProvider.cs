using CleanArchitucture.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitucture.Infrastructure.SmsProvider
{
    public class SmsProvider : ISmsAdapter
    {
        public Task<int> SendAsync(string receiver, string text)
        {
            throw new NotImplementedException();
        }
    }
}
