using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000380 RID: 896
	[Token(Token = "0x2000380")]
	public struct ShiftGridIndexer3 : IGridWorldIndexer3
	{
		// Token: 0x06001D5F RID: 7519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D5F")]
		[Address(RVA = "0x1E3C3D0", Offset = "0x1E3A9D0", VA = "0x181E3C3D0")]
		public ShiftGridIndexer3(Vector3d origin, double cellSize)
		{
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x000149E4 File Offset: 0x00012BE4
		[Token(Token = "0x6001D60")]
		[Address(RVA = "0x1F7C190", Offset = "0x1F7A790", VA = "0x181F7C190", Slot = "4")]
		public Vector3i ToGrid(Vector3d point)
		{
			return default(Vector3i);
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x000149FC File Offset: 0x00012BFC
		[Token(Token = "0x6001D61")]
		[Address(RVA = "0x1F7C1E0", Offset = "0x1F7A7E0", VA = "0x181F7C1E0", Slot = "5")]
		public Vector3d ToGridf(Vector3d point)
		{
			return default(Vector3d);
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x00014A14 File Offset: 0x00012C14
		[Token(Token = "0x6001D62")]
		[Address(RVA = "0x1F7C230", Offset = "0x1F7A830", VA = "0x181F7C230", Slot = "6")]
		public Vector3d FromGrid(Vector3i gridpoint)
		{
			return default(Vector3d);
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x00014A2C File Offset: 0x00012C2C
		[Token(Token = "0x6001D63")]
		[Address(RVA = "0x1F7C280", Offset = "0x1F7A880", VA = "0x181F7C280", Slot = "7")]
		public Vector3d FromGrid(Vector3d gridpointf)
		{
			return default(Vector3d);
		}

		// Token: 0x04000FAB RID: 4011
		[Token(Token = "0x4000FAB")]
		[FieldOffset(Offset = "0x0")]
		public Vector3d Origin;

		// Token: 0x04000FAC RID: 4012
		[Token(Token = "0x4000FAC")]
		[FieldOffset(Offset = "0x18")]
		public double CellSize;
	}
}
