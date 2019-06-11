using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarkPolDist.Common.Models;
using MarkPolDist.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MarkPolDist.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestRepository _testRepository;

        public TestController(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        // GET api/test/{id}
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<TestData>> Get(int id)
        {
            var result = await _testRepository.GetById(id);

            if (result == null) return NotFound();

            return result;
        }

        // GET api/test
        [HttpGet]
        public async Task<ActionResult<List<TestData>>> Get()
        {
            return await _testRepository.GetAllTestDataAsync();
        }
    }
}
