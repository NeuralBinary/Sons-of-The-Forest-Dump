using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000103")]
	public static class DGraph3Util
	{
		// Token: 0x060006AB RID: 1707 RVA: 0x0000575C File Offset: 0x0000395C
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1FB4D40", Offset = "0x1FB3340", VA = "0x181FB4D40")]
		public static DGraph3Util.Curves ExtractCurves(DGraph3 graph, bool bWantLoopIndices = false, [Optional] Func<int, bool> CurveOrientationF)
		{
			return default(DGraph3Util.Curves);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1FB6590", Offset = "0x1FB4B90", VA = "0x181FB6590")]
		public static void DisconnectJunction(DGraph3 graph, int vid, double shrinkFactor = 1.0)
		{
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00005774 File Offset: 0x00003974
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1FB6980", Offset = "0x1FB4F80", VA = "0x181FB6980")]
		public static Index2i NextEdgeAndVtx(int eid, int prev_vid, DGraph3 graph)
		{
			return default(Index2i);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1FB6B90", Offset = "0x1FB5190", VA = "0x181FB6B90")]
		public static List<int> WalkToNextNonRegularVtx(DGraph3 graph, int fromVtx, int eid)
		{
			return null;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1FB6D30", Offset = "0x1FB5330", VA = "0x181FB6D30")]
		public static void ErodeOpenSpurs(DGraph3 graph)
		{
		}

		// Token: 0x02000104 RID: 260
		[Token(Token = "0x2000104")]
		public struct Curves
		{
			// Token: 0x040003DC RID: 988
			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<DCurve3> Loops;

			// Token: 0x040003DD RID: 989
			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<DCurve3> Paths;

			// Token: 0x040003DE RID: 990
			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HashSet<int> BoundaryV;

			// Token: 0x040003DF RID: 991
			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HashSet<int> JunctionV;

			// Token: 0x040003E0 RID: 992
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<List<int>> LoopEdges;

			// Token: 0x040003E1 RID: 993
			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<List<int>> PathEdges;
		}
	}
}
