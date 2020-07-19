using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    /// <summary>
    /// This is responsible for providing the interface for creating guid,
    /// all implementing Types should generate gui
    /// </summary>
    public interface IGuidService
    {
        /// <summary>
        /// Retrieves the Guid value
        /// </summary>
        /// <returns></returns>
        Task<Guid> GetGuid();
    }
}
