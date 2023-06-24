using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002C5 RID: 709
	[Token(Token = "0x20002C5")]
	public class TriangulatedPolygonGenerator : MeshGenerator
	{
		// Token: 0x060018DE RID: 6366 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x1EEAFD0", Offset = "0x1EE95D0", VA = "0x181EEAFD0", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x1EEB5B0", Offset = "0x1EE9BB0", VA = "0x181EEB5B0")]
		public DMesh3 ComputeResult(out MeshInsertPolygon insertion)
		{
			return null;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x1EEBD80", Offset = "0x1EEA380", VA = "0x181EEBD80")]
		public TriangulatedPolygonGenerator()
		{
		}

		// Token: 0x04000C48 RID: 3144
		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0x40")]
		public GeneralPolygon2d Polygon;

		// Token: 0x04000C49 RID: 3145
		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x48")]
		public Vector3f FixedNormal;

		// Token: 0x04000C4A RID: 3146
		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x54")]
		public TrivialRectGenerator.UVModes UVMode;

		// Token: 0x04000C4B RID: 3147
		[Token(Token = "0x4000C4B")]
		[FieldOffset(Offset = "0x58")]
		public int Subdivisions;
	}
}
