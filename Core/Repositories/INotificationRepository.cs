using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Persistence.Repositories
{
    public interface INotificationRepository
    {
        IEnumerable<Notification> GetNewNotificationsFor(string userId);
    }
}