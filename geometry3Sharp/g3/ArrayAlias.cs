using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public struct ArrayAlias<T>
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D4")]
		public ArrayAlias(T[] source, int i)
		{
		}

		// Token: 0x17000023 RID: 35
		[Token(Token = "0x17000023")]
		public T this[int i]
		{
			[Token(Token = "0x60001D5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D6")]
			set
			{
			}
		}

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x0")]
		public T[] Source;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x0")]
		public int Index;
	}
}
