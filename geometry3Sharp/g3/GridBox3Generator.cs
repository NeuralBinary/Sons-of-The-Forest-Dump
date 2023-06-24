using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002AB RID: 683
	[Token(Token = "0x20002AB")]
	public class GridBox3Generator : MeshGenerator
	{
		// Token: 0x0600188E RID: 6286 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600188E")]
		[Address(RVA = "0x1ED3440", Offset = "0x1ED1A40", VA = "0x181ED3440", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600188F")]
		[Address(RVA = "0x1ED4E70", Offset = "0x1ED3470", VA = "0x181ED4E70")]
		public GridBox3Generator()
		{
		}

		// Token: 0x04000BB8 RID: 3000
		[Token(Token = "0x4000BB8")]
		[FieldOffset(Offset = "0x40")]
		public Box3d Box;

		// Token: 0x04000BB9 RID: 3001
		[Token(Token = "0x4000BB9")]
		[FieldOffset(Offset = "0xB8")]
		public int EdgeVertices;

		// Token: 0x04000BBA RID: 3002
		[Token(Token = "0x4000BBA")]
		[FieldOffset(Offset = "0xBC")]
		public bool NoSharedVertices;
	}
}
