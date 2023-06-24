using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	public static class Localization
	{
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EE")]
		public static Dictionary<string, string[]> dictionary
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x266B7A0", Offset = "0x2669DA0", VA = "0x18266B7A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x266B8C0", Offset = "0x2669EC0", VA = "0x18266B8C0")]
			set
			{
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000EF")]
		public static string[] knownLanguages
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x266B990", Offset = "0x2669F90", VA = "0x18266B990")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F0")]
		public static string language
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x266BAB0", Offset = "0x266A0B0", VA = "0x18266BAB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x266BC50", Offset = "0x266A250", VA = "0x18266BC50")]
			set
			{
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x266BD70", Offset = "0x266A370", VA = "0x18266BD70")]
		private static bool LoadDictionary(string value)
		{
			return default(bool);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x266C1D0", Offset = "0x266A7D0", VA = "0x18266C1D0")]
		private static bool LoadAndSelect(string value)
		{
			return default(bool);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x266C380", Offset = "0x266A980", VA = "0x18266C380")]
		public static void Load(TextAsset asset)
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x266C4B0", Offset = "0x266AAB0", VA = "0x18266C4B0")]
		public static void Set(string languageName, byte[] bytes)
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x266C580", Offset = "0x266AB80", VA = "0x18266C580")]
		public static void ReplaceKey(string key, string val)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x266C690", Offset = "0x266AC90", VA = "0x18266C690")]
		public static void ClearReplacements()
		{
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x266C710", Offset = "0x266AD10", VA = "0x18266C710")]
		public static bool LoadCSV(TextAsset asset, bool merge = false)
		{
			return default(bool);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x266C7D0", Offset = "0x266ADD0", VA = "0x18266C7D0")]
		public static bool LoadCSV(byte[] bytes, bool merge = false)
		{
			return default(bool);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x266C830", Offset = "0x266AE30", VA = "0x18266C830")]
		private static bool HasLanguage(string languageName)
		{
			return default(bool);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x266C940", Offset = "0x266AF40", VA = "0x18266C940")]
		private static bool LoadCSV(byte[] bytes, TextAsset asset, bool merge = false)
		{
			return default(bool);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x266D670", Offset = "0x266BC70", VA = "0x18266D670")]
		private static void AddCSV(BetterList<string> newValues, string[] newLanguages, Dictionary<string, int> languageIndices)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x266D970", Offset = "0x266BF70", VA = "0x18266D970")]
		private static string[] ExtractStrings(BetterList<string> added, string[] newLanguages, Dictionary<string, int> languageIndices)
		{
			return null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x266DD30", Offset = "0x266C330", VA = "0x18266DD30")]
		private static bool SelectLanguage(string language)
		{
			return default(bool);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x266DFD0", Offset = "0x266C5D0", VA = "0x18266DFD0")]
		public static void Set(string languageName, Dictionary<string, string> dictionary)
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x266E290", Offset = "0x266C890", VA = "0x18266E290")]
		public static void Set(string key, string value)
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x266E400", Offset = "0x266CA00", VA = "0x18266E400")]
		public static string Get(string key)
		{
			return null;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x266ECE0", Offset = "0x266D2E0", VA = "0x18266ECE0")]
		public static string Format(string key, params object[] parameters)
		{
			return null;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x170000F1")]
		[Obsolete("Localization is now always active. You no longer need to check this property.")]
		public static bool isActive
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x266ED50", Offset = "0x266D350", VA = "0x18266ED50")]
		[Obsolete("Use Localization.Get instead")]
		public static string Localize(string key)
		{
			return null;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x266EDA0", Offset = "0x266D3A0", VA = "0x18266EDA0")]
		public static bool Exists(string key)
		{
			return default(bool);
		}

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x0")]
		public static Localization.LoadFunction loadFunction;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x8")]
		public static Localization.OnLocalizeNotification onLocalize;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x10")]
		public static bool localizationHasBeenSet;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x18")]
		private static string[] mLanguages;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x20")]
		private static Dictionary<string, string> mOldDictionary;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x28")]
		private static Dictionary<string, string[]> mDictionary;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x30")]
		private static Dictionary<string, string> mReplacement;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x38")]
		private static int mLanguageIndex;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x40")]
		private static string mLanguage;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x48")]
		private static bool mMerging;

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060003E4 RID: 996
		[Token(Token = "0x200006C")]
		public delegate byte[] LoadFunction(string path);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060003E8 RID: 1000
		[Token(Token = "0x200006D")]
		public delegate void OnLocalizeNotification();
	}
}
