using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002DA RID: 730
	[Token(Token = "0x20002DA")]
	public class MeshInsertPolygon
	{
		// Token: 0x06001930 RID: 6448 RVA: 0x00012734 File Offset: 0x00010934
		[Token(Token = "0x6001930")]
		[Address(RVA = "0x1EFC470", Offset = "0x1EFAA70", VA = "0x181EFC470")]
		public bool Insert()
		{
			return default(bool);
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001931")]
		[Address(RVA = "0x1EA3300", Offset = "0x1EA1900", VA = "0x181EA3300")]
		public MeshInsertPolygon()
		{
		}

		// Token: 0x04000CDE RID: 3294
		[Token(Token = "0x4000CDE")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000CDF RID: 3295
		[Token(Token = "0x4000CDF")]
		[FieldOffset(Offset = "0x18")]
		public GeneralPolygon2d Polygon;

		// Token: 0x04000CE0 RID: 3296
		[Token(Token = "0x4000CE0")]
		[FieldOffset(Offset = "0x20")]
		public bool SimplifyInsertion;

		// Token: 0x04000CE1 RID: 3297
		[Token(Token = "0x4000CE1")]
		[FieldOffset(Offset = "0x28")]
		public MeshInsertUVPolyCurve OuterInsert;

		// Token: 0x04000CE2 RID: 3298
		[Token(Token = "0x4000CE2")]
		[FieldOffset(Offset = "0x30")]
		public List<MeshInsertUVPolyCurve> HoleInserts;

		// Token: 0x04000CE3 RID: 3299
		[Token(Token = "0x4000CE3")]
		[FieldOffset(Offset = "0x38")]
		public HashSet<int> InsertedPolygonEdges;

		// Token: 0x04000CE4 RID: 3300
		[Token(Token = "0x4000CE4")]
		[FieldOffset(Offset = "0x40")]
		public MeshFaceSelection InteriorTriangles;
	}
}
