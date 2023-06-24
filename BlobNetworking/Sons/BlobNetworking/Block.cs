using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sons.BlobNetworking
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public struct Block
	{
		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		public const byte TYPE = 184;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		public const short BLOCK_SIZE = 1024;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x0")]
		public byte Type;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x1")]
		public byte Channel;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x2")]
		public int BlobId;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x6")]
		public int BlobSize;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0xA")]
		public int BlockId;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0xE")]
		public int BlockCount;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x12")]
		[FixedBuffer(typeof(byte), 1024)]
		public Block.<Data>e__FixedBuffer Data;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x412")]
		public short DataLength;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x414")]
		public int Crc32;

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <Data>e__FixedBuffer
		{
			// Token: 0x0400006D RID: 109
			[Token(Token = "0x400006D")]
			[FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
