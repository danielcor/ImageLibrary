using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace Images
{
	public class MainApp
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		public static void Main()
		{
			// Create processor
			var processor = new Processor();

			// TODO: use Moq or other techinques to create a HttpPostedFileBase with the right contents to test FileSystemImageHandler.
			// including creating a file stream
			// var file = new HttpPostedFileBase

			HttpPostedFile httpPostedFile;
			Guid creativeWorkId = Guid.NewGuid();
			int imageIndex;

			processor.Construct(new FileSystemImageHandler());
			processor.NewImage(creativeWorkId, httpPostedFile, imageIndex);

			processor.DisplayImages();

			// Construct and display vehicles
			processor.Construct(new OpenStackImageHandler());
			processor.DisplayImages();

			processor.Construct(new AzureImageHandler());
			processor.DisplayImages();


			// Wait for user
			Console.ReadKey();
		}
	}

	// "Bridge" pattern used to implement image management.
	// Design needs a lot of work.
}

