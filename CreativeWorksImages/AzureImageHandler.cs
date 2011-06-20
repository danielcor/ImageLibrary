using System;

namespace Images
{
	/// <summary>
	/// The 'ConcreteBuilder2' class
	/// </summary>
	internal class AzureImageHandler : ImageHandler
	{
		// Invoke base class constructor
		public AzureImageHandler()
			: base(StorageProviderType.Azure)
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
	}
}