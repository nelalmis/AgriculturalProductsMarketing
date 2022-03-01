using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Types.AgriculturalProductsMarketing
{
    public class ContextInitializer: DropCreateDatabaseIfModelChanges<ProjectModel>
    {
        protected override void Seed(ProjectModel context)
        {
           

            base.Seed(context);
        }
    }
}
