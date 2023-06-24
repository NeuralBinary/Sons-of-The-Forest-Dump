using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Backtrace.Unity.Types
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[Flags]
	public enum DeduplicationStrategy
	{
		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[Tooltip("Deduplication rules are disabled.")]
		[InspectorName("Disable")]
		None = 0,
		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[Tooltip("Faulting callstack - use the faulting callstack as a factor in client-side rate limiting.")]
		[InspectorName("Faulting callstack")]
		Default = 1,
		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[Tooltip("Unity by default will validate ssl certificates. By using this option you can avoid ssl certificates validation. However, if you don't need to ignore ssl validation, please set this option to false.", order = 0)]
		[InspectorName("Exception type")]
		Classifier = 2,
		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[Tooltip("Unity by default will validate ssl certificates. By using this option you can avoid ssl certificates validation. However, if you don't need to ignore ssl validation, please set this option to false.", order = 0)]
		[InspectorName("Exception message")]
		Message = 4
	}
}
