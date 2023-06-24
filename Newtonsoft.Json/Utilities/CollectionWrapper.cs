using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	[Nullable(0)]
	[NullableContext(1)]
	internal class CollectionWrapper<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedCollection, IList, ICollection
	{
		// Token: 0x06000519 RID: 1305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000519")]
		public CollectionWrapper(IList list)
		{
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051A")]
		public CollectionWrapper(ICollection<T> list)
		{
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051B")]
		public virtual void Add(T item)
		{
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051C")]
		public virtual void Clear()
		{
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x600051D")]
		public virtual bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051E")]
		public virtual void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x170000AD")]
		public virtual int Count
		{
			[Token(Token = "0x600051F")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x170000AE")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x6000520")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x6000521")]
		public virtual bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000522")]
		public virtual IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000523")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x6000524")]
		[NullableContext(2)]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x6000525")]
		[NullableContext(2)]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x6000526")]
		[NullableContext(2)]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000527")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000528")]
		[NullableContext(2)]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x170000AF")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6000529")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052A")]
		[NullableContext(2)]
		private void Remove(object value)
		{
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B0")]
		[Nullable(2)]
		private object Item
		{
			[Token(Token = "0x600052B")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x600052C")]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052D")]
		private void CopyTo(Array array, int arrayIndex)
		{
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x170000B1")]
		private bool IsSynchronized
		{
			[Token(Token = "0x600052E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000B2")]
		private object SyncRoot
		{
			[Token(Token = "0x600052F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000530")]
		[NullableContext(2)]
		private static void VerifyValueType(object value)
		{
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x6000531")]
		[NullableContext(2)]
		private static bool IsCompatibleObject(object value)
		{
			return default(bool);
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000B3")]
		public object UnderlyingCollection
		{
			[Token(Token = "0x6000532")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x0")]
		[Nullable(2)]
		private readonly IList _list;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x0")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly ICollection<T> _genericCollection;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x0")]
		[Nullable(2)]
		private object _syncRoot;
	}
}
