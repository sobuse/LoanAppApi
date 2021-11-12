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
    public class LoanOfficerRepository : ILoanOfficerRepository
    {
        public LoanOfficer Add(LoanOfficer obj)
        {
            throw new NotImplementedException();
        }

        public Task<LoanOfficer> AddAsync(LoanOfficer obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoanOfficer> AddRange(IEnumerable<LoanOfficer> obj)
        {
            throw new NotImplementedException();
        }

        public bool Any(Expression<Func<LoanOfficer, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<LoanOfficer, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoanOfficer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LoanOfficer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoanOfficer> GetByCondition(Expression<Func<LoanOfficer, bool>> predicate = null, Func<IQueryable, IOrderedQueryable> orderby = null, int? skip = null, int? take = null, params string[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public LoanOfficer GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<LoanOfficer> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public LoanOfficer GetSingleByCondition(Expression<Func<LoanOfficer, bool>> predicate = null, Func<IQueryable, IOrderedQueryable> orderby = null, params string[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Insert(LoanOfficer entity)
        {
            throw new NotImplementedException();
        }

        public (LoanOfficer, string) SoftDelete(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
