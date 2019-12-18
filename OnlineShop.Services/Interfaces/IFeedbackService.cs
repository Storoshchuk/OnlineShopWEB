using OnlineShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services.Interfaces
{
    public interface IFeedbackService
    {
        Task<List<Feedback>> GetAllFeedbacks();
        Task CreateFeedback(Feedback item);
    }
}
