using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x020008FF RID: 2303
	[Token(Token = "0x20008FF")]
	public interface IIkHeldRenderer : IMonoBehaviour
	{
		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06004251 RID: 16977
		[Token(Token = "0x17000857")]
		IkLimbs Limb { [Token(Token = "0x6004251")] get; }

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06004252 RID: 16978
		[Token(Token = "0x17000858")]
		Vector3 InitialLocalPosition { [Token(Token = "0x6004252")] get; }

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06004253 RID: 16979
		[Token(Token = "0x17000859")]
		Quaternion InitialLocalRotation { [Token(Token = "0x6004253")] get; }

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06004254 RID: 16980
		[Token(Token = "0x1700085A")]
		Vector3 InitialLocalScale { [Token(Token = "0x6004254")] get; }
	}
}
