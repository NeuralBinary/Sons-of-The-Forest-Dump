using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000387 RID: 903
	[Token(Token = "0x2000387")]
	public struct ShiftGridIndexer2 : IGridWorldIndexer2
	{
		// Token: 0x06001D79 RID: 7545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D79")]
		[Address(RVA = "0x1F37280", Offset = "0x1F35880", VA = "0x181F37280")]
		public ShiftGridIndexer2(Vector2d origin, double cellSize)
		{
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00014B4C File Offset: 0x00012D4C
		[Token(Token = "0x6001D7A")]
		[Address(RVA = "0x1F7CEA0", Offset = "0x1F7B4A0", VA = "0x181F7CEA0", Slot = "4")]
		public Vector2i ToGrid(Vector2d point)
		{
			return default(Vector2i);
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00014B64 File Offset: 0x00012D64
		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0x1F7CEE0", Offset = "0x1F7B4E0", VA = "0x181F7CEE0", Slot = "5")]
		public Vector2d FromGrid(Vector2i gridpoint)
		{
			return default(Vector2d);
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x00014B7C File Offset: 0x00012D7C
		[Token(Token = "0x6001D7C")]
		[Address(RVA = "0x1F7CF20", Offset = "0x1F7B520", VA = "0x181F7CF20", Slot = "6")]
		public Vector2d FromGrid(Vector2d gridpointf)
		{
			return default(Vector2d);
		}

		// Token: 0x04000FB5 RID: 4021
		[Token(Token = "0x4000FB5")]
		[FieldOffset(Offset = "0x0")]
		public Vector2d Origin;

		// Token: 0x04000FB6 RID: 4022
		[Token(Token = "0x4000FB6")]
		[FieldOffset(Offset = "0x10")]
		public double CellSize;
	}
}
