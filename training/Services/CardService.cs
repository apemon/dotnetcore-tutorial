using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using training.Exceptions;

namespace training.Services
{
    public class CardService : ICardService
    {
        public void ValidateCardNo(string cardNo)
        {
            if (string.IsNullOrEmpty(cardNo))
                throw new InvalidCardFormatException("should not be null");
            if (cardNo.Length != 16)
                throw new InvalidCardFormatException("must be length 16");
            if (!cardNo.StartsWith("6233"))
                throw new InvalidCardFormatException("invalid card type");
        }
    }
}
