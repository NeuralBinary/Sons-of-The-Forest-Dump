using System;
using System.Collections.Generic;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Breadcrumbs;
using Il2CppDummyDll;

namespace Backtrace.Unity.Runtime.Native
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	internal static class NativeClientFactory
	{
		// Token: 0x0600011F RID: 287 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x747170", Offset = "0x745770", VA = "0x180747170")]
		internal static INativeClient CreateNativeClient(BacktraceConfiguration configuration, string gameObjectName, BacktraceBreadcrumbs breadcrumbs, IDictionary<string, string> attributes, ICollection<string> attachments)
		{
			return null;
		}
	}
}
