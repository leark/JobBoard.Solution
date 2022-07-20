using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using JobBoard.Models;
using System;

namespace JobBoard.Tests
{
  [TestClass]
  public class JobOpeningTests : IDisposable
  {
    public void Dispose()
    {
      JobOpening.ClearAll();
    }

    [TestMethod]
    public void JobOpeningConstructor_CreatesInstanceOfJobOpening_JobOpening()
    {
      JobOpening newJO = new JobOpening("", "", "");
      Assert.AreEqual(typeof(JobOpening), newJO.GetType());
    }

    [TestMethod]
    public void JobOpeningConstructor_ReturnsTitle_string()
    {
      JobOpening newJO = new JobOpening("software developer", "", "");
      Assert.AreEqual("software developer", newJO.Title);
    }

    [TestMethod]
    public void JobOpeningConstructor_ReturnsDescription_string()
    {
      JobOpening newJO = new JobOpening("software developer", "writes code", "");
      Assert.AreEqual("writes code", newJO.Description);
    }

    [TestMethod]
    public void JobOpeningConstructor_ReturnsContactInfo_string()
    {
      JobOpening newJO = new JobOpening("software developer", "writes code", "jobs@company.com");
      Assert.AreEqual("jobs@company.com", newJO.ContactInfo);
    }

    [TestMethod]
    public void JobOpeningConstructor_SetTitle_string()
    {
      JobOpening newJO = new JobOpening("software developer", "writes code", "jobs@company.com");
      newJO.Title = "senior software developer";
      Assert.AreEqual("senior software developer", newJO.Title);
    }

    [TestMethod]
    public void JobOpeningConstructor_SetDescription_string()
    {
      JobOpening newJO = new JobOpening("software developer", "writes code", "jobs@company.com");
      newJO.Description = "browses reddit";
      Assert.AreEqual("browses reddit", newJO.Description);
    }

    [TestMethod]
    public void JobOpeningConstructor_SetContactInfo_string()
    {
      JobOpening newJO = new JobOpening("software developer", "writes code", "jobs@company.com");
      newJO.ContactInfo = "ceo@company.com";
      Assert.AreEqual("ceo@company.com", newJO.ContactInfo);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_JobOpeningList()
    {
      // Arrange
      List<JobOpening> newList = new List<JobOpening> { };

      // Act
      List<JobOpening> result = JobOpening.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnListOfJobOpenings_JobOpeningList()
    {
      JobOpening newJO1 = new JobOpening("software developer", "writes code", "jobs@company.com");
      JobOpening newJO2 = new JobOpening("senior software developer", "judges code", "jobs@company.com");
      List<JobOpening> newList = new List<JobOpening> { newJO1, newJO2 };

      List<JobOpening> result = JobOpening.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnJobOpeningAtId_JobOpening()
    {
      JobOpening newJO1 = new JobOpening("software developer", "writes code", "jobs@company.com");
      JobOpening newJO2 = new JobOpening("senior software developer", "judges code", "jobs@company.com");

      JobOpening result = JobOpening.Find(2);

      Assert.AreEqual(newJO2, result);
    }
  }
}