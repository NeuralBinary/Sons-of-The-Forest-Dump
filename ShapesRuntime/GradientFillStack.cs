using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public readonly struct GradientFillStack : IDisposable
	{
		// Token: 0x06000A81 RID: 2689 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x2A36D70", Offset = "0x2A35370", VA = "0x182A36D70")]
		internal static void Push(bool prevOn, GradientFill prevState)
		{
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x2A36EA0", Offset = "0x2A354A0", VA = "0x182A36EA0")]
		internal static void Pop()
		{
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x2A370E0", Offset = "0x2A356E0", VA = "0x182A370E0")]
		internal GradientFillStack(bool on, GradientFill gradient)
		{
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x2A37210", Offset = "0x2A35810", VA = "0x182A37210", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<ValueTuple<bool, GradientFill>> gradients;
	}
}
