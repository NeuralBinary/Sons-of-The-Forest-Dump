using System;
using System.Net;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class BlobTransportEndpoint : IEquatable<BlobTransportEndpoint>
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x776160", Offset = "0x774760", VA = "0x180776160")]
		public BlobTransportEndpoint(string ip, ushort port)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x7762F0", Offset = "0x7748F0", VA = "0x1807762F0")]
		public BlobTransportEndpoint(IPEndPoint ep)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x776360", Offset = "0x774960", VA = "0x180776360")]
		public BlobTransportEndpoint(ulong steamId)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x7763C0", Offset = "0x7749C0", VA = "0x1807763C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x776480", Offset = "0x774A80", VA = "0x180776480", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x7764B0", Offset = "0x774AB0", VA = "0x1807764B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x776570", Offset = "0x774B70", VA = "0x180776570", Slot = "4")]
		public bool Equals(BlobTransportEndpoint other)
		{
			return default(bool);
		}

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x10")]
		public readonly IPEndPoint Ep;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x18")]
		public readonly ulong SteamId;
	}
}
