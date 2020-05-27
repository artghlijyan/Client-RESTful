using System.Threading.Tasks;

namespace Client.Interfaces
{
    public interface IRestService
    {
        Task<string> Post(int number);

        Task<string> Get();

        Task<string> Put(int id);

        Task<string> Delete(int id);
    }
}
