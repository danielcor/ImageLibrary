using System;
using System.Web;

namespace Images
{
	/// <summary>
	/// The 'Director' class
	/// </summary>
	internal class Processor
	{
		private ImageHandler _imageHandler;

		// Builder uses a complex series of steps
		public void Construct(ImageHandler imageHandler)
		{
			_imageHandler = imageHandler;

			_imageHandler.BuildThumbnail();
			_imageHandler.BuildTile();
			_imageHandler.BuildMainimage();
			_imageHandler.ManageStorage();
		}

		public void DisplayImages()
		{
			_imageHandler.ImageContainer.Show();
		}

		public ImageContainer NewImage(Guid creativeWorkId, HttpPostedFile httpPostedFile, int imageIndex)
		{
			return _imageHandler.NewImage(creativeWorkId, httpPostedFile, imageIndex);
		}
	}
}