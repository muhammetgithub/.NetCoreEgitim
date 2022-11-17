using BusinessLayer.Abstract;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    //--Concrete--//Yer alan Classlar(sınıflar):Manager olarak adlandırılıyor
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;
        //Ctor tab tab yhapınca asagıdakı public categorymanager olusturuyor 
        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }

        public void CategoryAdd(Category category)
        {
          efCategoryRepository.Insert(category);
          
        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }

        public List<Category> GetAllCategories()
        {
            return efCategoryRepository.GetListAll();
        }

        public Category GetCategoryId(int id)
        {
            return efCategoryRepository.GetById(id);
        }
    }
}
