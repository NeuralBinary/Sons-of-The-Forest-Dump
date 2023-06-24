using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	internal class SendRoundRobin
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x1700000E")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x777310", Offset = "0x775910", VA = "0x180777310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x777360", Offset = "0x775960", VA = "0x180777360")]
		public bool Next(out BlobSend o)
		{
			return default(bool);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x7775E0", Offset = "0x775BE0", VA = "0x1807775E0")]
		public void Clear()
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x7776E0", Offset = "0x775CE0", VA = "0x1807776E0")]
		public void Add(BlobSend blob)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x777960", Offset = "0x775F60", VA = "0x180777960")]
		public void Remove(int blobId)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x777AF0", Offset = "0x7760F0", VA = "0x180777AF0")]
		public bool Contains(int blobId)
		{
			return default(bool);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x777B60", Offset = "0x776160", VA = "0x180777B60")]
		public BlobSend Get(int blobId)
		{
			return null;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x777BC0", Offset = "0x7761C0", VA = "0x180777BC0")]
		public void Timeout(BlobTransportEndpoint ep)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x777E90", Offset = "0x776490", VA = "0x180777E90")]
		public void UpdateEndpointResponsiveness(BlobTransportEndpoint ep, bool isResponsive)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x777F70", Offset = "0x776570", VA = "0x180777F70")]
		public SendRoundRobin()
		{
		}

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, BlobSend> _blobSendMap;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x18")]
		private List<BlobTransportEndpoint> _remotesList;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<BlobTransportEndpoint, List<int>> _blobSendQueues;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<BlobTransportEndpoint> _responsiveRemotes;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x30")]
		private int _currentRemoteIndex;
	}
}
