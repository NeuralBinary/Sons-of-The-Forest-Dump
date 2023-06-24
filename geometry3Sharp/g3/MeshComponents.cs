using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200021B RID: 539
	[Token(Token = "0x200021B")]
	[Flags]
	public enum MeshComponents
	{
		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x40008C6")]
		None = 0,
		// Token: 0x040008C7 RID: 2247
		[Token(Token = "0x40008C7")]
		VertexNormals = 1,
		// Token: 0x040008C8 RID: 2248
		[Token(Token = "0x40008C8")]
		VertexColors = 2,
		// Token: 0x040008C9 RID: 2249
		[Token(Token = "0x40008C9")]
		VertexUVs = 4,
		// Token: 0x040008CA RID: 2250
		[Token(Token = "0x40008CA")]
		FaceGroups = 8,
		// Token: 0x040008CB RID: 2251
		[Token(Token = "0x40008CB")]
		All = 15
	}
}
