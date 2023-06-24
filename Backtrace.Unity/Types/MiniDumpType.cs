using System;
using Il2CppDummyDll;

namespace Backtrace.Unity.Types
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public enum MiniDumpType : uint
	{
		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		None = 524286U,
		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		Normal = 0U,
		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		WithDataSegs,
		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		WithFullMemory,
		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		WithHandleData = 4U,
		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		FilterMemory = 8U,
		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		ScanMemory = 16U,
		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		WithUnloadedModules = 32U,
		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		WithIndirectlyReferencedMemory = 64U,
		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		FilterModulePaths = 128U,
		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		WithProcessThreadData = 256U,
		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		WithPrivateReadWriteMemory = 512U,
		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		WithoutOptionalData = 1024U,
		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		WithFullMemoryInfo = 2048U,
		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		WithThreadInfo = 4096U,
		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		WithCodeSegs = 8192U,
		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		WithoutAuxiliaryState = 16384U,
		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		WithFullAuxiliaryState = 32768U,
		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		WithPrivateWriteCopyMemory = 65536U,
		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		IgnoreInaccessibleMemory = 131072U,
		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		ValidTypeFlags = 262143U
	}
}
