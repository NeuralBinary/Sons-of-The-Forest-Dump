using System;
using System.Collections.Generic;
using FMOD;
using Il2CppDummyDll;
using UnityEngine;

namespace FMODUnity
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x2000105")]
	public class Settings : ScriptableObject
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x1700000E")]
		public static Settings Instance
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0xB51DC0", Offset = "0xB503C0", VA = "0x180B51DC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x0000210E File Offset: 0x0000030E
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000F")]
		public string SourceProjectPath
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x0000210E File Offset: 0x0000030E
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000010")]
		public string SourceBankPath
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			set
			{
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00005EF4 File Offset: 0x000040F4
		[Token(Token = "0x600068F")]
		[Address(RVA = "0xB520F0", Offset = "0xB506F0", VA = "0x180B520F0")]
		public static FMODPlatform GetParent(FMODPlatform platform)
		{
			return FMODPlatform.None;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00005F0C File Offset: 0x0000410C
		[Token(Token = "0x6000690")]
		public static bool HasSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
			return default(bool);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000691")]
		public static U GetSetting<T, U>(List<T> list, FMODPlatform platform, U def) where T : PlatformSetting<U>
		{
			return null;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000692")]
		public static void SetSetting<T, U>(List<T> list, FMODPlatform platform, U value) where T : PlatformSetting<U>, new()
		{
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000693")]
		public static void RemoveSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00005F24 File Offset: 0x00004124
		[Token(Token = "0x6000694")]
		[Address(RVA = "0xB52160", Offset = "0xB50760", VA = "0x180B52160")]
		public bool IsLiveUpdateEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00005F3C File Offset: 0x0000413C
		[Token(Token = "0x6000695")]
		[Address(RVA = "0xB521C0", Offset = "0xB507C0", VA = "0x180B521C0")]
		public bool IsOverlayEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00005F54 File Offset: 0x00004154
		[Token(Token = "0x6000696")]
		[Address(RVA = "0xB52220", Offset = "0xB50820", VA = "0x180B52220")]
		public int GetRealChannels(FMODPlatform platform)
		{
			return 0;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00005F6C File Offset: 0x0000416C
		[Token(Token = "0x6000697")]
		[Address(RVA = "0xB52270", Offset = "0xB50870", VA = "0x180B52270")]
		public int GetVirtualChannels(FMODPlatform platform)
		{
			return 0;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00005F84 File Offset: 0x00004184
		[Token(Token = "0x6000698")]
		[Address(RVA = "0xB522C0", Offset = "0xB508C0", VA = "0x180B522C0")]
		public int GetSpeakerMode(FMODPlatform platform)
		{
			return 0;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00005F9C File Offset: 0x0000419C
		[Token(Token = "0x6000699")]
		[Address(RVA = "0xB52310", Offset = "0xB50910", VA = "0x180B52310")]
		public int GetSampleRate(FMODPlatform platform)
		{
			return 0;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600069A")]
		[Address(RVA = "0xB52360", Offset = "0xB50960", VA = "0x180B52360")]
		public string GetBankPlatform(FMODPlatform platform)
		{
			return null;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069B")]
		[Address(RVA = "0xB523F0", Offset = "0xB509F0", VA = "0x180B523F0")]
		private Settings()
		{
		}

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool SwitchSettingsMigration;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		private const string SettingsAssetName = "FMODStudioSettings";

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x0")]
		private static Settings instance;

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		public bool HasSourceProject;

		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0x1A")]
		[SerializeField]
		public bool HasPlatforms;

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string sourceProjectPath;

		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string sourceBankPath;

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public string SourceBankPathUnformatted;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public bool AutomaticEventLoading;

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public BankLoadType BankLoadType;

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public bool AutomaticSampleLoading;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public string EncryptionKey;

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public ImportType ImportType;

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public string TargetAssetPath;

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public DEBUG_FLAGS LoggingLevel;

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public List<PlatformIntSetting> SpeakerModeSettings;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public List<PlatformIntSetting> SampleRateSettings;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public List<PlatformBoolSetting> LiveUpdateSettings;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public List<PlatformBoolSetting> OverlaySettings;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		public List<PlatformBoolSetting> LoggingSettings;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		public List<PlatformStringSetting> BankDirectorySettings;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		public List<PlatformIntSetting> VirtualChannelSettings;

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		public List<PlatformIntSetting> RealChannelSettings;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		public List<string> Plugins;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		public List<string> MasterBanks;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		public List<string> Banks;

		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		public List<string> BanksToLoad;

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		public ushort LiveUpdatePort;
	}
}
