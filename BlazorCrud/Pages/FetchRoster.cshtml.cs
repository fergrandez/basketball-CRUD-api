using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using BlazorCrud.Models;
using BlazorCrud.Services;

namespace BlazorCrud.Pages
{
    public class FetchRosterModel : PageModel
    {
        private readonly PlayerService _service;
        public FetchRosterModel(PlayerService service)
        {
            _service = service;
        }
        public IList<Player> Roster { get; set; }
        public void OnGet()
        {
            Roster = _service.GetRoster();
        }
    }
}