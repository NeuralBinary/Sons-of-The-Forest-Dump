using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Gameplay.GameSetup;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sons.Save
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[DefaultExecutionOrder(-1)]
	public class GameState : SingletonBehaviour<GameState>, ISaveGameSerializer<GameStateData>, IQuitHandler
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		private string SerializedName
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2FE9490", Offset = "0x2FE7A90", VA = "0x182FE9490", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x17000002")]
		private bool UniqueFile
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x17000003")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x17000004")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2FE94C0", Offset = "0x2FE7AC0", VA = "0x182FE94C0")]
		public static IReadOnlyList<NamedIntData> GetNamedIntDatas()
		{
			return null;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x17000005")]
		public static bool IsQuitting
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2FE9570", Offset = "0x2FE7B70", VA = "0x182FE9570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2FE95C0", Offset = "0x2FE7BC0", VA = "0x182FE95C0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2FE9690", Offset = "0x2FE7C90", VA = "0x182FE9690")]
		private void OnDisable()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2FE9760", Offset = "0x2FE7D60", VA = "0x182FE9760")]
		private void OnSceneLoaded(Scene sceneLoaded, LoadSceneMode arg1)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2FE9870", Offset = "0x2FE7E70", VA = "0x182FE9870", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2FE98D0", Offset = "0x2FE7ED0", VA = "0x182FE98D0", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2FE9930", Offset = "0x2FE7F30", VA = "0x182FE9930")]
		public void SetGameName(string gameName)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x28A2FC0", Offset = "0x28A15C0", VA = "0x1828A2FC0")]
		public string GetGameName()
		{
			return null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2FE9990", Offset = "0x2FE7F90", VA = "0x182FE9990", Slot = "11")]
		private GameStateData OnSerialize()
		{
			return null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2FE9D70", Offset = "0x2FE8370", VA = "0x182FE9D70")]
		public static bool ContainsGeneratedSaveGameName(string gameSaveName)
		{
			return default(bool);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2FEA0B0", Offset = "0x2FE86B0", VA = "0x182FEA0B0")]
		public string UpdateGeneratedSaveGameName(string gameSaveName)
		{
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2FEA400", Offset = "0x2FE8A00", VA = "0x182FEA400")]
		public string GenerateSaveGameName()
		{
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2FEA720", Offset = "0x2FE8D20", VA = "0x182FEA720")]
		private static Mode GetGameMode()
		{
			return Mode.Normal;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2FEA780", Offset = "0x2FE8D80", VA = "0x182FEA780")]
		private ITimeOfDay GetTimeOfDay()
		{
			return null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2FEA7F0", Offset = "0x2FE8DF0", VA = "0x182FEA7F0")]
		private void ValidateStoredData()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2FEA890", Offset = "0x2FE8E90", VA = "0x182FEA890", Slot = "12")]
		private void OnDeserialize(GameStateData data)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2FEAA80", Offset = "0x2FE9080", VA = "0x182FEAA80")]
		private void SetTimeOfDay(int gameDays, int gameHours, int gameMinutes, int gameSeconds, int gameMilliseconds)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2FEAB20", Offset = "0x2FE9120", VA = "0x182FEAB20")]
		private void UpdateNamedIntInstances(GameStateData data)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2FEAD70", Offset = "0x2FE9370", VA = "0x182FEAD70")]
		private static NamedIntData FindMatching(List<NamedIntData> existingNamedIntData, NamedIntData source)
		{
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2FEAED0", Offset = "0x2FE94D0", VA = "0x182FEAED0")]
		private static bool TryGetManager(out GameState manager, string debugName)
		{
			return default(bool);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2FEAFA0", Offset = "0x2FE95A0", VA = "0x182FEAFA0")]
		public static string CrashSite()
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2FEB0D0", Offset = "0x2FE96D0", VA = "0x182FEB0D0")]
		public static bool IsRobbyDead()
		{
			return default(bool);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2FEB1F0", Offset = "0x2FE97F0", VA = "0x182FEB1F0")]
		public static bool IsVirginiaDead()
		{
			return default(bool);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2FEB310", Offset = "0x2FE9910", VA = "0x182FEB310")]
		public static bool CoreGameCompleted()
		{
			return default(bool);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2FEB430", Offset = "0x2FE9A30", VA = "0x182FEB430")]
		public static bool EscapedIsland()
		{
			return default(bool);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2FEB550", Offset = "0x2FE9B50", VA = "0x182FEB550")]
		public static bool StayedOnIsland()
		{
			return default(bool);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2FEB670", Offset = "0x2FE9C70", VA = "0x182FEB670")]
		public static void SetCrashSite(string value)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2FEB800", Offset = "0x2FE9E00", VA = "0x182FEB800")]
		public static void SetIsRobbyDead(bool value)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2FEB930", Offset = "0x2FE9F30", VA = "0x182FEB930")]
		public static void SetIsVirginiaDead(bool value)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2FEBA60", Offset = "0x2FEA060", VA = "0x182FEBA60")]
		public static void SetCoreGameCompleted(bool value)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2FEBB90", Offset = "0x2FEA190", VA = "0x182FEBB90")]
		public static void SetEscapedIsland(bool value)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2FEBCC0", Offset = "0x2FEA2C0", VA = "0x182FEBCC0")]
		public static void SetStayedOnIsland(bool value)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2FEBDF0", Offset = "0x2FEA3F0", VA = "0x182FEBDF0")]
		public NamedIntData GetNamedIntData(string namedIntData)
		{
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2FEBEA0", Offset = "0x2FEA4A0", VA = "0x182FEBEA0")]
		public NamedIntData GetNamedIntData(NamedIntData namedIntData)
		{
			return null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2FEBF30", Offset = "0x2FEA530", VA = "0x182FEBF30")]
		public void SetNamedIntData(NamedIntData namedIntData)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2FEC090", Offset = "0x2FEA690", VA = "0x182FEC090")]
		public static NamedIntData GetOrCreate(string saveObjectNameId, bool defaultValue)
		{
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2FEC0F0", Offset = "0x2FEA6F0", VA = "0x182FEC0F0")]
		public static NamedIntData GetOrCreate(string saveObjectNameId, int defaultValue)
		{
			return null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2FEC300", Offset = "0x2FEA900", VA = "0x182FEC300")]
		private static void SavedNamedIntData(NamedIntData obj)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2FEC3B0", Offset = "0x2FEA9B0", VA = "0x182FEC3B0", Slot = "17")]
		public void OnQuit()
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2FEC480", Offset = "0x2FEAA80", VA = "0x182FEC480")]
		public static void SetSaveTimeOfDayMethod(Func<ITimeOfDay> getTimeOfDayAction)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2FEC530", Offset = "0x2FEAB30", VA = "0x182FEC530")]
		public static void SetLoadTimeOfDayMethod(Action<int, int, int, int, int> loadTimeOfDay)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2FEC5E0", Offset = "0x2FEABE0", VA = "0x182FEC5E0")]
		public static bool TimeDeltaEffectivelyZero(float deltaTime)
		{
			return default(bool);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2FEC5F0", Offset = "0x2FEABF0", VA = "0x182FEC5F0")]
		public static void RegisterQuitHandler(Action quitHandler)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2FEC7B0", Offset = "0x2FEADB0", VA = "0x182FEC7B0")]
		public static void UnregisterQuitHandler(Action quitHandler)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2FEC880", Offset = "0x2FEAE80", VA = "0x182FEC880")]
		public static void RegisterQuitHandler(IQuitHandler quitHandler)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2FECA90", Offset = "0x2FEB090", VA = "0x182FECA90")]
		private static void CleanUpQuitHandlers()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2FECBC0", Offset = "0x2FEB1C0", VA = "0x182FECBC0")]
		public static void UnregisterQuitHandler(IQuitHandler quitHandler)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2FECCB0", Offset = "0x2FEB2B0", VA = "0x182FECCB0")]
		public static void RunQuittingGameCallbacks()
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2FECD10", Offset = "0x2FEB310", VA = "0x182FECD10")]
		private static void ProcessQuitHandlers()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2FED140", Offset = "0x2FEB740", VA = "0x182FED140")]
		private static void ProcessStaticQuitActions()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2FED4C0", Offset = "0x2FEBAC0", VA = "0x182FED4C0")]
		public GameState()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x28")]
		private string _saveTime;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x30")]
		private GameStateData _storedGameStateData;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		private static Action<int, int, int, int, int> _setTimeOfDay;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x8")]
		private static Func<ITimeOfDay> _getTimeOfDay;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		private static bool _isQuitting;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		private static List<IQuitHandler> _quitHandlers;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		private static List<Action> _staticQuitActions;
	}
}
