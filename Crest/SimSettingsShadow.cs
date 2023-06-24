using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	[CreateAssetMenu(fileName = "SimSettingsShadow", menuName = "Crest/Shadow Sim Settings", order = 10000)]
	public class SimSettingsShadow : SimSettingsBase
	{
		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x9FE490", Offset = "0x9FCA90", VA = "0x1809FE490")]
		public SimSettingsShadow()
		{
		}

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 32f)]
		[Tooltip("Jitter diameter for soft shadows, controls softness of this shadowing component.")]
		public float _jitterDiameterSoft;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		[Tooltip("Current frame weight for accumulation over frames for soft shadows. Roughly means 'responsiveness' for soft shadows.")]
		public float _currentFrameWeightSoft;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Jitter diameter for hard shadows, controls softness of this shadowing component.")]
		[Range(0f, 32f)]
		public float _jitterDiameterHard;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Current frame weight for accumulation over frames for hard shadows. Roughly means 'responsiveness' for hard shadows.")]
		[Range(0f, 1f)]
		public float _currentFrameWeightHard;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Whether to disable the null light warning, use this if you assign it dynamically and expect it to be null at points")]
		public bool _allowNullLight;
	}
}
