using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Quality.QualitySettings;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sons.Quality
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[CreateAssetMenu(menuName = "Sons/Quality/Profile", fileName = "QualityProfile")]
	public class QualityProfile : ScriptableObject
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000003")]
		public string Id
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x3116E70", Offset = "0x3115470", VA = "0x183116E70")]
		private void OnValidate()
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x31170F0", Offset = "0x31156F0", VA = "0x1831170F0")]
		public void Apply()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x3117240", Offset = "0x3115840", VA = "0x183117240")]
		private List<QualitySetting> GetAllSettings()
		{
			return null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x3117440", Offset = "0x3115A40", VA = "0x183117440")]
		public void CloneSettings(QualityProfile activeProfile)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		public void Override<T>(QualityProfile profile) where T : QualitySetting
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x31175D0", Offset = "0x3115BD0", VA = "0x1831175D0")]
		public bool Matches(QualityProfile newProfile)
		{
			return default(bool);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x3117720", Offset = "0x3115D20", VA = "0x183117720")]
		public void OnSceneLoaded(Scene sceneLoaded, LoadSceneMode mode)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x3117870", Offset = "0x3115E70", VA = "0x183117870")]
		public static bool MatchesId(string idA, string idB)
		{
			return default(bool);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x3117930", Offset = "0x3115F30", VA = "0x183117930")]
		public QualityProfile()
		{
		}

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		public const string OffId = "Off";

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		public const string CustomId = "Custom";

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		public const string UltraId = "Ultra";

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		public const string HighId = "High";

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		public const string MediumId = "Medium";

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		public const string LowId = "Low";

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		public const string UltraLowId = "Ultra Low";

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _id;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AmbientOcclusion _ambientOcclusion;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Shadow _shadow;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Fog _fog;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DrawDistance _drawDistance;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x40")]
		private List<QualitySetting> _cachedAllSettings;
	}
}
