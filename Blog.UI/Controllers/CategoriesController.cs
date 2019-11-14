using AutoMapper;
using Blog.Infrastructures.Abstractions;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnifiedLMS.Infrastructure.Abstractions;

namespace Blog.UI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IRepo<Category> _repo;
        public IMapper _mapper;
        public CategoriesController(IRepo<Category> repo, IMapper mapper, IGeneralQuery query)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpGet(Name = nameof(GetFaculty))]
        public async Task<IActionResult> GetFaculty()
        {
            var model = await _repo.GetAll();
            var data = _mapper.Map<List<CategoryListVm>>(model);
            return new ObjectResult(data);
        }

        [HttpGet("{id}", Name = nameof(GetFacultyById))]
        public async Task<IActionResult> GetFacultyById([FromRoute] int id)
        {
            var model = await _repo.GetById(id);
            var data = _mapper.Map<CategoryListVm>(model);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> PostFaculty([FromBody] CategoryListVm categoryListVm)
        {
            categoryListVm.Name = categoryListVm.Name.ToUpper();
            var model = _mapper.Map<Category>(categoryListVm);
            if (ModelState.IsValid)
            {
                if (model.CategoryId > 0)
                {
                    _repo.Update(model);
                }
                else
                {

                    await _repo.Save(model);
                }
                var (success, message) = await _repo.SaveContext();
                if (success)
                {
                    return CreatedAtAction(nameof(GetFaculty), new { id = model.CategoryId }, model);

                }
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFaculty([FromRoute] int id)
        {
            var model = await _repo.GetById(id);
            await _repo.Delete(id);
            var response = await _repo.SaveContext();
            if (response.success)
            {
                return Ok(model);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
