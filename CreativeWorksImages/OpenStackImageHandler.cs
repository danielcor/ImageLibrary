using System;
using System.Web;

namespace Images
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

		public override ImageContainer NewImage(Guid creativeWorkId, HttpPostedFile httpPostedFile, int imageIndex)
		{
			throw new NotImplementedException();
		}
	}
}