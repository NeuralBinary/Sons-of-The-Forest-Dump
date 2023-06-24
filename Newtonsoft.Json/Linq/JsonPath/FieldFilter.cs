using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	[Nullable(0)]
	[NullableContext(2)]
	internal class FieldFilter : PathFilter
	{
		// Token: 0x06000E1D RID: 3613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public FieldFilter(string name)
		{
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x25E51A0", Offset = "0x25E37A0", VA = "0x1825E51A0", Slot = "4")]
		[NullableContext(1)]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			return null;
		}

		// Token: 0x0400078D RID: 1933
		[Token(Token = "0x400078D")]
		[FieldOffset(Offset = "0x10")]
		internal string Name;
	}
}
