using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public class DVectorArray3<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x06000243 RID: 579 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000243")]
		public DVectorArray3(int nCount = 0)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000244")]
		public DVectorArray3(T[] data)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000335C File Offset: 0x0000155C
		[Token(Token = "0x17000031")]
		public int Count
		{
			[Token(Token = "0x6000245")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000246")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000247")]
		public void Resize(int count)
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000248")]
		public void Set(int i, T a, T b, T c)
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000249")]
		public void Append(T a, T b, T c)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024A")]
		public void Clear()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600024B")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x0")]
		public DVector<T> vector;
	}
}
