using System.Collections.Generic;

namespace CheckList.Models
{
    public interface IChkListRepository
    {
        IEnumerable<ChkList> ChkLists { get; }
    }
}
