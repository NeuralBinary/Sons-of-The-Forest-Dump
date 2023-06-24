using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Interfaces;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Database;
using Backtrace.Unity.Types;
using Il2CppDummyDll;

namespace Backtrace.Unity.Services
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	internal class BacktraceDatabaseContext : IBacktraceDatabaseContext, IDisposable
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002B")]
		internal IDictionary<int, List<BacktraceDatabaseRecord>> BatchRetry
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000023B4 File Offset: 0x000005B4
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002C")]
		internal RetryOrder RetryOrder
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			[CompilerGenerated]
			get
			{
				return RetryOrder.Stack;
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000023CC File Offset: 0x000005CC
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002D")]
		public DeduplicationStrategy DeduplicationStrategy
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return DeduplicationStrategy.None;
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x674030", Offset = "0x672630", VA = "0x180674030", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x741490", Offset = "0x73FA90", VA = "0x180741490")]
		public BacktraceDatabaseContext(BacktraceDatabaseSettings settings)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x7415B0", Offset = "0x73FBB0", VA = "0x1807415B0")]
		private void SetupBatch()
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x7417E0", Offset = "0x73FDE0", VA = "0x1807417E0", Slot = "20")]
		public string GetHash(BacktraceData backtraceData)
		{
			return null;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x7418F0", Offset = "0x73FEF0", VA = "0x1807418F0", Slot = "21")]
		public BacktraceDatabaseRecord GetRecordByHash(string hash)
		{
			return null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x741A90", Offset = "0x740090", VA = "0x180741A90", Slot = "4")]
		public BacktraceDatabaseRecord Add(BacktraceDatabaseRecord backtraceRecord)
		{
			return null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x741BC0", Offset = "0x7401C0", VA = "0x180741BC0", Slot = "10")]
		public bool Any(BacktraceDatabaseRecord record)
		{
			return default(bool);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x741E00", Offset = "0x740400", VA = "0x180741E00", Slot = "11")]
		public bool Any()
		{
			return default(bool);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x741E10", Offset = "0x740410", VA = "0x180741E10", Slot = "9")]
		public void Delete(BacktraceDatabaseRecord record)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x742060", Offset = "0x740660", VA = "0x180742060", Slot = "14")]
		public void IncrementBatchRetry()
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x742130", Offset = "0x740730", VA = "0x180742130")]
		private void IncrementBatches()
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x7423A0", Offset = "0x7409A0", VA = "0x1807423A0")]
		private void RemoveMaxRetries()
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x742470", Offset = "0x740A70", VA = "0x180742470", Slot = "8")]
		public IEnumerable<BacktraceDatabaseRecord> Get()
		{
			return null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x7425C0", Offset = "0x740BC0", VA = "0x1807425C0", Slot = "12")]
		public int Count()
		{
			return 0;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x7426D0", Offset = "0x740CD0", VA = "0x1807426D0", Slot = "23")]
		public void Dispose()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x742730", Offset = "0x740D30", VA = "0x180742730", Slot = "13")]
		public void Clear()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x742930", Offset = "0x740F30", VA = "0x180742930", Slot = "7")]
		public BacktraceDatabaseRecord LastOrDefault()
		{
			return null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x742950", Offset = "0x740F50", VA = "0x180742950", Slot = "5")]
		public BacktraceDatabaseRecord FirstOrDefault()
		{
			return null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x742970", Offset = "0x740F70", VA = "0x180742970", Slot = "6")]
		public BacktraceDatabaseRecord FirstOrDefault(Func<BacktraceDatabaseRecord, bool> predicate)
		{
			return null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x742AF0", Offset = "0x7410F0", VA = "0x180742AF0")]
		private BacktraceDatabaseRecord GetFirstRecord()
		{
			return null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x742D90", Offset = "0x741390", VA = "0x180742D90")]
		private BacktraceDatabaseRecord GetLastRecord()
		{
			return null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "15")]
		public long GetSize()
		{
			return 0L;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x7425C0", Offset = "0x740BC0", VA = "0x1807425C0", Slot = "16")]
		public int GetTotalNumberOfRecords()
		{
			return 0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x743000", Offset = "0x741600", VA = "0x180743000", Slot = "19")]
		public IEnumerable<BacktraceDatabaseRecord> GetRecordsToDelete()
		{
			return null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x743050", Offset = "0x741650", VA = "0x180743050", Slot = "22")]
		public void AddDuplicate(BacktraceDatabaseRecord record)
		{
		}

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x18")]
		internal long TotalSize;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x20")]
		internal int TotalRecords;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x24")]
		private readonly int _retryNumber;
	}
}
