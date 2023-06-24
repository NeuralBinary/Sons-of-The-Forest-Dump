using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000191 RID: 401
	[Token(Token = "0x2000191")]
	internal class ArrayIndexFilter : PathFilter
	{
		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00006A20 File Offset: 0x00004C20
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000233")]
		public int? Index
		{
			[Token(Token = "0x6000DF1")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DF2")]
			[Address(RVA = "0x754960", Offset = "0x752F60", VA = "0x180754960")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x25E2D30", Offset = "0x25E1330", VA = "0x1825E2D30", Slot = "4")]
		[NullableContext(1)]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			return null;
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ArrayIndexFilter()
		{
		}
	}
}
