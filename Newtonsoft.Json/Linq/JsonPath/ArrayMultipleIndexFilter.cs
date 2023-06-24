using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000193 RID: 403
	[Token(Token = "0x2000193")]
	[Nullable(0)]
	[NullableContext(1)]
	internal class ArrayMultipleIndexFilter : PathFilter
	{
		// Token: 0x06000DFF RID: 3583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFF")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public ArrayMultipleIndexFilter(List<int> indexes)
		{
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x25E38C0", Offset = "0x25E1EC0", VA = "0x1825E38C0", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			return null;
		}

		// Token: 0x04000770 RID: 1904
		[Token(Token = "0x4000770")]
		[FieldOffset(Offset = "0x10")]
		internal List<int> Indexes;
	}
}
