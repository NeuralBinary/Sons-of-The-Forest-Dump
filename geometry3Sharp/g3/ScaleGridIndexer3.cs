using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200037F RID: 895
	[Token(Token = "0x200037F")]
	public struct ScaleGridIndexer3 : IGridWorldIndexer3
	{
		// Token: 0x06001D5A RID: 7514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D5A")]
		[Address(RVA = "0x1F7C0A0", Offset = "0x1F7A6A0", VA = "0x181F7C0A0")]
		public ScaleGridIndexer3(double cellSize)
		{
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x00014984 File Offset: 0x00012B84
		[Token(Token = "0x6001D5B")]
		[Address(RVA = "0x1F7C0B0", Offset = "0x1F7A6B0", VA = "0x181F7C0B0", Slot = "4")]
		public Vector3i ToGrid(Vector3d point)
		{
			return default(Vector3i);
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x0001499C File Offset: 0x00012B9C
		[Token(Token = "0x6001D5C")]
		[Address(RVA = "0x1F7C0F0", Offset = "0x1F7A6F0", VA = "0x181F7C0F0", Slot = "5")]
		public Vector3d ToGridf(Vector3d point)
		{
			return default(Vector3d);
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x000149B4 File Offset: 0x00012BB4
		[Token(Token = "0x6001D5D")]
		[Address(RVA = "0x1F7C120", Offset = "0x1F7A720", VA = "0x181F7C120", Slot = "6")]
		public Vector3d FromGrid(Vector3i gridpoint)
		{
			return default(Vector3d);
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x000149CC File Offset: 0x00012BCC
		[Token(Token = "0x6001D5E")]
		[Address(RVA = "0x1F7C160", Offset = "0x1F7A760", VA = "0x181F7C160", Slot = "7")]
		public Vector3d FromGrid(Vector3d gridpointf)
		{
			return default(Vector3d);
		}

		// Token: 0x04000FAA RID: 4010
		[Token(Token = "0x4000FAA")]
		[FieldOffset(Offset = "0x0")]
		public double CellSize;
	}
}
