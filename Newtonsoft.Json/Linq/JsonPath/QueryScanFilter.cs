using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001A4 RID: 420
	[Token(Token = "0x20001A4")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class QueryScanFilter : PathFilter
	{
		// Token: 0x06000E6D RID: 3693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public QueryScanFilter(QueryExpression expression)
		{
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x25ECCE0", Offset = "0x25EB2E0", VA = "0x1825ECCE0", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			return null;
		}

		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		[FieldOffset(Offset = "0x10")]
		internal QueryExpression Expression;
	}
}
