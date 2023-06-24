using System;
using System.Diagnostics;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	public class BBTree : IAstarPooledObject
	{
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x000054D4 File Offset: 0x000036D4
		[Token(Token = "0x17000127")]
		public Rect Size
		{
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x6B0360", Offset = "0x6AE960", VA = "0x1806B0360")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x6B0430", Offset = "0x6AEA30", VA = "0x1806B0430")]
		public void Clear()
		{
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x6B06B0", Offset = "0x6AECB0", VA = "0x1806B06B0", Slot = "4")]
		private void OnEnterPool()
		{
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x6B06C0", Offset = "0x6AECC0", VA = "0x1806B06C0")]
		private void EnsureCapacity(int c)
		{
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x6B07D0", Offset = "0x6AEDD0", VA = "0x1806B07D0")]
		private void EnsureNodeCapacity(int c)
		{
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x000054EC File Offset: 0x000036EC
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x6B08E0", Offset = "0x6AEEE0", VA = "0x1806B08E0")]
		private int GetBox(IntRect rect)
		{
			return 0;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x6B0970", Offset = "0x6AEF70", VA = "0x1806B0970")]
		public void RebuildFrom(TriangleMeshNode[] nodes)
		{
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00005504 File Offset: 0x00003704
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x6B0E30", Offset = "0x6AF430", VA = "0x1806B0E30")]
		private static int SplitByX(TriangleMeshNode[] nodes, int[] permutation, int from, int to, int divider)
		{
			return 0;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0000551C File Offset: 0x0000371C
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x6B0ED0", Offset = "0x6AF4D0", VA = "0x1806B0ED0")]
		private static int SplitByZ(TriangleMeshNode[] nodes, int[] permutation, int from, int to, int divider)
		{
			return 0;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00005534 File Offset: 0x00003734
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x6B0F70", Offset = "0x6AF570", VA = "0x1806B0F70")]
		private int RebuildFromInternal(TriangleMeshNode[] nodes, int[] permutation, IntRect[] nodeBounds, int from, int to, bool odd)
		{
			return 0;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0000554C File Offset: 0x0000374C
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x6B1620", Offset = "0x6AFC20", VA = "0x1806B1620")]
		private static IntRect NodeBounds(int[] permutation, IntRect[] nodeBounds, int from, int to)
		{
			return default(IntRect);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x6B1760", Offset = "0x6AFD60", VA = "0x1806B1760")]
		[Conditional("ASTARDEBUG")]
		private static void DrawDebugRect(IntRect rect)
		{
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x6B1C40", Offset = "0x6B0240", VA = "0x1806B1C40")]
		[Conditional("ASTARDEBUG")]
		private static void DrawDebugNode(TriangleMeshNode node, float yoffset, Color color)
		{
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00005564 File Offset: 0x00003764
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x6B2500", Offset = "0x6B0B00", VA = "0x1806B2500")]
		public NNInfoInternal QueryClosest(Vector3 p, NNConstraint constraint, out float distance)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0000557C File Offset: 0x0000377C
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x6B2610", Offset = "0x6B0C10", VA = "0x1806B2610")]
		public NNInfoInternal QueryClosestXZ(Vector3 p, NNConstraint constraint, ref float distance, NNInfoInternal previous)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x6B2760", Offset = "0x6B0D60", VA = "0x1806B2760")]
		private void SearchBoxClosestXZ(int boxi, Vector3 p, ref float closestSqrDist, NNConstraint constraint, ref NNInfoInternal nnInfo)
		{
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00005594 File Offset: 0x00003794
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x6B2AB0", Offset = "0x6B10B0", VA = "0x1806B2AB0")]
		public NNInfoInternal QueryClosest(Vector3 p, NNConstraint constraint, ref float distance, NNInfoInternal previous)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x6B2C00", Offset = "0x6B1200", VA = "0x1806B2C00")]
		private void SearchBoxClosest(int boxi, Vector3 p, ref float closestSqrDist, NNConstraint constraint, ref NNInfoInternal nnInfo)
		{
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x6B2F10", Offset = "0x6B1510", VA = "0x1806B2F10")]
		private void GetOrderedChildren(ref int first, ref int second, out float firstDist, out float secondDist, Vector3 p)
		{
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x6B3020", Offset = "0x6B1620", VA = "0x1806B3020")]
		public TriangleMeshNode QueryInside(Vector3 p, NNConstraint constraint)
		{
			return null;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x6B30E0", Offset = "0x6B16E0", VA = "0x1806B30E0")]
		private TriangleMeshNode SearchBoxInside(int boxi, Vector3 p, NNConstraint constraint)
		{
			return null;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x6B33A0", Offset = "0x6B19A0", VA = "0x1806B33A0")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x6B3420", Offset = "0x6B1A20", VA = "0x1806B3420")]
		private void OnDrawGizmos(int boxi, int depth)
		{
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x000055AC File Offset: 0x000037AC
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x6B3780", Offset = "0x6B1D80", VA = "0x1806B3780")]
		private static bool NodeIntersectsCircle(TriangleMeshNode node, Vector3 p, float radius)
		{
			return default(bool);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x000055C4 File Offset: 0x000037C4
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x6B3850", Offset = "0x6B1E50", VA = "0x1806B3850")]
		private static bool RectIntersectsCircle(IntRect r, Vector3 p, float radius)
		{
			return default(bool);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x000055DC File Offset: 0x000037DC
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x6B39C0", Offset = "0x6B1FC0", VA = "0x1806B39C0")]
		private static float SquaredRectPointDistance(IntRect r, Vector3 p)
		{
			return 0f;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BBTree()
		{
		}

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x10")]
		private BBTree.BBTreeBox[] tree;

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x18")]
		private TriangleMeshNode[] nodeLookup;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x20")]
		private int count;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x24")]
		private int leafNodes;

		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		private const int MaximumLeafSize = 4;

		// Token: 0x020000B8 RID: 184
		[Token(Token = "0x20000B8")]
		private struct BBTreeBox
		{
			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000709 RID: 1801 RVA: 0x000055F4 File Offset: 0x000037F4
			[Token(Token = "0x17000128")]
			public bool IsLeaf
			{
				[Token(Token = "0x6000709")]
				[Address(RVA = "0x6B3B00", Offset = "0x6B2100", VA = "0x1806B3B00")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600070A RID: 1802 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x6B3B10", Offset = "0x6B2110", VA = "0x1806B3B10")]
			public BBTreeBox(IntRect rect)
			{
			}

			// Token: 0x0600070B RID: 1803 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x6B3B30", Offset = "0x6B2130", VA = "0x1806B3B30")]
			public BBTreeBox(int nodeOffset, IntRect rect)
			{
			}

			// Token: 0x0600070C RID: 1804 RVA: 0x0000560C File Offset: 0x0000380C
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x6B3B50", Offset = "0x6B2150", VA = "0x1806B3B50")]
			public bool Contains(Vector3 point)
			{
				return default(bool);
			}

			// Token: 0x04000480 RID: 1152
			[Token(Token = "0x4000480")]
			[FieldOffset(Offset = "0x0")]
			public IntRect rect;

			// Token: 0x04000481 RID: 1153
			[Token(Token = "0x4000481")]
			[FieldOffset(Offset = "0x10")]
			public int nodeOffset;

			// Token: 0x04000482 RID: 1154
			[Token(Token = "0x4000482")]
			[FieldOffset(Offset = "0x14")]
			public int left;

			// Token: 0x04000483 RID: 1155
			[Token(Token = "0x4000483")]
			[FieldOffset(Offset = "0x18")]
			public int right;
		}
	}
}
