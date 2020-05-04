using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

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

        public void Insert(Seller obj)
        {
            _contest.Add(obj);
            _contest.SaveChanges();
        }
    }
}
