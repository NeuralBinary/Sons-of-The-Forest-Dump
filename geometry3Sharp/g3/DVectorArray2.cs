using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	public class DVectorArray2<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x06000288 RID: 648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000288")]
		public DVectorArray2(int nCount = 0)
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000289")]
		public DVectorArray2(T[] data)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600028A RID: 650 RVA: 0x000034AC File Offset: 0x000016AC
		[Token(Token = "0x17000040")]
		public int Count
		{
			[Token(Token = "0x600028A")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600028B")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600028C")]
		public void Resize(int count)
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600028D")]
		public void Set(int i, T a, T b)
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600028E")]
		public void Append(T a, T b)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600028F")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x0")]
		public DVector<T> vector;
	}
}
