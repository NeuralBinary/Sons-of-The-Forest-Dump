using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace MTAssets.UltimateLODSystem.MeshSimplifier.Internal
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	internal struct BorderVertex
	{
		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x60DE80", Offset = "0x60C480", VA = "0x18060DE80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public BorderVertex(int index, int hash)
		{
		}

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x4")]
		public int hash;
	}
}
