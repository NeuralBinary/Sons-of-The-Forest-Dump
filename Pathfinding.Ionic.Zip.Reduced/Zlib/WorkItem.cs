using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	internal class WorkItem
	{
		// Token: 0x06000405 RID: 1029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x28997D0", Offset = "0x2897DD0", VA = "0x1828997D0")]
		public WorkItem(int size, CompressionLevel compressLevel, CompressionStrategy strategy, int ix)
		{
		}

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x10")]
		public byte[] buffer;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x18")]
		public byte[] compressed;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x20")]
		public int crc;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x24")]
		public int index;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x28")]
		public int ordinal;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x2C")]
		public int inputBytesAvailable;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x30")]
		public int compressedBytesAvailable;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x38")]
		public ZlibCodec compressor;
	}
}
