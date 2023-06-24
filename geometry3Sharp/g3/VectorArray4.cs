using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	public class VectorArray4<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x060004E4 RID: 1252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E4")]
		public VectorArray4(int nCount = 0)
		{
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E5")]
		public VectorArray4(T[] data)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00004454 File Offset: 0x00002654
		[Token(Token = "0x170000AD")]
		public int Count
		{
			[Token(Token = "0x60004E6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004E7")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E8")]
		public void Resize(int Count)
		{
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E9")]
		public void Set(int i, T a, T b, T c, T d)
		{
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004EA")]
		public void Set(int iStart, int iCount, VectorArray4<T> source)
		{
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004EB")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x0")]
		public T[] array;
	}
}
