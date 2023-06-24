using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Save
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[AddComponentMenu("Sons/Save/SaveGameManager")]
	[DefaultExecutionOrder(-1100)]
	public class SaveGameManager : SingletonBehaviour<SaveGameManager>
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x3129050", Offset = "0x3127650", VA = "0x183129050")]
		private void Start()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x3129330", Offset = "0x3127930", VA = "0x183129330")]
		private static void SetupSavePaths()
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x3129840", Offset = "0x3127E40", VA = "0x183129840")]
		public static void SetActiveGameType(SaveGameType saveGameType)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x31298A0", Offset = "0x3127EA0", VA = "0x1831298A0")]
		private static string GetSaveFolderForId(SaveGameType gameType, int saveId)
		{
			return null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x3129AB0", Offset = "0x31280B0", VA = "0x183129AB0")]
		private static uint GetNewRandomIndex(SaveGameType gameType)
		{
			return 0U;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x3129BD0", Offset = "0x31281D0", VA = "0x183129BD0")]
		private static bool IsValidNewId(uint saveId, List<uint> existingIds)
		{
			return default(bool);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3129DA0", Offset = "0x31283A0", VA = "0x183129DA0")]
		private static uint GetRandomIndex()
		{
			return 0U;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		public static void RegisterSerializer<T>(ISaveGameSerializer<T> serializer)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		public static void UnregisterSerializer<T>(ISaveGameSerializer<T> serializer)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x3129E40", Offset = "0x3128440", VA = "0x183129E40")]
		public static void RegisterBeforeSaveCallback(Action callback)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3129F30", Offset = "0x3128530", VA = "0x183129F30")]
		public static void UnregisterBeforeSaveCallback(Action callback)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x3129FE0", Offset = "0x31285E0", VA = "0x183129FE0")]
		public static void RegisterAfterSaveCallback(Action<bool> callback)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x312A120", Offset = "0x3128720", VA = "0x18312A120")]
		public static void UnregisterAfterSaveCallback(Action<bool> callback)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x312A1D0", Offset = "0x31287D0", VA = "0x18312A1D0")]
		public static void RegisterBeforeLoadCallback(Action callback)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x312A2C0", Offset = "0x31288C0", VA = "0x18312A2C0")]
		public static void UnregisterBeforeLoadCallback(Action callback)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x312A370", Offset = "0x3128970", VA = "0x18312A370")]
		public static void RegisterAfterLoadCallback(Action callback)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x312A460", Offset = "0x3128A60", VA = "0x18312A460")]
		public static void UnregisterAfterLoadCallback(Action callback)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x312A510", Offset = "0x3128B10", VA = "0x18312A510")]
		public static bool TryGetSaveGameIds(SaveGameType saveGameType, out List<uint> saveIds)
		{
			return default(bool);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x312A7E0", Offset = "0x3128DE0", VA = "0x18312A7E0")]
		private static string GetSaveGameFolder(SaveGameType saveGameType)
		{
			return null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000037")]
		public static T GetData<T>(SaveGameType saveGameType, int saveId)
		{
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000038")]
		public static bool IsScriptableObject<T>()
		{
			return default(bool);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x312A930", Offset = "0x3128F30", VA = "0x18312A930")]
		public static void TriggerQuickSave()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x312A9D0", Offset = "0x3128FD0", VA = "0x18312A9D0")]
		public static void TriggerQuickLoad()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x312AB30", Offset = "0x3129130", VA = "0x18312AB30")]
		public static bool IsValidFloat(float floatValue)
		{
			return default(bool);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x312AB60", Offset = "0x3129160", VA = "0x18312AB60")]
		public static void SetFloatIfInvalid(ref float targetValue, float invalidFallback)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x312ABF0", Offset = "0x31291F0", VA = "0x18312ABF0")]
		public static void Load(uint saveId, SaveGameType saveGameType)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x312AC50", Offset = "0x3129250", VA = "0x18312AC50")]
		public static void Load(int saveId, SaveGameType saveGameType)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x312ACD0", Offset = "0x31292D0", VA = "0x18312ACD0")]
		private static bool Load(string dir, string[] filenames)
		{
			return default(bool);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x312AE00", Offset = "0x3129400", VA = "0x18312AE00")]
		private static bool Load(string dir, string filename, SaveGameType saveGameType)
		{
			return default(bool);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x312B140", Offset = "0x3129740", VA = "0x18312B140")]
		private static bool ReadJson(string dir, string filename, SaveGameManager instance, SaveGameType saveGameType)
		{
			return default(bool);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000042")]
		public static T DeserializeScriptableObject<T>(string json) where T : ScriptableObject
		{
			return null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000043")]
		internal static T Deserialize<T>(string json)
		{
			return null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x312B850", Offset = "0x3129E50", VA = "0x18312B850")]
		public static bool ClearSaveGame(SaveGameType saveGameType, int existingSaveId)
		{
			return default(bool);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x312B9C0", Offset = "0x3129FC0", VA = "0x18312B9C0")]
		public static void SaveToSlot(int saveId, string gameName)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x312BA30", Offset = "0x312A030", VA = "0x18312BA30")]
		public static void Save(SaveGameType saveGameType, string gameName, int saveId = 0)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x312BAD0", Offset = "0x312A0D0", VA = "0x18312BAD0")]
		public static void Delete(SaveGameType saveGameType, int saveId = 0)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x312BBC0", Offset = "0x312A1C0", VA = "0x18312BBC0")]
		private static void Save(string dir, string baseFilename, string gameName, bool savePlayerOnly = false)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x312BF70", Offset = "0x312A570", VA = "0x18312BF70")]
		private static void BackupPreviousSave(string backupFolderPath)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x312C210", Offset = "0x312A810", VA = "0x18312C210")]
		private static void DeleteOldBackups(string dir, string backupNamePrefix)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x312C5E0", Offset = "0x312ABE0", VA = "0x18312C5E0")]
		private static void WriteJson(string dir, string baseFilename, SaveGameManager instance, string gameName, bool savePlayerOnly = false)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x312CDF0", Offset = "0x312B3F0", VA = "0x18312CDF0")]
		private static void CreateGameNameFile(string dir, string gameName)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x312D200", Offset = "0x312B800", VA = "0x18312D200")]
		private static string SanitizeGameName(string gameName)
		{
			return null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x312D310", Offset = "0x312B910", VA = "0x18312D310")]
		private static void WriteOutFile(string dir, string filename, SaveData saveData, out int length)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600004F")]
		internal static string Serialize<T>(T saveData)
		{
			return null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x312D3E0", Offset = "0x312B9E0", VA = "0x18312D3E0")]
		private static void CreateThumbnail(string dir, string filename, int factor = 1)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x312D690", Offset = "0x312BC90", VA = "0x18312D690")]
		private static void CaptureFromCamera(int thumbnailWidth, int thumbnailHeight, Texture2D screenShot)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x312DBF0", Offset = "0x312C1F0", VA = "0x18312DBF0")]
		private static string GetThumbnailFilename(string filename)
		{
			return null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x312DCA0", Offset = "0x312C2A0", VA = "0x18312DCA0")]
		public static Texture2D LoadThumbnail(SaveGameType saveGameType, uint saveId)
		{
			return null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x312DE40", Offset = "0x312C440", VA = "0x18312DE40")]
		public static Texture2D LoadThumbnail(int index)
		{
			return null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x312DFF0", Offset = "0x312C5F0", VA = "0x18312DFF0")]
		public SaveGameManager()
		{
		}

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		private const int QuickSaveIndex = -1;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		private const string QuickSaveFolderSuffix = "/QuickSave";

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		private const string SavesFolderSuffix = "/Saves";

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		private const string OldSaveFileName = "defaultsave.json";

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		private const string SaveFileName = "SaveData.json";

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		private const string SinglePlayerSubFolderSuffix = "/SinglePlayer";

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		private const string MultiplayerSubFolderSuffix = "/Multiplayer";

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		private const string MultiplayerClientSubFolderSuffix = "/MultiplayerClient";

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] SaveFileNames;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x8")]
		private static string _saveGameRootFolder;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x10")]
		private static string _steamUserSaveGameFolder;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x18")]
		private static string _singlePlayerSaveGameFolder;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x20")]
		private static string _multiplayerSaveGameFolder;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x28")]
		private static string _multiplayerClientSaveGameFolder;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x30")]
		private static string _quickSaveFolder;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _verbose;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<IRegisteredSerializer> _serializers;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x38")]
		private static readonly List<IRegisteredSerializer> _serializerQueue;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x38")]
		private List<Action> _beforeSaveCallback;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x40")]
		private List<Action<bool>> _afterSaveCallback;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x48")]
		private List<Action> _beforeLoadCallback;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x50")]
		private List<Action> _afterLoadCallback;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x58")]
		private float _saveTime;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x5C")]
		private float _loadTime;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x40")]
		private static SaveGameType _activeSaveGameType;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		private const int MaxBackups = 3;
	}
}
