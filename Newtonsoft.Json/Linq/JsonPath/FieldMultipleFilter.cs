using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class FieldMultipleFilter : PathFilter
	{
		// Token: 0x06000E29 RID: 3625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public FieldMultipleFilter(List<string> names)
		{
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E2A")]
		[Address(RVA = "0x25E5E30", Offset = "0x25E4430", VA = "0x1825E5E30", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			return null;
		}

		// Token: 0x04000798 RID: 1944
		[Token(Token = "0x4000798")]
		[FieldOffset(Offset = "0x10")]
		internal List<string> Names;
	}
}
