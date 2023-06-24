using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001A9 RID: 425
	[Token(Token = "0x20001A9")]
	[Nullable(0)]
	[NullableContext(1)]
	internal class ScanMultipleFilter : PathFilter
	{
		// Token: 0x06000E87 RID: 3719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E87")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public ScanMultipleFilter(List<string> names)
		{
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x25EE3F0", Offset = "0x25EC9F0", VA = "0x1825EE3F0", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			return null;
		}

		// Token: 0x040007E2 RID: 2018
		[Token(Token = "0x40007E2")]
		[FieldOffset(Offset = "0x10")]
		private List<string> _names;
	}
}
