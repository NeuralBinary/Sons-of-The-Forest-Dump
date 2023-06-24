using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public class BacktraceCredentials
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003B")]
		public Uri BacktraceHostUri
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x74B010", Offset = "0x749610", VA = "0x18074B010")]
		public Uri GetSubmissionUrl()
		{
			return null;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x74B0D0", Offset = "0x7496D0", VA = "0x18074B0D0")]
		public Uri GetPlCrashReporterSubmissionUrl()
		{
			return null;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x74B200", Offset = "0x749800", VA = "0x18074B200")]
		public Uri GetMinidumpSubmissionUrl()
		{
			return null;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x74B330", Offset = "0x749930", VA = "0x18074B330")]
		public Uri GetSymbolsSubmissionUrl(string token)
		{
			return null;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x74B5E0", Offset = "0x749BE0", VA = "0x18074B5E0")]
		public BacktraceCredentials(string backtraceSubmitUrl)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public BacktraceCredentials(Uri backtraceSubmitUrl)
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x74B6A0", Offset = "0x749CA0", VA = "0x18074B6A0")]
		internal bool IsValid(Uri uri, byte[] token)
		{
			return default(bool);
		}
	}
}
