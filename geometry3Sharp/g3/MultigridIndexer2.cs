using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000388 RID: 904
	[Token(Token = "0x2000388")]
	public struct MultigridIndexer2 : IMultigridIndexer2
	{
		// Token: 0x06001D7D RID: 7549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D7D")]
		[Address(RVA = "0x1F7CF50", Offset = "0x1F7B550", VA = "0x181F7CF50")]
		public MultigridIndexer2(Vector2i blockSize)
		{
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x00014B94 File Offset: 0x00012D94
		[Token(Token = "0x6001D7E")]
		[Address(RVA = "0x1F7CFC0", Offset = "0x1F7B5C0", VA = "0x181F7CFC0", Slot = "5")]
		public Vector2i ToBlockIndex(Vector2i outer_index)
		{
			return default(Vector2i);
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x00014BAC File Offset: 0x00012DAC
		[Token(Token = "0x6001D7F")]
		[Address(RVA = "0x1F7D0B0", Offset = "0x1F7B6B0", VA = "0x181F7D0B0", Slot = "6")]
		public Vector2i ToBlockLocal(Vector2i outer_index)
		{
			return default(Vector2i);
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00014BC4 File Offset: 0x00012DC4
		[Token(Token = "0x6001D80")]
		[Address(RVA = "0x1F7D160", Offset = "0x1F7B760", VA = "0x181F7D160", Slot = "4")]
		public GridLevelIndex2 ToBlock(Vector2i outer_index)
		{
			return default(GridLevelIndex2);
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x00014BDC File Offset: 0x00012DDC
		[Token(Token = "0x6001D81")]
		[Address(RVA = "0x1F7D2C0", Offset = "0x1F7B8C0", VA = "0x181F7D2C0", Slot = "7")]
		public Vector2i FromBlock(Vector2i block_idx)
		{
			return default(Vector2i);
		}

		// Token: 0x04000FB7 RID: 4023
		[Token(Token = "0x4000FB7")]
		[FieldOffset(Offset = "0x0")]
		public Vector2i OuterShift;

		// Token: 0x04000FB8 RID: 4024
		[Token(Token = "0x4000FB8")]
		[FieldOffset(Offset = "0x8")]
		public Vector2i BlockSize;

		// Token: 0x04000FB9 RID: 4025
		[Token(Token = "0x4000FB9")]
		[FieldOffset(Offset = "0x10")]
		public Vector2i BlockShift;
	}
}
