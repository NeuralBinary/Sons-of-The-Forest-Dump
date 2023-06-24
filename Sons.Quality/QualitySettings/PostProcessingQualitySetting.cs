using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons.Quality.QualitySettings
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[Serializable]
	public class PostProcessingQualitySetting<T> : QualitySetting where T : VolumeComponent
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		public override void OnValidate()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600003B")]
		public T GetSettings()
		{
			return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		public override void OnSceneLoaded()
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		public override void Apply()
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		public PostProcessingQualitySetting()
		{
		}

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private VolumeProfile _sourceProfile;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T _settings;
	}
}
