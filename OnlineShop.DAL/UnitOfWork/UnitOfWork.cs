using OnlineShop.DAL.Context;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.GenericRepository;
using System;
using System.Diagnostics;

namespace OnlineShop.DAL.UnitOfWork
{

    public class UnitOfWork: IUnitOfWork, IDisposable
    {
        private readonly OnlineShopContext _context;

        private GenericRepository<Customer> _customerRipository;
        private GenericRepository<Feedback> _feedbackRipository;
        private GenericRepository<Order> _orderRepository;
        private GenericRepository<PackageType> _packageTypeRepository;
        private GenericRepository<Product> _productRepository;
        private GenericRepository<ProductType> _productTypeRepository;
        private GenericRepository<ToDoItem> _toDoItemRepository;
        private GenericRepository<User> _userRepository;


        public UnitOfWork(OnlineShopContext context)
        {
            _context = context;
        }


        public GenericRepository<Customer> CustomerRepository
        {
            get { return _customerRipository ?? (_customerRipository = new GenericRepository<Customer>(_context)); }
        }

        public GenericRepository<Feedback> FeedbackRepository
        {
            get { return _feedbackRipository ?? (_feedbackRipository = new GenericRepository<Feedback>(_context)); }
        }

        public GenericRepository<Order> OrderRepository
        {
            get { return _orderRepository ?? (_orderRepository = new GenericRepository<Order>(_context)); }
        }

        public GenericRepository<PackageType> PackageTypeRepository
        {
            get { return _packageTypeRepository ?? (_packageTypeRepository = new GenericRepository<PackageType>(_context)); }
        }

        public GenericRepository<Product> ProductRepository
        {
            get { return _productRepository ?? (_productRepository = new GenericRepository<Product>(_context)); }
        }

        public GenericRepository<ProductType> ProductTypeRepository
        {
            get { return _productTypeRepository ?? (_productTypeRepository = new GenericRepository<ProductType>(_context)); }
        }

        public GenericRepository<ToDoItem> ToDoItemRepository
        {
            get { return _toDoItemRepository ?? (_toDoItemRepository = new GenericRepository<ToDoItem>(_context)); }
        }

        public GenericRepository<User> UserRepository
        {
            get { return _userRepository ?? (_userRepository = new GenericRepository<User>(_context)); }
        }

        public void Save()
        {
                _context.SaveChanges();
        }


        #region Implementing IDiosposable

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Debug.WriteLine("UnitOfWork is being disposed");
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}

