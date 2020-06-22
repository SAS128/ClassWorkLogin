using System.Collections.Generic;

namespace ClassWork_Login.Models.Repository
{
    public interface IRepository
    {
        IEnumerable<GuestResponse> GetAllResponses();
        void AddResponse(GuestResponse response);
    }
}
