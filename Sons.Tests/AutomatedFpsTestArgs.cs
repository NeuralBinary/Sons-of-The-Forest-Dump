using System;
using CommandLine;
using Il2CppDummyDll;

namespace Sons.Tests
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	internal class AutomatedFpsTestArgs : TestArgs
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000209C File Offset: 0x0000029C
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000003")]
		[Option("SampleTime", Required = false, HelpText = "Timer used when samlping FPS")]
		public float SampleTime
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0xA308C0", Offset = "0xA2EEC0", VA = "0x180A308C0")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000004")]
		[Option("RunCommand", Required = false, HelpText = "Command to run before executing test")]
		public string RunCommand
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			set
			{
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x314A320", Offset = "0x3148920", VA = "0x18314A320")]
		public AutomatedFpsTestArgs()
		{
		}

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		private float _sampleTime;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		public const string SampleTimeName = "SampleTime";

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		public const string SampleTimeHelp = "Timer used when samlping FPS";

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x20")]
		private string _runCommand;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		public const string RunCommandName = "RunCommand";

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		public const string RunCommandHelp = "Command to run before executing test";
	}
}
