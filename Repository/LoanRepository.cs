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
    public class LoanRepository : ILoanRepository
    {
        public Loan Add(Loan obj)
        {
            throw new NotImplementedException();
        }

        public Task<Loan> AddAsync(Loan obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Loan> AddRange(IEnumerable<Loan> obj)
        {
            throw new NotImplementedException();
        }

        public bool Any(Expression<Func<Loan, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<Loan, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Loan> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Loan>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Loan> GetByCondition(Expression<Func<Loan, bool>> predicate = null, Func<IQueryable, IOrderedQueryable> orderby = null, int? skip = null, int? take = null, params string[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Loan GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<Loan> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Loan GetSingleByCondition(Expression<Func<Loan, bool>> predicate = null, Func<IQueryable, IOrderedQueryable> orderby = null, params string[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Insert(Loan entity)
        {
            throw new NotImplementedException();
        }

        public (Loan, string) SoftDelete(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
