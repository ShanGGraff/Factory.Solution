using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly FactoryContext _db;

    public EngineersController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Engineers.ToList());
    }

    // public ActionResult Create()
    // {
    //   ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "CourseName");
    //   return View();
    // }

    // [HttpPost]
    // public ActionResult Create(Student student, int CourseId)
    // {
    //   bool isUnique = true;
    //   List<Student> studentList = _db.Students.ToList();
    //   foreach(Student iteration in studentList)
    //   {
    //     if (student.StudentName == iteration.StudentName) 
    //     {
    //       isUnique = false;
    //       // ModelState.AddModelError("DuplicateName", student.StudentName + " Is already enrolled");
    //       return RedirectToAction("Create");
    //     }
    //   }
    //   if (isUnique)
    //   {
    //     _db.Students.Add(student);
    //     _db.SaveChanges();
    //     if (CourseId != 0)
    //     {
    //       _db.Registrar.Add(new Registrar() { CourseId = CourseId, StudentId = student.StudentId });
    //     }
    //     _db.SaveChanges();
    //   }
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Details(int id)
    // {
    //   Student thisStudent = _db.Students
    //       .Include(student => student.JoinEntities)
    //       .ThenInclude(join => join.Course)
    //       .FirstOrDefault(student => student.StudentId == id);
    //   return View(thisStudent);
    // }

    // public ActionResult Edit(int id)
    // {
    //   Student thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
    //   ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "CourseName");
    //   return View(thisStudent);
    // }

    // [HttpPost]
    // public ActionResult Edit(Student student, int CourseId)
    // {
    //   if (CourseId != 0)
    //   {
    //     _db.Registrar.Add(new Registrar() { CourseId = CourseId, StudentId = student.StudentId });
    //   }
    //   _db.Entry(student).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult AddCourse(int id)
    // {
    //   Student thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
    //   ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "CourseName");
    //   return View(thisStudent);
    // }

    // [HttpPost]
    // public ActionResult AddCourse(Student student, int CourseId)
    // {
    //   if (CourseId != 0)
    //   {
    //   _db.Registrar.Add(new Registrar() { CourseId = CourseId, StudentId = student.StudentId });
    //   }
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   Student thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
    //   return View(thisStudent);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   Student thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
    //   _db.Students.Remove(thisStudent);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // [HttpPost]
    // public ActionResult DeleteCourse(int joinId)
    // {
    //   Registrar joinEntry = _db.Registrar.FirstOrDefault(entry => entry.RegistrarId == joinId);
    //   _db.Registrar.Remove(joinEntry);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}