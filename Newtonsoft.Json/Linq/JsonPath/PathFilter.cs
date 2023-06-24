using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	[Nullable(0)]
	[NullableContext(2)]
	internal abstract class PathFilter
	{
		// Token: 0x06000E4F RID: 3663
		[Token(Token = "0x6000E4F")]
		[NullableContext(1)]
		public abstract IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings);

		// Token: 0x06000E50 RID: 3664 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E50")]
		[Address(RVA = "0x25EA4C0", Offset = "0x25E8AC0", VA = "0x1825EA4C0")]
		protected static JToken GetTokenIndex([Nullable(1)] JToken t, JsonSelectSettings settings, int index)
		{
			return null;
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x25EA8A0", Offset = "0x25E8EA0", VA = "0x1825EA8A0")]
		protected static JToken GetNextScanValue([Nullable(1)] JToken originalParent, JToken container, JToken value)
		{
			return null;
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected PathFilter()
		{
		}
	}
}
