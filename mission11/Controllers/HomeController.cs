using Microsoft.AspNetCore.Mvc;
using mission11.Models;
using mission11.Models.ViewModels;
using System.Diagnostics;

namespace mission11.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;

        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;
            var newData = new BookListViewModel
            {
                 Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {   
                    CurrentPage= pageNum,
                    ItemsPerPage= pageSize,
                    TotalItems = _repo.Books.Count()
                }

             };
        


            return View(newData);
        }


    }
}
