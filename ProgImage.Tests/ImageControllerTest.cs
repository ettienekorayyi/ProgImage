using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgImage.Controllers;
using ProgImage.Classes;
using ProgImage.Tests.Common;
using System.Drawing;

namespace ProgImage.Tests
{
    [TestClass]
    public class ImageControllerTest
    {
        [TestMethod]
        public void TestPost()
        {
            ImageController controller = new ImageController();
            controller.Post(Constants.Image);
            Assert.AreEqual(true, ImageProcessor.DirectoryExistence);
        }
        [TestMethod]
        public void TestLeftRotation()
        {
            Assert.AreEqual(typeof(Bitmap), new ImageProcessor().LeftRotation(Constants.Image).GetType());
        }
        [TestMethod]
        public void TestRightRotation()
        {
            Assert.AreEqual(typeof(Bitmap), new ImageProcessor().LeftRotation(Constants.Image).GetType());
        }
    }
}
