using Microsoft.AspNetCore.Mvc.ModelBinding;
using ProjectAPI.Model.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Controllers;


namespace ProjectAPI.Model.Repository.Class
{
    public class UpdateModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
                throw new ArgumentNullException(nameof(bindingContext));

            var bodyData = bindingContext.HttpContext.Request.Query;
                var StudentData = new TblStudentDetails
                {
                    StudentId = Convert.ToInt32(bodyData["StudentId"]),
                    StudentName = bodyData["StudentName"],
                    Course = bodyData["Course"],
                    Address = bodyData["Address"],
                    Email = bodyData["Email"],
                    Gender = bodyData["Gender"]
                };
            bindingContext.Result = ModelBindingResult.Success(StudentData);
            return Task.CompletedTask;
           
        }
    }
}