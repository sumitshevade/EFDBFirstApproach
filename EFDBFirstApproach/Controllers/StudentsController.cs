﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFDBFirstApproach.Data;
using EFDBFirstApproach.Entities;
using EFDBFirstApproach.Implementations;
using EFDBFirstApproach.Interfaces;

namespace EFDBFirstApproach.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ApplicationDbContext _context;

        public StudentsController(IStudentRepository studentRepository, ApplicationDbContext context)
        {
            _studentRepository = studentRepository;
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }

        //// GET: Students/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var students = await _context.Students
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (students == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(students);
        //}

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,FirstName,LastName,Gender,MobileNo,Dob")] Students students)
        {
            if (ModelState.IsValid)
            {
                _studentRepository.Add(students);
                _studentRepository.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(students);
        }

        // GET: Students/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var students = await _context.Students.FindAsync(id);
        //    if (students == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(students);
        //}

        //// POST: Students/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Gender,MobileNo,Dob")] Students students)
        //{
        //    if (id != students.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(students);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!StudentsExists(students.Id))
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
        //    return View(students);
        //}

        //// GET: Students/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var students = await _context.Students
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (students == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(students);
        //}

        //// POST: Students/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var students = await _context.Students.FindAsync(id);
        //    _context.Students.Remove(students);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool StudentsExists(int id)
        //{
        //    return _context.Students.Any(e => e.Id == id);
        //}
    }
}
