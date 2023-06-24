using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Breadcrumbs;
using Il2CppDummyDll;

namespace Backtrace.Unity.Interfaces
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	public interface IBacktraceClient
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000327 RID: 807
		[Token(Token = "0x17000098")]
		IBacktraceBreadcrumbs Breadcrumbs { [Token(Token = "0x6000327")] get; }

		// Token: 0x06000328 RID: 808
		[Token(Token = "0x6000328")]
		void Send(BacktraceReport report, Action<BacktraceResult> sendCallback);

		// Token: 0x06000329 RID: 809
		[Token(Token = "0x6000329")]
		void Send(string message, [Optional] List<string> attachmentPaths, [Optional] Dictionary<string, string> attributes);

		// Token: 0x0600032A RID: 810
		[Token(Token = "0x600032A")]
		void Send(Exception exception, [Optional] List<string> attachmentPaths, [Optional] Dictionary<string, string> attributes);

		// Token: 0x0600032B RID: 811
		[Token(Token = "0x600032B")]
		void SetClientReportLimit(uint reportPerMin);

		// Token: 0x0600032C RID: 812
		[Token(Token = "0x600032C")]
		void Refresh();

		// Token: 0x0600032D RID: 813
		[Token(Token = "0x600032D")]
		bool EnableBreadcrumbsSupport();

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600032E RID: 814
		[Token(Token = "0x17000099")]
		IBacktraceMetrics Metrics { [Token(Token = "0x600032E")] get; }

		// Token: 0x0600032F RID: 815
		[Token(Token = "0x600032F")]
		bool EnableMetrics();

		// Token: 0x06000330 RID: 816
		[Token(Token = "0x6000330")]
		bool EnableMetrics(string uniqueEventsSubmissionUrl, string summedEventsSubmissionUrl, uint timeIntervalInSec, string uniqueEventName);
	}
}
