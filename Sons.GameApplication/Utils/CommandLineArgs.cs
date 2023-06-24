using System;
using System.Collections.Generic;
using CommandLine;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Utils
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public static class CommandLineArgs
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2FE8830", Offset = "0x2FE6E30", VA = "0x182FE8830")]
		public static CommandLineArgs.Options GetOptions()
		{
			return null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2FE8880", Offset = "0x2FE6E80", VA = "0x182FE8880")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void ProcessArgs()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2FE8C50", Offset = "0x2FE7250", VA = "0x182FE8C50")]
		private static void NotParsedOptions(IEnumerable<Error> obj)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2FE8F70", Offset = "0x2FE7570", VA = "0x182FE8F70")]
		private static void ProcessOptions(CommandLineArgs.Options o)
		{
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x0")]
		private static CommandLineArgs.Options _options;

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x200000A")]
		public class Options
		{
			// Token: 0x17000002 RID: 2
			// (get) Token: 0x0600001E RID: 30 RVA: 0x0000206C File Offset: 0x0000026C
			// (set) Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000002")]
			[Option("screen-width", Required = false, HelpText = "Set screen width")]
			public int ScreenWidth
			{
				[Token(Token = "0x600001E")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600001F")]
				[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
				set
				{
				}
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000020 RID: 32 RVA: 0x00002084 File Offset: 0x00000284
			// (set) Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000003")]
			[Option("screen-height", Required = false, HelpText = "Set screen height")]
			public int ScreenHeight
			{
				[Token(Token = "0x6000020")]
				[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000021")]
				[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
				set
				{
				}
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000022 RID: 34 RVA: 0x0000209C File Offset: 0x0000029C
			// (set) Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000004")]
			[Option('l', "logging", Required = false, HelpText = "Set output to log messages.")]
			public bool Logging
			{
				[Token(Token = "0x6000022")]
				[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000023")]
				[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
				set
				{
				}
			}

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000024 RID: 36 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000005")]
			[Option("testName", Required = false, HelpText = "Test name to run.")]
			public string TestCommand
			{
				[Token(Token = "0x6000024")]
				[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000025")]
				[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
				set
				{
				}
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000026 RID: 38 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000006")]
			[Option("testArgs", Required = false, HelpText = "Test arguments to use")]
			public string TestArgs
			{
				[Token(Token = "0x6000026")]
				[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000027")]
				[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
				set
				{
				}
			}

			// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2FE9140", Offset = "0x2FE7740", VA = "0x182FE9140")]
			public Options()
			{
			}

			// Token: 0x04000018 RID: 24
			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x10")]
			private int _screenWidth;

			// Token: 0x04000019 RID: 25
			[Token(Token = "0x4000019")]
			public const string ScreenWidthName = "screen-width";

			// Token: 0x0400001A RID: 26
			[Token(Token = "0x400001A")]
			public const string ScreenWidthHelp = "Set screen width";

			// Token: 0x0400001B RID: 27
			[Token(Token = "0x400001B")]
			[FieldOffset(Offset = "0x14")]
			private int _screenHeight;

			// Token: 0x0400001C RID: 28
			[Token(Token = "0x400001C")]
			public const string ScreenHeightName = "screen-height";

			// Token: 0x0400001D RID: 29
			[Token(Token = "0x400001D")]
			public const string ScreenHeightHelp = "Set screen height";

			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400001E")]
			[FieldOffset(Offset = "0x18")]
			private bool _logging;

			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400001F")]
			public const char LoggingShortName = 'l';

			// Token: 0x04000020 RID: 32
			[Token(Token = "0x4000020")]
			public const string LoggingName = "logging";

			// Token: 0x04000021 RID: 33
			[Token(Token = "0x4000021")]
			public const string LoggingHelp = "Set output to log messages.";

			// Token: 0x04000022 RID: 34
			[Token(Token = "0x4000022")]
			[FieldOffset(Offset = "0x20")]
			private string _testName;

			// Token: 0x04000023 RID: 35
			[Token(Token = "0x4000023")]
			public const string TestNameName = "testName";

			// Token: 0x04000024 RID: 36
			[Token(Token = "0x4000024")]
			public const string TestNameHelp = "Test name to run.";

			// Token: 0x04000025 RID: 37
			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x28")]
			private string _testArgs;

			// Token: 0x04000026 RID: 38
			[Token(Token = "0x4000026")]
			public const string TestArgsName = "testArgs";

			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			public const string TestArgsHelp = "Test arguments to use";
		}
	}
}
