using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x0200088D RID: 2189
	[Token(Token = "0x200088D")]
	public interface IIkHeldRenderer : IMonoBehaviour
	{
		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06003B25 RID: 15141
		[Token(Token = "0x17000732")]
		IkLimbs Limb
		{
			[Token(Token = "0x6003B25")]
			get;
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06003B26 RID: 15142
		[Token(Token = "0x17000733")]
		Vector3 InitialLocalPosition
		{
			[Token(Token = "0x6003B26")]
			get;
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06003B27 RID: 15143
		[Token(Token = "0x17000734")]
		Quaternion InitialLocalRotation
		{
			[Token(Token = "0x6003B27")]
			get;
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06003B28 RID: 15144
		[Token(Token = "0x17000735")]
		Vector3 InitialLocalScale
		{
			[Token(Token = "0x6003B28")]
			get;
		}
	}
}
