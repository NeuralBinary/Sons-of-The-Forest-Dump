using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	internal static class IMMaterialPool
	{
		// Token: 0x06000A92 RID: 2706 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x2A396D0", Offset = "0x2A37CD0", VA = "0x182A396D0")]
		internal static Material GetMaterial(ref RenderState state)
		{
			return null;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x2A398E0", Offset = "0x2A37EE0", VA = "0x182A398E0")]
		private static void FlushAllMaterials()
		{
		}

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<RenderState, Material> pool;
	}
}
