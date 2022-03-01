using Architecture.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Types.AgriculturalProductsMarketing
{
   [Serializable]
  public partial  class CategoryRequest : RequestBase
    {
        public CategoryContract Contract { get; set; }
        public CategoryRequest()
        {
            Contract = new CategoryContract();
        }
    }
}
