using System;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class GuidService : IGuidService
    {
        private readonly Guid getId;
        public GuidService()
        {
            this.getId = Guid.NewGuid();
        }
        public Task<Guid> GetGuid()
        {
            return Task.FromResult(this.getId);
        }
    }
}
