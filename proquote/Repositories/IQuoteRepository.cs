using proquote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proquote.Repositories
{
    public interface IQuoteRepository
    {
        Task<Quote> GetQuote(int id);
    }
}
