using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            //if (_context.Department.Any() || 
            //    _context.Seller.Any() ||
            //    _context.SalesRecord.Any())
            //{
            //    return;
            //}
            //Department d1 = new Department(1, "Computers");
            //Department d2 = new Department(2, "Eletronics");
            //Department d3 = new Department(3, "Fashion");
            //Department d4 = new Department(4, "Books");



        }


    }
}
