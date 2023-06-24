using System;
using System.Collections.Generic;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Settings
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[AddComponentMenu("Sons/Settings/AudioSettings")]
	public class AudioSettings : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		public static float MasterVolumeSettingDefault
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x268EE60", Offset = "0x268D460", VA = "0x18268EE60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x17000002")]
		public static float MusicVolumeSettingDefault
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x268EE60", Offset = "0x268D460", VA = "0x18268EE60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x17000003")]
		public static float SfxVolumeSettingDefault
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x268EE60", Offset = "0x268D460", VA = "0x18268EE60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x17000004")]
		public static float VoiceVolumeSettingDefault
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2F145B0", Offset = "0x2F12BB0", VA = "0x182F145B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x17000005")]
		public static string VoiceCountSettingDefault
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x31364A0", Offset = "0x3134AA0", VA = "0x1831364A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x17000006")]
		public static string DynamicRangeProfileSettingDefault
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x31364D0", Offset = "0x3134AD0", VA = "0x1831364D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x17000007")]
		public static List<string> VoiceCountOptions
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x3136500", Offset = "0x3134B00", VA = "0x183136500")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x31365F0", Offset = "0x3134BF0", VA = "0x1831365F0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x31368F0", Offset = "0x3134EF0", VA = "0x1831368F0")]
		private void VoiceVolumeChanged(float newValue)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x3136A20", Offset = "0x3135020", VA = "0x183136A20")]
		private void OnSfxVolumeChanged(float newValue)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x3136B10", Offset = "0x3135110", VA = "0x183136B10")]
		private void OnMusicVolumeChanged(float newValue)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3136C00", Offset = "0x3135200", VA = "0x183136C00")]
		private void OnMasterVolumeChanged(float newValue)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x3136D30", Offset = "0x3135330", VA = "0x183136D30")]
		private void VoiceCountChanged(string stringValue)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x31370F0", Offset = "0x31356F0", VA = "0x1831370F0")]
		private static void RefreshMusicVolume()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x31371D0", Offset = "0x31357D0", VA = "0x1831371D0")]
		private static void RefreshSfxVolume()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x31372B0", Offset = "0x31358B0", VA = "0x1831372B0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x3137350", Offset = "0x3135950", VA = "0x183137350")]
		private void DynamicRangeChanged(string newValue)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x3137450", Offset = "0x3135A50", VA = "0x183137450")]
		private void StartDynamicRangeSnapshot(string eventPath)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x31377D0", Offset = "0x3135DD0", VA = "0x1831377D0")]
		private bool TryGetEventDescription(string eventPath, ref EventDescription eventDescription)
		{
			return default(bool);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x3137950", Offset = "0x3135F50", VA = "0x183137950")]
		private void ClearDynamicRangeSnapshot()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3137990", Offset = "0x3135F90", VA = "0x183137990")]
		private static void SetMasterVolume(float newValue)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3137A00", Offset = "0x3136000", VA = "0x183137A00")]
		private static void SetMusicVolume(float newValue)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3137A70", Offset = "0x3136070", VA = "0x183137A70")]
		private static void SetSfxVolume(float newValue)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x3137AE0", Offset = "0x31360E0", VA = "0x183137AE0")]
		private static void SetVoiceVolume(float newValue)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x3137B50", Offset = "0x3136150", VA = "0x183137B50")]
		private static void RefreshVolumes()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3137CC0", Offset = "0x31362C0", VA = "0x183137CC0")]
		public static float InvertLogarithmicScale(float x)
		{
			return 0f;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3137CF0", Offset = "0x31362F0", VA = "0x183137CF0")]
		private static void ApplyVoiceVolume(float voiceVolume)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3137D90", Offset = "0x3136390", VA = "0x183137D90")]
		private static void ApplySfxVolume(float newValue)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x3138010", Offset = "0x3136610", VA = "0x183138010")]
		public static void OverrideMusicSourceVolume(Func<float> action)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x31380C0", Offset = "0x31366C0", VA = "0x1831380C0")]
		private static void ApplyMusicVolume(float newValue)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x3138390", Offset = "0x3136990", VA = "0x183138390")]
		private static void SetVcaVolume(string targetPath, float volume)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x3138590", Offset = "0x3136B90", VA = "0x183138590")]
		private static void SetBusVolume(string targetPath, float volume)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3138790", Offset = "0x3136D90", VA = "0x183138790")]
		public AudioSettings()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		public const string MusicVolumeSettingKey = "Audio.MusicVolume";

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		public const string MasterVolumeSettingKey = "Audio.MasterVolume";

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		public const string VoiceVolumeSettingKey = "Audio.VoiceVolume";

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		public const string VoiceCountSettingKey = "Audio.VoiceCount";

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		public const string SfxVolumeSettingKey = "Audio.SfxVolume";

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		public const string DynamicRangeProfileSettingKey = "Audio.DynamicRangeProfile";

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<object> _registeredActionPairs;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x0")]
		private static Action _refreshMusicVolumeAction;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x8")]
		private static Action _refreshSfxVolumeAction;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x10")]
		private static float _masterVolume;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x14")]
		private static float _sfxVolume;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x18")]
		private static float _musicVolume;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x1C")]
		private static float _voiceVolume;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x20")]
		private static Func<float> _overrideMusicAction;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, EventDescription> _dynamicRangeEventDict;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x30")]
		private EventInstance _dynamicRangeSnapshotInstance;
	}
}
