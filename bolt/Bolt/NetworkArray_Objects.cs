using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	[Documentation]
	public class NetworkArray_Objects<T> : NetworkObj, IEnumerable<T>, IEnumerable where T : NetworkObj
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x170000FE")]
		public int Length
		{
			[Token(Token = "0x6000534")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000FF")]
		internal override NetworkStorage Storage
		{
			[Token(Token = "0x6000535")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000536")]
		internal NetworkArray_Objects(int length, int stride)
		{
		}

		// Token: 0x17000100 RID: 256
		[Token(Token = "0x17000100")]
		public T this[int index]
		{
			[Token(Token = "0x6000537")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000538")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000539")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x0")]
		private int _length;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x0")]
		private int _stride;
	}
}
