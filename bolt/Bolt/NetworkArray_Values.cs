using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	public abstract class NetworkArray_Values<T> : NetworkObj, IEnumerable<T>, IEnumerable
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x170000F7")]
		public int Length
		{
			[Token(Token = "0x6000512")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F8")]
		internal override NetworkStorage Storage
		{
			[Token(Token = "0x6000513")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000514")]
		internal NetworkArray_Values(int length, int stride)
		{
		}

		// Token: 0x170000F9 RID: 249
		[Token(Token = "0x170000F9")]
		public T this[int index]
		{
			[Token(Token = "0x6000515")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000516")]
			set
			{
			}
		}

		// Token: 0x06000517 RID: 1303
		[Token(Token = "0x6000517")]
		protected abstract T GetValue(int index);

		// Token: 0x06000518 RID: 1304
		[Token(Token = "0x6000518")]
		protected abstract bool SetValue(int index, T value);

		// Token: 0x06000519 RID: 1305 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000519")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600051A")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x0")]
		private int _length;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x0")]
		private int _stride;
	}
}
