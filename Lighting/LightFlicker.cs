using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Lighting
{
	// Token: 0x02000577 RID: 1399
	[Token(Token = "0x2000577")]
	[AddComponentMenu("Sons/Lighting/LightFlicker")]
	public class LightFlicker : LightFlickerBase
	{
		// Token: 0x06002445 RID: 9285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002445")]
		[Address(RVA = "0x2D83FE0", Offset = "0x2D82FE0", VA = "0x182D83FE0")]
		private void Awake()
		{
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002446")]
		[Address(RVA = "0x2D840A0", Offset = "0x2D830A0", VA = "0x182D840A0", Slot = "4")]
		public override void SetLightIntensity(float intensity)
		{
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002447")]
		[Address(RVA = "0x2D83DB0", Offset = "0x2D82DB0", VA = "0x182D83DB0")]
		public LightFlicker()
		{
		}

		// Token: 0x040020AE RID: 8366
		[Token(Token = "0x40020AE")]
		[FieldOffset(Offset = "0x48")]
		private Light _light;

		// Token: 0x040020AF RID: 8367
		[Token(Token = "0x40020AF")]
		[FieldOffset(Offset = "0x50")]
		private HDAdditionalLightData _lightData;
	}
}
