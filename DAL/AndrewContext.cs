using System.Data.Entity;
using EFCF.DAL.Models;

namespace EFCF.DAL
{
    public class AndrewContext : DbContext
    {
        public AndrewContext() : base("name=AndrewContext")
    {
    }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Order> Orders { get; set; }
    }
}
