using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	public struct BatchData
	{
		// Token: 0x060003CB RID: 971 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x279BDC0", Offset = "0x279A3C0", VA = "0x18279BDC0")]
		public BatchData(int index, int maxBatches)
		{
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x279BE00", Offset = "0x279A400", VA = "0x18279BE00")]
		public void GetConstraintRange(int workItemIndex, out int start, out int end)
		{
		}

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x0")]
		public ushort batchID;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x4")]
		public int startIndex;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x8")]
		public int constraintCount;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0xC")]
		public int activeConstraintCount;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x10")]
		public int workItemSize;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x14")]
		public int workItemCount;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x18")]
		public bool isLast;
	}
}
