using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public struct FixedArray3<T> : IEnumerable, IEnumerable<T> where T : class
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000E1")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000028 RID: 40
		[Token(Token = "0x17000028")]
		public T this[int index]
		{
			[Token(Token = "0x60000E2")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E3")]
			set
			{
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x60000E4")]
		public bool Contains(T value)
		{
			return default(bool);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x60000E5")]
		public int IndexOf(T value)
		{
			return 0;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		public void Clear()
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		public void Clear(T value)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000E8")]
		[DebuggerHidden]
		private IEnumerable<T> Enumerate()
		{
			return null;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000E9")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x0")]
		public T _0;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x0")]
		public T _1;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x0")]
		public T _2;
	}
}
