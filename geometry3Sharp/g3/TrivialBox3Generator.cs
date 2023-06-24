using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002AA RID: 682
	[Token(Token = "0x20002AA")]
	public class TrivialBox3Generator : MeshGenerator
	{
		// Token: 0x0600188C RID: 6284 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600188C")]
		[Address(RVA = "0x1ED2640", Offset = "0x1ED0C40", VA = "0x181ED2640", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600188D")]
		[Address(RVA = "0x1ED3360", Offset = "0x1ED1960", VA = "0x181ED3360")]
		public TrivialBox3Generator()
		{
		}

		// Token: 0x04000BB6 RID: 2998
		[Token(Token = "0x4000BB6")]
		[FieldOffset(Offset = "0x40")]
		public Box3d Box;

		// Token: 0x04000BB7 RID: 2999
		[Token(Token = "0x4000BB7")]
		[FieldOffset(Offset = "0xB8")]
		public bool NoSharedVertices;
	}
}
