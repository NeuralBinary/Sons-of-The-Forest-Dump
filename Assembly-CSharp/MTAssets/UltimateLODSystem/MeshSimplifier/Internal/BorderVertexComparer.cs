using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace MTAssets.UltimateLODSystem.MeshSimplifier.Internal
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	internal class BorderVertexComparer : IComparer<BorderVertex>
	{
		// Token: 0x0600023E RID: 574 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x60DE90", Offset = "0x60C490", VA = "0x18060DE90", Slot = "4")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int Compare(BorderVertex x, BorderVertex y)
		{
			return 0;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BorderVertexComparer()
		{
		}

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BorderVertexComparer instance;
	}
}
