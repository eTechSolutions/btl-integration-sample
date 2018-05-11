using System;
using Microsoft.AspNetCore.Mvc;
using BtlLenderSampleApi.Models;
using BtlLenderSampleApi.Services;
using Newtonsoft.Json;

namespace BtlLenderSampleApi.Controllers
{
    [Route("[controller]")]
    public class IntegrationController : Controller
    {
        private readonly IBtlPayloadValidator _payloadValidator;

        public IntegrationController(IBtlPayloadValidator payloadValidator)
        {
            _payloadValidator = payloadValidator;
        }

        [HttpPost]
        public IActionResult Post()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            // Ensure that the payload came from BTL Hub by checking the signature in the header
            if (_payloadValidator.IsPayloadValid(Request, out string payload))
            {
                Console.WriteLine("Payload matched signature.");
            }
            else
            {
                Console.WriteLine("Payload did not match signature.");
            }

            // Deserialize the payload into an application object, ready to use as needed
            Application application;
            try
            {
                application = JsonConvert.DeserializeObject<Application>(payload);
                Console.WriteLine(
                    $"Received application from {application.SubmittedByBrokerFirm} by {application.SubmittedByBrokerUser}");
            }
            catch (JsonException)
            {
                Console.WriteLine("Error deserializing payload.");
                return BadRequest("Payload was not valid.");
            }

            return NoContent();
        }
    }
}
