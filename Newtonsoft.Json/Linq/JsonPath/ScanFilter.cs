using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001A7 RID: 423
	[Token(Token = "0x20001A7")]
	[NullableContext(2)]
	[Nullable(0)]
	internal class ScanFilter : PathFilter
	{
		// Token: 0x06000E7C RID: 3708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public ScanFilter(string name)
		{
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0x25ED9D0", Offset = "0x25EBFD0", VA = "0x1825ED9D0", Slot = "4")]
		[NullableContext(1)]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			return null;
		}

		// Token: 0x040007D8 RID: 2008
		[Token(Token = "0x40007D8")]
		[FieldOffset(Offset = "0x10")]
		internal string Name;
	}
}
