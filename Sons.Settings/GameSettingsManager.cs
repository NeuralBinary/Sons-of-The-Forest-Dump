using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Sons.Settings
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[AddComponentMenu("Sons/Game/Settings Manager")]
	public class GameSettingsManager : SingletonBehaviour<GameSettingsManager>
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x3131510", Offset = "0x312FB10", VA = "0x183131510")]
		private static void RunCallbacks(string nameKey, bool value)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x31316E0", Offset = "0x312FCE0", VA = "0x1831316E0")]
		private static void RunCallbacks(string nameKey, int value)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x31318B0", Offset = "0x312FEB0", VA = "0x1831318B0")]
		private static void RunCallbacks(string nameKey, float value)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3131A80", Offset = "0x3130080", VA = "0x183131A80")]
		private static void RunCallbacks(string nameKey, string value)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x3131C50", Offset = "0x3130250", VA = "0x183131C50")]
		public static bool RegisterSettingChangeCallback(string nameKey, GameSettingsManager.BoolAction action)
		{
			return default(bool);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x3131CD0", Offset = "0x31302D0", VA = "0x183131CD0")]
		public static bool RegisterSettingChangeCallbackAndRun(string nameKey, GameSettingsManager.BoolAction action, bool defaultValue)
		{
			return default(bool);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x3131DB0", Offset = "0x31303B0", VA = "0x183131DB0")]
		public static void UnregisterSettingChangeCallback(string nameKey, GameSettingsManager.BoolAction action)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x3131E30", Offset = "0x3130430", VA = "0x183131E30")]
		public static bool SetupCallbackAndRun(string settingKey, GameSettingsManager.BoolAction action, bool settingDefault, List<object> registeredActionPairs)
		{
			return default(bool);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x31320B0", Offset = "0x31306B0", VA = "0x1831320B0")]
		public static bool RegisterSettingChangeCallback(string nameKey, GameSettingsManager.IntAction action)
		{
			return default(bool);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x3132130", Offset = "0x3130730", VA = "0x183132130")]
		public static bool RegisterSettingChangeCallbackAndRun(string nameKey, GameSettingsManager.IntAction action, int defaultValue)
		{
			return default(bool);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x3132210", Offset = "0x3130810", VA = "0x183132210")]
		public static void UnregisterSettingChangeCallback(string nameKey, GameSettingsManager.IntAction action)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x3132290", Offset = "0x3130890", VA = "0x183132290")]
		public static bool SetupCallbackAndRun(string settingKey, GameSettingsManager.IntAction action, int settingDefault, List<object> registeredActionPairs)
		{
			return default(bool);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x3132550", Offset = "0x3130B50", VA = "0x183132550")]
		public static bool RegisterSettingChangeCallback(string nameKey, GameSettingsManager.FloatAction action)
		{
			return default(bool);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x31325D0", Offset = "0x3130BD0", VA = "0x1831325D0")]
		public static bool RegisterSettingChangeCallbackAndRun(string nameKey, GameSettingsManager.FloatAction action, float defaultValue)
		{
			return default(bool);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x31326C0", Offset = "0x3130CC0", VA = "0x1831326C0")]
		public static void UnregisterSettingChangeCallback(string nameKey, GameSettingsManager.FloatAction action)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x3132740", Offset = "0x3130D40", VA = "0x183132740")]
		public static bool SetupCallbackAndRun(string settingKey, GameSettingsManager.FloatAction action, float settingDefault, List<object> registeredActionPairs)
		{
			return default(bool);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x31329D0", Offset = "0x3130FD0", VA = "0x1831329D0")]
		public static bool RegisterSettingChangeCallback(string nameKey, GameSettingsManager.StringAction action)
		{
			return default(bool);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x3132A50", Offset = "0x3131050", VA = "0x183132A50")]
		public static bool RegisterSettingChangeCallbackAndRun(string nameKey, GameSettingsManager.StringAction action, string defaultValue)
		{
			return default(bool);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x3132B40", Offset = "0x3131140", VA = "0x183132B40")]
		public static void UnregisterSettingChangeCallback(string nameKey, GameSettingsManager.StringAction action)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x3132BC0", Offset = "0x31311C0", VA = "0x183132BC0")]
		public static bool SetupCallbackAndRun(string settingKey, GameSettingsManager.StringAction action, string settingDefault, List<object> registeredActionPairs)
		{
			return default(bool);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x600003F")]
		private static bool RegisterSettingChangeCallback<T>(string nameKey, T action, ref Dictionary<string, List<T>> dictionary)
		{
			return default(bool);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		private static void UnregisterSettingChangeCallback<T>(string nameKey, T action, ref Dictionary<string, List<T>> dictionary)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x3132E40", Offset = "0x3131440", VA = "0x183132E40")]
		public static void UnregisterSettingChangeCallbacks(List<object> pairs)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x3133140", Offset = "0x3131740", VA = "0x183133140")]
		public static void UnregisterSettingChangeCallbacks(List<GameSettingsManager.KeyBoolActionPair> pairs)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x3133320", Offset = "0x3131920", VA = "0x183133320")]
		public static void UnregisterSettingChangeCallbacks(List<GameSettingsManager.KeyStringActionPair> pairs)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x3133500", Offset = "0x3131B00", VA = "0x183133500")]
		public static void UnregisterSettingChangeCallbacks(List<GameSettingsManager.KeyIntActionPair> pairs)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x31336E0", Offset = "0x3131CE0", VA = "0x1831336E0")]
		public static void UnregisterSettingChangeCallbacks(List<GameSettingsManager.KeyFloatActionPair> pairs)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x31338C0", Offset = "0x3131EC0", VA = "0x1831338C0")]
		public static void BatchResetSettingToDefaultValue(Dictionary<string, object> defaults)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x3133DB0", Offset = "0x31323B0", VA = "0x183133DB0", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x3133DF0", Offset = "0x31323F0", VA = "0x183133DF0")]
		public static bool GetSetting(string nameKey, bool defaultResult)
		{
			return default(bool);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x3133EA0", Offset = "0x31324A0", VA = "0x183133EA0")]
		public static int GetSetting(string nameKey, int defaultResult)
		{
			return 0;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x3133F50", Offset = "0x3132550", VA = "0x183133F50")]
		public static float GetSetting(string nameKey, float defaultResult)
		{
			return 0f;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x3134000", Offset = "0x3132600", VA = "0x183134000")]
		public static string GetSetting(string nameKey, string defaultResult)
		{
			return null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x31340B0", Offset = "0x31326B0", VA = "0x1831340B0")]
		public static string GetSetting(int nameKey, string defaultResult)
		{
			return null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x3134160", Offset = "0x3132760", VA = "0x183134160")]
		public static void SetSetting(string nameKey, bool value)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x3134260", Offset = "0x3132860", VA = "0x183134260")]
		public static void SetSetting(string nameKey, bool value, out bool changed)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x3134340", Offset = "0x3132940", VA = "0x183134340")]
		public static void SetSetting(string nameKey, int value)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x3134440", Offset = "0x3132A40", VA = "0x183134440")]
		public static void SetSetting(string nameKey, int value, out bool changed)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x3134510", Offset = "0x3132B10", VA = "0x183134510")]
		public static void SetSetting(string nameKey, float value)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x3134610", Offset = "0x3132C10", VA = "0x183134610")]
		public static void SetSetting(string nameKey, float value, out bool changed)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x31346E0", Offset = "0x3132CE0", VA = "0x1831346E0")]
		public static void SetSetting(string nameKey, string value)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x31347E0", Offset = "0x3132DE0", VA = "0x1831347E0")]
		public static void SetSetting(string nameKey, string value, out bool changed)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x31348B0", Offset = "0x3132EB0", VA = "0x1831348B0")]
		public static bool TryClearSetting(string nameKey)
		{
			return default(bool);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x3134930", Offset = "0x3132F30", VA = "0x183134930")]
		private static void SetSetting(PersistentValue eachPersistentValue)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x3134AB0", Offset = "0x31330B0", VA = "0x183134AB0")]
		public static void Save()
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x3134D00", Offset = "0x3133300", VA = "0x183134D00")]
		public static void Reset()
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x3135220", Offset = "0x3133820", VA = "0x183135220")]
		public static void Load()
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x31354C0", Offset = "0x3133AC0", VA = "0x1831354C0")]
		private static void CreateBlankSettings(GameSettingsManager instance, string settingsName)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x3135590", Offset = "0x3133B90", VA = "0x183135590")]
		public static string BuildKey(params string[] keys)
		{
			return null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x31355E0", Offset = "0x3133BE0", VA = "0x1831355E0")]
		public static void ClearAllSettings()
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x3135740", Offset = "0x3133D40", VA = "0x183135740")]
		public static void ClearSetting(string settingKey)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x31357B0", Offset = "0x3133DB0", VA = "0x1831357B0")]
		public GameSettingsManager()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000060")]
		[CompilerGenerated]
		internal static void <BatchResetSettingToDefaultValue>g__RunCallbacksWithDefaultsForeach|40_0<T>(Dictionary<string, List<T>> actions, ref GameSettingsManager.<>c__DisplayClass40_0 A_1)
		{
		}

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, List<GameSettingsManager.BoolAction>> BoolActions;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, List<GameSettingsManager.IntAction>> IntActions;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<string, List<GameSettingsManager.FloatAction>> FloatActions;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<string, List<GameSettingsManager.StringAction>> StringActions;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		public const string MultiplayerKeyPrefix = "Multiplayer";

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameSettings _gameSettings;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private GameSettings _gameSettingsOriginal;

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000062 RID: 98
		[Token(Token = "0x2000008")]
		public delegate void StringAction(string newValue);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000066 RID: 102
		[Token(Token = "0x2000009")]
		public delegate void IntAction(int newValue);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600006A RID: 106
		[Token(Token = "0x200000A")]
		public delegate void FloatAction(float newValue);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600006E RID: 110
		[Token(Token = "0x200000B")]
		public delegate void BoolAction(bool newValue);

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		public class KeyDelegateActionPair<T> where T : Delegate
		{
			// Token: 0x06000071 RID: 113 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000071")]
			public KeyDelegateActionPair([NotNull] T action, [NotNull] string key)
			{
			}

			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x0")]
			public T Action;

			// Token: 0x04000020 RID: 32
			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x0")]
			public string Key;
		}

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		public class KeyStringActionPair : GameSettingsManager.KeyDelegateActionPair<GameSettingsManager.StringAction>
		{
			// Token: 0x06000072 RID: 114 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x3135C70", Offset = "0x3134270", VA = "0x183135C70")]
			public KeyStringActionPair([NotNull] GameSettingsManager.StringAction action, [NotNull] string key)
			{
			}
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		public class KeyBoolActionPair : GameSettingsManager.KeyDelegateActionPair<GameSettingsManager.BoolAction>
		{
			// Token: 0x06000073 RID: 115 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x3135E10", Offset = "0x3134410", VA = "0x183135E10")]
			public KeyBoolActionPair([NotNull] GameSettingsManager.BoolAction action, [NotNull] string key)
			{
			}
		}

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		public class KeyIntActionPair : GameSettingsManager.KeyDelegateActionPair<GameSettingsManager.IntAction>
		{
			// Token: 0x06000074 RID: 116 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x3135FB0", Offset = "0x31345B0", VA = "0x183135FB0")]
			public KeyIntActionPair([NotNull] GameSettingsManager.IntAction action, [NotNull] string key)
			{
			}
		}

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x2000010")]
		public class KeyFloatActionPair : GameSettingsManager.KeyDelegateActionPair<GameSettingsManager.FloatAction>
		{
			// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x3136150", Offset = "0x3134750", VA = "0x183136150")]
			public KeyFloatActionPair([NotNull] GameSettingsManager.FloatAction action, [NotNull] string key)
			{
			}
		}
	}
}
