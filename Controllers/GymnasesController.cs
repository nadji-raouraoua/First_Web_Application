using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GymnaseWebAppModel;
using WebApplication.Data;

namespace WebApplication.Controllers
{
    public class GymnasesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GymnasesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Gymnases
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gymnase.ToListAsync());
        }

        // GET: Gymnases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gymnase = await _context.Gymnase
                .FirstOrDefaultAsync(m => m.IDGymnase == id);
            if (gymnase == null)
            {
                return NotFound();
            }

            return View(gymnase);
        }

        // GET: Gymnases/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gymnases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDClient,NomGymnase,Adresse,Ville,Surface")] Gymnase gymnase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gymnase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gymnase);
        }

        // GET: Gymnases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gymnase = await _context.Gymnase.FindAsync(id);
            if (gymnase == null)
            {
                return NotFound();
            }
            return View(gymnase);
        }

        // POST: Gymnases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDClient,NomGymnase,Adresse,Ville,Surface")] Gymnase gymnase)
        {
            if (id != gymnase.IDGymnase)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gymnase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GymnaseExists(gymnase.IDGymnase))
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
            return View(gymnase);
        }

        // GET: Gymnases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gymnase = await _context.Gymnase
                .FirstOrDefaultAsync(m => m.IDGymnase == id);
            if (gymnase == null)
            {
                return NotFound();
            }

            return View(gymnase);
        }

        // POST: Gymnases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gymnase = await _context.Gymnase.FindAsync(id);
            _context.Gymnase.Remove(gymnase);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GymnaseExists(int id)
        {
            return _context.Gymnase.Any(e => e.IDGymnase == id);
        }
    }
}
