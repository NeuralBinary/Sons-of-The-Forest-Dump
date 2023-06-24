using System;
using System.Collections.Generic;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Breadcrumbs;
using Backtrace.Unity.Model.Database;
using Backtrace.Unity.Services;
using Backtrace.Unity.Types;
using Il2CppDummyDll;

namespace Backtrace.Unity.Interfaces
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public interface IBacktraceDatabase
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000331 RID: 817
		// (set) Token: 0x06000332 RID: 818
		[Token(Token = "0x1700009A")]
		int ScreenshotQuality { [Token(Token = "0x6000331")] get; [Token(Token = "0x6000332")] set; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000333 RID: 819
		// (set) Token: 0x06000334 RID: 820
		[Token(Token = "0x1700009B")]
		int ScreenshotMaxHeight { [Token(Token = "0x6000333")] get; [Token(Token = "0x6000334")] set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000335 RID: 821
		[Token(Token = "0x1700009C")]
		IBacktraceBreadcrumbs Breadcrumbs { [Token(Token = "0x6000335")] get; }

		// Token: 0x06000336 RID: 822
		[Token(Token = "0x6000336")]
		void Flush();

		// Token: 0x06000337 RID: 823
		[Token(Token = "0x6000337")]
		void SetApi(IBacktraceApi backtraceApi);

		// Token: 0x06000338 RID: 824
		[Token(Token = "0x6000338")]
		void Clear();

		// Token: 0x06000339 RID: 825
		[Token(Token = "0x6000339")]
		bool ValidConsistency();

		// Token: 0x0600033A RID: 826
		[Token(Token = "0x600033A")]
		[Obsolete("Please use Add method with Backtrace data parameter instead")]
		BacktraceDatabaseRecord Add(BacktraceReport backtraceReport, Dictionary<string, string> attributes, MiniDumpType miniDumpType = MiniDumpType.Normal);

		// Token: 0x0600033B RID: 827
		[Token(Token = "0x600033B")]
		IEnumerable<BacktraceDatabaseRecord> Get();

		// Token: 0x0600033C RID: 828
		[Token(Token = "0x600033C")]
		void Delete(BacktraceDatabaseRecord record);

		// Token: 0x0600033D RID: 829
		[Token(Token = "0x600033D")]
		BacktraceDatabaseSettings GetSettings();

		// Token: 0x0600033E RID: 830
		[Token(Token = "0x600033E")]
		long GetDatabaseSize();

		// Token: 0x0600033F RID: 831
		[Token(Token = "0x600033F")]
		void SetReportWatcher(ReportLimitWatcher reportLimitWatcher);

		// Token: 0x06000340 RID: 832
		[Token(Token = "0x6000340")]
		void Reload();

		// Token: 0x06000341 RID: 833
		[Token(Token = "0x6000341")]
		BacktraceDatabaseRecord Add(BacktraceData data, bool @lock = true);

		// Token: 0x06000342 RID: 834
		[Token(Token = "0x6000342")]
		bool Enabled();

		// Token: 0x06000343 RID: 835
		[Token(Token = "0x6000343")]
		bool EnableBreadcrumbsSupport();
	}
}
