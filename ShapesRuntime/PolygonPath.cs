using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	public class PolygonPath : PointPath<Vector2>
	{
		// Token: 0x06000B20 RID: 2848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x2A3F470", Offset = "0x2A3DA70", VA = "0x182A3F470")]
		public PolygonPath()
		{
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x2A3F560", Offset = "0x2A3DB60", VA = "0x182A3F560")]
		public void AddPoint(float x, float y)
		{
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x2A3F600", Offset = "0x2A3DC00", VA = "0x182A3F600")]
		public void BezierTo(Vector2 startTangent, Vector2 endTangent, Vector2 end, int pointCount)
		{
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x2A3F740", Offset = "0x2A3DD40", VA = "0x182A3F740")]
		public void BezierTo(Vector2 startTangent, Vector2 endTangent, Vector2 end, float pointsPerTurn)
		{
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x2A3FA60", Offset = "0x2A3E060", VA = "0x182A3FA60")]
		public void ArcTo(Vector2 corner, Vector2 next, float radius, float pointsPerTurn)
		{
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x2A3FB10", Offset = "0x2A3E110", VA = "0x182A3FB10")]
		public void ArcTo(Vector2 corner, Vector2 next, float radius, int pointCount)
		{
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x2A3FBC0", Offset = "0x2A3E1C0", VA = "0x182A3FBC0")]
		public void ArcTo(Vector2 corner, Vector2 next, float radius)
		{
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x2A3FC80", Offset = "0x2A3E280", VA = "0x182A3FC80")]
		public void ArcTo(Vector2 corner, Vector2 next, float radius, float pointsPerTurn, Color color)
		{
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x2A3FD30", Offset = "0x2A3E330", VA = "0x182A3FD30")]
		private void AddArcPoints(Vector2 corner, Vector2 next, float radius, bool useDensity, int targetPointCount, float pointsPerTurn)
		{
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0000458C File Offset: 0x0000278C
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x2A40080", Offset = "0x2A3E680", VA = "0x182A40080")]
		public bool EnsureMeshIsReadyToRender(PolygonTriangulation triangulation, out Mesh outMesh)
		{
			return default(bool);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x2A401A0", Offset = "0x2A3E7A0", VA = "0x182A401A0")]
		private void TryUpdateMesh(PolygonTriangulation triangulation)
		{
		}

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x30")]
		private PolygonTriangulation lastUsedTriangulationMode;
	}
}
