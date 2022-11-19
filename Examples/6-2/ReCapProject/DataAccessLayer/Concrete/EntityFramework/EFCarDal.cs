using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFCarDal : ICarDal
    {
        public void Add(Car item)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var addedItem = context.Entry(item);
                addedItem.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car item)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var deletedItem = context.Entry(item);
                deletedItem.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car item)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var updatedItem = context.Entry(item);
                updatedItem.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
