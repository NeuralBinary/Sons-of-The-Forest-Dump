using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection
	{
		// Token: 0x06000578 RID: 1400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000578")]
		public DictionaryWrapper(IDictionary dictionary)
		{
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000579")]
		public DictionaryWrapper(IDictionary<TKey, TValue> dictionary)
		{
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057A")]
		public DictionaryWrapper(IReadOnlyDictionary<TKey, TValue> dictionary)
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000B7")]
		internal IDictionary<TKey, TValue> GenericDictionary
		{
			[Token(Token = "0x600057B")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057C")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x600057D")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000B8")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x600057E")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x600057F")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x6000580")]
		public bool TryGetValue(TKey key, [Nullable(2)] out TValue value)
		{
			return default(bool);
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000B9")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6000581")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BA RID: 186
		[Token(Token = "0x170000BA")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x6000582")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000583")]
			set
			{
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000584")]
		public void Add([Nullable(new byte[]
		{
			0,
			1,
			1
		})] KeyValuePair<TKey, TValue> item)
		{
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000585")]
		public void Clear()
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x6000586")]
		public bool Contains([Nullable(new byte[]
		{
			0,
			1,
			1
		})] KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000587")]
		public void CopyTo([Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x170000BB")]
		public int Count
		{
			[Token(Token = "0x6000588")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x170000BC")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000589")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x600058A")]
		public bool Remove([Nullable(new byte[]
		{
			0,
			1,
			1
		})] KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600058B")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600058C")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600058D")]
		private void Add(object key, [Nullable(2)] object value)
		{
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BD")]
		[Nullable(2)]
		private object Item
		{
			[Token(Token = "0x600058E")]
			get
			{
				return null;
			}
			[Token(Token = "0x600058F")]
			[param: Nullable(2)]
			set
			{
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000590")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x6000591")]
		private bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x170000BE")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6000592")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000BF")]
		private ICollection Keys
		{
			[Token(Token = "0x6000593")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000594")]
		public void Remove(object key)
		{
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000C0")]
		private ICollection Values
		{
			[Token(Token = "0x6000595")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000596")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x170000C1")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6000597")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000C2")]
		private object SyncRoot
		{
			[Token(Token = "0x6000598")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000C3")]
		public object UnderlyingDictionary
		{
			[Token(Token = "0x6000599")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x0")]
		[Nullable(2)]
		private readonly IDictionary _dictionary;

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x0")]
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly IDictionary<TKey, TValue> _genericDictionary;

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x0")]
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary;

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x0")]
		[Nullable(2)]
		private object _syncRoot;

		// Token: 0x020000A9 RID: 169
		[Token(Token = "0x20000A9")]
		[Nullable(0)]
		private readonly struct DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue> : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x0600059A RID: 1434 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600059A")]
			public DictionaryEnumerator([Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})] IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x0600059B RID: 1435 RVA: 0x00003A50 File Offset: 0x00001C50
			[Token(Token = "0x170000C4")]
			public DictionaryEntry Entry
			{
				[Token(Token = "0x600059B")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x0600059C RID: 1436 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x170000C5")]
			public object Key
			{
				[Token(Token = "0x600059C")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x0600059D RID: 1437 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x170000C6")]
			[Nullable(2)]
			public object Value
			{
				[Token(Token = "0x600059D")]
				[NullableContext(2)]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x0600059E RID: 1438 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x170000C7")]
			public object Current
			{
				[Token(Token = "0x600059E")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600059F RID: 1439 RVA: 0x00003A68 File Offset: 0x00001C68
			[Token(Token = "0x600059F")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060005A0 RID: 1440 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005A0")]
			public void Reset()
			{
			}

			// Token: 0x04000409 RID: 1033
			[Token(Token = "0x4000409")]
			[FieldOffset(Offset = "0x0")]
			[Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;
		}
	}
}
