using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Modelo;

namespace Biblioteca.Controllers
{
    public class LectorsController : Controller
    {
        private readonly BibliotecaContext _context;

        public LectorsController(BibliotecaContext context)
        {
            _context = context;
        }

        // GET: Lectors
        public async Task<IActionResult> Index()
        {
            return View(await _context.lectores.ToListAsync());
        }

        // GET: Lectors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lector = await _context.lectores
                .FirstOrDefaultAsync(m => m.lectorId == id);
            if (lector == null)
            {
                return NotFound();
            }

            return View(lector);
        }

        // GET: Lectors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lectors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("lectorId,Apellido,Nombre,Domicilio,Localidad,Provincia")] Lector lector)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lector);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lector);
        }

        // GET: Lectors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lector = await _context.lectores.FindAsync(id);
            if (lector == null)
            {
                return NotFound();
            }
            return View(lector);
        }

        // POST: Lectors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("lectorId,Apellido,Nombre,Domicilio,Localidad,Provincia")] Lector lector)
        {
            if (id != lector.lectorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lector);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LectorExists(lector.lectorId))
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
            return View(lector);
        }

        // GET: Lectors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lector = await _context.lectores
                .FirstOrDefaultAsync(m => m.lectorId == id);
            if (lector == null)
            {
                return NotFound();
            }

            return View(lector);
        }

        // POST: Lectors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lector = await _context.lectores.FindAsync(id);
            _context.lectores.Remove(lector);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LectorExists(int id)
        {
            return _context.lectores.Any(e => e.lectorId == id);
        }
    }
}
