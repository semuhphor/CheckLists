using System.Collections.Generic;
using CheckList.Models;

namespace CheckList.ViewModels
{
    public class ChkListListViewModel
    {
        public IEnumerable<ChkList> ChkLists { get; set; }
    }
}
