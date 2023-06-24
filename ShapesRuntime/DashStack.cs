using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public readonly struct DashStack : IDisposable
	{
		// Token: 0x06000278 RID: 632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2A337F0", Offset = "0x2A31DF0", VA = "0x182A337F0")]
		internal static void Push(bool prevOn, DashStyle prevState)
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2A33910", Offset = "0x2A31F10", VA = "0x182A33910")]
		internal static void Pop()
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2A33B00", Offset = "0x2A32100", VA = "0x182A33B00")]
		internal DashStack(bool on, DashStyle dash)
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2A33C20", Offset = "0x2A32220", VA = "0x182A33C20", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<ValueTuple<bool, DashStyle>> dashes;
	}
}
