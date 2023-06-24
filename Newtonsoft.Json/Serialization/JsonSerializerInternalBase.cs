using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	[Nullable(0)]
	[NullableContext(1)]
	internal abstract class JsonSerializerInternalBase
	{
		// Token: 0x060008A9 RID: 2217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x25873F0", Offset = "0x25859F0", VA = "0x1825873F0")]
		protected JsonSerializerInternalBase(JsonSerializer serializer)
		{
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700014D")]
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings
		{
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x2587540", Offset = "0x2585B40", VA = "0x182587540")]
			get
			{
				return null;
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x2587680", Offset = "0x2585C80", VA = "0x182587680")]
		protected NullValueHandling ResolvedNullValueHandling([Nullable(2)] JsonObjectContract containerContract, JsonProperty property)
		{
			return NullValueHandling.Include;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x2587720", Offset = "0x2585D20", VA = "0x182587720")]
		private ErrorContext GetErrorContext([Nullable(2)] object currentObject, [Nullable(2)] object member, string path, Exception error)
		{
			return null;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x25879A0", Offset = "0x2585FA0", VA = "0x1825879A0")]
		protected void ClearErrorContext()
		{
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x2587A50", Offset = "0x2586050", VA = "0x182587A50")]
		[NullableContext(2)]
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, [Nullable(1)] string path, [Nullable(1)] Exception ex)
		{
			return default(bool);
		}

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x10")]
		[Nullable(2)]
		private ErrorContext _currentErrorContext;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x18")]
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private BidirectionalDictionary<string, object> _mappings;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x20")]
		internal readonly JsonSerializer Serializer;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x28")]
		[Nullable(2)]
		internal readonly ITraceWriter TraceWriter;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x30")]
		[Nullable(2)]
		protected JsonSerializerProxy InternalSerializer;

		// Token: 0x02000126 RID: 294
		[Token(Token = "0x2000126")]
		[NullableContext(0)]
		private class ReferenceEqualsEqualityComparer : IEqualityComparer<object>
		{
			// Token: 0x060008AF RID: 2223 RVA: 0x00004C50 File Offset: 0x00002E50
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x903220", Offset = "0x901820", VA = "0x180903220", Slot = "4")]
			[NullableContext(2)]
			private bool Equals(object x, object y)
			{
				return default(bool);
			}

			// Token: 0x060008B0 RID: 2224 RVA: 0x00004C68 File Offset: 0x00002E68
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x9A28D0", Offset = "0x9A0ED0", VA = "0x1809A28D0", Slot = "5")]
			[NullableContext(1)]
			private int GetHashCode(object obj)
			{
				return 0;
			}

			// Token: 0x060008B1 RID: 2225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ReferenceEqualsEqualityComparer()
			{
			}
		}
	}
}
