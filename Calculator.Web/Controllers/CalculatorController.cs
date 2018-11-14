using Calculator.Data.Abstractions;
using Calculator.Data.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Web.Controllers
{
    public class CalculatorController : Controller
    {
        #region Fields

        private readonly ICalculatorRepository calculatorRepository;

        #endregion

        #region Constructors

        public CalculatorController(ICalculatorRepository calculatorRepository)
        {
            this.calculatorRepository = calculatorRepository ?? throw new ArgumentNullException(nameof(calculatorRepository));
        }

        #endregion

        #region Methods

        // GET: Calculator
        public async Task<ActionResult> Index()
        {
            await this.calculatorRepository.GetUsers();

            return View();
        }

        #endregion
    }
}