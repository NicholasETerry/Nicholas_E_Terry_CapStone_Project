using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nicholas_E_Terry_CapStone.Data;
using Nicholas_E_Terry_CapStone.Models;
using Nicholas_E_Terry_CapStone.Services;

namespace Nicholas_E_Terry_CapStone.Controllers
{
    public class ContributorController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly NYTService _nytService;

        public ContributorController(ApplicationDbContext context, NYTService nytService)
        {
            _context = context;
            _nytService = nytService;
        }

        // GET: Contributor
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user =  _context.UserModels.Where(c => c.IdentityUserId ==
            userId).FirstOrDefault();
            if (user == null)
            {
                return RedirectToAction(nameof(Create));
            }
            else
            {
                var newArticle = await _nytService.GetCurrentArticles();
                List<CleanArticle> cleaned = new List<CleanArticle>();

                int i = 0;
                foreach (var item in newArticle.response.docs)
                {
                    CleanArticle newCleanedArticle = new CleanArticle();
                    cleaned.Add(newCleanedArticle);
                    cleaned[i].Lead_paragraph = item.snippet;
                    cleaned[i].Web_url = item.web_url;
                    var tempResults = await Scrapper.GetHtmlAsString(cleaned[i].Web_url); //just to test the scrapper
                    cleaned[i].Word_count = tempResults;
                    i++;
                }
                var applicationDbContext = _context.UserModels.Include(u => u.Education).Include(u => u.Occupation).Include(u => u.Rank).Include(u => u.UserModelAddress).Include(u => u.UserNameModel);
                return View(cleaned/*await applicationDbContext.ToListAsync()*/);
            }
        }

        // GET: Contributor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = await _context.UserModels
                .Include(u => u.Education)
                .Include(u => u.IdentityUser)
                .Include(u => u.Occupation)
                .Include(u => u.Rank)
                .Include(u => u.UserModelAddress)
                .Include(u => u.UserNameModel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userModel == null)
            {
                return NotFound();
            }

            return View(userModel);
        }

        // GET: Contributor/Create
        public IActionResult Create()
        {
            SkillLibrary newSkillLibrary = new SkillLibrary();
            OccupationLibrary newOccupationLibrary = new OccupationLibrary();
            HobbyLibrary newHobbyLibrary = new HobbyLibrary();
            ViewData["OccupationLibrary"] = newOccupationLibrary.occupationLibrary;
            ViewData["HobbyLibrary"] = newHobbyLibrary.hobbyLibrary;
            ViewData["SkillLibrary"] = newSkillLibrary.skillLibrary;
            var mview = new UserModel {First_name = "test", Last_name = "last Name"}; // for testing only
            return View(mview);
        }

        // POST: Contributor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(  UserModel userModel)
        {
             
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                userModel.IdentityUserId = userId;
                _context.Add(userModel);
                await _context.SaveChangesAsync();

                foreach (var item in userModel.Skills)
                {
                    var newSkill = new Skill
                    {
                        UserModelId = userModel.Id,
                        SKill = item
                    };
                    _context.Add(newSkill);
                }
                foreach (var item in userModel.Hobbies)
                {
                    var newHobby = new Hobby
                    {
                        UserModelId = userModel.Id,
                        Hobby_user = item
                    };
                    _context.Add(newHobby);
                }
                foreach (var item in userModel.Previous_Occupations)
                {
                    var newOccupation = new PreviousOccupation
                    {
                        UserModelId = userModel.Id,
                        Previous_occupation = item
                    };
                    _context.Add(newOccupation);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ContributorTest));
            }
            return View(userModel);
        }
        public IActionResult ContributorTest()
        {
            ContributorTestLibrary contributorTestLibrary = new ContributorTestLibrary();
            ViewData["ContributorTestLibrary"] = contributorTestLibrary.NewTestLibrary;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ContributorTest(List<ContributorTest> newTest) // returning nothing at this point.
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.UserModels.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            return RedirectToAction(nameof(Index));
        }

        // GET: Contributor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = await _context.UserModels.FindAsync(id);
            if (userModel == null)
            {
                return NotFound();
            }
            ViewData["EducationId"] = new SelectList(_context.Education, "Id", "Id", userModel.EducationId);
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", userModel.IdentityUserId);
            ViewData["OccupationId"] = new SelectList(_context.Occupations, "Id", "Id", userModel.OccupationId);
            ViewData["RankId"] = new SelectList(_context.Rankings, "Id", "Id", userModel.RankId);
            ViewData["UserAddressId"] = new SelectList(_context.UserModelAddresses, "Id", "Id", userModel.UserAddressId);
            ViewData["UserNameId"] = new SelectList(_context.UserNamesModel, "Id", "Id", userModel.UserNameId);
            return View(userModel);
        }

        // POST: Contributor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,First_name,Last_name,Email_address,UserAddressId,OccupationId,EducationId,UserNameId,RankId,IdentityUserId")] UserModel userModel)
        {
            if (id != userModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserModelExists(userModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EducationId"] = new SelectList(_context.Education, "Id", "Id", userModel.EducationId);
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", userModel.IdentityUserId);
            ViewData["OccupationId"] = new SelectList(_context.Occupations, "Id", "Id", userModel.OccupationId);
            ViewData["RankId"] = new SelectList(_context.Rankings, "Id", "Id", userModel.RankId);
            ViewData["UserAddressId"] = new SelectList(_context.UserModelAddresses, "Id", "Id", userModel.UserAddressId);
            ViewData["UserNameId"] = new SelectList(_context.UserNamesModel, "Id", "Id", userModel.UserNameId);
            return View(userModel);
        }

        // GET: Contributor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = await _context.UserModels
                .Include(u => u.Education)
                .Include(u => u.IdentityUser)
                .Include(u => u.Occupation)
                .Include(u => u.Rank)
                .Include(u => u.UserModelAddress)
                .Include(u => u.UserNameModel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userModel == null)
            {
                return NotFound();
            }

            return View(userModel);
        }

        // POST: Contributor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userModel = await _context.UserModels.FindAsync(id);
            _context.UserModels.Remove(userModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserModelExists(int id)
        {
            return _context.UserModels.Any(e => e.Id == id);
        }
    }
}
