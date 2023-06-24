using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace TheForest.World
{
	// Token: 0x0200037E RID: 894
	[Token(Token = "0x200037E")]
	public class LightFadeInAndOut : MonoBehaviour
	{
		// Token: 0x060017F4 RID: 6132 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x60017F4")]
		[Address(RVA = "0x3277200", Offset = "0x3275800", VA = "0x183277200")]
		private float CollectIntensity()
		{
			return 0f;
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F5")]
		[Address(RVA = "0x32773C0", Offset = "0x32759C0", VA = "0x1832773C0")]
		private void OnEnable()
		{
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F6")]
		[Address(RVA = "0x3277630", Offset = "0x3275C30", VA = "0x183277630")]
		private void SetIntensity(float targetLightIntensity)
		{
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F7")]
		[Address(RVA = "0x32777E0", Offset = "0x3275DE0", VA = "0x1832777E0")]
		private IEnumerator FadeRoutine()
		{
			return null;
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F8")]
		[Address(RVA = "0x64C640", Offset = "0x64AC40", VA = "0x18064C640")]
		public LightFadeInAndOut()
		{
		}

		// Token: 0x040016E5 RID: 5861
		[Token(Token = "0x40016E5")]
		[FieldOffset(Offset = "0x20")]
		public Light _targetLight;

		// Token: 0x040016E6 RID: 5862
		[Token(Token = "0x40016E6")]
		[FieldOffset(Offset = "0x28")]
		public float _fadeInDuration;

		// Token: 0x040016E7 RID: 5863
		[Token(Token = "0x40016E7")]
		[FieldOffset(Offset = "0x2C")]
		public float _fadeOutDuration;

		// Token: 0x040016E8 RID: 5864
		[Token(Token = "0x40016E8")]
		[FieldOffset(Offset = "0x30")]
		private float _startIntensity;

		// Token: 0x040016E9 RID: 5865
		[Token(Token = "0x40016E9")]
		[FieldOffset(Offset = "0x38")]
		private HDAdditionalLightData _lightData;
	}
}
