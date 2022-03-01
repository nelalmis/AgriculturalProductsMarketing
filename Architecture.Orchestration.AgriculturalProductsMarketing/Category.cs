using Architecture.Base;
using Architecture.Core;
using Architecture.Types.AgriculturalProductsMarketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Orchestration.AgriculturalProductsMarketing
{
   public partial class Category
    {
        public GenericResponse<List<Types.AgriculturalProductsMarketing.CategoryContract>> Select(ObjectHelper objectHelper, CategoryRequest request)
        {
            GenericResponse<List<Types.AgriculturalProductsMarketing.CategoryContract>> returnObject =objectHelper.InitializeGenericResponse<List<Types.AgriculturalProductsMarketing.CategoryContract>>("SelectByColumns");
            Architecture.Business.AgriculturalProductsMarketing.Category bo = new Business.AgriculturalProductsMarketing.Category(objectHelper.ExecutionDataContext);

            GenericResponse<List<Types.AgriculturalProductsMarketing.CategoryContract>> response = bo.Select();
            if (!response.Success)
            {
                returnObject.Results.AddRange(response.Results);
                return returnObject;
            }

            returnObject.Value = response.Value;
            return returnObject;
        }

    }
}
