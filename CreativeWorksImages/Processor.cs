using System;
using System.IO;
using System.Web;
using Images.StorageHandlers;

namespace Images
{
	/// <summary>
	/// The 'Director' class
	/// </summary>
	public class Processor
	{
		private ImageHandler _imageHandler;

		// Builder uses a complex series of steps
		internal void Construct(ImageHandler imageHandler)
		{
			_imageHandler = imageHandler;

			_imageHandler.BuildThumbnail();
			_imageHandler.BuildTile();
			_imageHandler.BuildMainimage();
			_imageHandler.ManageStorage();
		}

		// Builder uses a complex series of steps
		public Processor Construct(StorageProviderType storageProviderType)
		{
			switch(storageProviderType)
			{
				case StorageProviderType.FileSystem:
					Construct(new FileSystemImageHandler());
					break;
			}
			return this;
		}

		public void DisplayImages()
		{
			_imageHandler.ImageContainer.Show();
		}

		public Processor NewImage(Guid creativeWorkId, Stream fileStream, string originalFileName, int imageIndex, out ImageContainer imageContainer)
		{
			imageContainer = _imageHandler.NewImage(creativeWorkId, fileStream, originalFileName, imageIndex);
			return this;
		}

		public ImageContainer NewImage(Guid creativeWorkId, Stream fileStream, string originalFileName, int imageIndex)
		{
			return _imageHandler.NewImage(creativeWorkId, fileStream, originalFileName, imageIndex);
		}

		public ImageContainer NewImage(Guid creativeWorkId, HttpPostedFileBase httpPostedFile, int imageIndex)
		{
			return _imageHandler.NewImage(creativeWorkId, httpPostedFile.InputStream, Path.GetFileName(httpPostedFile.FileName), imageIndex);
		}
	}
}