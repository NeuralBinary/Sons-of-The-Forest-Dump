using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public readonly struct StyleStack : IDisposable
	{
		// Token: 0x06000B81 RID: 2945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x2A45D00", Offset = "0x2A44300", VA = "0x182A45D00")]
		internal static void Push(DrawStyle prevState)
		{
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x2A45E00", Offset = "0x2A44400", VA = "0x182A45E00")]
		internal static void Pop()
		{
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x2A46120", Offset = "0x2A44720", VA = "0x182A46120")]
		internal StyleStack(DrawStyle style)
		{
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x2A46220", Offset = "0x2A44820", VA = "0x182A46220", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<DrawStyle> styles;
	}
}
