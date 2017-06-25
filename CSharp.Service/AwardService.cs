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
    public class AwardService : IAwardService
    {
        private readonly IAwardRepository awardRepository;
        private readonly IUnitOfWork unitOfWork;

        public AwardService(IAwardRepository awardRepository, IUnitOfWork unitOfWork)
        {
            this.awardRepository = awardRepository;
            this.unitOfWork = unitOfWork;
        }
        public void CreateAward(Award award)
        {
            awardRepository.Add(award);
        }

        public Award GetAward(int id)
        {
            var award = awardRepository.GetById(id);
            return award;
        }

        public Award GetAward(string title)
        {
            var award = awardRepository.Get(a => a.Title == title);
            return award;
        }

        public IEnumerable<Award> GetAwards()
        {
            var awards = awardRepository.GetAll();
            return awards;
        }

        public void SaveAward()
        {
            unitOfWork.Commit();
        }
    }
}
