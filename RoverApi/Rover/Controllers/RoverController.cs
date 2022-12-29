using Microsoft.AspNetCore.Mvc;
using Rover.Contracts;
using Rover.Models;

namespace Rover.Controllers
{
    [ApiController]
    public class RoverController : ControllerBase
    {
        public RoverDom _rover = new RoverDom();

        public RoverController(RoverDom rover)
        {
            _rover = rover;
        }

        [HttpGet("rover/plateau")]
        public List<int> SetRoverPlateau()
        {
            List<int> response = _rover.Plateau();
            return response;
        }

        [HttpPost("/rover/plateau")]
        public List<int> SetRoverPlateau(RoverRequest request)
        {
            List<int> response = _rover.Plateau(int.Parse(request.x), int.Parse(request.y));
            return response;
        }

        [HttpGet("/rover/location")]
        public List<string> GetRoverLocation()
        {
             return _rover.GetLocation();
        }

        [HttpPut("/rover")]
        public List<string> MoveRover(RoverRequest request)
        {
            List<string> response = _rover.MoveRover(int.Parse(request.x), int.Parse(request.y));
            return response;
        }
    }
}
