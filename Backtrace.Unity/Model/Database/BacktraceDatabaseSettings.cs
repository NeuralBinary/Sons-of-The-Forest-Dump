using System;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Types;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Database
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public class BacktraceDatabaseSettings
	{
		// Token: 0x0600026B RID: 619 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x75D040", Offset = "0x75B640", VA = "0x18075D040")]
		public BacktraceDatabaseSettings(string databasePath, BacktraceConfiguration configuration)
		{
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007A")]
		public string DatabasePath
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00002AEC File Offset: 0x00000CEC
		[Token(Token = "0x1700007B")]
		public uint MaxRecordCount
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x75D210", Offset = "0x75B810", VA = "0x18075D210")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00002B04 File Offset: 0x00000D04
		[Token(Token = "0x1700007C")]
		public long MaxDatabaseSize
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x75D2A0", Offset = "0x75B8A0", VA = "0x18075D2A0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00002B1C File Offset: 0x00000D1C
		[Token(Token = "0x1700007D")]
		public bool AutoSendMode
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x75D2D0", Offset = "0x75B8D0", VA = "0x18075D2D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x1700007E")]
		public uint RetryInterval
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x1700007F")]
		public uint RetryLimit
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x75D2F0", Offset = "0x75B8F0", VA = "0x18075D2F0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x17000080")]
		public DeduplicationStrategy DeduplicationStrategy
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x75D380", Offset = "0x75B980", VA = "0x18075D380")]
			get
			{
				return DeduplicationStrategy.None;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x17000081")]
		public bool GenerateScreenshotOnException
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x75D3A0", Offset = "0x75B9A0", VA = "0x18075D3A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00002B94 File Offset: 0x00000D94
		[Token(Token = "0x17000082")]
		public bool AddUnityLogToReport
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x75D3C0", Offset = "0x75B9C0", VA = "0x18075D3C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00002BAC File Offset: 0x00000DAC
		[Token(Token = "0x17000083")]
		public RetryOrder RetryOrder
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x75D3E0", Offset = "0x75B9E0", VA = "0x18075D3E0")]
			get
			{
				return RetryOrder.Stack;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Token(Token = "0x17000084")]
		public MiniDumpType MinidumpType
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x75D400", Offset = "0x75BA00", VA = "0x18075D400")]
			get
			{
				return MiniDumpType.Normal;
			}
		}

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x10")]
		private readonly BacktraceConfiguration _configuration;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x18")]
		private readonly uint _retryInterval;
	}
}
