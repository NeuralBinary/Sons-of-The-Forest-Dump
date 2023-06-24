using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000110 RID: 272
	[Token(Token = "0x2000110")]
	[NullableContext(1)]
	public interface ITraceWriter
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060007C8 RID: 1992
		[Token(Token = "0x170000F8")]
		TraceLevel LevelFilter { [Token(Token = "0x60007C8")] get; }

		// Token: 0x060007C9 RID: 1993
		[Token(Token = "0x60007C9")]
		void Trace(TraceLevel level, string message, [Nullable(2)] Exception ex);
	}
}
