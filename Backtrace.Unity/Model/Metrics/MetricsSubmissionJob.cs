using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Metrics
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	internal sealed class MetricsSubmissionJob<T>
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000296C File Offset: 0x00000B6C
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005C")]
		public double NextInvokeTime
		{
			[Token(Token = "0x60001F1")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60001F2")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005D")]
		public ICollection<T> Events
		{
			[Token(Token = "0x60001F3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F4")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00002984 File Offset: 0x00000B84
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005E")]
		public uint NumberOfAttempts
		{
			[Token(Token = "0x60001F5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60001F6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F7")]
		public MetricsSubmissionJob()
		{
		}
	}
}
