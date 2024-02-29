using System;
using System.Collections.Generic;
using Model;

namespace IDAL
{
    public interface ICategory
    {
        IList<CategoryInfo> GetCategoryById(string nCategoryId);
        IList<CategoryInfo> GetCategory();
    }
}