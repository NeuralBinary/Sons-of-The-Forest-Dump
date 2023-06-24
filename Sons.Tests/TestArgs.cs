using System;
using CommandLine;
using Il2CppDummyDll;

namespace Sons.Tests
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	internal class TestArgs
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00002594 File Offset: 0x00000794
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003D")]
		[Option("ShutdownOnComplete", Required = false, HelpText = "Close game when finished")]
		public bool ShutdownOnComplete
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
			set
			{
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TestArgs()
		{
		}

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x10")]
		private bool _shutdownOnComplete;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		public const string ShutdownOnCompleteName = "ShutdownOnComplete";

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		public const string ShutdownOnCompleteHelp = "Close game when finished";
	}
}
