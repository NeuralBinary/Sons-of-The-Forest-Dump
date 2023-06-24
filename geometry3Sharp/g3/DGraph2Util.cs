using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	public static class DGraph2Util
	{
		// Token: 0x06000675 RID: 1653 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1FAD1F0", Offset = "0x1FAB7F0", VA = "0x181FAD1F0")]
		public static DGraph2Util.Curves ExtractCurves(DGraph2 graph)
		{
			return null;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1FAE560", Offset = "0x1FACB60", VA = "0x181FAE560")]
		public static void ChainOpenPaths(DGraph2Util.Curves c, double epsilon = 2.220446049250313E-16)
		{
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1FAEEE0", Offset = "0x1FAD4E0", VA = "0x181FAEEE0")]
		private static List<PolyLine2d> find_connected_start(PolyLine2d pTest, List<PolyLine2d> potential, double eps = 2.220446049250313E-16)
		{
			return null;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1FAF340", Offset = "0x1FAD940", VA = "0x181FAF340")]
		private static List<PolyLine2d> find_connected_end(PolyLine2d pTest, List<PolyLine2d> potential, double eps = 2.220446049250313E-16)
		{
			return null;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1FAF6D0", Offset = "0x1FADCD0", VA = "0x181FAF6D0")]
		private static Polygon2d to_loop(PolyLine2d p1, PolyLine2d p2, double eps = 2.220446049250313E-16)
		{
			return null;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1FAF970", Offset = "0x1FADF70", VA = "0x181FAF970")]
		private static PolyLine2d merge_paths(PolyLine2d p1, PolyLine2d p2, double eps = 2.220446049250313E-16)
		{
			return null;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0000557C File Offset: 0x0000377C
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1FAFFD0", Offset = "0x1FAE5D0", VA = "0x181FAFFD0")]
		public static int DisconnectJunctions(DGraph2 graph)
		{
			return 0;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1FB0AB0", Offset = "0x1FAF0B0", VA = "0x181FB0AB0")]
		public static void DisconnectJunction(DGraph2 graph, int vid, double shrinkFactor = 1.0)
		{
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00005594 File Offset: 0x00003794
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1FB0E40", Offset = "0x1FAF440", VA = "0x181FB0E40")]
		public static Vector2d VertexLaplacian(DGraph2 graph, int vid, out bool isValid)
		{
			return default(Vector2d);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x000055AC File Offset: 0x000037AC
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1FB1190", Offset = "0x1FAF790", VA = "0x181FB1190")]
		public static bool FindRayIntersection(Vector2d o, Vector2d d, out int hit_eid, out double hit_ray_t, DGraph2 graph)
		{
			return default(bool);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000055C4 File Offset: 0x000037C4
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1FB17C0", Offset = "0x1FAFDC0", VA = "0x181FB17C0")]
		public static Index2i NextEdgeAndVtx(int eid, int prev_vid, DGraph2 graph)
		{
			return default(Index2i);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1FB19D0", Offset = "0x1FAFFD0", VA = "0x181FB19D0")]
		public static List<int> WalkToNextNonRegularVtx(DGraph2 graph, int fromVtx, int eid)
		{
			return null;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x000055DC File Offset: 0x000037DC
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1FB1B70", Offset = "0x1FB0170", VA = "0x181FB1B70")]
		public static double PathLength(DGraph2 graph, IList<int> pathVertices)
		{
			return 0.0;
		}

		// Token: 0x020000FF RID: 255
		[Token(Token = "0x20000FF")]
		public class Curves
		{
			// Token: 0x06000682 RID: 1666 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Curves()
			{
			}

			// Token: 0x040003CB RID: 971
			[Token(Token = "0x40003CB")]
			[FieldOffset(Offset = "0x10")]
			public List<Polygon2d> Loops;

			// Token: 0x040003CC RID: 972
			[Token(Token = "0x40003CC")]
			[FieldOffset(Offset = "0x18")]
			public List<PolyLine2d> Paths;
		}
	}
}
