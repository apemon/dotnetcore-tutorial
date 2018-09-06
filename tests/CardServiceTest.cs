using System;
using training.Exceptions;
using training.Services;
using Xunit;

namespace tests
{
    public class CardServiceTest
    {
        private readonly ICardService _card;

        public CardServiceTest()
        {
            _card = new CardService();
        }

        [Theory]
        [InlineData("6233111111111111")]
        public void ValidateCardFormatWithSuccessCard(string cardNo)
        {
            _card.ValidateCardNo(cardNo);
        }

        [Theory]
        [InlineData("")]
        [InlineData("1")]
        [InlineData("1111111111111111")]
        public void ValidateCardFormatWithInvalidCase(string cardNo)
        {
            Assert.Throws<InvalidCardFormatException>(() => _card.ValidateCardNo(cardNo));
        }
    }
}
