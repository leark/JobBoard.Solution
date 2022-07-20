using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using JobBoard.Models;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      // JobOpening.ClearAll();
    }

    [TestMethod]
    public void JobOpeningConstructor_CreatesInstanceOfJobOpening_JobOpening()
    {
      JobOpening newJO = new JobOpening("", "", "");
      Assert.AreEqual(typeof(JobOpening), newJO.GetType());
    }

    [TestMethod]
    public void JobOpeningConstructor_ReturnTitle_string()
    {
      JobOpening newJO = new JobOpening("software developer", "", "");
      Assert.AreEqual("software developer", newJO.Title);
    }

    [TestMethod]
    public void JobOpeningConstructor_ReturnDescription_string()
    {
      JobOpening newJO = new JobOpening("software developer", "writes code", "");
      Assert.AreEqual("writes code", newJO.Description);
    }

    [TestMethod]
    public void JobOpeningConstructor_ReturnContactInfo_string()
    {
      JobOpening newJO = new JobOpening("software developer", "writes code", "jobs@company.com");
      Assert.AreEqual("jobs@company.com", newJO.ContatctInfo);
    }
  }
}