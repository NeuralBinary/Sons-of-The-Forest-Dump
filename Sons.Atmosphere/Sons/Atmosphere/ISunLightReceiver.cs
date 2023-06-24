using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Atmosphere
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public interface ISunLightReceiver
	{
		// Token: 0x0600016D RID: 365
		[Token(Token = "0x600016D")]
		void UpdateSunLight(GameObject sunlightGameObject, Light sunLight, HDAdditionalLightData lightData);
	}
}
