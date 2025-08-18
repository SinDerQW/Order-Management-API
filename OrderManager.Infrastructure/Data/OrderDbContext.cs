using System;
using System.Collections.Generic;
using System.Linq;
 
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;          // Нужно для DbContext и DbSet
using OrderManagement.Domain.Entities;       // Чтобы использовать Order и OrderItem
                                             // Чтобы использовать Order и OrderItem


namespace OrderManagement.Infrastructure.Data
{
    internal class OrderDbContext: DbContext
    {     
    }
}
