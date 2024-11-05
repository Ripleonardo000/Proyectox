using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyectox.Data;
using Proyectox.Models;

namespace Proyectox.Controllers
{
    public class LigasController : Controller
    {
        private readonly ProyectoxContext _context;

        public LigasController(ProyectoxContext context)
        {
            _context = context;
        }

        // GET: Ligas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Liga.ToListAsync());
        }

        // GET: Ligas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liga = await _context.Liga
                .FirstOrDefaultAsync(m => m.Id == id);
            if (liga == null)
            {
                return NotFound();
            }

            return View(liga);
        }

        // GET: Ligas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ligas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Pais")] Liga liga)
        {
            if (ModelState.IsValid)
            {
                _context.Add(liga);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View (liga);
        }


        // GET: Ligas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liga = await _context.Liga.FindAsync(id);
            if (liga == null)
            {
                return NotFound();
            }
            return View(liga);
        }

        // POST: Ligas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Pais")] Liga liga)
        {
            if (id != liga.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(liga);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LigaExists(liga.Id))
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
            return View(liga);
        }

        // GET: Ligas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liga = await _context.Liga
                .FirstOrDefaultAsync(m => m.Id == id);
            if (liga == null)
            {
                return NotFound();
            }

            return View(liga);
        }

        // POST: Ligas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var liga = await _context.Liga.FindAsync(id);
            if (liga != null)
            {
                _context.Liga.Remove(liga);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LigaExists(int id)
        {
            return _context.Liga.Any(e => e.Id == id);
        }
    }
}
