using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public struct DiscColors
	{
		// Token: 0x0600027D RID: 637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1E77570", Offset = "0x1E75B70", VA = "0x181E77570")]
		internal DiscColors(Color innerStart, Color outerStart, Color innerEnd, Color outerEnd)
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00003A7C File Offset: 0x00001C7C
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2A33D90", Offset = "0x2A32390", VA = "0x182A33D90")]
		public static DiscColors Flat(Color color)
		{
			return default(DiscColors);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00003A94 File Offset: 0x00001C94
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2A33DB0", Offset = "0x2A323B0", VA = "0x182A33DB0")]
		public static DiscColors Radial(Color inner, Color outer)
		{
			return default(DiscColors);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00003AAC File Offset: 0x00001CAC
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2A33DE0", Offset = "0x2A323E0", VA = "0x182A33DE0")]
		public static DiscColors Angular(Color start, Color end)
		{
			return default(DiscColors);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2A33E00", Offset = "0x2A32400", VA = "0x182A33E00")]
		public static DiscColors Bilinear(Color innerStart, Color outerStart, Color innerEnd, Color outerEnd)
		{
			return default(DiscColors);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00003ADC File Offset: 0x00001CDC
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2A33E30", Offset = "0x2A32430", VA = "0x182A33E30")]
		public static implicit operator DiscColors(Color flatColor)
		{
			return default(DiscColors);
		}

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x0")]
		public Color innerStart;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x10")]
		public Color outerStart;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x20")]
		public Color innerEnd;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x30")]
		public Color outerEnd;
	}
}
