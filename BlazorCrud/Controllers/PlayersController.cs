using BlazorCrud.Models;
using BlazorCrud.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlazorCrud.Controllers
{
    public class PlayersController : Controller
    {
        private readonly PlayerService _playerService;
        public PlayersController(PlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        [Route("api/Players/Get")]
        public ActionResult<List<Player>> GetRoster()
        {
            return _playerService.GetRoster();
        }

        [HttpGet]
        [Route("api/Players/Get/{id}")]
        public ActionResult<Player> GetPlayer(string id)
        {
            return _playerService.GetPlayer(id);
        }


        [HttpPost]
        [Route("api/Players/Create")]
        public ActionResult<Player> Create(Player player)
        {
            _playerService.AddPlayer(player);

            return CreatedAtRoute("GetBook", new { id = player.Id.ToString() }, player);
        }

        //[HttpPut("{id:length(24)}")]
        [HttpPut]
        [Route("api/Players/Edit")]
        public IActionResult Update(string id, Player playerIn)
        {
            var player = _playerService.GetPlayer(id);

            if (player == null)
            {
                return NotFound();
            }

            _playerService.Update(id, playerIn);

            return NoContent();
        }

        [HttpDelete("api/Players/Delete/{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var player = _playerService.GetPlayer(id);

            if (player == null)
            {
                return NotFound();
            }

            _playerService.Remove(player.Id);

            return NoContent();
        }
    }
}
