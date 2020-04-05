using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Interfaces
{
    public interface IRestClient
    {
        Task<string> Post(int number);

        Task<string> Get();

        Task<string> Put();

        Task<string> Delete();
    }
}
