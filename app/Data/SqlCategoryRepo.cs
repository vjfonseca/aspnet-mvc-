using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using teste.Models;

namespace teste.Data
{
    public class SqlCategoryRepo : ICategoryRepo
    {
        private readonly TesteContext context;
        public SqlCategoryRepo(TesteContext ctx)
        {
            this.context = ctx;
        }
        public Category Create(Category cat)
        {
            context.Categories.Add(cat);
            context.SaveChanges();
            return context.Categories.Single(x => x.Id == cat.Id);
        }

        public Category Get(int id)
        {
            var d = context.Categories.FirstOrDefault(x=>x.Id ==id);
            return d;
        }

        public IEnumerable<Category> GetAll()
        {
            var d = context.Categories.ToList();
            return d;
        }
    }
}   