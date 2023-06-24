using System;
using Il2CppDummyDll;
using Steamworks;

namespace Sons.BlobNetworking
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public class BlobTransportSteamNetworkInterface : IBlobSyncNetworkInterface, IDisposable
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x7765F0", Offset = "0x774BF0", VA = "0x1807765F0")]
		public BlobTransportSteamNetworkInterface(bool listen)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x7766A0", Offset = "0x774CA0", VA = "0x1807766A0", Slot = "4")]
		public void Send(byte[] data, int length, BlobTransportEndpoint ep)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x7768A0", Offset = "0x774EA0", VA = "0x1807768A0", Slot = "5")]
		public void Receive(byte[] data, out int length, out BlobTransportEndpoint remoteEp)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x776C30", Offset = "0x775230", VA = "0x180776C30")]
		private bool SendP2PPacket(CSteamID id, byte[] data, int length, EP2PSend mode)
		{
			return default(bool);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x776C80", Offset = "0x775280", VA = "0x180776C80")]
		private bool ReadP2PPacket(byte[] data, out uint msgSize, out CSteamID id)
		{
			return default(bool);
		}

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x10")]
		private bool _isServer;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x14")]
		private readonly int _steamChannel;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _dummy;
	}
}
