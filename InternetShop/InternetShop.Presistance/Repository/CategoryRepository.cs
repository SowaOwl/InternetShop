using InternetShop.Application.Interfaces;
using InternetShop.Domain.Entites;

namespace InternetShop.Presistance.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(Category category)
        {
            _appDbContext.Categories.Add(category);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            IEnumerable<Category> categories = _appDbContext.Categories;
            return categories;
        }

        public Category GetById(int id)
        {
            Category category = _appDbContext.Categories.First(c => c.Id == id);
            return category;
        }

        public void Update(Category category)
        {
            _appDbContext.Categories.Update(category);
            _appDbContext.SaveChanges();
        }
    }
}
