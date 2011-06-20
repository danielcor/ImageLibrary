using System;
using System.Web;

namespace Images
{
	/// <summary>
	/// The 'ConcreteBuilder1' class
	/// </summary>
	internal class FileSystemImageHandler : ImageHandler
	{
		// Invoke base class constructor
		public FileSystemImageHandler() : base(StorageProviderType.FileSystem)
		{
		}

		public override void ManageStorage()
		{
		}

		public override void UploadFiles()
		{
			throw new NotImplementedException();
		}

		public override void DownloadFiles()
		{
			throw new NotImplementedException();
		}

		public override void FindAlternateSite()
		{
			throw new NotImplementedException();
		}

		public override void Archive()
		{
			throw new NotImplementedException();
		}

		public override ImageContainer NewImage(Guid creativeWorkId, HttpPostedFile httpPostedFile, int imageIndex)
		{
			throw new NotImplementedException();
		}
	}
}