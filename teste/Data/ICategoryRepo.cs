using System.Collections.Generic;
using teste.Models;

namespace teste.Data
{
    public interface ICategoryRepo 
    {
        public IEnumerable<Category> GetAll();
        public Category Get(int id);
        public Category Create(Category cat);
        public bool Delete(int id);
        public bool Update(Category cat);
    }
}