using System;
using Il2CppDummyDll;
using Sons.PostProcessing;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Quality.QualitySettings
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[Serializable]
	public class Shadow : QualitySetting
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x3117B60", Offset = "0x3116160", VA = "0x183117B60", Slot = "6")]
		public override void OnValidate()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x3117BC0", Offset = "0x31161C0", VA = "0x183117BC0", Slot = "4")]
		public override void Apply()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x268E470", Offset = "0x268CA70", VA = "0x18268E470", Slot = "5")]
		public override void OnSceneLoaded()
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Shadow()
		{
		}

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PostProcessingQualitySetting<HDShadowSettings> _shadowDay;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ShadowsAdditionalSettings _shadowDayAddSettings;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x30")]
		[Space(8f)]
		[SerializeField]
		private PostProcessingQualitySetting<HDShadowSettings> _shadowTwilight;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ShadowsAdditionalSettings _shadowTwilightAddSettings;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x48")]
		[Space(8f)]
		[SerializeField]
		private PostProcessingQualitySetting<HDShadowSettings> _shadowNight;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ShadowsAdditionalSettings _shadowNightAddSettings;
	}
}
