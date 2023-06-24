using System;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Breadcrumbs
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	[Flags]
	public enum BacktraceBreadcrumbType
	{
		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		None = 0,
		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		Manual = 1,
		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		Log = 2,
		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		Navigation = 4,
		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		Http = 8,
		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		System = 16,
		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		User = 32,
		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		Configuration = 64
	}
}
