using System;
using System.Collections.Generic;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	public class PointSetHashtable
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public PointSetHashtable(IPointSet points)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1E186A0", Offset = "0x1E16CA0", VA = "0x181E186A0")]
		public void Build(int maxAxisSubdivs = 64)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1E18730", Offset = "0x1E16D30", VA = "0x181E18730")]
		public void Build(double cellSize, Vector3d origin)
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1E18BF0", Offset = "0x1E171F0", VA = "0x181E18BF0")]
		public bool FindInBall(Vector3d pt, double r, int[] buffer, out int buffer_count)
		{
			return default(bool);
		}

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x10")]
		private IPointSet Points;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x18")]
		private DSparseGrid3<PointSetHashtable.PointList> Grid;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x20")]
		private ShiftGridIndexer3 indexF;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x40")]
		private Vector3d Origin;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x58")]
		private double CellSize;

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		public class PointList : List<int>, IGridElement3
		{
			// Token: 0x0600010C RID: 268 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1E195C0", Offset = "0x1E17BC0", VA = "0x181E195C0", Slot = "35")]
			public IGridElement3 CreateNewGridElement(bool bCopy)
			{
				return null;
			}

			// Token: 0x0600010D RID: 269 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1E19650", Offset = "0x1E17C50", VA = "0x181E19650")]
			public PointList()
			{
			}
		}
	}
}
