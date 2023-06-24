using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	[Nullable(0)]
	[NullableContext(1)]
	public readonly struct JEnumerable<T> : IJEnumerable<T>, IEnumerable<T>, IEnumerable, IEquatable<JEnumerable<T>> where T : JToken
	{
		// Token: 0x06000BD0 RID: 3024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD0")]
		public JEnumerable(IEnumerable<T> enumerable)
		{
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BD1")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BD2")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x170001F0 RID: 496
		[Token(Token = "0x170001F0")]
		public IJEnumerable<JToken> this[object key]
		{
			[Token(Token = "0x6000BD3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[Token(Token = "0x6000BD4")]
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] JEnumerable<T> other)
		{
			return default(bool);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00005CB8 File Offset: 0x00003EB8
		[Token(Token = "0x6000BD5")]
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00005CD0 File Offset: 0x00003ED0
		[Token(Token = "0x6000BD6")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040006BD RID: 1725
		[Token(Token = "0x40006BD")]
		[FieldOffset(Offset = "0x0")]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static readonly JEnumerable<T> Empty;

		// Token: 0x040006BE RID: 1726
		[Token(Token = "0x40006BE")]
		[FieldOffset(Offset = "0x0")]
		private readonly IEnumerable<T> _enumerable;
	}
}
