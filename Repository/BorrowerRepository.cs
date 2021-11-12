using Contract;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BorrowerRepository : IBorrowerRepository
    {
        public Borrower Add(Borrower obj)
        {
            throw new NotImplementedException();
        }

        public Task<Borrower> AddAsync(Borrower obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Borrower> AddRange(IEnumerable<Borrower> obj)
        {
            throw new NotImplementedException();
        }

        public bool Any(Expression<Func<Borrower, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<Borrower, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Borrower> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Borrower>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Borrower> GetByCondition(Expression<Func<Borrower, bool>> predicate = null, Func<IQueryable, IOrderedQueryable> orderby = null, int? skip = null, int? take = null, params string[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Borrower GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<Borrower> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Borrower GetSingleByCondition(Expression<Func<Borrower, bool>> predicate = null, Func<IQueryable, IOrderedQueryable> orderby = null, params string[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Insert(Borrower entity)
        {
            throw new NotImplementedException();
        }

        public (Borrower, string) SoftDelete(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
