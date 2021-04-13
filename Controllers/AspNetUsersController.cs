﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fag_el_Gamous.Models;
using Fag_el_Gamous.Data;

namespace Fag_el_Gamous.Controllers
{
    public class AspNetUsersController : Controller
    {
        private readonly waterbuffaloContext _context;

        private readonly IdentityContext id_context;

        public AspNetUsersController(waterbuffaloContext context, IdentityContext ctx)
        {
            _context = context;
            id_context = ctx;
        }

        // GET: AspNetUsers
        public async Task<IActionResult> Index()
        {
            ViewBag.AdminList = id_context.AspNetUsers
                .Where(c => c.isAdmin == true)
                .ToList();

            var isAdmin = id_context.AspNetUsers
                .Where(c => c.UserName == User.Identity.Name);

            foreach(var thing in isAdmin)
            {
                if( thing.isAdmin == true )
                {
                    ViewData["isAdmin"] = true;
                }
            }


            return View(await id_context.AspNetUsers.ToListAsync());
        }

        // GET: AspNetUsers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aspNetUsers = await id_context.AspNetUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aspNetUsers == null)
            {
                return NotFound();
            }

            return View(aspNetUsers);
        }

        // GET: AspNetUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AspNetUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount,isResearcher,isAdmin")] AspNetUsers aspNetUsers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aspNetUsers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aspNetUsers);
        }

        // GET: AspNetUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            ViewBag.AdminList = id_context.AspNetUsers
                .Where(c => c.isAdmin == true)
                .ToList();

           var isAdmin = id_context.AspNetUsers
                .Where(c => c.UserName == User.Identity.Name);

            foreach(var thing in isAdmin)
            {
                if( thing.isAdmin == true )
                {
                    ViewData["isAdmin"] = true;
                }
            }


            if (id == null)
            {
                return NotFound();
            }

            var aspNetUsers = await id_context.AspNetUsers.FindAsync(id);
            if (aspNetUsers == null)
            {
                return NotFound();
            }
            return View(aspNetUsers);
        }

        // POST: AspNetUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount,isResearcher,isAdmin")] AspNetUsers aspNetUsers)
        {


            if (id != aspNetUsers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aspNetUsers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AspNetUsersExists(aspNetUsers.Id))
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
            return View(aspNetUsers);
        }

        // GET: AspNetUsers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aspNetUsers = await id_context.AspNetUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aspNetUsers == null)
            {
                return NotFound();
            }

            return View(aspNetUsers);
        }

        // POST: AspNetUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var aspNetUsers = await id_context.AspNetUsers.FindAsync(id);
            id_context.AspNetUsers.Remove(aspNetUsers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AspNetUsersExists(string id)
        {
            return id_context.AspNetUsers.Any(e => e.Id == id);
        }
    }
}
