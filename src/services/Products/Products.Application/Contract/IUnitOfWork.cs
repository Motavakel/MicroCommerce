using Products.Domin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Contract;

public interface IUnitOfWork
{
    Task<int> SaveAsync();
    IGenericRepository<T> GetGenericRepository<T>() where T : BaseEntity;
}
