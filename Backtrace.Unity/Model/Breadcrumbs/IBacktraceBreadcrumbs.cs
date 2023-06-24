using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Backtrace.Unity.Model.Breadcrumbs
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	public interface IBacktraceBreadcrumbs
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002A8 RID: 680
		[Token(Token = "0x17000088")]
		BacktraceBreadcrumbType BreadcrumbsLevel { [Token(Token = "0x60002A8")] get; }

		// Token: 0x060002A9 RID: 681
		[Token(Token = "0x60002A9")]
		bool EnableBreadcrumbs();

		// Token: 0x060002AA RID: 682
		[Token(Token = "0x60002AA")]
		[Obsolete("Please use EnableBreadcrumbs instead. This function will be removed in the future updates")]
		bool EnableBreadcrumbs(BacktraceBreadcrumbType level, UnityEngineLogLevel unityLogLevel);

		// Token: 0x060002AB RID: 683
		[Token(Token = "0x60002AB")]
		bool ClearBreadcrumbs();

		// Token: 0x060002AC RID: 684
		[Token(Token = "0x60002AC")]
		bool Log(string message, LogType type, IDictionary<string, string> attributes);

		// Token: 0x060002AD RID: 685
		[Token(Token = "0x60002AD")]
		bool Log(string message, LogType type);

		// Token: 0x060002AE RID: 686
		[Token(Token = "0x60002AE")]
		bool Debug(string message);

		// Token: 0x060002AF RID: 687
		[Token(Token = "0x60002AF")]
		bool Debug(string message, IDictionary<string, string> attributes);

		// Token: 0x060002B0 RID: 688
		[Token(Token = "0x60002B0")]
		bool Info(string message);

		// Token: 0x060002B1 RID: 689
		[Token(Token = "0x60002B1")]
		bool Info(string message, IDictionary<string, string> attributes);

		// Token: 0x060002B2 RID: 690
		[Token(Token = "0x60002B2")]
		bool Warning(string message);

		// Token: 0x060002B3 RID: 691
		[Token(Token = "0x60002B3")]
		bool Warning(string message, IDictionary<string, string> attributes);

		// Token: 0x060002B4 RID: 692
		[Token(Token = "0x60002B4")]
		bool Exception(Exception exception);

		// Token: 0x060002B5 RID: 693
		[Token(Token = "0x60002B5")]
		bool Exception(Exception exception, IDictionary<string, string> attributes);

		// Token: 0x060002B6 RID: 694
		[Token(Token = "0x60002B6")]
		bool Exception(string message);

		// Token: 0x060002B7 RID: 695
		[Token(Token = "0x60002B7")]
		bool Exception(string message, IDictionary<string, string> attributes);

		// Token: 0x060002B8 RID: 696
		[Token(Token = "0x60002B8")]
		bool FromBacktrace(BacktraceReport report);

		// Token: 0x060002B9 RID: 697
		[Token(Token = "0x60002B9")]
		bool FromMonoBehavior(string message, LogType type, IDictionary<string, string> attributes);

		// Token: 0x060002BA RID: 698
		[Token(Token = "0x60002BA")]
		string GetBreadcrumbLogPath();

		// Token: 0x060002BB RID: 699
		[Token(Token = "0x60002BB")]
		double BreadcrumbId();

		// Token: 0x060002BC RID: 700
		[Token(Token = "0x60002BC")]
		void UnregisterEvents();

		// Token: 0x060002BD RID: 701
		[Token(Token = "0x60002BD")]
		void Update();

		// Token: 0x060002BE RID: 702
		[Token(Token = "0x60002BE")]
		string Archive();
	}
}
