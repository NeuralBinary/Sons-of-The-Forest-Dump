using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public static class CoroutineHelper
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xA6E110", Offset = "0xA6C710", VA = "0x180A6E110")]
		public static Coroutine StartCoroutine(IEnumerator coroutineSource)
		{
			return null;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xA6E170", Offset = "0xA6C770", VA = "0x180A6E170")]
		private static void ValidateBlankMono()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xA6E3B0", Offset = "0xA6C9B0", VA = "0x180A6E3B0")]
		public static void StopCoroutine(Coroutine coroutineSource)
		{
		}

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x0")]
		private static BlankMono _blankMono;
	}
}
