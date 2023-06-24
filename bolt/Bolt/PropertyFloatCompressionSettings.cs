using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	internal struct PropertyFloatCompressionSettings
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x17000122")]
		public int BitsRequired
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x8FE250", Offset = "0x8FC850", VA = "0x1808FE250")]
		public static PropertyFloatCompressionSettings Create()
		{
			return default(PropertyFloatCompressionSettings);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x8FE260", Offset = "0x8FC860", VA = "0x1808FE260")]
		public static PropertyFloatCompressionSettings Create(int bits, float shift, float pack, float read)
		{
			return default(PropertyFloatCompressionSettings);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x8FE280", Offset = "0x8FC880", VA = "0x1808FE280")]
		public void Pack(UdpPacket stream, float value)
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x8FE2E0", Offset = "0x8FC8E0", VA = "0x1808FE2E0")]
		public float Read(UdpPacket stream)
		{
			return 0f;
		}

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x0")]
		private int _bits;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x4")]
		private float _pack;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x8")]
		private float _read;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0xC")]
		private float _shift;
	}
}
