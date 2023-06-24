using System;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public class MeshInsertProjectedPolygon
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1E02EE0", Offset = "0x1E014E0", VA = "0x181E02EE0")]
		public MeshInsertProjectedPolygon(DMesh3 mesh, Polygon2d poly, Frame3f frame, int seedTri)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1E03040", Offset = "0x1E01640", VA = "0x181E03040")]
		public MeshInsertProjectedPolygon(DMesh3 mesh, DCurve3 polygon3, Frame3f frame, int seedTri)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1E03510", Offset = "0x1E01B10", VA = "0x181E03510", Slot = "4")]
		public virtual ValidationStatus Validate()
		{
			return ValidationStatus.Ok;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1E03550", Offset = "0x1E01B50", VA = "0x181E03550")]
		public bool Insert()
		{
			return default(bool);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1E045F0", Offset = "0x1E02BF0", VA = "0x181E045F0", Slot = "5")]
		protected virtual bool BackPropagate(RegionOperator regionOp, int[] insertedPolyVerts, EdgeLoop insertedLoop)
		{
			return default(bool);
		}

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x18")]
		public int SeedTriangle;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x1C")]
		public Frame3f ProjectFrame;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x38")]
		public bool SimplifyInsertion;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x39")]
		public bool RemovePolygonInterior;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x40")]
		public RegionOperator ModifiedRegion;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x48")]
		public int[] InsertedPolygonVerts;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x50")]
		public EdgeLoop InsertedLoop;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x58")]
		public int[] InteriorTriangles;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x60")]
		public Polygon2d Polygon;
	}
}
