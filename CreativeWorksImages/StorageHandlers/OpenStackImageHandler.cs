using System;
using System.IO;
using System.Web;

namespace Images.StorageHandlers
{
	/// <summary>
	/// The 'ConcreteBuilder3' class
	/// </summary>
	internal class OpenStackImageHandler : ImageHandler
	{
		// Invoke base class constructor
		public OpenStackImageHandler()
			: base(StorageProviderType.OpenStack)
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

		}

		public override ImageContainer NewImage(Guid creativeWorkId, Stream stream, string fileName, int imageIndex)
		{
			throw new NotImplementedException();
		}
	}
}