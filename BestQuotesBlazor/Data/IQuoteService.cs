using System.Collections.Generic;
using System.Threading.Tasks;

namespace BestQuotesBlazor.Data
{
    public interface IQuoteService
    {
        Task AddQuote(Quote quote);
        Task<List<Quote>> GetQuotes();
    }
}