//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Web;
//using System.Web.Mvc;
//using Moq;
//using Xunit;

//namespace Images
//{
//    public class MainApp
//    {
//        /// <summary>
//        /// Entry point into console application.
//        /// </summary>
//        public static void Main()
//        {
//            // Create processor
//            var processor = new Processor();

//            // TODO: use Moq or other mocking tools to create a HttpPostedFileBase with the right contents to test FileSystemImageHandler.
//            // including creating a file stream
//            // var file = new HttpPostedFileBase

//            var httpPostedFile = new Mock<HttpPostedFileBase>();
//            int imageIndex;

//            var creativeWorkId = Guid.NewGuid();

//            processor.Construct(new FileSystemImageHandler());
//            processor.NewImage(creativeWorkId, httpPostedFile, imageIndex);

//            processor.DisplayImages();

//            // Construct and display vehicles
//            processor.Construct(new OpenStackImageHandler());
//            processor.DisplayImages();

//            processor.Construct(new AzureImageHandler());
//            processor.DisplayImages();


//            // Wait for user
//            Console.ReadKey();
//        }

		
//    public void TestUpload() {
//        HomeController c = new HomeController();
//        Mock<ControllerContext> cc = new Mock<ControllerContext>();
//        UTF8Encoding enc = new UTF8Encoding();

//        Mock<HttpPostedFileBase> file1 = new Mock<HttpPostedFileBase>();
//        file1.Expect(d => d.FileName).Returns("test1.txt");
//        file1.Expect(d => d.InputStream).Returns(new MemoryStream(enc.GetBytes(Resources.UploadTestFiles.test1)));

//        Mock<HttpPostedFileBase> file2 = new Mock<HttpPostedFileBase>();
//        file2.Expect(d => d.FileName).Returns("test2.txt");
//        file2.Expect(d => d.InputStream).Returns(new MemoryStream(enc.GetBytes(Resources.UploadTestFiles.test2)));
                
//        cc.Expect(d => d.HttpContext.Request.Files.Count).Returns(2);
//        cc.Expect(d => d.HttpContext.Request.Files[0]).Returns(file1.Object);
//        cc.Expect(d => d.HttpContext.Request.Files[1]).Returns(file2.Object);
//        c.ControllerContext = cc.Object;

//        ActionResult r = c.Upload();
//        Assert.IsInstanceOfType(r, typeof(ContentResult));
//        Assert.AreNotEqual("Uploaded 2 files.<br/>\nFile test1.txt: Contents of test file 1<br/>\nFile test2.txt: Contents of test file 2<br/>", ((ContentResult)r).Content);
//    }

//    // "Bridge" pattern used to implement image management.
//    // Design needs a lot of work.
	
//    class HomeController : Controller
//    {
		
//    }

//}

