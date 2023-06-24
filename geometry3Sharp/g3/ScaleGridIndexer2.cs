using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000386 RID: 902
	[Token(Token = "0x2000386")]
	public struct ScaleGridIndexer2 : IGridWorldIndexer2
	{
		// Token: 0x06001D75 RID: 7541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D75")]
		[Address(RVA = "0x1F7C0A0", Offset = "0x1F7A6A0", VA = "0x181F7C0A0")]
		public ScaleGridIndexer2(double cellSize)
		{
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00014B04 File Offset: 0x00012D04
		[Token(Token = "0x6001D76")]
		[Address(RVA = "0x1F7CE20", Offset = "0x1F7B420", VA = "0x181F7CE20", Slot = "4")]
		public Vector2i ToGrid(Vector2d point)
		{
			return default(Vector2i);
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x00014B1C File Offset: 0x00012D1C
		[Token(Token = "0x6001D77")]
		[Address(RVA = "0x1F7CE50", Offset = "0x1F7B450", VA = "0x181F7CE50", Slot = "5")]
		public Vector2d FromGrid(Vector2i gridpoint)
		{
			return default(Vector2d);
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00014B34 File Offset: 0x00012D34
		[Token(Token = "0x6001D78")]
		[Address(RVA = "0x1F7CE80", Offset = "0x1F7B480", VA = "0x181F7CE80", Slot = "6")]
		public Vector2d FromGrid(Vector2d gridpointf)
		{
			return default(Vector2d);
		}

		// Token: 0x04000FB4 RID: 4020
		[Token(Token = "0x4000FB4")]
		[FieldOffset(Offset = "0x0")]
		public double CellSize;
	}
}
