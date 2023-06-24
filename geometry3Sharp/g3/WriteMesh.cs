using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200019B RID: 411
	[Token(Token = "0x200019B")]
	public struct WriteMesh
	{
		// Token: 0x06000B2A RID: 2858 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x200B410", Offset = "0x2009A10", VA = "0x18200B410")]
		public WriteMesh(IMesh mesh, string name = "")
		{
		}

		// Token: 0x0400067B RID: 1659
		[Token(Token = "0x400067B")]
		[FieldOffset(Offset = "0x0")]
		public IMesh Mesh;

		// Token: 0x0400067C RID: 1660
		[Token(Token = "0x400067C")]
		[FieldOffset(Offset = "0x8")]
		public string Name;

		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x10")]
		public List<GenericMaterial> Materials;

		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0x18")]
		public IIndexMap TriToMaterialMap;

		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0x20")]
		public DenseUVMesh UVs;
	}
}
