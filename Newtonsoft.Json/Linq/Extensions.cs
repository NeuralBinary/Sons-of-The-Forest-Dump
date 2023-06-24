using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000157 RID: 343
	[Token(Token = "0x2000157")]
	[NullableContext(1)]
	[Nullable(0)]
	public static class Extensions
	{
		// Token: 0x06000AE1 RID: 2785 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AE1")]
		public static IJEnumerable<JToken> Ancestors<T>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AE2")]
		public static IJEnumerable<JToken> AncestorsAndSelf<T>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AE3")]
		public static IJEnumerable<JToken> Descendants<T>(this IEnumerable<T> source) where T : JContainer
		{
			return null;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AE4")]
		public static IJEnumerable<JToken> DescendantsAndSelf<T>(this IEnumerable<T> source) where T : JContainer
		{
			return null;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x25B4360", Offset = "0x25B2960", VA = "0x1825B4360")]
		public static IJEnumerable<JProperty> Properties(this IEnumerable<JObject> source)
		{
			return null;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x25B4520", Offset = "0x25B2B20", VA = "0x1825B4520")]
		public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source, [Nullable(2)] object key)
		{
			return null;
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x25B45A0", Offset = "0x25B2BA0", VA = "0x1825B45A0")]
		public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source)
		{
			return null;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AE8")]
		public static IEnumerable<U> Values<U>(this IEnumerable<JToken> source, object key)
		{
			return null;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AE9")]
		public static IEnumerable<U> Values<U>(this IEnumerable<JToken> source)
		{
			return null;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AEA")]
		[NullableContext(2)]
		public static U Value<U>([Nullable(1)] this IEnumerable<JToken> value)
		{
			return null;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AEB")]
		public static U Value<T, U>(this IEnumerable<T> value) where T : JToken
		{
			return null;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AEC")]
		internal static IEnumerable<U> Values<T, U>(this IEnumerable<T> source, [Nullable(2)] object key) where T : JToken
		{
			return null;
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AED")]
		public static IJEnumerable<JToken> Children<T>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AEE")]
		public static IEnumerable<U> Children<T, U>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AEF")]
		internal static IEnumerable<U> Convert<T, U>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AF0")]
		[NullableContext(2)]
		internal static U Convert<T, U>([Nullable(1)] this T token) where T : JToken
		{
			return null;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x25B4610", Offset = "0x25B2C10", VA = "0x1825B4610")]
		public static IJEnumerable<JToken> AsJEnumerable(this IEnumerable<JToken> source)
		{
			return null;
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AF2")]
		public static IJEnumerable<T> AsJEnumerable<T>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}
	}
}
