using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000316 RID: 790
	[Token(Token = "0x2000316")]
	public interface IAntiAliasing
	{
		// Token: 0x060014AA RID: 5290
		[Token(Token = "0x60014AA")]
		void Awake();

		// Token: 0x060014AB RID: 5291
		[Token(Token = "0x60014AB")]
		void OnEnable(AntiAliasing owner);

		// Token: 0x060014AC RID: 5292
		[Token(Token = "0x60014AC")]
		void OnDisable();

		// Token: 0x060014AD RID: 5293
		[Token(Token = "0x60014AD")]
		void OnPreCull(Camera camera);

		// Token: 0x060014AE RID: 5294
		[Token(Token = "0x60014AE")]
		void OnPostRender(Camera camera);

		// Token: 0x060014AF RID: 5295
		[Token(Token = "0x60014AF")]
		void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination);
	}
}
