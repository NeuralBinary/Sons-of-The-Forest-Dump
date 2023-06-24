using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Lighting
{
	// Token: 0x02000587 RID: 1415
	[Token(Token = "0x2000587")]
	[AddComponentMenu("Sons/Lighting/LightFlicker")]
	public class LightFlicker : LightFlickerBase
	{
		// Token: 0x06002544 RID: 9540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002544")]
		[Address(RVA = "0x339AD30", Offset = "0x3399330", VA = "0x18339AD30")]
		private void Awake()
		{
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002545")]
		[Address(RVA = "0x339AF20", Offset = "0x3399520", VA = "0x18339AF20", Slot = "4")]
		public override void SetLightIntensity(float intensity)
		{
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002546")]
		[Address(RVA = "0x339B030", Offset = "0x3399630", VA = "0x18339B030")]
		public LightFlicker()
		{
		}

		// Token: 0x04002182 RID: 8578
		[Token(Token = "0x4002182")]
		[FieldOffset(Offset = "0x48")]
		private Light _light;

		// Token: 0x04002183 RID: 8579
		[Token(Token = "0x4002183")]
		[FieldOffset(Offset = "0x50")]
		private HDAdditionalLightData _lightData;
	}
}
