using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	public struct BIHNode
	{
		// Token: 0x06000746 RID: 1862 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x27D7A30", Offset = "0x27D6030", VA = "0x1827D7A30")]
		public BIHNode(int start, int count)
		{
		}

		// Token: 0x0400062F RID: 1583
		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x0")]
		public int firstChild;

		// Token: 0x04000630 RID: 1584
		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x4")]
		public int start;

		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0xC")]
		public int axis;

		// Token: 0x04000633 RID: 1587
		[Token(Token = "0x4000633")]
		[FieldOffset(Offset = "0x10")]
		public float min;

		// Token: 0x04000634 RID: 1588
		[Token(Token = "0x4000634")]
		[FieldOffset(Offset = "0x14")]
		public float max;
	}
}
