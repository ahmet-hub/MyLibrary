using System;
using System.Data.Entity;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.DataAccess.Concrete.EntityFramework
{
   public  class MyInitializer:CreateDatabaseIfNotExists <DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            
        }
    }
}
