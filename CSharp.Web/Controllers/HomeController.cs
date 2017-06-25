using AutoMapper;
using CSharp.Model;
using CSharp.Service;
using CSharp.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAwardService awardService;
        private readonly IGrantService grantService;

        public HomeController(IAwardService awardService, IGrantService grantService)
        {
            this.awardService = awardService;
            this.grantService = grantService;
        }

        // GET: Home
        public ActionResult Index(string award = null)
        {
            IEnumerable<AwardViewModel> viewModelAwards;
            IEnumerable<Award> awards;

            awards = awardService.GetAwards().ToList();

            viewModelAwards = Mapper.Map<IEnumerable<Award>, IEnumerable<AwardViewModel>>(awards);
            return View(viewModelAwards);
        }

        //public ActionResult Filter(string category, string gadgetName)
        //{
        //    IEnumerable<GadgetViewModel> viewModelGadgets;
        //    IEnumerable<Gadget> gadgets;

        //    gadgets = gadgetService.GetCategoryGadgets(category, gadgetName);

        //    viewModelGadgets = Mapper.Map<IEnumerable<Gadget>, IEnumerable<GadgetViewModel>>(gadgets);

        //    return View(viewModelGadgets);
        //}

        [HttpPost]
        public ActionResult Create(GrantFormViewModel newGrant)
        {
            if (newGrant != null )
            {
                var grant = Mapper.Map<GrantFormViewModel, Grant>(newGrant);
                grantService.CreateGrant(grant);
                                
                grantService.SaveGrant();
            }

            var award = awardService.GetAward(newGrant.OriginalAwardId);
            return RedirectToAction("Index", new { award = "" });
        }
    }
}