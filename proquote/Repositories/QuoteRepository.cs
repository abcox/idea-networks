using AutoMapper;
using proquote.Models;
using proquote.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proquote.Repositories
{
    public class QuoteRepository : IQuoteRepository
    {
        private readonly IMapper _mapper;
        private readonly proquote_ideaContext _context;

        public QuoteRepository(
            proquote_ideaContext context,
            IMapper mapper
            )
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Quote> GetQuote(int id)
        {
            var tblQuoteMain = await _context.TblQuoteMain.FindAsync(id);
            return _mapper.Map<Quote>(tblQuoteMain);
        }
    }
}
