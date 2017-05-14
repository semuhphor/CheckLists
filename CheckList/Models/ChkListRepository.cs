using System.Collections.Generic;

namespace CheckList.Models
{
    public class ChkListRepository : IChkListRepository
    {
        private readonly AppDbContext _appDbContext;

        public ChkListRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ChkList> ChkLists => _appDbContext.ChkLists;
    }
}
