using System.Collections.Generic;

namespace ClassWork_Login.Models.Repository
{
    public class MemoryRepository : IRepository
    {
        private List<GuestResponse> responses = new List<GuestResponse>();
        public void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }

        public IEnumerable<GuestResponse> GetAllResponses()
        {
            return responses;
        }
    }
}