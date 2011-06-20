using System;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ImageServices.ServiceContracts
{
	/// <summary>
	/// Image server service contract.
	/// </summary>
	[ServiceContract]
	public interface IImageService
	{
		[OperationContract, WebInvoke(UriTemplate = "PutThumbnail/{creativeWorkGuid}/{ImageNumber}")]
		bool PutThumbnail(Guid creativeWorkId, byte imageNumber, Stream stream);

		[OperationContract, WebInvoke(UriTemplate = "PutTile/{creativeWorkGuid}/{ImageNumber}")]
		bool PutTile(Guid creativeWorkId, byte imageNumber, Stream stream);/

		[OperationContract, WebInvoke(UriTemplate = "PutPage/{creativeWorkGuid}/{ImageNumber}")]
		bool PutPage(Guid creativeWorkId, byte imageNumber, Stream stream);

		[OperationContract, WebInvoke(UriTemplate = "PutOriginal/{creativeWorkGuid}/{ImageNumber}")]
		bool PutOriginal(Guid creativeWorkId, byte imageNumber, Stream stream);

		[OperationContract, WebInvoke(UriTemplate = "Remove/{creativeWorkGuid}")]
		bool Remove(Guid creativeWorkId);

		[OperationContract, WebInvoke(UriTemplate = "Remove/{creativeWorkGuid}/{ImageNumber}")]
		bool Renive(Guid creativeWorkId, byte imageNumber);

		[OperationContract, WebInvoke(UriTemplate = "Permissions/{CreativeWorkGuid}/?")]
		bool Permissions(Guid creativeWorkId /* , TBD criteria */);
	}
}

