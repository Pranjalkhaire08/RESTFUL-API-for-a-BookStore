using BookStore.Application_Layer;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public interface IBookController1
    {
        IActionResult Create();
        IActionResult Create(BookViewModel book);
        IActionResult Delete(int id);
        IActionResult DeleteConfirmed(int id);
        IActionResult Details(int id);
        IActionResult Edit(BookViewModel book);
        IActionResult Edit(int id);
        IActionResult Index();
    }
}