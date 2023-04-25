using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppVeterinariaUCR.Data;
using AppVeterinariaUCR.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
namespace AppVeterinariaUCR
{
    //Class  MascotasController   hereda de controlador
    public class MascotasController : Controller
    {
        //variable _context  permite manejar la referencia con la Base Datos
        private readonly VeterinariaContext _context;

        //Constructor con parámetros  y recibe como argumento el contexto
        public MascotasController(VeterinariaContext context)
        {
            _context = context;
        }

        // GET: Mascotas
        //primer  método de ejecución  asincronico
        public async Task<IActionResult> Index()
        {
            //retorna  una vista
            return View(await _context.Mascotas.ToListAsync());
        }

        // GET: Mascotas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mascotas = await _context.Mascotas
                .FirstOrDefaultAsync(m => m.id == id);
            if (mascotas == null)
            {
                return NotFound();
            }

            return View(mascotas);
        }

        // GET: Mascotas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mascotas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nombre,fechaIngreso,peso,raza,estado")] Mascotas mascotas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mascotas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mascotas);
        }

        // GET: Mascotas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mascotas = await _context.Mascotas.FindAsync(id);
            if (mascotas == null)
            {
                return NotFound();
            }
            return View(mascotas);
        }

        // POST: Mascotas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nombre,fechaIngreso,peso,raza,estado")] Mascotas mascotas)
        {
            if (id != mascotas.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mascotas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MascotasExists(mascotas.id))
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
            return View(mascotas);
        }

        // GET: Mascotas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mascotas = await _context.Mascotas
                .FirstOrDefaultAsync(m => m.id == id);
            if (mascotas == null)
            {
                return NotFound();
            }

            return View(mascotas);
        }

        // POST: Mascotas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mascotas = await _context.Mascotas.FindAsync(id);
            _context.Mascotas.Remove(mascotas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MascotasExists(int id)
        {
            return _context.Mascotas.Any(e => e.id == id);
        }
    }
}
