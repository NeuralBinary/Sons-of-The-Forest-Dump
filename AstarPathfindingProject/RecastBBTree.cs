using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	public class RecastBBTree
	{
		// Token: 0x06000746 RID: 1862 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x6BA4B0", Offset = "0x6B8AB0", VA = "0x1806BA4B0")]
		public void QueryInBounds(Rect bounds, List<RecastMeshObj> buffer)
		{
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x6BA4F0", Offset = "0x6B8AF0", VA = "0x1806BA4F0")]
		private void QueryBoxInBounds(RecastBBTreeBox box, Rect bounds, List<RecastMeshObj> boxes)
		{
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0000572C File Offset: 0x0000392C
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x6BA780", Offset = "0x6B8D80", VA = "0x1806BA780")]
		public bool Remove(RecastMeshObj mesh)
		{
			return default(bool);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x6BA9C0", Offset = "0x6B8FC0", VA = "0x1806BA9C0")]
		private RecastBBTreeBox RemoveBox(RecastBBTreeBox c, RecastMeshObj mesh, Rect bounds, ref bool found)
		{
			return null;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x6BAD90", Offset = "0x6B9390", VA = "0x1806BAD90")]
		public void Insert(RecastMeshObj mesh)
		{
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00005744 File Offset: 0x00003944
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x6BB260", Offset = "0x6B9860", VA = "0x1806BB260")]
		private static bool RectIntersectsRect(Rect r, Rect r2)
		{
			return default(bool);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0000575C File Offset: 0x0000395C
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x6BB2B0", Offset = "0x6B98B0", VA = "0x1806BB2B0")]
		private static float ExpansionRequired(Rect r, Rect r2)
		{
			return 0f;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00005774 File Offset: 0x00003974
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x6BB330", Offset = "0x6B9930", VA = "0x1806BB330")]
		private static Rect ExpandToContain(Rect r, Rect r2)
		{
			return default(Rect);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0000578C File Offset: 0x0000398C
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x6BB3B0", Offset = "0x6B99B0", VA = "0x1806BB3B0")]
		private static float RectArea(Rect r)
		{
			return 0f;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public RecastBBTree()
		{
		}

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x10")]
		private RecastBBTreeBox root;
	}
}
