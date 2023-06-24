using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	internal struct PropertyIntCompressionSettings
	{
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x17000123")]
		public int BitsRequired
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x8FE350", Offset = "0x8FC950", VA = "0x1808FE350")]
		public static PropertyIntCompressionSettings Create()
		{
			return default(PropertyIntCompressionSettings);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x8FE370", Offset = "0x8FC970", VA = "0x1808FE370")]
		public static PropertyIntCompressionSettings Create(int bits, int shift)
		{
			return default(PropertyIntCompressionSettings);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x8FE390", Offset = "0x8FC990", VA = "0x1808FE390")]
		public void Pack(UdpPacket stream, int value)
		{
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x8FE3C0", Offset = "0x8FC9C0", VA = "0x1808FE3C0")]
		public int Read(UdpPacket stream)
		{
			return 0;
		}

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x0")]
		private int _bits;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x4")]
		private int _shift;
	}
}
