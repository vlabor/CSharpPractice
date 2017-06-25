using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Model;
using CSharp.Repositories.Interface;
using CSharp.Infrastructure;
using CSharp.Repositories;

namespace CSharp.Service
{
    public class GrantService : IGrantService
    {
        private readonly IGrantRepository grantRepository;
        private readonly IAwardRepository awardRepository;
        private readonly IUnitOfWork unitOfWork;

        public GrantService(IGrantRepository grantRepository, IAwardRepository awardRepository, IUnitOfWork unitOfWork)
        {
            this.grantRepository = grantRepository;
            this.awardRepository = awardRepository;
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

        public IEnumerable<Grant> GetGrantsByAward(int awardId)
        {
            var award = awardRepository.GetById(awardId);
            var grants = award.Grants.ToList();
            return grants;
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
