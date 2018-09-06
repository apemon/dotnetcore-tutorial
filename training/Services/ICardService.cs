using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace training.Services
{
    public interface ICardService
    {
        void ValidateCardNo(string cardNo);
    }
}
