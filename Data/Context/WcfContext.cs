using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFService.Data.Context
{
    public class WcfContext : DbContext
    {
        public CodeToContext(DbContextOptions<CodeToContext> options) : base(options)
        {

        }

    
    }
}
