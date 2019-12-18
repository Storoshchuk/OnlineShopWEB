using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.UnitOfWork;
using OnlineShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FeedbackService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<List<Feedback>> GetAllFeedbacks()
        {
            var products = await _unitOfWork.FeedbackRepository.GetAll().ToListAsync();
            return products;
        }

        public async Task CreateFeedback(Feedback item)
        {
            await _unitOfWork.FeedbackRepository.Create(item);
        }
    }
}
