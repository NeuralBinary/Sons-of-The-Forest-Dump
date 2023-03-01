using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x0200088F RID: 2191
	[Token(Token = "0x200088F")]
	public interface IIkFakeBone
	{
		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06003B2A RID: 15146
		[Token(Token = "0x17000736")]
		Transform TipTransform
		{
			[Token(Token = "0x6003B2A")]
			get;
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06003B2B RID: 15147
		[Token(Token = "0x17000737")]
		IkLimbs Limb
		{
			[Token(Token = "0x6003B2B")]
			get;
		}
	}
}
