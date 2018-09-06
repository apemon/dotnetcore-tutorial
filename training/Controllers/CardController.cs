using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using training.Exceptions;
using training.Services;

namespace training.Controllers
{
    [Produces("application/json")]
    [Route("api/Card")]
    public class CardController : Controller
    {
        private ICardService _card;

        public CardController(ICardService card)
        {
            _card = card;
        }

        [HttpGet]
        [Route("validate/{cardNo}")]
        public IActionResult ValidateCardNo([FromRoute] string cardNo)
        {
            try
            {
                // should validate input here

                // validate card number
                _card.ValidateCardNo(cardNo);
            } catch(InvalidCardFormatException ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
    }
}