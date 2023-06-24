using System;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Breadcrumbs
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	[Flags]
	public enum UnityEngineLogLevel
	{
		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		None = 0,
		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		Debug = 1,
		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		Warning = 2,
		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		Info = 4,
		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		Fatal = 8,
		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		Error = 16
	}
}
