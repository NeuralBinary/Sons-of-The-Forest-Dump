using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	public class VectorArray3<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x0600046B RID: 1131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046B")]
		public VectorArray3(int nCount = 0)
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046C")]
		public VectorArray3(T[] data)
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x000041FC File Offset: 0x000023FC
		[Token(Token = "0x17000092")]
		public int Count
		{
			[Token(Token = "0x600046D")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600046E")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046F")]
		public void Resize(int Count)
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000470")]
		public void Set(int i, T a, T b, T c)
		{
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000471")]
		public void Set(int iStart, int iCount, VectorArray3<T> source)
		{
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000472")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x0")]
		public T[] array;
	}
}
