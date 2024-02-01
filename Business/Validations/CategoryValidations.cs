using Business.Tools.Exceptions;
using Core.Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validations;

public class CategoryValidations
{
    public async Task CategoryNameCanNotBeEmpty(Category? category)
    {
        if (category == null)
        {
            throw new ValidationException("Category name can not be empty.");
        }
        await Task.CompletedTask;
    }
}
