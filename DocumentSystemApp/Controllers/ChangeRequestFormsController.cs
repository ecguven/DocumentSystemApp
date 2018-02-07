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

namespace DocumentSystemApp.Controllers
{
    public class ChangeRequestFormsController : Controller
    {
        private readonly DocumentSystemDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IChangeRequestFormRepository _changeRequestFormRepository;

        public ChangeRequestFormsController(DocumentSystemDbContext context, 
            UserManager<ApplicationUser> userManager,
            IChangeRequestFormRepository changeRequestFormRepository)
        {
            _context = context;
            _userManager = userManager;
            _changeRequestFormRepository = changeRequestFormRepository;
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

            var changeRequestForm = await _context.ChangeRequestForms
                .SingleOrDefaultAsync(m => m.ChangeRequestFormId == id);
            if (changeRequestForm == null)
            {
                return NotFound();
            }

            return View(changeRequestForm);
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
        public async Task<IActionResult> Create([Bind("ChangeRequestFormId,CompanyId,SPRS,Version,ChangeRequestID,ChangeRequestDescrpition,ChangeReason,PriorityEmergency,PriorityRoutine,PriorityNextVersion,Date,ReferenceNumber,InitiatedBy,SignatureDate,ConfigurationHardware,ConfigurationSoftware,ConfigurationSystemDocumentation,ConfigurationUserTraining,ConfigurationFirmware,ChangeType1NewRequirement,ChangeType1RequirementChange,ChangeType1DesignChange,ChangeType1Other,ChangeType1BugFixing,ChangeType2Commercial,ChangeType2Investment,ChangeType2Text,bImpactAssessmentToA,ImpactAssessmentToA,bImpactAssessmentMA,ImpactAssessmentMA,bImpactAssessmentDC,ImpactAssessmentDC,bImpactAssessmentTtE,ImpactAssessmentTtE,bImpactAssessmentOth,ImpactAssessmentOth,ChangeAccept,ChangeReject,ChangeJustification,CHARole1,CHAPrintName1,CHASignatureDate1,CHARole2,CHAPrintName2,CHASignatureDate2,CHARole3,CHAPrintName3,CHASignatureDate3,SummaryofResults,Attachments,FARole1,FAPrintName1,FASignatureDate1,FARole2,FAPrintName2,FASignatureDate2,FARole3,FAPrintName3,FASignatureDate3,CreateDate,CreatorUserId,UpdateDate,UpdaterUserId")] ChangeRequestForm changeRequestForm)
        {
            if (ModelState.IsValid)
            {
                var userID = _userManager.GetUserId(User);
                changeRequestForm.CreateDate = DateTime.Now;
                changeRequestForm.CreatorUserId = userID;
                _context.Add(changeRequestForm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(changeRequestForm);
        }

        // GET: ChangeRequestForms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var changeRequestForm = await _context.ChangeRequestForms.SingleOrDefaultAsync(m => m.ChangeRequestFormId == id);
            if (changeRequestForm == null)
            {
                return NotFound();
            }
            return View(changeRequestForm);
        }

        // POST: ChangeRequestForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ChangeRequestFormId,CompanyId,SPRS,Version,ChangeRequestID,ChangeRequestDescrpition,ChangeReason,PriorityEmergency,PriorityRoutine,PriorityNextVersion,Date,ReferenceNumber,InitiatedBy,SignatureDate,ConfigurationHardware,ConfigurationSoftware,ConfigurationSystemDocumentation,ConfigurationUserTraining,ConfigurationFirmware,ChangeType1NewRequirement,ChangeType1RequirementChange,ChangeType1DesignChange,ChangeType1Other,ChangeType1BugFixing,ChangeType2Commercial,ChangeType2Investment,ChangeType2Text,bImpactAssessmentToA,ImpactAssessmentToA,bImpactAssessmentMA,ImpactAssessmentMA,bImpactAssessmentDC,ImpactAssessmentDC,bImpactAssessmentTtE,ImpactAssessmentTtE,bImpactAssessmentOth,ImpactAssessmentOth,ChangeAccept,ChangeReject,ChangeJustification,CHARole1,CHAPrintName1,CHASignatureDate1,CHARole2,CHAPrintName2,CHASignatureDate2,CHARole3,CHAPrintName3,CHASignatureDate3,SummaryofResults,Attachments,FARole1,FAPrintName1,FASignatureDate1,FARole2,FAPrintName2,FASignatureDate2,FARole3,FAPrintName3,FASignatureDate3,CreateDate,CreatorUserId,UpdateDate,UpdaterUserId")] ChangeRequestForm changeRequestForm)
        {
            if (id != changeRequestForm.ChangeRequestFormId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var userID = _userManager.GetUserId(User);
                    changeRequestForm.UpdateDate = DateTime.Now;
                    changeRequestForm.UpdaterUserId = userID;
                    _context.Update(changeRequestForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChangeRequestFormExists(changeRequestForm.ChangeRequestFormId))
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
            return View(changeRequestForm);
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
