using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine.Infrastructure
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	internal sealed class ReferenceEqualityComparer : IEqualityComparer, IEqualityComparer<object>
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x903220", Offset = "0x901820", VA = "0x180903220", Slot = "6")]
		public bool Equals(object x, object y)
		{
			return default(bool);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x9A28D0", Offset = "0x9A0ED0", VA = "0x1809A28D0", Slot = "7")]
		public int GetHashCode(object obj)
		{
			return 0;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ReferenceEqualityComparer()
		{
		}

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ReferenceEqualityComparer Default;
	}
}
