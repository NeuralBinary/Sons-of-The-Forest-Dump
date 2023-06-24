using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	[Nullable(0)]
	[NullableContext(1)]
	internal class BidirectionalDictionary<TFirst, TSecond>
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F9")]
		public BidirectionalDictionary()
		{
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FA")]
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer)
		{
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FB")]
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FC")]
		public void Set(TFirst first, TSecond second)
		{
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x60004FD")]
		public bool TryGetByFirst(TFirst first, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out TSecond second)
		{
			return default(bool);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x60004FE")]
		public bool TryGetBySecond(TSecond second, [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] [Nullable(2)] out TFirst first)
		{
			return default(bool);
		}

		// Token: 0x0400037E RID: 894
		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TFirst, TSecond> _firstToSecond;

		// Token: 0x0400037F RID: 895
		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TSecond, TFirst> _secondToFirst;

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _duplicateFirstErrorMessage;

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _duplicateSecondErrorMessage;
	}
}
