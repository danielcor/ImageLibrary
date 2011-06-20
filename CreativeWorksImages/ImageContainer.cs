using System;
using System.Web;

namespace Images
{
	/// <summary>
	/// The 'Product' class
	/// </summary>
	internal class ImageContainer
	{
		private readonly StorageProviderType _storageProvider;

		// Constructor
		public ImageContainer(StorageProviderType storageProvider)
		{
			_storageProvider = storageProvider;
		}

		public void Show()
		{
			Console.WriteLine("\n---------------------------");
			Console.WriteLine("Storage Provider: {0}", _storageProvider);
		}

	}
}