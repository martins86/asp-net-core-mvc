using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _contest;

        public SellerService(SalesWebMvcContext context)
        {
            _contest = context;
        }

        public List<Seller> FindAll()
        {
            return _contest.Seller.ToList();
        }
    }
}
