using GolfApi.Model.GameManagement.Request;
using GolfApi.Model.GameManagement.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;

using Common.Entities;
using System.Text.Json;

namespace GolfApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class GameManagementController : Controller
    {
        private readonly ILogger<GameManagementController> _logger;
        private readonly GolfApi.Services.GameManagementService _GameManagementService;

        public GameManagementController(ILogger<GameManagementController> logger, GolfApi.Services.GameManagementService gameManagementService)
         {
            _logger = logger;
            _GameManagementService = gameManagementService;
        }

        [HttpPost("GetGameList")]
        [Authorize]
        public IActionResult GetGameList([FromBody]GameListRequest request)
        {
            var userEmailClaim  = HttpContext.User.FindFirst("email")?.Value;
            _logger.LogInformation(userEmailClaim);
            request.Email = userEmailClaim;
            _logger.LogInformation(request.game_type_id.ToString());
            var result = _GameManagementService.getGameList4Email(request);
            var response = new GolfApi.Model.ResponseModel<List<GameListResponse>>();
            response.Value = result;
            return Ok(response); 
        }
        [HttpGet("GetNewGameParam")]
        [Authorize]
        public IActionResult GetNewGameParam()
        {
            var userEmailClaim  = HttpContext.User.FindFirst("email")?.Value;
            _logger.LogInformation(userEmailClaim);
           
            var result = _GameManagementService.GetNewGameParam();
            var response = new GolfApi.Model.ResponseModel<GameNewResponse>();
            response.Value = result;
            return Ok(response); 
        }      
        [HttpPost("SubmitGameScoreCard")]
        [Authorize]
        public IActionResult SubmitGameScoreCard([FromBody] JsonElement serializedScoreCard)
        {
            var userEmailClaim  = HttpContext.User.FindFirst("email")?.Value;
            _logger.LogInformation(userEmailClaim);
            _logger.LogInformation(serializedScoreCard.ToString());
            var serializerOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
            var gameScoreCard = JsonSerializer.Deserialize<GameInitScoreCardResponse>(serializedScoreCard.GetRawText(), serializerOptions);
           
            var result = "ok";
            if(gameScoreCard != null)
                result = _GameManagementService.GameSubmitScoreCard(gameScoreCard);
            var response = new GolfApi.Model.ResponseModel<string>();
            response.Value = result;
            return Ok(response); 
        }
        [HttpPost("InitGameScoreCard")]
        [Authorize]
        public IActionResult InitGameScoreCard([FromBody] GameInitScoreCardRequest req)
        {
            _logger.LogInformation("Here in InitGameScoreCard");
            try{
                var userEmailClaim  = HttpContext.User.FindFirst("email")?.Value;
                _logger.LogInformation(userEmailClaim);
            
                var result = _GameManagementService.InitGameScoreCard(req.game_id,userEmailClaim);
                var response = new GolfApi.Model.ResponseModel<GameInitScoreCardResponse>();
                response.Value = result;
                return Ok(response); 
            }
            catch(Exception E)
            {
                var response = new GolfApi.Model.ResponseModel<string>();
                _logger.LogInformation(E.Message);
                response.Value = null;
                 
                response.ErrorMessages.Add("reason",E.Message); 

                return Ok(response); 
            }
            
        }   
        [HttpPost("CreateNewGame")]
        [Authorize]
        public IActionResult CreateNewGame([FromBody]NewGameRequest request)
        {
            var creator  = HttpContext.User.FindFirst("email")?.Value;
            _logger.LogInformation(creator);
            _logger.LogInformation(request.game_date.ToLongTimeString());
            _logger.LogInformation(request.golfcourse_id.ToString());
            _logger.LogInformation(request.golfcourse_name);
            _logger.LogInformation(request.golfhandle1);
            _logger.LogInformation(request.golfhandle2);
            _logger.LogInformation(request.golfhandle3);
            _logger.LogInformation(request.golfhandle4);
            _logger.LogInformation(request.golfhandle5);
            _logger.LogInformation(request.golfhandle6);
            _logger.LogInformation(request.golfhandle7);

           
            var result = _GameManagementService.CreateNewGame(request,creator);
            var response = new GolfApi.Model.ResponseModel<int>();
            response.Value = result;
            return Ok(response); 
        }          
    }
}
