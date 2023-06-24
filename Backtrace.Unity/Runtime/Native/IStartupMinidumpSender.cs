using System;
using System.Collections;
using System.Collections.Generic;
using Backtrace.Unity.Interfaces;
using Il2CppDummyDll;

namespace Backtrace.Unity.Runtime.Native
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	internal interface IStartupMinidumpSender
	{
		// Token: 0x0600011E RID: 286
		[Token(Token = "0x600011E")]
		IEnumerator SendMinidumpOnStartup(ICollection<string> clientAttachments, IBacktraceApi backtraceApi);
	}
}
