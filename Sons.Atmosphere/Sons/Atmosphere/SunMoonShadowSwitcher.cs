using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Atmosphere
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public class SunMoonShadowSwitcher : MonoBehaviour
	{
		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2D4DAA0", Offset = "0x2D4C0A0", VA = "0x182D4DAA0")]
		private void Update()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2D4E0E0", Offset = "0x2D4C6E0", VA = "0x182D4E0E0")]
		private void UpdateSunLightManager()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2D4E300", Offset = "0x2D4C900", VA = "0x182D4E300")]
		private void FadeLight(AnimationCurve curve, float angle, HDAdditionalLightData hdAdditionalLightData, float baseIntensity, out float dimmer)
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2D4E400", Offset = "0x2D4CA00", VA = "0x182D4E400")]
		private void FadeLight(float start, float end, float angle, HDAdditionalLightData hdAdditionalLightData, float baseIntensity, out float dimmer)
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2D4E4D0", Offset = "0x2D4CAD0", VA = "0x182D4E4D0")]
		private void FadeLightShadows(float start, float end, float angle, HDAdditionalLightData hdAdditionalLightData, bool blockShadows, ref bool enabledShadows, ref float dimmer)
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SunMoonShadowSwitcher()
		{
		}

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Light _sunLight;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve _sunFadeCurve;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _sunLightShadowStartFade;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _sunLightShadowEndFade;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _sunLightStartFade;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _sunLightEndFade;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x40")]
		private bool _sunLightShadows;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Light _moonLight;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _moonLightShadowStartFade;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _moonLightShadowEndFade;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _disableSunIntensityFade;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _moonLightStartFade;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _moonLightEndFade;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x64")]
		private bool _moonLightShadows;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x68")]
		private Quaternion _sunRotation;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x78")]
		private float _sunLightBaseIntensity;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x7C")]
		private float _sunAngle;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x80")]
		private float _sunLightDimmer;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x84")]
		private float _sunShadowDimmer;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x88")]
		private HDAdditionalLightData _sunLightHdData;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x90")]
		private HDAdditionalLightData _moonLightHdData;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x98")]
		private float _moonAngle;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x9C")]
		private float _moonLightDimmer;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0xA0")]
		private float _moonShadowDimmer;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0xA4")]
		private float _moonLightBaseIntensity;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0xA8")]
		private float _finalSunIntensity;
	}
}
