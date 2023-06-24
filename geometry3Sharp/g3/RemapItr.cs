using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	public class RemapItr<T, T2> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x060002EB RID: 747 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EB")]
		public RemapItr(IEnumerable<T2> otherIterator, Func<T2, T> valueFunction)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002EC")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002ED")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x0")]
		public IEnumerable<T2> OtherItr;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x0")]
		public Func<T2, T> ValueF;
	}
}
