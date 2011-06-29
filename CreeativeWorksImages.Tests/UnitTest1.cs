using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Images;
using SubSpec;
using Xunit;

namespace CreeativeWorksImages.Tests
{
	public class TestFileSystemProcessing
	{
		[Specification]
		public void TestArgumentValidation()
		{
			var sut = default(Processor);
			var imageGuid = Guid.NewGuid();
			const string testfilePath = @"..\..\TestFiles\with-curves-005.jpg";
			var testFileName = Path.GetFileName(testfilePath);
			var imageContainer = default(ImageContainer);
			var testFileIndex = 1;
			var fileStream = new FileStream(@"..\..\TestFiles\with-curves-005.jpg", FileMode.Open, FileAccess.Read);

			"Given that you process that file stream using Processor with the fileSystem Storage Provider"
				.Context(() =>
				         (sut = new Processor()).Construct(StorageProviderType.FileSystem));

			var exception = default(Exception); // capture exception in a var called exception

			"Expect that passing stream = null to sut.NewImage() will produce an exception".Do(
				() => exception = Record.Exception(() =>
				                                   sut.NewImage(imageGuid, null, testFileName, 1)));

			"Expect that the exception is the ArgmentNullException".Assert(() => exception.IsInstanceOf<ArgumentNullException>());
		}

		//void test2()
		//{
		//    "Process fileStream to produce ImageContainer".Do(() => imageContainer = sut.NewImage(imageGuid, fileStream, testFileName, testFileIndex));

		//}
	}
}
