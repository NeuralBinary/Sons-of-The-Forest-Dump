using System;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	internal struct BlockAck
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x7771C0", Offset = "0x7757C0", VA = "0x1807771C0")]
		public static BlockAck FromPacket(Block p)
		{
			return default(BlockAck);
		}

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		public const byte TYPE = 237;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x0")]
		public byte Type;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x1")]
		public int BlobId;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x5")]
		public int BlockId;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x9")]
		public int Crc32;
	}
}
