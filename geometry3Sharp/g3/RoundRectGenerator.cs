using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002BD RID: 701
	[Token(Token = "0x20002BD")]
	public class RoundRectGenerator : MeshGenerator
	{
		// Token: 0x060018D1 RID: 6353 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018D1")]
		[Address(RVA = "0x1EE5260", Offset = "0x1EE3860", VA = "0x181EE5260", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018D2")]
		[Address(RVA = "0x1EE6300", Offset = "0x1EE4900", VA = "0x181EE6300")]
		public Vector3d[] GetBorderLoop()
		{
			return null;
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018D3")]
		[Address(RVA = "0x1EE67D0", Offset = "0x1EE4DD0", VA = "0x181EE67D0")]
		public RoundRectGenerator()
		{
		}

		// Token: 0x04000C1B RID: 3099
		[Token(Token = "0x4000C1B")]
		[FieldOffset(Offset = "0x40")]
		public float Width;

		// Token: 0x04000C1C RID: 3100
		[Token(Token = "0x4000C1C")]
		[FieldOffset(Offset = "0x44")]
		public float Height;

		// Token: 0x04000C1D RID: 3101
		[Token(Token = "0x4000C1D")]
		[FieldOffset(Offset = "0x48")]
		public float Radius;

		// Token: 0x04000C1E RID: 3102
		[Token(Token = "0x4000C1E")]
		[FieldOffset(Offset = "0x4C")]
		public int CornerSteps;

		// Token: 0x04000C1F RID: 3103
		[Token(Token = "0x4000C1F")]
		[FieldOffset(Offset = "0x50")]
		public RoundRectGenerator.Corner SharpCorners;

		// Token: 0x04000C20 RID: 3104
		[Token(Token = "0x4000C20")]
		[FieldOffset(Offset = "0x54")]
		public RoundRectGenerator.UVModes UVMode;

		// Token: 0x04000C21 RID: 3105
		[Token(Token = "0x4000C21")]
		[FieldOffset(Offset = "0x0")]
		private static int[] corner_spans;

		// Token: 0x04000C22 RID: 3106
		[Token(Token = "0x4000C22")]
		[FieldOffset(Offset = "0x8")]
		private static readonly float[] signx;

		// Token: 0x04000C23 RID: 3107
		[Token(Token = "0x4000C23")]
		[FieldOffset(Offset = "0x10")]
		private static readonly float[] signy;

		// Token: 0x04000C24 RID: 3108
		[Token(Token = "0x4000C24")]
		[FieldOffset(Offset = "0x18")]
		private static readonly float[] startangle;

		// Token: 0x04000C25 RID: 3109
		[Token(Token = "0x4000C25")]
		[FieldOffset(Offset = "0x20")]
		private static readonly float[] endangle;

		// Token: 0x020002BE RID: 702
		[Token(Token = "0x20002BE")]
		[Flags]
		public enum Corner
		{
			// Token: 0x04000C27 RID: 3111
			[Token(Token = "0x4000C27")]
			BottomLeft = 1,
			// Token: 0x04000C28 RID: 3112
			[Token(Token = "0x4000C28")]
			BottomRight = 2,
			// Token: 0x04000C29 RID: 3113
			[Token(Token = "0x4000C29")]
			TopRight = 4,
			// Token: 0x04000C2A RID: 3114
			[Token(Token = "0x4000C2A")]
			TopLeft = 8
		}

		// Token: 0x020002BF RID: 703
		[Token(Token = "0x20002BF")]
		public enum UVModes
		{
			// Token: 0x04000C2C RID: 3116
			[Token(Token = "0x4000C2C")]
			FullUVSquare,
			// Token: 0x04000C2D RID: 3117
			[Token(Token = "0x4000C2D")]
			CenteredUVRectangle,
			// Token: 0x04000C2E RID: 3118
			[Token(Token = "0x4000C2E")]
			BottomCornerUVRectangle
		}
	}
}
