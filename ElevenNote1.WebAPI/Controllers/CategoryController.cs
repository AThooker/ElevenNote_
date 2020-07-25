using ElevenNote.Models;
using ElevenNote.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElevenNote1.WebAPI.Controllers
{
    public class CategoryController : ApiController
    {
        //READ
        public IHttpActionResult Get()
        {
            CategoryService categoryService = CreateCategoryService();
            var categories = categoryService.GetCategories();
            return Ok(categories);
        }
        //READ
        public IHttpActionResult Get(int id)
        {
            CategoryService categoryService = CreateCategoryService();
            var category = categoryService = CreateCategoryService();
            return Ok(category);
        }
        //CREATE
        public IHttpActionResult Post(CategoryCreate note)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCategoryService();

            if (!service.CreateNote(note))
                return InternalServerError();

            return Ok();

        }
        //CREATE
        private CategoryService CreateCategoryService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var categoryService = new CategoryService(userId);
            return categoryService;
        }
        //UPDATE
        public IHttpActionResult Put(CategoryEdit note)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCategoryService();

            if (!service.UpdateCategory(note))
                return InternalServerError();

            return Ok();
        }
        //DELETE
        public IHttpActionResult Delete(int id)
        {
            var service = CreateCategoryService();

            if (!service.DeleteCategory(id))
                return InternalServerError();

            return Ok();
        }
    }
}
