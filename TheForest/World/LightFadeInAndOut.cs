using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace TheForest.World
{
	// Token: 0x0200038C RID: 908
	[Token(Token = "0x200038C")]
	public class LightFadeInAndOut : MonoBehaviour
	{
		// Token: 0x060017B9 RID: 6073 RVA: 0x000074A0 File Offset: 0x000056A0
		[Token(Token = "0x60017B9")]
		[Address(RVA = "0x2CB3E10", Offset = "0x2CB2E10", VA = "0x182CB3E10")]
		private float CollectIntensity()
		{
			return default(float);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BA")]
		[Address(RVA = "0x2CB3F50", Offset = "0x2CB2F50", VA = "0x182CB3F50")]
		private void OnEnable()
		{
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x2CB4110", Offset = "0x2CB3110", VA = "0x182CB4110")]
		private void SetIntensity(float targetLightIntensity)
		{
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x2CB3EE0", Offset = "0x2CB2EE0", VA = "0x182CB3EE0")]
		private IEnumerator FadeRoutine()
		{
			return null;
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BD")]
		[Address(RVA = "0x5B6290", Offset = "0x5B5290", VA = "0x1805B6290")]
		public LightFadeInAndOut()
		{
		}

		// Token: 0x040016C6 RID: 5830
		[Token(Token = "0x40016C6")]
		[FieldOffset(Offset = "0x20")]
		public Light _targetLight;

		// Token: 0x040016C7 RID: 5831
		[Token(Token = "0x40016C7")]
		[FieldOffset(Offset = "0x28")]
		public float _fadeInDuration;

		// Token: 0x040016C8 RID: 5832
		[Token(Token = "0x40016C8")]
		[FieldOffset(Offset = "0x2C")]
		public float _fadeOutDuration;

		// Token: 0x040016C9 RID: 5833
		[Token(Token = "0x40016C9")]
		[FieldOffset(Offset = "0x30")]
		private float _startIntensity;

		// Token: 0x040016CA RID: 5834
		[Token(Token = "0x40016CA")]
		[FieldOffset(Offset = "0x38")]
		private HDAdditionalLightData _lightData;
	}
}
