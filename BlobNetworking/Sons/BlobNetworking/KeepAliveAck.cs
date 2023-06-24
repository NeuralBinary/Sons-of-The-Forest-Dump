using System;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public struct KeepAliveAck
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x777300", Offset = "0x775900", VA = "0x180777300")]
		public KeepAliveAck(long ticks)
		{
		}

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		public const byte TYPE = 87;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x0")]
		public byte Type;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x1")]
		public long Ticks;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x9")]
		public int Crc32;
	}
}
