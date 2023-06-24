using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	public static class ShapesMeshGen
	{
		// Token: 0x06000C92 RID: 3218 RVA: 0x00005174 File Offset: 0x00003374
		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x2A52DB0", Offset = "0x2A513B0", VA = "0x182A52DB0")]
		private static bool SamePosition(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x2A52E00", Offset = "0x2A51400", VA = "0x182A52E00")]
		public static void GenPolylineMesh(Mesh mesh, IList<PolylinePoint> path, bool closed, PolylineJoins joins, bool flattenZ, bool useColors)
		{
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x2A546E0", Offset = "0x2A52CE0", VA = "0x182A546E0")]
		public static void GenPolygonMesh(Mesh mesh, List<Vector2> path, PolygonTriangulation triangulation)
		{
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x2A553A0", Offset = "0x2A539A0", VA = "0x182A553A0")]
		public static void CreateDisc(Mesh mesh, int segmentsPerFullTurn, float radius)
		{
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x2A553E0", Offset = "0x2A539E0", VA = "0x182A553E0")]
		public static void CreateCircleSector(Mesh mesh, int segmentsPerFullTurn, float radius, float angRadiansStart, float angRadiansEnd)
		{
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x2A55430", Offset = "0x2A53A30", VA = "0x182A55430")]
		public static void CreateAnnulus(Mesh mesh, int segmentsPerFullTurn, float radius, float radiusInner)
		{
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x2A55470", Offset = "0x2A53A70", VA = "0x182A55470")]
		public static void CreateAnnulusSector(Mesh mesh, int segmentsPerFullTurn, float radius, float radiusInner, float angRadiansStart, float angRadiansEnd)
		{
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C99")]
		[Address(RVA = "0x2A554C0", Offset = "0x2A53AC0", VA = "0x182A554C0")]
		private static void GenerateDiscMesh(Mesh mesh, int segmentsPerFullTurn, bool hasSector, bool hasInnerRadius, float radius, float radiusInner, float angRadiansStart, float angRadiansEnd)
		{
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0x2A55AF0", Offset = "0x2A540F0", VA = "0x182A55AF0")]
		[CompilerGenerated]
		internal static void <GenPolylineMesh>g__SetUv0|1_0(int id, float x, float y, ref ShapesMeshGen.<>c__DisplayClass1_0 A_3, ref ShapesMeshGen.<>c__DisplayClass1_1 A_4, ref ShapesMeshGen.<>c__DisplayClass1_2 A_5)
		{
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0x2A55C50", Offset = "0x2A54250", VA = "0x182A55C50")]
		[CompilerGenerated]
		internal static void <GenPolylineMesh>g__SetPrevNext|1_1(int atIndex, ref ShapesMeshGen.<>c__DisplayClass1_0 A_1, ref ShapesMeshGen.<>c__DisplayClass1_2 A_2)
		{
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0x2A55CC0", Offset = "0x2A542C0", VA = "0x182A55CC0")]
		[CompilerGenerated]
		internal static void <GenPolylineMesh>g__AddQuad|1_2(int a, int b, int c, int d, ref ShapesMeshGen.<>c__DisplayClass1_0 A_4)
		{
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0x2A55DC0", Offset = "0x2A543C0", VA = "0x182A55DC0")]
		[CompilerGenerated]
		internal static void <GenerateDiscMesh>g__DblTri|10_0(int a, int b, int c, ref ShapesMeshGen.<>c__DisplayClass10_0 A_3)
		{
		}

		// Token: 0x0400037F RID: 895
		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x0")]
		private static bool generatingClockwisePolygon;

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x2000093")]
		private enum ReflexState
		{
			// Token: 0x04000381 RID: 897
			[Token(Token = "0x4000381")]
			Unknown,
			// Token: 0x04000382 RID: 898
			[Token(Token = "0x4000382")]
			Reflex,
			// Token: 0x04000383 RID: 899
			[Token(Token = "0x4000383")]
			Convex
		}

		// Token: 0x02000094 RID: 148
		[Token(Token = "0x2000094")]
		private class EarClipPoint
		{
			// Token: 0x06000C9E RID: 3230 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x2A55EB0", Offset = "0x2A544B0", VA = "0x182A55EB0")]
			public EarClipPoint(int vertIndex, Vector2 pt)
			{
			}

			// Token: 0x06000C9F RID: 3231 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x2A55EC0", Offset = "0x2A544C0", VA = "0x182A55EC0")]
			public void MarkReflexUnknown()
			{
			}

			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x0000518C File Offset: 0x0000338C
			[Token(Token = "0x170001D4")]
			public ShapesMeshGen.ReflexState ReflexState
			{
				[Token(Token = "0x6000CA0")]
				[Address(RVA = "0x2A55ED0", Offset = "0x2A544D0", VA = "0x182A55ED0")]
				get
				{
					return ShapesMeshGen.ReflexState.Unknown;
				}
			}

			// Token: 0x04000384 RID: 900
			[Token(Token = "0x4000384")]
			[FieldOffset(Offset = "0x10")]
			public int vertIndex;

			// Token: 0x04000385 RID: 901
			[Token(Token = "0x4000385")]
			[FieldOffset(Offset = "0x14")]
			public Vector2 pt;

			// Token: 0x04000386 RID: 902
			[Token(Token = "0x4000386")]
			[FieldOffset(Offset = "0x1C")]
			private ShapesMeshGen.ReflexState reflex;

			// Token: 0x04000387 RID: 903
			[Token(Token = "0x4000387")]
			[FieldOffset(Offset = "0x20")]
			public ShapesMeshGen.EarClipPoint prev;

			// Token: 0x04000388 RID: 904
			[Token(Token = "0x4000388")]
			[FieldOffset(Offset = "0x28")]
			public ShapesMeshGen.EarClipPoint next;
		}
	}
}
