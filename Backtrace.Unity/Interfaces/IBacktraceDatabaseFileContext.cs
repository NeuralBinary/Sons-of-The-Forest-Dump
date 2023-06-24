using System;
using System.Collections.Generic;
using System.IO;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Database;
using Il2CppDummyDll;

namespace Backtrace.Unity.Interfaces
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	internal interface IBacktraceDatabaseFileContext
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000357 RID: 855
		// (set) Token: 0x06000358 RID: 856
		[Token(Token = "0x1700009E")]
		int ScreenshotQuality { [Token(Token = "0x6000357")] get; [Token(Token = "0x6000358")] set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000359 RID: 857
		// (set) Token: 0x0600035A RID: 858
		[Token(Token = "0x1700009F")]
		int ScreenshotMaxHeight { [Token(Token = "0x6000359")] get; [Token(Token = "0x600035A")] set; }

		// Token: 0x0600035B RID: 859
		[Token(Token = "0x600035B")]
		IEnumerable<FileInfo> GetRecords();

		// Token: 0x0600035C RID: 860
		[Token(Token = "0x600035C")]
		IEnumerable<FileInfo> GetAll();

		// Token: 0x0600035D RID: 861
		[Token(Token = "0x600035D")]
		bool ValidFileConsistency();

		// Token: 0x0600035E RID: 862
		[Token(Token = "0x600035E")]
		void RemoveOrphaned(IEnumerable<BacktraceDatabaseRecord> existingRecords);

		// Token: 0x0600035F RID: 863
		[Token(Token = "0x600035F")]
		void Clear();

		// Token: 0x06000360 RID: 864
		[Token(Token = "0x6000360")]
		void Delete(BacktraceDatabaseRecord record);

		// Token: 0x06000361 RID: 865
		[Token(Token = "0x6000361")]
		IEnumerable<string> GenerateRecordAttachments(BacktraceData data);

		// Token: 0x06000362 RID: 866
		[Token(Token = "0x6000362")]
		bool Save(BacktraceDatabaseRecord record);

		// Token: 0x06000363 RID: 867
		[Token(Token = "0x6000363")]
		bool IsValidRecord(BacktraceDatabaseRecord record);
	}
}
