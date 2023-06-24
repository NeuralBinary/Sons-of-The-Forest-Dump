using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000275 RID: 629
	[Token(Token = "0x2000275")]
	public class DenseUVMesh
	{
		// Token: 0x0600164B RID: 5707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600164B")]
		[Address(RVA = "0x1EAAEB0", Offset = "0x1EA94B0", VA = "0x181EAAEB0")]
		public DenseUVMesh()
		{
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00010F94 File Offset: 0x0000F194
		[Token(Token = "0x600164C")]
		[Address(RVA = "0x1EAB130", Offset = "0x1EA9730", VA = "0x181EAB130")]
		public int AppendUV(Vector2f uv)
		{
			return 0;
		}

		// Token: 0x04000A67 RID: 2663
		[Token(Token = "0x4000A67")]
		[FieldOffset(Offset = "0x10")]
		public DVector<Vector2f> UVs;

		// Token: 0x04000A68 RID: 2664
		[Token(Token = "0x4000A68")]
		[FieldOffset(Offset = "0x18")]
		public DVector<Index3i> TriangleUVs;
	}
}
