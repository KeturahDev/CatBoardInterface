using CatBoardInterface.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace CatBoardInterface.Controllers
{
  public class BoardsController : Controller
  {
    public IActionResult Index()
    {
      var allBoards = Board.GetBoards();
      return View(allBoards);
    }

    public ActionResult Details(int id)
    {
      var thisBoard = Board.GetDetails(id);
      return View(thisBoard);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Board board)
    {
      Board.Post(board);
      return RedirectToAction("Index");
    }
  }
}