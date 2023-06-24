using System;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public class BlobTransportUdpNetworkInterface : IBlobSyncNetworkInterface, IDisposable
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x776CD0", Offset = "0x7752D0", VA = "0x180776CD0")]
		public BlobTransportUdpNetworkInterface(bool listen, int listenPort)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x776DA0", Offset = "0x7753A0", VA = "0x180776DA0", Slot = "4")]
		public void Send(byte[] data, int length, BlobTransportEndpoint ep)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x776DD0", Offset = "0x7753D0", VA = "0x180776DD0", Slot = "5")]
		public void Receive(byte[] data, out int length, out BlobTransportEndpoint remoteEp)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x777190", Offset = "0x775790", VA = "0x180777190", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x10")]
		private readonly UdpClient _udpClient;
	}
}
