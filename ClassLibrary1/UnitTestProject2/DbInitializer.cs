﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    class DbInitializer : DropCreateDatabaseAlways<CompanyContext>
    {
        public override Seed()
        {
            
        }
    }
}
