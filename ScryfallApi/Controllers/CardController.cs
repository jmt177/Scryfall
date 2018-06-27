using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Scryfall;

namespace ScryfallApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Scryfall/")]
    public class CardController : Controller
    {
        private static readonly ScryfallClient scryfallClient = new ScryfallClient();

        // cards

        [HttpGet]
        [Route("cards/random")]
        public IActionResult GetRandomCard()
        {
            try
            {
                var card = scryfallClient.GetRandomCard().Result;
                var jsonContent = JsonConvert.SerializeObject(card, Formatting.Indented);
                return Content(jsonContent);
            }
            catch (Exception e)
            {
                return StatusCode(503, e);
            }
        }

        [HttpGet]
        [Route("cards/exact")]
        public IActionResult GetExactCard([FromQuery] string name)
        {
            try
            {
                var card = scryfallClient.GetNamedCardExact(name).Result;
                var jsonContent = JsonConvert.SerializeObject(card, Formatting.Indented);
                return Content(jsonContent);
            }
            catch (Exception e)
            {
                return StatusCode(503, e);
            }
        }

        [HttpGet]
        [Route("cards/partialName")]
        public IActionResult GetCardPartialName([FromQuery] string name)
        {
            try
            {
                var card = scryfallClient.GetNamedCardPartial(name).Result;
                var jsonContent = JsonConvert.SerializeObject(card, Formatting.Indented);
                return Content(jsonContent);
            }
            catch (Exception e)
            {
                return StatusCode(503, e);
            }
        }

        [HttpGet]
        [Route("cards/MultiverseId/{id}")]
        public IActionResult GetCardByMultiverseId([FromRoute] string id)
        {
            try
            {
                var card = scryfallClient.GetCardByMultiverseId(id).Result;
                var jsonContent = JsonConvert.SerializeObject(card, Formatting.Indented);
                return Content(jsonContent);
            }
            catch (Exception e)
            {
                return StatusCode(503, e);
            }
        }

        [HttpGet]
        [Route("cards/mtgoId/{id}")]
        public IActionResult GetCardByMtgoId([FromRoute] string id)
        {
            try
            {
                var card = scryfallClient.GetCardByMtgoId(id).Result;
                var jsonContent = JsonConvert.SerializeObject(card, Formatting.Indented);
                return Content(jsonContent);
            }
            catch (Exception e)
            {
                return StatusCode(503, e);
            }
        }

        [HttpGet]
        [Route("cards/arenaId/{id}")]
        public IActionResult GetCardByArenaId([FromRoute] string id)
        {
            try
            {
                var card = scryfallClient.GetCardByArenaId(id).Result;
                var jsonContent = JsonConvert.SerializeObject(card, Formatting.Indented);
                return Content(jsonContent);
            }
            catch (Exception e)
            {
                return StatusCode(503, e);
            }
        }

        // sets

        [HttpGet]
        [Route("sets/{id}")]
        public IActionResult GetSetByCode([FromRoute] string id)
        {
            try
            {
                var set = scryfallClient.GetSetByCode(id).Result;
                var jsonContent = JsonConvert.SerializeObject(set, Formatting.Indented);
                return Content(jsonContent);
            }
            catch (Exception e)
            {
                return StatusCode(503, e);
            }
        }
    }
}