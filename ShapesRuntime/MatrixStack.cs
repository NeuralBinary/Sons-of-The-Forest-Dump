using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public readonly struct MatrixStack : IDisposable
	{
		// Token: 0x06000A9D RID: 2717 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x2A39FD0", Offset = "0x2A385D0", VA = "0x182A39FD0")]
		internal static void Push(Matrix4x4 prevState)
		{
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x2A3A070", Offset = "0x2A38670", VA = "0x182A3A070")]
		internal static void Pop()
		{
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x2A3A210", Offset = "0x2A38810", VA = "0x182A3A210")]
		internal MatrixStack(Matrix4x4 mtx)
		{
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x2A3A2B0", Offset = "0x2A388B0", VA = "0x182A3A2B0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Stack<Matrix4x4> matrices;
	}
}
