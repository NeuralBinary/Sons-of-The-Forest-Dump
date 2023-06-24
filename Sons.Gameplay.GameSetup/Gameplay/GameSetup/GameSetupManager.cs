using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Save;
using Sons.Settings;
using UnityEngine;

namespace Sons.Gameplay.GameSetup
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class GameSetupManager : SingletonBehaviour<GameSetupManager>, ISaveGameSerializer<GameSettings>
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2FEE8C0", Offset = "0x2FECEC0", VA = "0x182FEE8C0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2FEE930", Offset = "0x2FECF30", VA = "0x182FEE930", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2FEE990", Offset = "0x2FECF90", VA = "0x182FEE990")]
		public static Mode GetMode(Mode defaultMode = Mode.Normal)
		{
			return Mode.Normal;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2FEEA30", Offset = "0x2FED030", VA = "0x182FEEA30")]
		public static bool TryGetMode(out Mode result)
		{
			return default(bool);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2FEEB70", Offset = "0x2FED170", VA = "0x182FEEB70")]
		private bool TryGetModeSetting(out Mode result)
		{
			return default(bool);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2FEEC50", Offset = "0x2FED250", VA = "0x182FEEC50")]
		private string GetSettingInternal(string nameKey, string defaultResult)
		{
			return null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2FEECB0", Offset = "0x2FED2B0", VA = "0x182FEECB0")]
		private int GetSettingInternal(string nameKey, int defaultResult)
		{
			return 0;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2FEED10", Offset = "0x2FED310", VA = "0x182FEED10")]
		private bool GetSettingInternal(string nameKey, bool defaultResult)
		{
			return default(bool);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2FEED70", Offset = "0x2FED370", VA = "0x182FEED70")]
		private float GetSettingInternal(string nameKey, float defaultResult)
		{
			return 0f;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2FEEDD0", Offset = "0x2FED3D0", VA = "0x182FEEDD0")]
		private void SetSettingInternal(string nameKey, string value)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2FEEE00", Offset = "0x2FED400", VA = "0x182FEEE00")]
		private void SetSettingInternal(string nameKey, int value)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2FEEE30", Offset = "0x2FED430", VA = "0x182FEEE30")]
		private void SetSettingInternal(string nameKey, bool value)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2FEEE60", Offset = "0x2FED460", VA = "0x182FEEE60")]
		private void SetSettingInternal(string nameKey, float value)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2FEEE90", Offset = "0x2FED490", VA = "0x182FEEE90")]
		private void Initialize()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2FEF070", Offset = "0x2FED670", VA = "0x182FEF070")]
		public void ClearSetMode()
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2FEF0C0", Offset = "0x2FED6C0", VA = "0x182FEF0C0")]
		private static string GenerateUniqueId()
		{
			return null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2FEF150", Offset = "0x2FED750", VA = "0x182FEF150")]
		private void SetUid(string value)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2FEF1C0", Offset = "0x2FED7C0", VA = "0x182FEF1C0")]
		public static void SetSaveId(uint saveId)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2FEF270", Offset = "0x2FED870", VA = "0x182FEF270")]
		public static void SetSaveGameType(SaveGameType saveGameType)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2FEF390", Offset = "0x2FED990", VA = "0x182FEF390")]
		public static void SetGameId(string guid)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2FEF480", Offset = "0x2FEDA80", VA = "0x182FEF480")]
		public static string GetGameId()
		{
			return null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2FEF520", Offset = "0x2FEDB20", VA = "0x182FEF520")]
		public static uint GetSelectedSaveId()
		{
			return 0U;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2FEF5C0", Offset = "0x2FEDBC0", VA = "0x182FEF5C0")]
		public static void SetMode(string modeString)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2FEF6C0", Offset = "0x2FEDCC0", VA = "0x182FEF6C0")]
		public static void SetMode(Mode modeValue)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2FEF770", Offset = "0x2FEDD70", VA = "0x182FEF770")]
		private void SetModeInternal(Mode result)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700000E")]
		public string SerializedName
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x2FEFA70", Offset = "0x2FEE070", VA = "0x182FEFA70", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x1700000F")]
		public bool UniqueFile
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x17000010")]
		public bool ShouldSerialize
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x17000011")]
		public bool IncludeInPlayerSave
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "11")]
		public GameSettings OnSerialize()
		{
			return null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2FEFAA0", Offset = "0x2FEE0A0", VA = "0x182FEFAA0", Slot = "12")]
		public void OnDeserialize(GameSettings data)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000012")]
		public Func<string, GameSettings> DeserializeOverrideAction
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x2FEFB80", Offset = "0x2FEE180", VA = "0x182FEFB80", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2FEFBE0", Offset = "0x2FEE1E0", VA = "0x182FEFBE0")]
		public static void ClearSelectedLoadSlot()
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2FEFC30", Offset = "0x2FEE230", VA = "0x182FEFC30")]
		public static bool GameLoadedFromSave()
		{
			return default(bool);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2FEFCD0", Offset = "0x2FEE2D0", VA = "0x182FEFCD0")]
		public static SaveGameType GetSaveGameType()
		{
			return SaveGameType.SinglePlayer;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2FEFD70", Offset = "0x2FEE370", VA = "0x182FEFD70")]
		public static void SetSetting(string nameKey, bool value)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2FEFE60", Offset = "0x2FEE460", VA = "0x182FEFE60")]
		public static void SetSetting(string nameKey, int value)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2FEFF50", Offset = "0x2FEE550", VA = "0x182FEFF50")]
		public static void SetSetting(string nameKey, string value)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2FF0040", Offset = "0x2FEE640", VA = "0x182FF0040")]
		public static void SetSetting(string nameKey, float value)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2FF0130", Offset = "0x2FEE730", VA = "0x182FF0130")]
		public static bool GetSetting(string nameKey, bool defaultValue)
		{
			return default(bool);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2FF01E0", Offset = "0x2FEE7E0", VA = "0x182FF01E0")]
		public static int GetSetting(string nameKey, int defaultValue)
		{
			return 0;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2FF0290", Offset = "0x2FEE890", VA = "0x182FF0290")]
		public static float GetSetting(string nameKey, float defaultValue)
		{
			return 0f;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2FF0340", Offset = "0x2FEE940", VA = "0x182FF0340")]
		public static string GetSetting(string nameKey, string defaultValue)
		{
			return null;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2FF03F0", Offset = "0x2FEE9F0", VA = "0x182FF03F0")]
		private static void ClearSettingsMatching(string regexString)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2FF0610", Offset = "0x2FEEC10", VA = "0x182FF0610")]
		private static void ClearGameModeSettings()
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2FF0690", Offset = "0x2FEEC90", VA = "0x182FF0690")]
		public static SeasonSetting GetStartingSeasonSetting()
		{
			return default(SeasonSetting);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2FF0750", Offset = "0x2FEED50", VA = "0x182FF0750")]
		public static ShortDefaultLongRealisticSetting GetSeasonLengthSetting()
		{
			return default(ShortDefaultLongRealisticSetting);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2FF0810", Offset = "0x2FEEE10", VA = "0x182FF0810")]
		public static ShortDefaultLongRealisticSetting GetDayLengthSetting()
		{
			return default(ShortDefaultLongRealisticSetting);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2FF08D0", Offset = "0x2FEEED0", VA = "0x182FF08D0")]
		public static LowDefaultHighSetting GetPrecipitationFrequencySetting()
		{
			return default(LowDefaultHighSetting);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2FF0990", Offset = "0x2FEEF90", VA = "0x182FF0990")]
		public static void SetStartingSeasonSetting(SeasonSetting value)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2FF0A20", Offset = "0x2FEF020", VA = "0x182FF0A20")]
		public static void SetSeasonLengthSetting(ShortDefaultLongRealisticSetting value)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2FF0AB0", Offset = "0x2FEF0B0", VA = "0x182FF0AB0")]
		public static void SetDayLengthSetting(ShortDefaultLongRealisticSetting value)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2FF0B40", Offset = "0x2FEF140", VA = "0x182FF0B40")]
		public static void SetPrecipitationFrequencySetting(LowDefaultHighSetting value)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2FF0BD0", Offset = "0x2FEF1D0", VA = "0x182FF0BD0")]
		public static void ApplyHardGameModeSettings()
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2FF0F30", Offset = "0x2FEF530", VA = "0x182FF0F30")]
		public static void ApplyHardSurvivalGameModeSettings()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2FF1540", Offset = "0x2FEFB40", VA = "0x182FF1540")]
		public static void ApplyPeacefulGameModeSettings()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2FF1680", Offset = "0x2FEFC80", VA = "0x182FF1680")]
		public static SurvivalSetting GetConsumableEffectsSetting()
		{
			return default(SurvivalSetting);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2FF1740", Offset = "0x2FEFD40", VA = "0x182FF1740")]
		public static SurvivalSetting GetPlayerStatsDamageSetting()
		{
			return default(SurvivalSetting);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2FF1800", Offset = "0x2FEFE00", VA = "0x182FF1800")]
		public static SurvivalSetting GetSleepingDelaySetting()
		{
			return default(SurvivalSetting);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2FF18A0", Offset = "0x2FEFEA0", VA = "0x182FF18A0")]
		public static SurvivalSetting GetColdPenaltiesSetting()
		{
			return default(SurvivalSetting);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2FF1960", Offset = "0x2FEFF60", VA = "0x182FF1960")]
		public static bool GetReducedFoodInContainersSetting()
		{
			return default(bool);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2FF19C0", Offset = "0x2FEFFC0", VA = "0x182FF19C0")]
		public static bool GetSingleUseContainersSetting()
		{
			return default(bool);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2FF1A20", Offset = "0x2FF0020", VA = "0x182FF1A20")]
		public static bool GetPausedInInventorySetting()
		{
			return default(bool);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2FF1A80", Offset = "0x2FF0080", VA = "0x182FF1A80")]
		public static void SetConsumableEffectsSetting(SurvivalSetting value)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2FF1B10", Offset = "0x2FF0110", VA = "0x182FF1B10")]
		public static void SetPlayerStatsDamageSetting(SurvivalSetting value)
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2FF1BA0", Offset = "0x2FF01A0", VA = "0x182FF1BA0")]
		public static void SetColdPenaltiesSetting(SurvivalSetting value)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2FF1C30", Offset = "0x2FF0230", VA = "0x182FF1C30")]
		public static void SetReducedFoodInContainersSetting(bool value)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2FF1C90", Offset = "0x2FF0290", VA = "0x182FF1C90")]
		public static void SetSingleUseContainersSetting(bool value)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2FF1CF0", Offset = "0x2FF02F0", VA = "0x182FF1CF0")]
		public static void SetPausedInInventorySetting(bool value)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2FF1D50", Offset = "0x2FF0350", VA = "0x182FF1D50")]
		public static bool GetVailEnemySpawnSetting()
		{
			return default(bool);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2FF1DB0", Offset = "0x2FF03B0", VA = "0x182FF1DB0")]
		public static LowNormalHighSetting GetVailEnemyHealthSetting()
		{
			return default(LowNormalHighSetting);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2FF1E70", Offset = "0x2FF0470", VA = "0x182FF1E70")]
		public static LowNormalHighSetting GetVailEnemyDamageSetting()
		{
			return default(LowNormalHighSetting);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2FF1F30", Offset = "0x2FF0530", VA = "0x182FF1F30")]
		public static LowNormalHighSetting GetVailEnemyArmourSetting()
		{
			return default(LowNormalHighSetting);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2FF1FF0", Offset = "0x2FF05F0", VA = "0x182FF1FF0")]
		public static LowNormalHighSetting GetVailEnemyAggressionSetting()
		{
			return default(LowNormalHighSetting);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2FF20B0", Offset = "0x2FF06B0", VA = "0x182FF20B0")]
		public static LowNormalHighSetting GetVailAnimalSpawnRateSetting()
		{
			return default(LowNormalHighSetting);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2FF2170", Offset = "0x2FF0770", VA = "0x182FF2170")]
		public static void SetVailEnemySpawnSetting(bool value)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2FF21D0", Offset = "0x2FF07D0", VA = "0x182FF21D0")]
		public static void SetVailEnemyHealthSetting(LowNormalHighSetting value)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2FF2260", Offset = "0x2FF0860", VA = "0x182FF2260")]
		public static void SetVailEnemyDamageSetting(LowNormalHighSetting value)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2FF22F0", Offset = "0x2FF08F0", VA = "0x182FF22F0")]
		public static void SetVailEnemyArmourSetting(LowNormalHighSetting value)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2FF2380", Offset = "0x2FF0980", VA = "0x182FF2380")]
		public static void SetVailEnemyAggressionSetting(LowNormalHighSetting value)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2FF2410", Offset = "0x2FF0A10", VA = "0x182FF2410")]
		public static void SetVailAnimalSpawnRateSetting(LowNormalHighSetting value)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2FF24A0", Offset = "0x2FF0AA0", VA = "0x182FF24A0")]
		public GameSetupManager()
		{
		}

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		private const string ModeKey = "Mode";

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		private const string UniqueIdKey = "UID";

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		private const string DefaultModeString = "Normal";

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		private const string GameSettingKeyPrefix = "GameSetting.";

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameSettings _gameSetup;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x30")]
		private bool _initialized;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x34")]
		private uint _saveId;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x38")]
		private SaveGameType _saveGameType;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x3C")]
		private bool _gameLoadedFromSave;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x40")]
		private string _gameId;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string EscapedGameSettingsKeyPrefix;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		public const string StartingSeasonKey = "GameSetting.Environment.StartingSeason";

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		public const string SeasonLengthKey = "GameSetting.Environment.SeasonLength";

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		public const string DayLengthKey = "GameSetting.Environment.DayLength";

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		public const string PrecipitationFrequencyKey = "GameSetting.Environment.PrecipitationFrequency";

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string DefaultStartingSeasonSettingValue;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string DefaultSeasonLengthSettingValue;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string DefaultDayLengthSettingValue;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string DefaultPrecipitationFrequencySettingValue;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x28")]
		public static readonly List<string> StartingSeasonSettings;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x30")]
		public static readonly List<string> SeasonLengthSettings;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x38")]
		public static readonly List<string> DayLengthSettings;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x40")]
		public static readonly List<string> PrecipitationFrequencySettings;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		public const string ConsumableEffectsKey = "GameSetting.Survival.ConsumableEffects";

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		public const string PlayerStatsDamageKey = "GameSetting.Survival.PlayerStatsDamage";

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		public const string SleepingDelayKey = "GameSetting.Survival.SleepingDelay";

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		public const string ColdPenaltiesKey = "GameSetting.Survival.ColdPenalties";

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		public const string ReducedFoodInContainersKey = "GameSetting.Survival.ReducedFoodInContainers";

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		public const string SingleUseContainersKey = "GameSetting.Survival.SingleUseContainers";

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		public const string PausedInInventoryKey = "GameSetting.Survival.PausedInInventory";

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x48")]
		public static readonly string DefaultConsumableEffectsSettingValue;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x50")]
		public static readonly string DefaultPlayerStatsDamageSettingValue;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x58")]
		public static readonly string DefaultSleepingDelaySettingValue;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x60")]
		public static readonly string DefaultColdPenaltiesSettingValue;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		public const bool DefaultReducedFoodInContainersSettingValue = false;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		public const bool DefaultSingleUseContainersSettingValue = false;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		public const bool DefaultPausedInInventorySettingValue = true;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x68")]
		public static readonly List<string> ConsumableEffectsSettings;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x70")]
		public static readonly List<string> PlayerStatsDamageSettings;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x78")]
		public static readonly List<string> SleepingDelaySettings;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x80")]
		public static readonly List<string> ColdPenaltiesSettings;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		public const string VailEnemySpawnKey = "GameSetting.Vail.EnemySpawn";

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		public const string VailEnemyHealthKey = "GameSetting.Vail.EnemyHealth";

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		public const string VailEnemyDamageKey = "GameSetting.Vail.EnemyDamage";

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		public const string VailEnemyArmourKey = "GameSetting.Vail.EnemyArmour";

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		public const string VailEnemyAggressionKey = "GameSetting.Vail.EnemyAggression";

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		public const string VailAnimalSpawnRateKey = "GameSetting.Vail.AnimalSpawnRate";

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		public const bool DefaultEnemySpawnSettingValue = true;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x88")]
		public static readonly string DefaultVailEnemyHealthSettingValue;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x90")]
		public static readonly string DefaultVailEnemyDamageSettingValue;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x98")]
		public static readonly string DefaultVailEnemyArmourSettingValue;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly string DefaultVailEnemyAggressionSettingValue;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly string DefaultVailAnimalSpawnRateSettingValue;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly List<string> VailEnemyHealthSettings;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly List<string> VailEnemyDamageSettings;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly List<string> VailEnemyArmourSettings;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly List<string> VailEnemyAggressionSettings;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly List<string> VailAnimalSpawnRateSettings;
	}
}
