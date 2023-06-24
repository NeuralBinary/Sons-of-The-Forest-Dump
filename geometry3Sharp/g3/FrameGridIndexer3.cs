using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000381 RID: 897
	[Token(Token = "0x2000381")]
	public struct FrameGridIndexer3 : IGridWorldIndexer3
	{
		// Token: 0x06001D64 RID: 7524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D64")]
		[Address(RVA = "0x1F7C2C0", Offset = "0x1F7A8C0", VA = "0x181F7C2C0")]
		public FrameGridIndexer3(Frame3f frame, Vector3f cellSize)
		{
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x00014A44 File Offset: 0x00012C44
		[Token(Token = "0x6001D65")]
		[Address(RVA = "0x1F7C2F0", Offset = "0x1F7A8F0", VA = "0x181F7C2F0", Slot = "4")]
		public Vector3i ToGrid(Vector3d point)
		{
			return default(Vector3i);
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x00014A5C File Offset: 0x00012C5C
		[Token(Token = "0x6001D66")]
		[Address(RVA = "0x1F7C480", Offset = "0x1F7AA80", VA = "0x181F7C480", Slot = "5")]
		public Vector3d ToGridf(Vector3d point)
		{
			return default(Vector3d);
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00014A74 File Offset: 0x00012C74
		[Token(Token = "0x6001D67")]
		[Address(RVA = "0x1F7C570", Offset = "0x1F7AB70", VA = "0x181F7C570", Slot = "6")]
		public Vector3d FromGrid(Vector3i gridpoint)
		{
			return default(Vector3d);
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00014A8C File Offset: 0x00012C8C
		[Token(Token = "0x6001D68")]
		[Address(RVA = "0x1F7C710", Offset = "0x1F7AD10", VA = "0x181F7C710", Slot = "7")]
		public Vector3d FromGrid(Vector3d gridpointf)
		{
			return default(Vector3d);
		}

		// Token: 0x04000FAD RID: 4013
		[Token(Token = "0x4000FAD")]
		[FieldOffset(Offset = "0x0")]
		public Frame3f GridFrame;

		// Token: 0x04000FAE RID: 4014
		[Token(Token = "0x4000FAE")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3f CellSize;
	}
}
