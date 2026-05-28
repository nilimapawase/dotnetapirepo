using ApiProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{//  [Route("api/[controller]")]
    [ApiController]
    public class StateApiController : ControllerBase
    {

        [HttpGet()]
        [Route("api/allstates")]
        public List<State> GetAllStates()
        {
            List<State> lst = GetStates();
            return lst;
        }
        [HttpGet("api/state/{id}")]
        public State GetState(int id)
        {
            State st = GetStates().FirstOrDefault(e => e.StateId.Equals(id));
            return st;
        }


        [NonAction]
        public List<State> GetStates()
        {
            List<State> states = new List<State>()
            {
                new State(){StateId=1,StateName="Maharashtra"},
                new State(){StateId=2,StateName="Gujarat"},
                new State(){StateId=3,StateName="Rajasthan"},
                new State(){StateId=4,StateName="Punjab"},
                new State(){StateId=5,StateName="Goa"},
                new State(){StateId=6,StateName="Haryana"},
                new State(){StateId=7,StateName="Karnataka"},
                new State(){StateId=8,StateName="MP"},
                new State(){StateId=9,StateName="UP"},
                new State(){StateId=10,StateName="Kerala"}
            };
            return states;
        }
    }
}
