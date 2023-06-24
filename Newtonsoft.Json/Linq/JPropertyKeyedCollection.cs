using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class JPropertyKeyedCollection : Collection<JToken>
	{
		// Token: 0x06000C76 RID: 3190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x25C8BB0", Offset = "0x25C71B0", VA = "0x1825C8BB0")]
		public JPropertyKeyedCollection()
		{
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x25C8C80", Offset = "0x25C7280", VA = "0x1825C8C80")]
		private void AddKey(string key, JToken item)
		{
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x25C8D10", Offset = "0x25C7310", VA = "0x1825C8D10")]
		protected void ChangeItemKey(JToken item, string newKey)
		{
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x25C8F50", Offset = "0x25C7550", VA = "0x1825C8F50", Slot = "35")]
		protected override void ClearItems()
		{
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00006030 File Offset: 0x00004230
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x25C8FF0", Offset = "0x25C75F0", VA = "0x1825C8FF0")]
		public bool Contains(string key)
		{
			return default(bool);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x25C90C0", Offset = "0x25C76C0", VA = "0x1825C90C0")]
		private bool ContainsItem(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x25C9190", Offset = "0x25C7790", VA = "0x1825C9190")]
		private void EnsureDictionary()
		{
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x25C9290", Offset = "0x25C7890", VA = "0x1825C9290")]
		private string GetKeyForItem(JToken item)
		{
			return null;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x25C9300", Offset = "0x25C7900", VA = "0x1825C9300", Slot = "36")]
		protected override void InsertItem(int index, JToken item)
		{
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x25C93C0", Offset = "0x25C79C0", VA = "0x1825C93C0")]
		public bool Remove(string key)
		{
			return default(bool);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x25C94A0", Offset = "0x25C7AA0", VA = "0x1825C94A0", Slot = "37")]
		protected override void RemoveItem(int index)
		{
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x25C9600", Offset = "0x25C7C00", VA = "0x1825C9600")]
		private void RemoveKey(string key)
		{
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x25C9650", Offset = "0x25C7C50", VA = "0x1825C9650", Slot = "38")]
		protected override void SetItem(int index, JToken item)
		{
		}

		// Token: 0x17000207 RID: 519
		[Token(Token = "0x17000207")]
		public JToken this[string key]
		{
			[Token(Token = "0x6000C83")]
			[Address(RVA = "0x25C98B0", Offset = "0x25C7EB0", VA = "0x1825C98B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00006078 File Offset: 0x00004278
		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x25C9990", Offset = "0x25C7F90", VA = "0x1825C9990")]
		public bool TryGetValue(string key, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out JToken value)
		{
			return default(bool);
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000208")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x6000C85")]
			[Address(RVA = "0x25C9A50", Offset = "0x25C8050", VA = "0x1825C9A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000209")]
		public ICollection<JToken> Values
		{
			[Token(Token = "0x6000C86")]
			[Address(RVA = "0x25C9AA0", Offset = "0x25C80A0", VA = "0x1825C9AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00006090 File Offset: 0x00004290
		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x25C9AF0", Offset = "0x25C80F0", VA = "0x1825C9AF0")]
		public int IndexOfReference(JToken t)
		{
			return 0;
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000060A8 File Offset: 0x000042A8
		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x25C9BF0", Offset = "0x25C81F0", VA = "0x1825C9BF0")]
		public bool Compare(JPropertyKeyedCollection other)
		{
			return default(bool);
		}

		// Token: 0x040006F1 RID: 1777
		[Token(Token = "0x40006F1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IEqualityComparer<string> Comparer;

		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x18")]
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, JToken> _dictionary;
	}
}
