namespace WebApp.Models
{
    public static class CategoriesRepository
    {
        public static List<Category> _category = new List<Category>()
        {
            new Category(1,"Cake","Chocolate flavour"),
            new Category(2,"Cool drinks","No sugar"),
            new Category(3,"Egg rice","Less spicy")
        };

        // Add
        public static void AddCategory(Category category)
        {
            if (category == null) return;
            var maxId = _category.Max(x => x.Id);
            category.Id = maxId + 1;
            _category.Add(category);

        }

        // print
        public static List<Category> GetCategories()
        {
            return _category;
        }



        public static Category GetCategoryById(int id)
        {
            Category found = _category.FirstOrDefault(x => x.Id == id);
            if (found != null)
            {
                return new Category
                {
                    Id = found.Id,
                    Name = found.Name,
                    Description = found.Description
                };
            }
            return null;
        }

        // update
        public static void UpdateCategoryById(int id, Category category)
        {
            var ccategory = _category.FirstOrDefault(x => x.Id == id);
            if (ccategory != null)
            {
                ccategory.Name = category.Name;
                ccategory.Description = category.Description;
            }

        }

        // delete
        public static void DeleteById(int id)
        {
            var ccategory = _category.FirstOrDefault(x => x.Id == id);
            if (ccategory != null)
            {
                _category.Remove(ccategory);
            }
        }
    }
}
