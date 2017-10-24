using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private ASMDbContext dbContext;
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public ASMDbContext DbContext()
        {
            return dbContext ?? (dbContext = dbFactory.Init());
        }
        public void Commit()
        {
            dbContext.SaveChanges();
        }
    }
}
