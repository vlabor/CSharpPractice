using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Model;
using CSharp.Repositories.Interface;
using CSharp.Infrastructure;

namespace CSharp.Service
{
    public class GrantService : IGrantService
    {
        private readonly IGrantRepository grantRepository;
        private readonly IUnitOfWork unitOfWork;

        public GrantService(IGrantRepository grantRepository, IUnitOfWork unitOfWork)
        {
            this.grantRepository = grantRepository;
            this.unitOfWork = unitOfWork;
        }
        public void CreateGrant(Grant grant)
        {
            grantRepository.Add(grant);
        }

        public Grant GetGrant(int id)
        {
            var grant = grantRepository.GetById(id);
            return grant;
        }

        public Grant GetGrantByAward(int awardId)
        {
            var grant = grantRepository.GetGrantByAwardId(awardId);
            return grant;
        }

        public IEnumerable<Grant> GetGrants()
        {
            var grants = grantRepository.GetAll();
            return grants;
        }

        public void SaveGrant()
        {
            unitOfWork.Commit();
        }
    }
}
