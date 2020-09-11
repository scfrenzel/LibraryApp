using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Api.Services
{
    public interface INotifyService
    {
        void SendNotification(string message);
    }
}
