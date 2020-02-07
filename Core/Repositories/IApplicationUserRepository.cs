using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Persistence.Repositories
{
    public interface IApplicationUserRepository
    {
        IEnumerable<ApplicationUser> GetArtistsFollowedBy(string userId);
    }
}