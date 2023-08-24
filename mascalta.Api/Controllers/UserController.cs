using mascalta.Core.IService;
using mascalta.Data.Modules;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mascalta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        //private readonly IMapper _mapper;

        public UserController(IUserService userService/*, IMapper mapper*/)
        {
            _userService = userService;
          //  _mapper = mapper;
        }

        [Route("getUser")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserTbl))]
        [HttpGet]
        public async Task<ActionResult> GetItems([FromHeader] int IdUser)
        {
            try
            {
                UserTbl user=_userService.GetUser(IdUser);
                if (user != null)
                   return Ok(user);
               
                return BadRequest();
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}
