using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobOpeningsController : Controller
  {
    [HttpGet("/jobOpenings")]
    public ActionResult Index()
    {
      return View(JobOpening.GetAll());
    }
    [HttpGet("/jobOpenings/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/jobOpenings")]
    public ActionResult Create(string title, string description, string contactInfo)
    {
      JobOpening jO1 = new JobOpening(title, description, contactInfo);
      return RedirectToAction("Index");
    }
    [HttpGet("/jobOpenings/{id}")]
    public ActionResult Show(int id)
    {
      JobOpening foundJO = JobOpening.Find(id);
      return View(foundJO);
    }
    [HttpPost("/jobOpenings/{id}")]
    public ActionResult Destroy(int id)
    {
      JobOpening jO = JobOpening.Find(id);
      if (jO != null)
      {
        JobOpening.Delete(jO);
      }
      return RedirectToAction("Index");
    }
  }
}