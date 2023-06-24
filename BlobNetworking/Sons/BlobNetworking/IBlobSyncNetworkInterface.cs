using System;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public interface IBlobSyncNetworkInterface : IDisposable
	{
		// Token: 0x0600006B RID: 107
		[Token(Token = "0x600006B")]
		void Send(byte[] data, int length, BlobTransportEndpoint ep);

		// Token: 0x0600006C RID: 108
		[Token(Token = "0x600006C")]
		void Receive(byte[] data, out int length, out BlobTransportEndpoint remoteEp);
	}
}
