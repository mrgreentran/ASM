using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        ASMDbContext dbContext;
        public ASMDbContext Init()
        {
            return dbContext ?? (dbContext = new ASMDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
