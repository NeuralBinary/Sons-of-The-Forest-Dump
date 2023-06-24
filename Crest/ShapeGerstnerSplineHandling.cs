using System;
using Crest.Spline;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	public static class ShapeGerstnerSplineHandling
	{
		// Token: 0x060002C0 RID: 704 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xA16B10", Offset = "0xA15110", VA = "0x180A16B10")]
		public static bool GenerateMeshFromSpline(Spline spline, Transform transform, int subdivisions, float radius, int smoothingIterations, Vector2 customDataDefault, ref Mesh mesh)
		{
			return default(bool);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x60002C1")]
		public static bool GenerateMeshFromSpline<SplinePointCustomData>(Spline spline, Transform transform, int subdivisions, float radius, int smoothingIterations, Vector2 customDataDefault, ref Mesh mesh) where SplinePointCustomData : ISplinePointCustomData
		{
			return default(bool);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xA16B80", Offset = "0xA15180", VA = "0x180A16B80")]
		private static bool UpdateMesh(Transform transform, Vector3[] sampledPtsOnSpline, Vector3[] sampledPtsOffSpline, Vector2[] customData, bool closed, ref Mesh mesh)
		{
			return default(bool);
		}
	}
}
