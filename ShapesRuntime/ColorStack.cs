using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public readonly struct ColorStack : IDisposable
	{
		// Token: 0x06000273 RID: 627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2A33320", Offset = "0x2A31920", VA = "0x182A33320")]
		internal static void Push(Color prevState)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2A333F0", Offset = "0x2A319F0", VA = "0x182A333F0")]
		internal static void Pop()
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2A335B0", Offset = "0x2A31BB0", VA = "0x182A335B0")]
		internal ColorStack(Color mtx)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2A33680", Offset = "0x2A31C80", VA = "0x182A33680", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<Color> colors;
	}
}
