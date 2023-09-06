﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;
using Object_Pool_Design_Pattern_Practive_6.Classes;

namespace Object_Pool_Design_Pattern_Practive_6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        readonly ObjectPool<X> _pool;

        public ValuesController(ObjectPool<X> pool)
        {
            _pool = pool;
        }

        [HttpGet("[action]")]
        public IActionResult Get1()
        {
            var x1 = _pool.Get();
            x1.Count++;
            x1.Write();
            _pool.Return(x1);
            return Ok();
        }
        [HttpGet("[action]")]
        public IActionResult Get2()
        {
            var x2 = _pool.Get();
            x2.Count++;
            x2.Write();
            _pool.Return(x2);

            return Ok();
        }
    }
}
