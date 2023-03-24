﻿using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Book Book { get; set; }
        public void OnGet() 
        { 
        

        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
             await _db.Book.AddAsync(Book);
                await _db.SaveChangesAsync();
                return RedirectToPage("BookList");
            }
            else
            {
             return Page();
            }

        }
    }
}
