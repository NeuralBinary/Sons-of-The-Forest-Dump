using System;
using Backtrace.Unity.Types;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[Serializable]
	public class BacktraceDatabaseConfiguration : BacktraceClientConfiguration
	{
		// Token: 0x0600016C RID: 364 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x74C470", Offset = "0x74AA70", VA = "0x18074C470")]
		public bool ValidDatabasePath()
		{
			return default(bool);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x74C5E0", Offset = "0x74ABE0", VA = "0x18074C5E0")]
		public BacktraceDatabaseConfiguration()
		{
		}

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x38")]
		public bool Enabled;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x40")]
		public string DatabasePath;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x48")]
		public bool AutoSendMode;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x49")]
		public bool CreateDatabase;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x4A")]
		public bool GenerateScreenshotOnException;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x4C")]
		public DeduplicationStrategy DeduplicationStrategy;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x50")]
		public int MaxRecordCount;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x58")]
		public long MaxDatabaseSize;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x60")]
		public int RetryInterval;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x64")]
		public int RetryLimit;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x68")]
		public RetryOrder RetryOrder;
	}
}
