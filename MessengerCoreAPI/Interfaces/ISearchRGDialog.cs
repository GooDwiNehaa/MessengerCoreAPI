using MessengerCoreAPI.Models;
using System;
using System.Collections.Generic;

namespace MessengerCoreAPI.Interfaces
{
    public interface ISearchRGDialog
    {
        public Guid API(List<RGDialogsClients> clientsDialogs, List<Guid> clientsIds);
    }
}
