using System;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Breadcrumbs
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	public enum BreadcrumbLevel
	{
		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		Manual = 1,
		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		Log,
		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		Navigation = 4,
		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		Http = 8,
		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		System = 16,
		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		User = 32,
		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		Configuration = 64
	}
}
