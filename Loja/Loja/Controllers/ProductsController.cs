using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Loja.Data;
using Loja.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Loja.Controllers
{
    public class ProductsController : Controller
    {
        private readonly LojaDB _context;
        private readonly IWebHostEnvironment _caminho;
        public ProductsController(LojaDB context, IWebHostEnvironment caminho)
        {
            _context = context;
            _caminho = caminho;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,item,stock,description,price,foto")] Product product, IFormFile fotoProd)
        {
            string caminhoCompleto = "";
            bool haImagem = false;

            // será q há fotografia?
            //    - uma hipótese possível, seria reenviar os dados para a View e solicitar a adição da imagem
            //    - outra hipótese, será associar ao veterinário uma fotografia 'por defeito'
            if (fotoProd == null) { product.foto = "noVet.png"; }
            else
            {
                // há ficheiro
                // será o ficheiro uma imagem?
                if (fotoProd.ContentType == "image/jpeg" ||
                    fotoProd.ContentType == "image/png")
                {
                    // o ficheiro é uma imagem válida
                    // preparar a imagem para ser guardada no disco rígido
                    // e o seu nome associado ao Veterinario
                    Guid g;
                    g = Guid.NewGuid();
                    string extensao = Path.GetExtension(fotoProd.FileName).ToLower();
                    string nome = g.ToString() + extensao;
                    // onde guardar o ficheiro
                    caminhoCompleto = Path.Combine(_caminho.WebRootPath, "Imagens\\Vets", nome);
                    // associar o nome do ficheiro ao Veterinário
                    product.foto = nome;
                    // assinalar que existe imagem e é preciso guardá-la no disco rígido
                    haImagem = true;
                }
                else
                {
                    // há imagem, mas não é do tipo correto
                    product.foto = "noVet.png";
                }
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(product);
                    await _context.SaveChangesAsync();
                    // se há imagem, vou guardá-la no disco rígido
                    if (haImagem)
                    {
                        using var stream = new FileStream(caminhoCompleto, FileMode.Create);
                        await fotoProd.CopyToAsync(stream);
                    }
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception) { }
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,item,stock,description,price,foto")] Product product)
        {
            if (id != product.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.id))
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
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.id == id);
        }
    }
}
