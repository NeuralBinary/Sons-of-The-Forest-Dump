using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000BB RID: 187
	[Token(Token = "0x20000BB")]
	public struct IntTagPair
	{
		// Token: 0x06000440 RID: 1088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1F4DA00", Offset = "0x1F4C000", VA = "0x181F4DA00")]
		public IntTagPair(byte type, int value)
		{
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1F4DA10", Offset = "0x1F4C010", VA = "0x181F4DA10")]
		public IntTagPair(int combined)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0000404C File Offset: 0x0000224C
		[Token(Token = "0x17000091")]
		public int intValue
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x1F4DA30", Offset = "0x1F4C030", VA = "0x181F4DA30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x0")]
		public byte type;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x4")]
		public int value;
	}
}
