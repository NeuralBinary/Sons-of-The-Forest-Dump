using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000901 RID: 2305
	[Token(Token = "0x2000901")]
	public interface IIkFakeBone
	{
		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06004256 RID: 16982
		[Token(Token = "0x1700085B")]
		Transform TipTransform { [Token(Token = "0x6004256")] get; }

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06004257 RID: 16983
		[Token(Token = "0x1700085C")]
		IkLimbs Limb { [Token(Token = "0x6004257")] get; }
	}
}
