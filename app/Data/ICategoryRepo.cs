using System.Collections.Generic;
using teste.Models;

namespace teste.Data
{
    public interface ICategoryRepo 
    {
        public IEnumerable<Category> GetAll();
        public Category Get(int id);
        public Category Create(Category cat);
    }
}