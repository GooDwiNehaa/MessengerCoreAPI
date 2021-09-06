using MessengerCoreAPI.Interfaces;
using MessengerCoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MessengerCoreAPI.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class SearchRGDialogsController : ControllerBase
    {
        private readonly ISearchRGDialog _searchRGDialog;

        public SearchRGDialogsController(ISearchRGDialog searchRGDialog)
        {
            _searchRGDialog = searchRGDialog;
        }

        [HttpPost]
        [Route("search-dialogs")]
        public Guid SearchRGDialog([FromBody] List<Guid> clientsIds)
        {
            RGDialogsClients rgDialogsClients = new RGDialogsClients();

            var rgDialogs = rgDialogsClients.Init();

            return _searchRGDialog.API(rgDialogs, clientsIds);
        }
    }
}
