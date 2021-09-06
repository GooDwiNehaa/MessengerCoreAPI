using MessengerCoreAPI.Interfaces;
using MessengerCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MessengerCoreAPI.Services
{
    public class SearchEngineDialogs : ISearchRGDialog
    {
        public Guid API(List<RGDialogsClients> clientsDialogs, List<Guid> clientsIds)
        {
            var articipants = clientsDialogs
                .GroupBy(cd => cd.IDRGDialog)
                .Where(g => g.All(cd => clientsIds.Contains(cd.IDClient)) &&
                g.Select(cd => cd.IDClient).Distinct().Count() == clientsIds.Count())
                .FirstOrDefault()?
                .FirstOrDefault();

            return articipants == null ? Guid.Empty : articipants.IDRGDialog;
        }
    }
}
