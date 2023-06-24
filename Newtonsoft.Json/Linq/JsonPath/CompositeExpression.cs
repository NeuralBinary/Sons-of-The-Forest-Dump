using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001A0 RID: 416
	[Token(Token = "0x20001A0")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class CompositeExpression : QueryExpression
	{
		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000242")]
		public List<QueryExpression> Expressions
		{
			[Token(Token = "0x6000E56")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E57")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x25EA9A0", Offset = "0x25E8FA0", VA = "0x1825EA9A0")]
		public CompositeExpression(QueryOperator @operator)
		{
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00006BA0 File Offset: 0x00004DA0
		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x25EAA50", Offset = "0x25E9050", VA = "0x1825EAA50", Slot = "4")]
		public override bool IsMatch(JToken root, JToken t, [Nullable(2)] JsonSelectSettings settings)
		{
			return default(bool);
		}
	}
}
