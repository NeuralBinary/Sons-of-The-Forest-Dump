using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	public class ConstantItr<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E2")]
		public ConstantItr(int count, T constant)
		{
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002E3")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002E4")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x0")]
		public T ConstantValue;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x0")]
		public int N;
	}
}
