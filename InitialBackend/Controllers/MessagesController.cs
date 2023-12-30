using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InitialBackend;
using InitialBackend.DataObjects;
using InitialBackend.Interfaces;
using InitialBackend.Repositories;

namespace InitialBackend.Controllers
{
    [Route("api/messages")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageRepository _messageRepository;

        public MessageController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        [HttpPost]
        public ActionResult<int> Create(Message message)
        {
            var messageId = _messageRepository.Create(message);
            return Ok(messageId);
        }

        [HttpGet("{id}")]
        public ActionResult<Message> Retrieve(int id)
        {
            var message = _messageRepository.Retrieve(id);

            if (message == null)
            {
                return NotFound();
            }

            return Ok(message);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Message>> List()
        {
            var messages = _messageRepository.List();
            return Ok(messages);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _messageRepository.Delete(id);
            return NoContent();
        }
    }
}
