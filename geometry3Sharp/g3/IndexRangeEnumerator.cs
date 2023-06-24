using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	public class IndexRangeEnumerator : IEnumerable<int>, IEnumerable
	{
		// Token: 0x06000358 RID: 856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
		public IndexRangeEnumerator(int count)
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1F436F0", Offset = "0x1F41CF0", VA = "0x181F436F0")]
		public IndexRangeEnumerator(int start, int count)
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1F43700", Offset = "0x1F41D00", VA = "0x181F43700", Slot = "4")]
		public IEnumerator<int> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1F43700", Offset = "0x1F41D00", VA = "0x181F43700", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x10")]
		private int Start;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x14")]
		private int Count;
	}
}
