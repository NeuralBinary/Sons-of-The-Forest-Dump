using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace Sons.Quality
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[AddComponentMenu("Sons/Quality/Quality Manager")]
	public class QualityManager : SingletonBehaviour<QualityManager>
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x3115840", Offset = "0x3113E40", VA = "0x183115840")]
		public static bool IsOnValue(string newValue)
		{
			return default(bool);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x3115930", Offset = "0x3113F30", VA = "0x183115930")]
		public static bool IsOffValue(string newValue)
		{
			return default(bool);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020C8 File Offset: 0x000002C8
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3115A20", Offset = "0x3114020", VA = "0x183115A20")]
		public static bool IsLowValue(string newValue)
		{
			return default(bool);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020E0 File Offset: 0x000002E0
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x3115B10", Offset = "0x3114110", VA = "0x183115B10")]
		public static bool IsMediumValue(string newValue)
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020F8 File Offset: 0x000002F8
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x3115C00", Offset = "0x3114200", VA = "0x183115C00")]
		public static bool IsHighValue(string newValue)
		{
			return default(bool);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000001")]
		public static string CurrentProfileId
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x3115CF0", Offset = "0x31142F0", VA = "0x183115CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x17000002")]
		public static bool IsCustomProfile
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x3115D30", Offset = "0x3114330", VA = "0x183115D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x3115DA0", Offset = "0x31143A0", VA = "0x183115DA0")]
		private static bool MatchesCustomProfile(string profileId)
		{
			return default(bool);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x3115DE0", Offset = "0x31143E0", VA = "0x183115DE0")]
		public static bool MatchesOption(string profileId, string option)
		{
			return default(bool);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		public static event Action<QualityProfile> OnActiveProfileChanged
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x3115EB0", Offset = "0x31144B0", VA = "0x183115EB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x3116040", Offset = "0x3114640", VA = "0x183116040")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3051500", Offset = "0x304FB00", VA = "0x183051500")]
		public static List<string> GetProfileIds()
		{
			return null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x30516C0", Offset = "0x304FCC0", VA = "0x1830516C0")]
		public static List<string> GetProfileIdsWithCustom()
		{
			return null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x31161D0", Offset = "0x31147D0", VA = "0x1831161D0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x3116320", Offset = "0x3114920", VA = "0x183116320")]
		private void OnDisable()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x31163B0", Offset = "0x31149B0", VA = "0x1831163B0")]
		private void OnSceneLoaded(Scene sceneLoaded, LoadSceneMode mode)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		public static void ApplyCustom<T>(string profileId) where T : QualitySetting
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		private static void ApplyCustom<T>(QualityProfile profile) where T : QualitySetting
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3116410", Offset = "0x3114A10", VA = "0x183116410")]
		private static QualityProfile EvaluateCustomProfile(QualityProfile newProfile)
		{
			return null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x3116700", Offset = "0x3114D00", VA = "0x183116700")]
		public static void Apply(string profileId)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x3116800", Offset = "0x3114E00", VA = "0x183116800")]
		private static QualityProfile FindProfile(string profileId)
		{
			return null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x3116AC0", Offset = "0x31150C0", VA = "0x183116AC0")]
		public static void Apply(QualityProfile targetProfile)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000022")]
		public static T GetVolumeComponent<T>() where T : VolumeComponent
		{
			return null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3116D40", Offset = "0x3115340", VA = "0x183116D40")]
		public QualityManager()
		{
		}

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		public const string HighOption = "HIGH";

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		public const string MediumOption = "MEDIUM";

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		public const string LowOption = "LOW";

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		public const string OnOption = "ON";

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		public const string OffOption = "OFF";

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		public const string DefaultId = "High";

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<QualityProfile> _staticProfilesAssets;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _defaultProfileId;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _setProfile;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x0")]
		private static string _currentProfileId;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x40")]
		private string _currentProfileIdReadout;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x8")]
		private static List<QualityProfile> _staticProfiles;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x10")]
		private static QualityProfile _activeProfile;
	}
}
