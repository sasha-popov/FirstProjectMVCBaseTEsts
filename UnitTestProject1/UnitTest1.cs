using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLayerApp.DAL.EF;
using NLayerApp.DAL.Entities.Interfaces;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Find_Categories_ReturnsNotNull()
        {
            SearchContext db = new SearchContext("DefaultConnection");
            var result = db.Categories.Find(3);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Find_Categories_ReturnsNotNull1()
        {
            SearchContext db = new SearchContext("DefaultConnection");
            var result = db.Categories.Find(5);
            Assert.IsNotNull(result);
        }
    }
}
