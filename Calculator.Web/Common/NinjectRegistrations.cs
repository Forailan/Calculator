using Calculator.Data;
using Calculator.Data.Abstractions;
using Calculator.Data.Implementations;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Web.Common
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            base.Bind<IDbContext>()
                .ToConstant<IDbContext>(new DBContext(@"Data Source=HADRON-CALIDER\SQLEXPRESS;Initial Catalog=Calculator;Persist Security Info=True;User ID=SomeUser;Password=qwe123", Logger.Instance));

            base.Bind<ICalculatorRepository>()
                .To<CalculatorRepository>();
        }
    }
}