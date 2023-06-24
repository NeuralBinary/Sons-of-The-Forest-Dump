using System;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public struct KeepAlive
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x7772E0", Offset = "0x7758E0", VA = "0x1807772E0")]
		public KeepAlive(ulong token, long ticks, short lastRtt)
		{
		}

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		public const byte TYPE = 165;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x0")]
		public byte Type;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x1")]
		public ulong Token;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x9")]
		public long Ticks;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x11")]
		public short LastRtt;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x13")]
		public int Crc32;
	}
}
