using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public class GraphCells2d
	{
		// Token: 0x06000186 RID: 390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public GraphCells2d(DGraph2 graph)
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1E255C0", Offset = "0x1E23BC0", VA = "0x181E255C0")]
		public void FindCells()
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1E25DA0", Offset = "0x1E243A0", VA = "0x181E25DA0")]
		public List<Polygon2d> CellsToPolygons([Optional] Func<Polygon2d, bool> FilterF)
		{
			return null;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1E25F80", Offset = "0x1E24580", VA = "0x181E25F80")]
		public List<Polygon2d> ContainedCells(GeneralPolygon2d container)
		{
			return null;
		}

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DGraph2 Graph;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int[]> CellLoops;
	}
}
