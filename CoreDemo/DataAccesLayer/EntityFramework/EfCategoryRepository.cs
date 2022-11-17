using DataAccesLayer.Abstract;
using DataAccesLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    //--Burada :Hangitablonun Soruglarını çalıştırıcaksın:Hangi Voidler üzerinden
    public class EfCategoryRepository:GenericRepository<Category>,ICategoryDal
    {

    }
}
