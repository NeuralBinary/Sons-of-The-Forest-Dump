using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	public class VectorArray2<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x060004AF RID: 1199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AF")]
		public VectorArray2(int nCount = 0)
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B0")]
		public VectorArray2(T[] data)
		{
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x0000434C File Offset: 0x0000254C
		[Token(Token = "0x170000A1")]
		public int Count
		{
			[Token(Token = "0x60004B1")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004B2")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B3")]
		public void Resize(int Count)
		{
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B4")]
		public void Set(int i, T a, T b)
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B5")]
		public void Set(int iStart, int iCount, VectorArray2<T> source)
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004B6")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x0")]
		public T[] array;
	}
}
