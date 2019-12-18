using OnlineShop.DAL.Entities;
using OnlineShop.DAL.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        GenericRepository<Customer> CustomerRepository { get;}
        GenericRepository<Feedback> FeedbackRepository { get;}
        GenericRepository<Order> OrderRepository { get;} 
        GenericRepository<PackageType> PackageTypeRepository { get;}
        GenericRepository<Product> ProductRepository { get;}
        GenericRepository<ProductType> ProductTypeRepository { get;}
        GenericRepository<ToDoItem> ToDoItemRepository { get;}
        GenericRepository<User> UserRepository { get;}
        
    }
}
