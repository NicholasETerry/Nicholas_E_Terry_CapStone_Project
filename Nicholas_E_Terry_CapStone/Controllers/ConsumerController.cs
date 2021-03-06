﻿using System;
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
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.UserModels.Where(c => c.IdentityUserId ==
            userId).FirstOrDefault();
            if(user == null)
            {              
                var newArticle = await _nytService.GetCurrentArticles();
                List<CleanArticle> cleaned = new List<CleanArticle>();
                 
          
                int i = 0;
                foreach (var item in newArticle.response.docs)
                {
                    CleanArticle newCleanedArticle = new CleanArticle();
                    cleaned.Add(newCleanedArticle);
                    cleaned[i].Lead_paragraph = item.headline.main;
                    cleaned[i].Web_url = item.web_url;
                   var tempResults = await Scrapper.GetHtmlAsString(cleaned[i].Web_url) ; //just to test the scrapper
                    cleaned[i].Word_count = tempResults ;

                    var DoesExist = _context.CleanArticles.Where(a => a.Web_url == cleaned[i].Web_url).FirstOrDefault();

                    if (DoesExist == null)
                    {
                        _context.Add(cleaned[i]);
                    }
                    else
                    {
                        cleaned[i].Id = DoesExist.Id;
                    }
                    i++;
                }
                await _context.SaveChangesAsync();
                List<int> userPoints = new List<int>();
                List<string> userName = new List<string>();
                List<int> userList = new List<int>();
                List<int> articleList = new List<int>();
                var newTag = _context.TagsContributorsSuggest.ToList();
                foreach (var item in newTag)
                {

                    if (articleList.Contains(item.TagCleanArticleId) == false)
                    {
                        articleList.Add(item.TagCleanArticleId);
                        var getUser = _context.UserNamesModel.Where(c => c.Id == item.UserId).FirstOrDefault();
                        userName.Add(getUser.User_name);
                        userPoints.Add(getUser.User_points);
                    }
                }
                ViewData["userPoint"] = userPoints;
                ViewData["userName"] = userName;
                ViewData["articleList"] = articleList;
                return View(cleaned);
            }
            else
            {
                return RedirectToAction("Index", "Contributor", new { area = "Contributor" });
            }
        }
        public async Task<IActionResult> BreakingNews()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.UserModels.Where(c => c.IdentityUserId ==
            userId).FirstOrDefault();
            if (user == null)
            {
                var newArticle = await _nytService.GetBreakingArticles();
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
            else
            {
                return RedirectToAction("Index", "Consumer", new { area = "Consumer" });
            }
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
