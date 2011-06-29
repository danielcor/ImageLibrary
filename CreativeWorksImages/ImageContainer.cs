using System;
using System.Web;

namespace Images
{
	/// <summary>
	/// The 'Product' class
	/// </summary>
	public class ImageContainer
	{
		private readonly StorageProviderType _storageProvider;
		public Guid imageGuid;
		public string fileName;

		// TODO: // Need to have in here, enough information to construct an URL, or even store the URL,
		// TODO: // Need to have enough inforation here so that this library can find the images.. to delete, move them to an alternate provider, etc.
		// TODO: // No matter which provider we are using.

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