using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x0200019F RID: 415
	[Token(Token = "0x200019F")]
	[NullableContext(1)]
	[Nullable(0)]
	internal abstract class QueryExpression
	{
		// Token: 0x06000E53 RID: 3667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E53")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public QueryExpression(QueryOperator @operator)
		{
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00006B88 File Offset: 0x00004D88
		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x25EA970", Offset = "0x25E8F70", VA = "0x1825EA970")]
		public bool IsMatch(JToken root, JToken t)
		{
			return default(bool);
		}

		// Token: 0x06000E55 RID: 3669
		[Token(Token = "0x6000E55")]
		public abstract bool IsMatch(JToken root, JToken t, [Nullable(2)] JsonSelectSettings settings);

		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		[FieldOffset(Offset = "0x10")]
		internal QueryOperator Operator;
	}
}
