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

        public bool Delete(int id)
        {
            var cat = Get(id);
            context.Categories.Remove(cat);
            var check = context.Categories.First(x => x.Id == id);
            var entries = context.SaveChanges();
            return entries == 1;
        }

        public Category Get(int id)
        {
            var d = context.Categories.Single(x => x.Id == id);
            return d;
        }

        public IEnumerable<Category> GetAll()
        {
            var d = context.Categories.ToList();
            return d;
        }

        public bool Update(Category cat)
        {
            context.Update(cat);
            return context.SaveChanges() == 1;
        }
    }
}