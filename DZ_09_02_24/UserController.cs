using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DZ_09_02_24
{
    internal class UserController : Controller
    {
        private readonly IProductService productService;

        public UserController(IProductService productService)
        {
            this.productService = productService;
        }
    }
}
