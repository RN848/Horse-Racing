using Backend.Data;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Dtos;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryController : ControllerBase // Renamed from BaseController for clarity
    {
        private readonly DbContextApp _dbContext;

        public DeliveryController(DbContextApp dbContext)
        {
            _dbContext = dbContext;
        }
        
        
        [HttpPost("send-robot")]
        public async Task<IActionResult> SendRobot([FromBody] CreateDeliveryDto dto)
        {
            if (dto == null || !dto.Samples.Any())
            {
                return BadRequest("Request must contain at least one sample.");
            }

            // 1. Create the Delivery Request object
            var newRequest = new DeliveryRequest
            {
                OriginRoomId = dto.OriginRoomId,
                DestinationRoomId = dto.DestinationRoomId,
                RequesterId = dto.StaffId, 
                RequestTime = DateTime.Now // C# handles the time as we planned
            };

            // 2. Map the Samples from the DTO to the Model
            foreach (var s in dto.Samples)
            {
                newRequest.Samples.Add(new Sample
                {
                    SampleUniqueId = s.SampleId,
                    SampleType = s.SampleType
                });
            }

            // 3. Save to Database
            _dbContext.DeliveryRequests.Add(newRequest);
            await _dbContext.SaveChangesAsync();

            return Ok(new { 
                message = "Robot dispatched successfully!", 
                requestId = newRequest.RequestId 
            });
        }
        
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto login)
        {
            // 1. Look for the user in the database
            var user = _dbContext.Staffs
                .FirstOrDefault(u => u.Username == login.Username && u.Password == login.Password);

            // 2. If not found, return 401 Unauthorized
            if (user == null)
            {
                return Unauthorized(new { message = "Invalid username or password" });
            }

            // 3. If found, return the user info (so the UI knows who is logged in)
            return Ok(new {
                message = "Login successful!",
                staffId = user.StaffId,
                fullName = user.FullName
            });
        }
        
        // GET: api/delivery/my-history/1
        [HttpGet("my-history/{staffId}")]
        public async Task<IActionResult> GetMyHistory(int staffId)
        {
            var history = await _dbContext.DeliveryRequests
                .Where(d => d.RequesterId == staffId)
                .Select(d => new DeliveryHistoryDto 
                {
                    RequestId = d.RequestId,
                    OriginRoom = d.OriginRoomId,
                    DestinationRoom = d.DestinationRoomId,
                    Time = d.RequestTime,
                    SampleIds = d.Samples.Select(s => s.SampleUniqueId).ToList()
                })
                .OrderByDescending(d => d.Time)
                .ToListAsync();

            return Ok(history);
        }
        
        
        // GET: api/delivery/rooms
        [HttpGet("rooms")]
        public async Task<IActionResult> GetRooms()
        {
            // Fetch all locations from the database
            var rooms = await _dbContext.Locations
                .Select(l => new {
                    l.RoomId,
                    l.Description
                })
                .ToListAsync();

            return Ok(rooms);
        }
        
        // GET: api/delivery/my-waiting/{staffId}
        [HttpGet("my-waiting/{staffId}")]
        public async Task<IActionResult> GetMyWaiting(int staffId)
        {
            var waiting = await _dbContext.DeliveryRequests
                .Where(d => d.RequesterId == staffId && d.Status == "Waiting")
                .Select(d => new WaitingRequestDto
                {
                    RequestId = d.RequestId,
                    OriginRoomId = d.OriginRoomId,
                    DestinationRoomId = d.DestinationRoomId,
                    Status = d.Status,
                    Samples = d.Samples.Select(s => new SampleSummaryDto 
                    {
                        SampleId = s.SampleUniqueId,
                        SampleType = s.SampleType
                    }).ToList()
                })
                .ToListAsync();

            return Ok(waiting);
        }

// 2. Confirm pickup and change status to "In Transit"
        [HttpPost("confirm-pickup/{requestId}")]
        public async Task<IActionResult> ConfirmPickup(int requestId)
        {
            var request = await _dbContext.DeliveryRequests.FindAsync(requestId);
            if (request == null) return NotFound();

            request.Status = "In Transit";
            await _dbContext.SaveChangesAsync();

            return Ok(new { message = "Robot is now moving to destination!" });
        }
        
        [HttpGet("my-transit/{staffId}")]
        public async Task<IActionResult> GetMyInTransit(int staffId)
        {
            var moving = await _dbContext.DeliveryRequests
                .Where(d => d.RequesterId == staffId && d.Status == "In Transit")
                .Select(d => new TransitRequestDto
                {
                    RequestId = d.RequestId,
                    OriginRoomId = d.OriginRoomId,
                    DestinationRoomId = d.DestinationRoomId,
                    Status = d.Status,
                    RequestTime = d.RequestTime,
                    Samples = d.Samples.Select(s => new SampleSummaryDto
                    {
                        SampleId = s.SampleUniqueId,
                        SampleType = s.SampleType
                    }).ToList()
                })
                .OrderBy(d => d.RequestId)
                .ToListAsync();

            return Ok(moving);
        }

// 2. Confirm the robot has reached the destination
        [HttpPost("confirm-arrival/{requestId}")]
        public async Task<IActionResult> ConfirmArrival(int requestId)
        {
            var request = await _dbContext.DeliveryRequests.FindAsync(requestId);
            if (request == null) return NotFound();

            request.Status = "Completed";
            request.ArrivalTime = DateTime.Now; // Record the exact time it reached
            await _dbContext.SaveChangesAsync();

            return Ok(new { message = "Delivery marked as Completed!" });
        }
        
        [HttpGet("all-trips/{staffId}")]
        public async Task<IActionResult> GetAllTrips(int staffId)
        {
            return Ok(await _dbContext.DeliveryRequests
                .Where(d => d.RequesterId == staffId)
                .Select(d => new DeliveryResponseDto
                {
                    RequestId = d.RequestId,
                    OriginRoomId = d.OriginRoomId,
                    DestinationRoomId = d.DestinationRoomId,
                    Status = d.Status,
                    RequestTime = d.RequestTime,
                    ArrivalTime = d.ArrivalTime,
                    Samples = d.Samples.Select(s => new SampleDto
                    {
                        SampleId = s.SampleUniqueId,
                        SampleType = s.SampleType
                    }).ToList()
                })
                .OrderByDescending(d => d.RequestTime)
                .ToListAsync());
        }
        
    }
    
    
}