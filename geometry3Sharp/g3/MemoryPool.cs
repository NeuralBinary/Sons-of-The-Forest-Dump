using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	public class MemoryPool<T> where T : class, new()
	{
		// Token: 0x060003A1 RID: 929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A1")]
		public MemoryPool()
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003A2")]
		public T Allocate()
		{
			return null;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A3")]
		public void Return(T obj)
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A4")]
		public void ReturnAll()
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003A5")]
		public void FreeAll()
		{
		}

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x0")]
		private DVector<T> Allocated;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x0")]
		private DVector<T> Free;
	}
}
