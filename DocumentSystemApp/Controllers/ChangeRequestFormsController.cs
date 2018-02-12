using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DocumentSystemApp.Data;
using DocumentSystemApp.Data.Entities;
using Microsoft.AspNetCore.Identity;
using DocumentSystemApp.Models;
using DocumentSystemApp.Models.ChangeRequestFormViewModels;
using DocumentSystemApp.Repositories;
using AutoMapper;

namespace DocumentSystemApp.Controllers
{
    public class ChangeRequestFormsController : Controller
    {
        private readonly DocumentSystemDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IChangeRequestFormRepository _changeRequestFormRepository;
        private readonly IMapper _mapper;

        public ChangeRequestFormsController(DocumentSystemDbContext context, 
            UserManager<ApplicationUser> userManager,
            IChangeRequestFormRepository changeRequestFormRepository,
            IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _changeRequestFormRepository = changeRequestFormRepository;
            _mapper = mapper;
        }

        // GET: ChangeRequestForms
        public async Task<IActionResult> Index()
        {
            var model = _changeRequestFormRepository.ChangeRequestFormLists();
            return View(model);
        }

        // GET: ChangeRequestForms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var changeRequestForm = _changeRequestFormRepository.GetById(id.Value);
            
            //var changeRequestForm = await _context.ChangeRequestForms
            //    .SingleOrDefaultAsync(m => m.ChangeRequestFormId == id);
            if (changeRequestForm == null)
            {
                return NotFound();
            }
            var model = _mapper.Map<ChangeRequestForm, RequestFormCreateEditViewModel>(changeRequestForm);

            return View(model);
        }

        // GET: ChangeRequestForms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChangeRequestForms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RequestFormCreateEditViewModel requestFormCreateEditViewModel)
        {
            if (requestFormCreateEditViewModel.ChangeRequestFormId != null)
            {
                requestFormCreateEditViewModel.ChangeRequestFormId = null;
            }

            if (ModelState.IsValid)
            {
                var userID = _userManager.GetUserId(User);
                var model = _mapper.Map<RequestFormCreateEditViewModel, ChangeRequestForm>(requestFormCreateEditViewModel);
                model.CreateDate = DateTime.Now;
                model.CreatorUserId = userID;
                _changeRequestFormRepository.Create(model);
                return RedirectToAction(nameof(Index));
            }
            return View(requestFormCreateEditViewModel);
        }

        // GET: ChangeRequestForms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var changeRequestForm = _changeRequestFormRepository.GetById(id.Value);

            if (changeRequestForm == null)
            {
                return NotFound();
            }
            var model = _mapper.Map<ChangeRequestForm, RequestFormCreateEditViewModel>(changeRequestForm);

            //var changeRequestForm = await _context.ChangeRequestForms.SingleOrDefaultAsync(m => m.ChangeRequestFormId == id);
            //if (changeRequestForm == null)
            //{
            //    return NotFound();
            //}
            return View(model);
        }

        // POST: ChangeRequestForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(RequestFormCreateEditViewModel requestFormCreateEditViewModel)
        {
            if (requestFormCreateEditViewModel.ChangeRequestFormId == null || requestFormCreateEditViewModel.ChangeRequestFormId == 0)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var userID = _userManager.GetUserId(User);
                    var model = _mapper.Map<RequestFormCreateEditViewModel, ChangeRequestForm>(requestFormCreateEditViewModel);
                    model.CreateDate = DateTime.Now;
                    model.CreatorUserId = userID;
                    _changeRequestFormRepository.Update(model);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChangeRequestFormExists(requestFormCreateEditViewModel.ChangeRequestFormId.Value))
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
            return View(requestFormCreateEditViewModel);
        }

        // GET: ChangeRequestForms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var changeRequestForm = await _context.ChangeRequestForms
                .SingleOrDefaultAsync(m => m.ChangeRequestFormId == id);
            if (changeRequestForm == null)
            {
                return NotFound();
            }

            return View(changeRequestForm);
        }

        // POST: ChangeRequestForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var changeRequestForm = await _context.ChangeRequestForms.SingleOrDefaultAsync(m => m.ChangeRequestFormId == id);
            _context.ChangeRequestForms.Remove(changeRequestForm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChangeRequestFormExists(int id)
        {
            return _context.ChangeRequestForms.Any(e => e.ChangeRequestFormId == id);
        }
    }
}
