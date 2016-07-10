using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_v1.Data;
using System;
using AspNetCore_v1.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_v1.ViewComponents
{
    public class CompletedViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public CompletedViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(bool isCompleted)
        {
            var items = await GetItemAsync(isCompleted);

            return View(items);
        }

        private Task<List<Item>> GetItemAsync(bool isCompleted)
        {
            return _context.Items.Where(x => x.Completed == isCompleted).ToListAsync();

        }
    }
}