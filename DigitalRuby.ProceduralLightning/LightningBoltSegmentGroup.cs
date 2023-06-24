using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public class LightningBoltSegmentGroup
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x17000009")]
		public int SegmentCount
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0xA305E0", Offset = "0xA2EBE0", VA = "0x180A305E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000063")]
		[Address(RVA = "0xA30620", Offset = "0xA2EC20", VA = "0x180A30620")]
		public void Reset()
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000064")]
		[Address(RVA = "0xA306F0", Offset = "0xA2ECF0", VA = "0x180A306F0")]
		public LightningBoltSegmentGroup()
		{
		}

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x10")]
		public float LineWidth;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x14")]
		public int StartIndex;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x18")]
		public int Generation;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x1C")]
		public float Delay;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x20")]
		public float PeakStart;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x24")]
		public float PeakEnd;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x28")]
		public float LifeTime;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x2C")]
		public float EndWidthMultiplier;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x30")]
		[ColorUsage(true, true)]
		public Color32 Color;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x38")]
		public readonly List<LightningBoltSegment> Segments;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x40")]
		public readonly List<Light> Lights;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x48")]
		public LightningLightParameters LightParameters;
	}
}
