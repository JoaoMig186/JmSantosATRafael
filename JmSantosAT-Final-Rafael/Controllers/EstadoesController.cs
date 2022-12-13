using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JmSantosAT_Final_Rafael.Data;
using JmSantosAT_Final_Rafael.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace JmSantosAT_Final_Rafael.Controllers
{
    public class EstadoesController : Controller
    {
        private readonly JmSantosAT_Final_RafaelContext _context;

        public EstadoesController(JmSantosAT_Final_RafaelContext context)
        {
            _context = context;
        }

        // GET: Estadoes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Estado.ToListAsync());
        }

        // GET: Estadoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Estado == null)
            {
                return NotFound();
            }

            var estado = await _context.Estado
                .FirstOrDefaultAsync(m => m.EstadosId == id);
            if (estado == null)
            {
                return NotFound();
            }

            return View(estado);
        }

        // GET: Estadoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Create([Bind("EstadosId,EstadosNome,EstadoImagem")] Estado estado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estado);
        }

        // GET: Estadoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Estado == null)
            {
                return NotFound();
            }

            var estado = await _context.Estado.FindAsync(id);
            if (estado == null)
            {
                return NotFound();
            }
            return View(estado);
        }

        // POST: Estadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EstadosId,EstadosNome,EstadoImagem")] Estado estado)
        {
            if (id != estado.EstadosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoExists(estado.EstadosId))
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
            return View(estado);
        }

        // GET: Estadoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Estado == null)
            {
                return NotFound();
            }

            var estado = await _context.Estado
                .FirstOrDefaultAsync(m => m.EstadosId == id);
            if (estado == null)
            {
                return NotFound();
            }

            return View(estado);
        }

        // POST: Estadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Estado == null)
            {
                return Problem("Entity set 'JmSantosAT_Final_RafaelContext.Estado'  is null.");
            }
            var estado = await _context.Estado.FindAsync(id);
            if (estado != null)
            {
                _context.Estado.Remove(estado);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadoExists(int id)
        {
          return _context.Estado.Any(e => e.EstadosId == id);
        }
    }
}
