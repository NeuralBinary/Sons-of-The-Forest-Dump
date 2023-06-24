using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	[Serializable]
	public struct RangeOfFloats
	{
		// Token: 0x06000129 RID: 297 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x6000129")]
		[Address(RVA = "0xA44D30", Offset = "0xA43330", VA = "0x180A44D30")]
		public float Random()
		{
			return 0f;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x600012A")]
		[Address(RVA = "0xA44D50", Offset = "0xA43350", VA = "0x180A44D50")]
		public float Random(System.Random r)
		{
			return 0f;
		}

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x0")]
		[Tooltip("Minimum value (inclusive)")]
		public float Minimum;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x4")]
		[Tooltip("Maximum value (inclusive)")]
		public float Maximum;
	}
}
