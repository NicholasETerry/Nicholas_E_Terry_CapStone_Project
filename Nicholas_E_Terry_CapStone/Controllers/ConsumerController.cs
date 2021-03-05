using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nicholas_E_Terry_CapStone.Data;
using Nicholas_E_Terry_CapStone.Models;
using Nicholas_E_Terry_CapStone.Services;

namespace Nicholas_E_Terry_CapStone.Controllers
{
    public class ConsumerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly NYTService _nytService;

        public ConsumerController(ApplicationDbContext context, NYTService nytService)
        {
            _context = context;
            _nytService = nytService;
        }

        // GET: Consumer
        public async Task<IActionResult> Index()
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
                i++;
            }
            var applicationDbContext = _context.UserModels.Include(u => u.Education).Include(u => u.Hobby).Include(u => u.Occupation).Include(u => u.PreviousOccupation).Include(u => u.Rank).Include(u => u.Skill).Include(u => u.UserModelAddress).Include(u => u.UserNameModel);
            return View(cleaned/*await applicationDbContext.ToListAsync()*/);
        }

        // GET: Consumer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = await _context.UserModels
                .Include(u => u.Education)
                .Include(u => u.Hobby)
                .Include(u => u.Occupation)
                .Include(u => u.PreviousOccupation)
                .Include(u => u.Rank)
                .Include(u => u.Skill)
                .Include(u => u.UserModelAddress)
                .Include(u => u.UserNameModel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userModel == null)
            {
                return NotFound();
            }

            return View(userModel);
        }

        // GET: Consumer/Create
        public IActionResult Create()
        {
            ViewData["EducationId"] = new SelectList(_context.Education, "Id", "Id");
            ViewData["HobbyId"] = new SelectList(_context.Hobbies, "Id", "Id");
            ViewData["OccupationId"] = new SelectList(_context.Occupations, "Id", "Id");
            ViewData["PreviousOccupationId"] = new SelectList(_context.PreviousOccupations, "Id", "Id");
            ViewData["RankId"] = new SelectList(_context.Rankings, "Id", "Id");
            ViewData["SkillId"] = new SelectList(_context.Skills, "Id", "Id");
            ViewData["UserAddressId"] = new SelectList(_context.UserModelAddresses, "Id", "Id");
            ViewData["UserNameId"] = new SelectList(_context.UserNamesModel, "Id", "Id");
            return View();
        }

        // POST: Consumer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,First_name,Last_name,Email_address,UserAddressId,OccupationId,PreviousOccupationId,EducationId,SkillId,HobbyId,UserNameId,RankId")] UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EducationId"] = new SelectList(_context.Education, "Id", "Id", userModel.EducationId);
            ViewData["HobbyId"] = new SelectList(_context.Hobbies, "Id", "Id", userModel.HobbyId);
            ViewData["OccupationId"] = new SelectList(_context.Occupations, "Id", "Id", userModel.OccupationId);
            ViewData["PreviousOccupationId"] = new SelectList(_context.PreviousOccupations, "Id", "Id", userModel.PreviousOccupationId);
            ViewData["RankId"] = new SelectList(_context.Rankings, "Id", "Id", userModel.RankId);
            ViewData["SkillId"] = new SelectList(_context.Skills, "Id", "Id", userModel.SkillId);
            ViewData["UserAddressId"] = new SelectList(_context.UserModelAddresses, "Id", "Id", userModel.UserAddressId);
            ViewData["UserNameId"] = new SelectList(_context.UserNamesModel, "Id", "Id", userModel.UserNameId);
            return View(userModel);
        }

        // GET: Consumer/Edit/5
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
            ViewData["HobbyId"] = new SelectList(_context.Hobbies, "Id", "Id", userModel.HobbyId);
            ViewData["OccupationId"] = new SelectList(_context.Occupations, "Id", "Id", userModel.OccupationId);
            ViewData["PreviousOccupationId"] = new SelectList(_context.PreviousOccupations, "Id", "Id", userModel.PreviousOccupationId);
            ViewData["RankId"] = new SelectList(_context.Rankings, "Id", "Id", userModel.RankId);
            ViewData["SkillId"] = new SelectList(_context.Skills, "Id", "Id", userModel.SkillId);
            ViewData["UserAddressId"] = new SelectList(_context.UserModelAddresses, "Id", "Id", userModel.UserAddressId);
            ViewData["UserNameId"] = new SelectList(_context.UserNamesModel, "Id", "Id", userModel.UserNameId);
            return View(userModel);
        }

        // POST: Consumer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,First_name,Last_name,Email_address,UserAddressId,OccupationId,PreviousOccupationId,EducationId,SkillId,HobbyId,UserNameId,RankId")] UserModel userModel)
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
            ViewData["HobbyId"] = new SelectList(_context.Hobbies, "Id", "Id", userModel.HobbyId);
            ViewData["OccupationId"] = new SelectList(_context.Occupations, "Id", "Id", userModel.OccupationId);
            ViewData["PreviousOccupationId"] = new SelectList(_context.PreviousOccupations, "Id", "Id", userModel.PreviousOccupationId);
            ViewData["RankId"] = new SelectList(_context.Rankings, "Id", "Id", userModel.RankId);
            ViewData["SkillId"] = new SelectList(_context.Skills, "Id", "Id", userModel.SkillId);
            ViewData["UserAddressId"] = new SelectList(_context.UserModelAddresses, "Id", "Id", userModel.UserAddressId);
            ViewData["UserNameId"] = new SelectList(_context.UserNamesModel, "Id", "Id", userModel.UserNameId);
            return View(userModel);
        }

        // GET: Consumer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = await _context.UserModels
                .Include(u => u.Education)
                .Include(u => u.Hobby)
                .Include(u => u.Occupation)
                .Include(u => u.PreviousOccupation)
                .Include(u => u.Rank)
                .Include(u => u.Skill)
                .Include(u => u.UserModelAddress)
                .Include(u => u.UserNameModel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userModel == null)
            {
                return NotFound();
            }

            return View(userModel);
        }

        // POST: Consumer/Delete/5
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
