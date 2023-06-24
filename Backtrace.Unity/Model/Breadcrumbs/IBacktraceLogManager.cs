using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Breadcrumbs
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	internal interface IBacktraceLogManager
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002BF RID: 703
		[Token(Token = "0x17000089")]
		string BreadcrumbsFilePath { [Token(Token = "0x60002BF")] get; }

		// Token: 0x060002C0 RID: 704
		[Token(Token = "0x60002C0")]
		bool Add(string message, BreadcrumbLevel level, UnityEngineLogLevel type, IDictionary<string, string> attributes);

		// Token: 0x060002C1 RID: 705
		[Token(Token = "0x60002C1")]
		bool Clear();

		// Token: 0x060002C2 RID: 706
		[Token(Token = "0x60002C2")]
		bool Enable();

		// Token: 0x060002C3 RID: 707
		[Token(Token = "0x60002C3")]
		int Length();

		// Token: 0x060002C4 RID: 708
		[Token(Token = "0x60002C4")]
		double BreadcrumbId();
	}
}
