using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace MTAssets.UltimateLODSystem.MeshSimplifier
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	[Serializable]
	[StructLayout(3)]
	public struct BlendShape
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x5F84C0", Offset = "0x5F6AC0", VA = "0x1805F84C0")]
		public BlendShape(string shapeName, BlendShapeFrame[] frames)
		{
		}

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string ShapeName;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public BlendShapeFrame[] Frames;
	}
}
