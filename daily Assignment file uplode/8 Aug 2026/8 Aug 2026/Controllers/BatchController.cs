using _8_Aug_2026.Models;
using _8_Aug_2026.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _8_Aug_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatchController : ControllerBase
    {
        
            private readonly IBatchService service;
            public BatchController(IBatchService service)
            {
                this.service = service;
            }
            [HttpGet]
            public IActionResult GetBatchs()
            {
                return Ok(service.GetBatchs());
            }

           

            [HttpPost]
            public IActionResult AddStudent(Batch batch)

            {
                service.Addbatch(batch);
                return Ok(batch);
            }

            [HttpPut]
            public IActionResult UpdateBatch(int id, Batch batch)
            {
                var updateBatch = service.UpdateBatch(id, batch);
                if (updateBatch == null)
                {
                    return NotFound();
                }
                return Ok(updateBatch);
            }

            [HttpDelete]
            public IActionResult DeleteById(int id)
            {
                var batch = service.DeleteBatch(id);
                if (batch == null)
                {
                    return NotFound();
                }
                return Ok(batch);
            }
        }
}
