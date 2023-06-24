using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	public class SafeListBuilder<T>
	{
		// Token: 0x060003E5 RID: 997 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E5")]
		public SafeListBuilder()
		{
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E6")]
		public void SafeAdd(T value)
		{
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E7")]
		public void SafeOperation(Action<List<T>> opF)
		{
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000082")]
		public List<T> Result
		{
			[Token(Token = "0x60003E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x0")]
		public List<T> List;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x0")]
		public SpinLock spinlock;
	}
}
