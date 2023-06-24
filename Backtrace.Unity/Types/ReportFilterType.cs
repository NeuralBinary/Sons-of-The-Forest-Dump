using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Backtrace.Unity.Types
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[Flags]
	public enum ReportFilterType
	{
		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[Tooltip("Disable report filtering.")]
		[InspectorName("Disable")]
		None = 0,
		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[Tooltip("String message report.")]
		Message = 1,
		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[InspectorName("Handled exception")]
		[Tooltip("Handled exception.")]
		Exception = 2,
		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[Tooltip("Game unhandled exception.")]
		[InspectorName("Unhandled exception")]
		UnhandledException = 4,
		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[Tooltip("Game hang.")]
		Hang = 8,
		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[InspectorName("Game error")]
		[Tooltip("Game error.")]
		Error = 16
	}
}
