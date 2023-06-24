using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Sons.Settings
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[CreateAssetMenu(fileName = "GameSettings", menuName = "Sons/Game/Settings", order = 0)]
	public class GameSettings : ScriptableObject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		[JsonIgnore]
		public IReadOnlyList<PersistentValue> Settings
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x312ED00", Offset = "0x312D300", VA = "0x18312ED00")]
		public static void SaveToPath(string targetPath, GameSettings instanceGameSettings)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x312EE90", Offset = "0x312D490", VA = "0x18312EE90")]
		private void SerializeTo(StringBuilder stringBuilder)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x312EFB0", Offset = "0x312D5B0", VA = "0x18312EFB0")]
		public static bool LoadFromPath(string sourcePath, out GameSettings instanceGameSettings)
		{
			return default(bool);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x312F2C0", Offset = "0x312D8C0", VA = "0x18312F2C0")]
		private void ProcessSettings()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x312F4F0", Offset = "0x312DAF0", VA = "0x18312F4F0")]
		private void SerializeFrom(string textSource)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x312F510", Offset = "0x312DB10", VA = "0x18312F510")]
		public bool GetSetting(string nameKey, bool defaultResult)
		{
			return default(bool);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x312F560", Offset = "0x312DB60", VA = "0x18312F560")]
		public bool GetSetting(int nameKey, bool defaultResult)
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x312F5B0", Offset = "0x312DBB0", VA = "0x18312F5B0")]
		public int GetSetting(string nameKey, int defaultResult)
		{
			return 0;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x312F600", Offset = "0x312DC00", VA = "0x18312F600")]
		public int GetSetting(int nameKey, int defaultResult)
		{
			return 0;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x312F650", Offset = "0x312DC50", VA = "0x18312F650")]
		public float GetSetting(string nameKey, float defaultResult)
		{
			return 0f;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x312F6B0", Offset = "0x312DCB0", VA = "0x18312F6B0")]
		public float GetSetting(int nameKey, float defaultResult)
		{
			return 0f;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x312F710", Offset = "0x312DD10", VA = "0x18312F710")]
		public string GetSetting(string nameKey, string defaultResult)
		{
			return null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x312F760", Offset = "0x312DD60", VA = "0x18312F760")]
		public string GetSetting(int nameKey, string defaultResult)
		{
			return null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x312F7B0", Offset = "0x312DDB0", VA = "0x18312F7B0")]
		private bool TryGetSetting(string nameKey, out PersistentValue persistentValue)
		{
			return default(bool);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x312F970", Offset = "0x312DF70", VA = "0x18312F970")]
		private bool TryGetSetting(int nameKey, SettingType settingType, out PersistentValue persistentValue)
		{
			return default(bool);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x312FBD0", Offset = "0x312E1D0", VA = "0x18312FBD0")]
		private bool TryGetSetting(string nameKey, SettingType settingType, out PersistentValue persistentValue)
		{
			return default(bool);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x312FDD0", Offset = "0x312E3D0", VA = "0x18312FDD0")]
		public void SetSetting(string nameKey, bool value, out bool changed)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x312FFC0", Offset = "0x312E5C0", VA = "0x18312FFC0")]
		public void SetSetting(string nameKey, int value, out bool changed)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x31301B0", Offset = "0x312E7B0", VA = "0x1831301B0")]
		public void SetSetting(string nameKey, float value, out bool changed)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x31303D0", Offset = "0x312E9D0", VA = "0x1831303D0")]
		private void ClearSettingInstances(string nameKey)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x31304E0", Offset = "0x312EAE0", VA = "0x1831304E0")]
		public void SetSetting(string nameKey, string value, out bool changed)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3130800", Offset = "0x312EE00", VA = "0x183130800")]
		public bool TryClearSetting(string nameKey)
		{
			return default(bool);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x3130920", Offset = "0x312EF20", VA = "0x183130920")]
		public void Clone(GameSettings source)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x3130D50", Offset = "0x312F350", VA = "0x183130D50")]
		public void ClearAllSettings()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3130E30", Offset = "0x312F430", VA = "0x183130E30")]
		public bool ClearSettingsMatchingRegex(string regexString)
		{
			return default(bool);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3130FC0", Offset = "0x312F5C0", VA = "0x183130FC0")]
		public GameSettings()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[JsonProperty]
		private List<PersistentValue> _settings;
	}
}
