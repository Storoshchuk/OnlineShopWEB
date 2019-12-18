using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using OnlineShop.DAL.Entities;
using OnlineShop.Services.Interfaces;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    public class FeedbackController : Controller
    {
        private readonly ILogger _logger;
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(ILogger<FeedbackController> logger, IFeedbackService feedbackService)
        {
            _logger = logger;
            _feedbackService = feedbackService;
        }


        [HttpGet]
        public async Task<IEnumerable<Feedback>> GetAll()
        {
            var feedbacks = await _feedbackService.GetAllFeedbacks();
            return feedbacks;
        }

        [HttpGet("{id}", Name = "")]
        public async Task<IActionResult> GetById(int id)
        {
            throw new System.Exception();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Feedback item)
        {
            throw new System.Exception();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int? id, [FromBody] Feedback item)
        {
            throw new System.Exception();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            throw new System.Exception();
        }


    }
}