using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public struct LightningBoltSegment
	{
		// Token: 0x06000065 RID: 101 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000065")]
		[Address(RVA = "0xA30840", Offset = "0xA2EE40", VA = "0x180A30840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 Start;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 End;
	}
}
