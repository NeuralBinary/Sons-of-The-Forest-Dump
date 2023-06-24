using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace SonsLOD
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	public struct SonsRangeKey : IEquatable<SonsRangeKey>
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "4")]
		public bool Equals(SonsRangeKey other)
		{
			return default(bool);
		}

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x0")]
		public ShadowCastingMode shadows;
	}
}
