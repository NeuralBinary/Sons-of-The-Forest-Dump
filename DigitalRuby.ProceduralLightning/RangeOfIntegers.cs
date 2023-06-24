using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[Serializable]
	public struct RangeOfIntegers
	{
		// Token: 0x06000127 RID: 295 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x6000127")]
		[Address(RVA = "0xA44C90", Offset = "0xA43290", VA = "0x180A44C90")]
		public int Random()
		{
			return 0;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x6000128")]
		[Address(RVA = "0xA44CF0", Offset = "0xA432F0", VA = "0x180A44CF0")]
		public int Random(System.Random r)
		{
			return 0;
		}

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x0")]
		[Tooltip("Minimum value (inclusive)")]
		public int Minimum;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x4")]
		[Tooltip("Maximum value (inclusive)")]
		public int Maximum;
	}
}
