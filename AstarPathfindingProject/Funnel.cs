using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000101 RID: 257
	[Token(Token = "0x2000101")]
	public class Funnel
	{
		// Token: 0x06000892 RID: 2194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x6E0C10", Offset = "0x6DF210", VA = "0x1806E0C10")]
		public static List<Funnel.PathPart> SplitIntoParts(Path path)
		{
			return null;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00005D2C File Offset: 0x00003F2C
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x6E13A0", Offset = "0x6DF9A0", VA = "0x1806E13A0")]
		public static Funnel.FunnelPortals ConstructFunnelPortals(List<GraphNode> nodes, Funnel.PathPart part)
		{
			return default(Funnel.FunnelPortals);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000894")]
		[Address(RVA = "0x6E1B30", Offset = "0x6E0130", VA = "0x1806E1B30")]
		public static void ShrinkPortals(Funnel.FunnelPortals portals, float shrink)
		{
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00005D44 File Offset: 0x00003F44
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x6E1F00", Offset = "0x6E0500", VA = "0x1806E1F00")]
		private static bool UnwrapHelper(Vector3 portalStart, Vector3 portalEnd, Vector3 prevPoint, Vector3 nextPoint, ref Quaternion mRot, ref Vector3 mOffset)
		{
			return default(bool);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x6E23D0", Offset = "0x6E09D0", VA = "0x1806E23D0")]
		public static void Unwrap(Funnel.FunnelPortals funnel, Vector2[] left, Vector2[] right)
		{
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00005D5C File Offset: 0x00003F5C
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x6E2CE0", Offset = "0x6E12E0", VA = "0x1806E2CE0")]
		private static int FixFunnel(Vector2[] left, Vector2[] right, int numPortals)
		{
			return 0;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00005D74 File Offset: 0x00003F74
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x6E2E90", Offset = "0x6E1490", VA = "0x1806E2E90")]
		protected static Vector2 ToXZ(Vector3 p)
		{
			return default(Vector2);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00005D8C File Offset: 0x00003F8C
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x6E2EB0", Offset = "0x6E14B0", VA = "0x1806E2EB0")]
		protected static Vector3 FromXZ(Vector2 p)
		{
			return default(Vector3);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00005DA4 File Offset: 0x00003FA4
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x6E2EE0", Offset = "0x6E14E0", VA = "0x1806E2EE0")]
		protected static bool RightOrColinear(Vector2 a, Vector2 b)
		{
			return default(bool);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00005DBC File Offset: 0x00003FBC
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x6E2F20", Offset = "0x6E1520", VA = "0x1806E2F20")]
		protected static bool LeftOrColinear(Vector2 a, Vector2 b)
		{
			return default(bool);
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089C")]
		[Address(RVA = "0x6E2F60", Offset = "0x6E1560", VA = "0x1806E2F60")]
		public static List<Vector3> Calculate(Funnel.FunnelPortals funnel, bool unwrap, bool splitAtEveryPortal)
		{
			return null;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x6E38F0", Offset = "0x6E1EF0", VA = "0x1806E38F0")]
		private static void Calculate(Vector2[] left, Vector2[] right, int numPortals, int startIndex, List<int> funnelPath, int maxCorners, out bool lastCorner)
		{
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Funnel()
		{
		}

		// Token: 0x02000102 RID: 258
		[Token(Token = "0x2000102")]
		public struct FunnelPortals
		{
			// Token: 0x040005CF RID: 1487
			[Token(Token = "0x40005CF")]
			[FieldOffset(Offset = "0x0")]
			public List<Vector3> left;

			// Token: 0x040005D0 RID: 1488
			[Token(Token = "0x40005D0")]
			[FieldOffset(Offset = "0x8")]
			public List<Vector3> right;
		}

		// Token: 0x02000103 RID: 259
		[Token(Token = "0x2000103")]
		public struct PathPart
		{
			// Token: 0x040005D1 RID: 1489
			[Token(Token = "0x40005D1")]
			[FieldOffset(Offset = "0x0")]
			public int startIndex;

			// Token: 0x040005D2 RID: 1490
			[Token(Token = "0x40005D2")]
			[FieldOffset(Offset = "0x4")]
			public int endIndex;

			// Token: 0x040005D3 RID: 1491
			[Token(Token = "0x40005D3")]
			[FieldOffset(Offset = "0x8")]
			public Vector3 startPoint;

			// Token: 0x040005D4 RID: 1492
			[Token(Token = "0x40005D4")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 endPoint;

			// Token: 0x040005D5 RID: 1493
			[Token(Token = "0x40005D5")]
			[FieldOffset(Offset = "0x20")]
			public bool isLink;
		}
	}
}
