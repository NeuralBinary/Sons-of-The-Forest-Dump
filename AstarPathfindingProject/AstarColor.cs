using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[Serializable]
	public class AstarColor
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00002CCC File Offset: 0x00000ECC
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x6326C0", Offset = "0x630CC0", VA = "0x1806326C0")]
		public static int ColorHash()
		{
			return 0;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x6329B0", Offset = "0x630FB0", VA = "0x1806329B0")]
		public static Color GetAreaColor(uint area)
		{
			return default(Color);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002CFC File Offset: 0x00000EFC
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x632B20", Offset = "0x631120", VA = "0x180632B20")]
		public static Color GetTagColor(uint tag)
		{
			return default(Color);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x632C90", Offset = "0x631290", VA = "0x180632C90")]
		public void PushToStatic(AstarPath astar)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x632E60", Offset = "0x631460", VA = "0x180632E60")]
		public AstarColor()
		{
		}

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x10")]
		public Color _SolidColor;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x20")]
		public Color _UnwalkableNode;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x30")]
		public Color _BoundsHandles;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x40")]
		public Color _ConnectionLowLerp;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x50")]
		public Color _ConnectionHighLerp;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x60")]
		public Color _MeshEdgeColor;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x70")]
		public Color[] _AreaColors;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x0")]
		public static Color SolidColor;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x10")]
		public static Color UnwalkableNode;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x20")]
		public static Color BoundsHandles;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x30")]
		public static Color ConnectionLowLerp;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x40")]
		public static Color ConnectionHighLerp;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x50")]
		public static Color MeshEdgeColor;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x60")]
		private static Color[] AreaColors;
	}
}
