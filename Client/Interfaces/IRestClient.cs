using System.Threading.Tasks;

namespace Client.Interfaces
{
    public interface IRestClient
    {
        Task<string> Post(int number);

        Task<string> Get();

        Task<string> Put(int id);

        Task<string> Delete(int id);
    }
}
