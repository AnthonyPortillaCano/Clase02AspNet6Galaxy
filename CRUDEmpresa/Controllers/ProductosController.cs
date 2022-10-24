﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AccesoDatos.EFCore.Modelos;
using Negocios;

namespace CRUDEmpresa.Controllers
{
    public class ProductosController : BaseController
    {
      //  private readonly BDEmpresaContext _context;

        public ProductosController(IUnitOfWork unitOfWork):base(unitOfWork)
        {
           // _context = context;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
              return View(await _unitOfWork.productoNegocio.GetProductos());
        }

        //// GET: Productos/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Productos == null)
        //    {
        //        return NotFound();
        //    }

        //    var producto = await _context.Productos
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (producto == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(producto);
        //}

        //// GET: Productos/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Productos/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Nombre,Tipo,Precio")] Producto producto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(producto);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(producto);
        //}

        //// GET: Productos/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Productos == null)
        //    {
        //        return NotFound();
        //    }

        //    var producto = await _context.Productos.FindAsync(id);
        //    if (producto == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(producto);
        //}

        //// POST: Productos/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Tipo,Precio")] Producto producto)
        //{
        //    if (id != producto.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(producto);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ProductoExists(producto.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(producto);
        //}

        //// GET: Productos/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Productos == null)
        //    {
        //        return NotFound();
        //    }

        //    var producto = await _context.Productos
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (producto == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(producto);
        //}

        //// POST: Productos/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Productos == null)
        //    {
        //        return Problem("Entity set 'BDEmpresaContext.Productos'  is null.");
        //    }
        //    var producto = await _context.Productos.FindAsync(id);
        //    if (producto != null)
        //    {
        //        _context.Productos.Remove(producto);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool ProductoExists(int id)
        //{
        //  return _context.Productos.Any(e => e.Id == id);
        //}
    }
}
