using System;
using System.Web;

namespace Images
{
	/// <summary>
	/// The 'Builder' abstract class
	/// </summary>
	internal abstract class ImageHandler
	{
		public ImageContainer ImageContainer { get; private set; }

		// Constructor
		public ImageHandler(StorageProviderType storageProvider)
		{
			ImageContainer = new ImageContainer(storageProvider);
		}

		public void BuildThumbnail()
		{
		}

		public void BuildTile()
		{
		}

		public void BuildMainimage()
		{
		}

		public abstract void ManageStorage();
		public abstract void UploadFiles();
		public abstract void DownloadFiles();
		public abstract void FindAlternateSite();
		public abstract void Archive();

		public abstract ImageContainer NewImage(Guid creativeWorkId, HttpPostedFile httpPostedFile, int imageIndex);
	}
}