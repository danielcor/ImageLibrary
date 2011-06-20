using System;
using System.IO;
using System.ServiceModel.Web;
using ImageServices.ServiceContracts;

namespace ImageService.ServiceImplementations
{
	/// <summary>
	/// Image server service implementation. Returns requested images.
	/// Currently, the service provides no add, edit, delete functionality.
	/// </summary>
	public class ImageService : IImageService
	{
		/// <summary>
		/// Gets large customer image
		/// </summary>
		/// <param name="customerId">Customer Identifier.</param>
		/// <returns>Image stream.</returns>
		public Stream GetCustomerImageLarge(string customerId)
		{
			return GetCustomerImage("Large", customerId);
		}

		/// <summary>
		/// Gets small customer image
		/// </summary>
		/// <param name="customerId">Customer Identifier.</param>
		/// <returns>Image stream.</returns>
		public Stream GetCustomerImageSmall(string customerId)
		{
			return GetCustomerImage("Small", customerId);
		}

		/// <summary>
		/// Helper methods. Gets large or small customer image.
		/// </summary>
		/// <param name="size">Image size. Small or Large.</param>
		/// <param name="customerId">Customer Identifier.</param>
		/// <returns>Image stream.</returns>
		private Stream GetCustomerImage(string size, string customerId)
		{
			// Get host folder
			string path = AppDomain.CurrentDomain.BaseDirectory;

			// Application has up to 91 images. Note: image upload is not implemented.
			int id = int.Parse(customerId);
			if (id > 91) id = 0; // New customers use silouette image

			string file = Path.Combine(path, @"Images\Customers\" + size + @"\" + id + ".jpg");

			var stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
			WebOperationContext.Current.OutgoingResponse.ContentType = "image/jpeg";
			return stream;
		}

		/// <summary>
		/// Gets product image. For demo purposed, this returns always same image.
		/// </summary>
		/// <param name="productId">Product Identifier.</param>
		/// <returns>Image stream.</returns>
		public Stream GetProductImage(string productId)
		{
			// Get host folder
			string path = AppDomain.CurrentDomain.BaseDirectory;
			string file = Path.Combine(path, @"Images\Products\" + productId + ".jpg");

			var stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
			WebOperationContext.Current.OutgoingResponse.ContentType = "image/gif";
			return stream;
		}
	}
}