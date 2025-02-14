using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace wpi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class CityController : ControllerBase
{
    class Obj
    {
        public int[] a;
    }

    [HttpGet]
    public IEnumerable<int> Get()
    {
        return [5, 6];
    }

    // GET POST PUT PATCH DELETE
    // CRUD create read update delete
    [HttpGet("{id}")]
    public string Get(int id)
    {
        Obj obj = new Obj();
        // call backend database requests using entity
        if (id == 1)
        {
            // query your database + other logic + entity frame...
            obj.a = [1, 2];
            return JsonConvert.SerializeObject(obj);
        }
        else 
        {
            obj.a = [0];
            return JsonConvert.SerializeObject(obj);
        }
    }
}
