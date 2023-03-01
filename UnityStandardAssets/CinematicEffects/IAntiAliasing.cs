using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000324 RID: 804
	[Token(Token = "0x2000324")]
	public interface IAntiAliasing
	{
		// Token: 0x0600147F RID: 5247
		[Token(Token = "0x600147F")]
		void Awake();

		// Token: 0x06001480 RID: 5248
		[Token(Token = "0x6001480")]
		void OnEnable(AntiAliasing owner);

		// Token: 0x06001481 RID: 5249
		[Token(Token = "0x6001481")]
		void OnDisable();

		// Token: 0x06001482 RID: 5250
		[Token(Token = "0x6001482")]
		void OnPreCull(Camera camera);

		// Token: 0x06001483 RID: 5251
		[Token(Token = "0x6001483")]
		void OnPostRender(Camera camera);

		// Token: 0x06001484 RID: 5252
		[Token(Token = "0x6001484")]
		void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination);
	}
}
