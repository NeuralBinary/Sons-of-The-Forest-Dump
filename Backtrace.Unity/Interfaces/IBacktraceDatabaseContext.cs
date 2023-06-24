using System;
using System.Collections.Generic;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Database;
using Backtrace.Unity.Types;
using Il2CppDummyDll;

namespace Backtrace.Unity.Interfaces
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	public interface IBacktraceDatabaseContext : IDisposable
	{
		// Token: 0x06000344 RID: 836
		[Token(Token = "0x6000344")]
		BacktraceDatabaseRecord Add(BacktraceDatabaseRecord backtraceDatabaseRecord);

		// Token: 0x06000345 RID: 837
		[Token(Token = "0x6000345")]
		BacktraceDatabaseRecord FirstOrDefault();

		// Token: 0x06000346 RID: 838
		[Token(Token = "0x6000346")]
		BacktraceDatabaseRecord FirstOrDefault(Func<BacktraceDatabaseRecord, bool> predicate);

		// Token: 0x06000347 RID: 839
		[Token(Token = "0x6000347")]
		BacktraceDatabaseRecord LastOrDefault();

		// Token: 0x06000348 RID: 840
		[Token(Token = "0x6000348")]
		IEnumerable<BacktraceDatabaseRecord> Get();

		// Token: 0x06000349 RID: 841
		[Token(Token = "0x6000349")]
		void Delete(BacktraceDatabaseRecord record);

		// Token: 0x0600034A RID: 842
		[Token(Token = "0x600034A")]
		bool Any(BacktraceDatabaseRecord n);

		// Token: 0x0600034B RID: 843
		[Token(Token = "0x600034B")]
		bool Any();

		// Token: 0x0600034C RID: 844
		[Token(Token = "0x600034C")]
		int Count();

		// Token: 0x0600034D RID: 845
		[Token(Token = "0x600034D")]
		void Clear();

		// Token: 0x0600034E RID: 846
		[Token(Token = "0x600034E")]
		void IncrementBatchRetry();

		// Token: 0x0600034F RID: 847
		[Token(Token = "0x600034F")]
		long GetSize();

		// Token: 0x06000350 RID: 848
		[Token(Token = "0x6000350")]
		[Obsolete("Please use Count method instead")]
		int GetTotalNumberOfRecords();

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000351 RID: 849
		// (set) Token: 0x06000352 RID: 850
		[Token(Token = "0x1700009D")]
		DeduplicationStrategy DeduplicationStrategy { [Token(Token = "0x6000351")] get; [Token(Token = "0x6000352")] set; }

		// Token: 0x06000353 RID: 851
		[Token(Token = "0x6000353")]
		IEnumerable<BacktraceDatabaseRecord> GetRecordsToDelete();

		// Token: 0x06000354 RID: 852
		[Token(Token = "0x6000354")]
		string GetHash(BacktraceData backtraceData);

		// Token: 0x06000355 RID: 853
		[Token(Token = "0x6000355")]
		BacktraceDatabaseRecord GetRecordByHash(string hash);

		// Token: 0x06000356 RID: 854
		[Token(Token = "0x6000356")]
		void AddDuplicate(BacktraceDatabaseRecord record);
	}
}
