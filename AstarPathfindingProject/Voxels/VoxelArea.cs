using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Voxels
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	public class VoxelArea
	{
		// Token: 0x060008CF RID: 2255 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x6EBBC0", Offset = "0x6EA1C0", VA = "0x1806EBBC0")]
		public void Reset()
		{
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x6EBC40", Offset = "0x6EA240", VA = "0x1806EBC40")]
		private void ResetLinkedVoxelSpans()
		{
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x6EBF00", Offset = "0x6EA500", VA = "0x1806EBF00")]
		public VoxelArea(int width, int depth)
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00005EF4 File Offset: 0x000040F4
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x6EC370", Offset = "0x6EA970", VA = "0x1806EC370")]
		public int GetSpanCountAll()
		{
			return 0;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00005F0C File Offset: 0x0000410C
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x6EC3F0", Offset = "0x6EA9F0", VA = "0x1806EC3F0")]
		public int GetSpanCount()
		{
			return 0;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x6EC480", Offset = "0x6EAA80", VA = "0x1806EC480")]
		private void PushToSpanRemovedStack(int index)
		{
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x6EC5A0", Offset = "0x6EABA0", VA = "0x1806EC5A0")]
		public void AddLinkedSpan(int index, uint bottom, uint top, int area, int voxelWalkableClimb)
		{
		}

		// Token: 0x040005FC RID: 1532
		[Token(Token = "0x40005FC")]
		public const uint MaxHeight = 65536U;

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x40005FD")]
		public const int MaxHeightInt = 65536;

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40005FE")]
		public const uint InvalidSpanValue = 4294967295U;

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		public const float AvgSpanLayerCountEstimate = 8f;

		// Token: 0x04000600 RID: 1536
		[Token(Token = "0x4000600")]
		[FieldOffset(Offset = "0x10")]
		public readonly int width;

		// Token: 0x04000601 RID: 1537
		[Token(Token = "0x4000601")]
		[FieldOffset(Offset = "0x14")]
		public readonly int depth;

		// Token: 0x04000602 RID: 1538
		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0x18")]
		public CompactVoxelSpan[] compactSpans;

		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0x20")]
		public CompactVoxelCell[] compactCells;

		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		[FieldOffset(Offset = "0x28")]
		public int compactSpanCount;

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0x30")]
		public ushort[] tmpUShortArr;

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0x38")]
		public int[] areaTypes;

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0x40")]
		public ushort[] dist;

		// Token: 0x04000608 RID: 1544
		[Token(Token = "0x4000608")]
		[FieldOffset(Offset = "0x48")]
		public ushort maxDistance;

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		[FieldOffset(Offset = "0x4C")]
		public int maxRegions;

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		[FieldOffset(Offset = "0x50")]
		public int[] DirectionX;

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0x58")]
		public int[] DirectionZ;

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x60")]
		public Vector3[] VectorDirection;

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		[FieldOffset(Offset = "0x68")]
		private int linkedSpanCount;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x70")]
		public LinkedVoxelSpan[] linkedSpans;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x78")]
		private int[] removedStack;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0x80")]
		private int removedStackCount;
	}
}
