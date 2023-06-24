using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001A6 RID: 422
	[Token(Token = "0x20001A6")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class RootFilter : PathFilter
	{
		// Token: 0x06000E79 RID: 3705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private RootFilter()
		{
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x25ED8A0", Offset = "0x25EBEA0", VA = "0x1825ED8A0", Slot = "4")]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			return null;
		}

		// Token: 0x040007D7 RID: 2007
		[Token(Token = "0x40007D7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RootFilter Instance;
	}
}
