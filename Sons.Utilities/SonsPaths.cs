using System;
using Il2CppDummyDll;

namespace Sons.Utilities
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public static class SonsPaths
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000003")]
		public static string UserData
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x315F940", Offset = "0x315DF40", VA = "0x18315F940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000004")]
		public static string OwnersWhitelist
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x315F9E0", Offset = "0x315DFE0", VA = "0x18315F9E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000005")]
		public static string GameSettings
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x315FA80", Offset = "0x315E080", VA = "0x18315FA80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000006")]
		public static string DsLogs
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x315FB20", Offset = "0x315E120", VA = "0x18315FB20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x315FBC0", Offset = "0x315E1C0", VA = "0x18315FBC0")]
		private static string InitializeUserDataPath()
		{
			return null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x315FFE0", Offset = "0x315E5E0", VA = "0x18315FFE0")]
		public static bool SafeCreateDirectory(string path, out string fullPath)
		{
			return default(bool);
		}

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Lazy<string> _userData;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Lazy<string> _ownersWhitelist;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Lazy<string> _dsLogs;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Lazy<string> _gameSettings;
	}
}
