using MailKit.API.Models;
using MailKit.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MailKit.API.Controllers
{
    [ApiController]
    [Route("api/Mail")]
    public class SendMailController : ControllerBase
    {
        private readonly ISendMailService mailService;
        public SendMailController(ISendMailService mailService)
        {
            this.mailService = mailService;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromForm] MailRequest request)
        {
            try
            {
                await mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message.ToString());
                throw;
            }

        }
    }
}
