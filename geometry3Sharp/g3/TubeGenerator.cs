using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002B3 RID: 691
	[Token(Token = "0x20002B3")]
	public class TubeGenerator : MeshGenerator
	{
		// Token: 0x0600189E RID: 6302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600189E")]
		[Address(RVA = "0x1EDBA50", Offset = "0x1EDA050", VA = "0x181EDBA50")]
		public TubeGenerator()
		{
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600189F")]
		[Address(RVA = "0x1EDBB20", Offset = "0x1EDA120", VA = "0x181EDBB20")]
		public TubeGenerator(Polygon2d tubePath, Frame3f pathPlane, Polygon2d tubeShape, int nPlaneNormal = 2)
		{
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x1EDC0A0", Offset = "0x1EDA6A0", VA = "0x181EDC0A0")]
		public TubeGenerator(PolyLine2d tubePath, Frame3f pathPlane, Polygon2d tubeShape, int nPlaneNormal = 2)
		{
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x1EDC620", Offset = "0x1EDAC20", VA = "0x181EDC620")]
		public TubeGenerator(DCurve3 tubePath, Polygon2d tubeShape)
		{
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x1EDC840", Offset = "0x1EDAE40", VA = "0x181EDC840", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x04000BE3 RID: 3043
		[Token(Token = "0x4000BE3")]
		[FieldOffset(Offset = "0x40")]
		public List<Vector3d> Vertices;

		// Token: 0x04000BE4 RID: 3044
		[Token(Token = "0x4000BE4")]
		[FieldOffset(Offset = "0x48")]
		public Polygon2d Polygon;

		// Token: 0x04000BE5 RID: 3045
		[Token(Token = "0x4000BE5")]
		[FieldOffset(Offset = "0x50")]
		public bool Capped;

		// Token: 0x04000BE6 RID: 3046
		[Token(Token = "0x4000BE6")]
		[FieldOffset(Offset = "0x51")]
		public bool OverrideCapCenter;

		// Token: 0x04000BE7 RID: 3047
		[Token(Token = "0x4000BE7")]
		[FieldOffset(Offset = "0x58")]
		public Vector2d CapCenter;

		// Token: 0x04000BE8 RID: 3048
		[Token(Token = "0x4000BE8")]
		[FieldOffset(Offset = "0x68")]
		public bool ClosedLoop;

		// Token: 0x04000BE9 RID: 3049
		[Token(Token = "0x4000BE9")]
		[FieldOffset(Offset = "0x6C")]
		public Frame3f Frame;

		// Token: 0x04000BEA RID: 3050
		[Token(Token = "0x4000BEA")]
		[FieldOffset(Offset = "0x88")]
		public bool NoSharedVertices;

		// Token: 0x04000BEB RID: 3051
		[Token(Token = "0x4000BEB")]
		[FieldOffset(Offset = "0x8C")]
		public int startCapCenterIndex;

		// Token: 0x04000BEC RID: 3052
		[Token(Token = "0x4000BEC")]
		[FieldOffset(Offset = "0x90")]
		public int endCapCenterIndex;
	}
}
