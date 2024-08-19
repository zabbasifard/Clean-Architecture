using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitucture.Application.Common.Interfaces
{
    public interface ISmsAdapter
    {
        Task<int> SendAsync(string receiver, string text);
    }
}
