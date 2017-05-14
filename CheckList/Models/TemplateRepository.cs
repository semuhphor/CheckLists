using System.Collections.Generic;

namespace CheckList.Models
{
    public class TemplateRepository : ITemplateRepository
    {
        private readonly AppDbContext _appDbContext;

        public TemplateRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Template> Templates => _appDbContext.Templates;
    }
}
