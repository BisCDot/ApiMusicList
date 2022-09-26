using ApiMusicList.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiMusicList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SongsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("GetSong")]
        public IActionResult GetSong()
        {
            var songs = _context.itemSongs;
            return Ok(songs);
        }

        [HttpPost("PostSong")]
        public IActionResult PostSong([FromBody] ItemSong itemSong)
        {
            if (itemSong == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.Add(itemSong);
            _context.SaveChanges();
            return Created("URI of the created entity", itemSong);
        }
    }
}