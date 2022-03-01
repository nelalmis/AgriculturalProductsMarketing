using Architecture.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Architecture.Base;
using Architecture.Types.AgriculturalProductsMarketing;

namespace Architecture.Business.AgriculturalProductsMarketing
{
    public partial class Category:ObjectHelper<CategoryContract,ProjectModel>
    {
        public Category(ExecutionDataContext ex):base(ex,new ProjectModel()) { }

        public GenericResponse<List<CategoryContract>> Select()
        {
            GenericResponse<List<CategoryContract>> returnObject;
            returnObject = this.InitializeGenericResponse<List<CategoryContract>>("");

            var response= base.Select();

            if (!response.Success)
            {
                returnObject.Results.AddRange(response.Results);
                return returnObject;
            }
            returnObject.Value = response.Value.ToList();
            return returnObject;
        }
    }
}
