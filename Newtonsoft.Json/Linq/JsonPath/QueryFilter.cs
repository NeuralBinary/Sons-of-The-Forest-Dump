using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001A2 RID: 418
	[Token(Token = "0x20001A2")]
	[Nullable(0)]
	[NullableContext(1)]
	internal class QueryFilter : PathFilter
	{
		// Token: 0x06000E61 RID: 3681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public QueryFilter(QueryExpression expression)
		{
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E62")]
		[Address(RVA = "0x25EC200", Offset = "0x25EA800", VA = "0x1825EC200", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			return null;
		}

		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		[FieldOffset(Offset = "0x10")]
		internal QueryExpression Expression;
	}
}
