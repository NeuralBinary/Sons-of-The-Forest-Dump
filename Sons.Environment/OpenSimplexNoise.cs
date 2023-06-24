using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sons.Environment
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public class OpenSimplexNoise
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2F959F0", Offset = "0x2F93FF0", VA = "0x182F959F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int FastFloor(float x)
		{
			return 0;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2F95A10", Offset = "0x2F94010", VA = "0x182F95A10")]
		public OpenSimplexNoise()
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2F95A70", Offset = "0x2F94070", VA = "0x182F95A70")]
		public OpenSimplexNoise(long seed)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2F95E10", Offset = "0x2F94410", VA = "0x182F95E10")]
		public float Evaluate(float x, float y)
		{
			return 0f;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2F96120", Offset = "0x2F94720", VA = "0x182F96120")]
		public float Evaluate(float x, float y, float z)
		{
			return 0f;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2F96520", Offset = "0x2F94B20", VA = "0x182F96520")]
		public float Evaluate(float x, float y, float z, float w)
		{
			return 0f;
		}

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		private const float STRETCH_2D = -0.21132487f;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		private const float STRETCH_3D = -0.16666667f;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		private const float STRETCH_4D = -0.1381966f;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		private const float SQUISH_2D = 0.36602542f;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		private const float SQUISH_3D = 0.33333334f;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		private const float SQUISH_4D = 0.309017f;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		private const float NORM_2D = 0.021276595f;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		private const float NORM_3D = 0.009708738f;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		private const float NORM_4D = 0.033333335f;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x10")]
		private byte[] perm;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x18")]
		private byte[] perm2D;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x20")]
		private byte[] perm3D;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x28")]
		private byte[] perm4D;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x0")]
		private static float[] gradients2D;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x8")]
		private static float[] gradients3D;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x10")]
		private static float[] gradients4D;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x18")]
		private static OpenSimplexNoise.Contribution2[] lookup2D;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x20")]
		private static OpenSimplexNoise.Contribution3[] lookup3D;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x28")]
		private static OpenSimplexNoise.Contribution4[] lookup4D;

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000014")]
		private class Contribution2
		{
			// Token: 0x06000050 RID: 80 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2F96A00", Offset = "0x2F95000", VA = "0x182F96A00")]
			public Contribution2(float multiplier, int xsb, int ysb)
			{
			}

			// Token: 0x040000B0 RID: 176
			[Token(Token = "0x40000B0")]
			[FieldOffset(Offset = "0x10")]
			public float dx;

			// Token: 0x040000B1 RID: 177
			[Token(Token = "0x40000B1")]
			[FieldOffset(Offset = "0x14")]
			public float dy;

			// Token: 0x040000B2 RID: 178
			[Token(Token = "0x40000B2")]
			[FieldOffset(Offset = "0x18")]
			public int xsb;

			// Token: 0x040000B3 RID: 179
			[Token(Token = "0x40000B3")]
			[FieldOffset(Offset = "0x1C")]
			public int ysb;

			// Token: 0x040000B4 RID: 180
			[Token(Token = "0x40000B4")]
			[FieldOffset(Offset = "0x20")]
			public OpenSimplexNoise.Contribution2 Next;
		}

		// Token: 0x02000015 RID: 21
		[Token(Token = "0x2000015")]
		private class Contribution3
		{
			// Token: 0x06000051 RID: 81 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2F96A40", Offset = "0x2F95040", VA = "0x182F96A40")]
			public Contribution3(float multiplier, int xsb, int ysb, int zsb)
			{
			}

			// Token: 0x040000B5 RID: 181
			[Token(Token = "0x40000B5")]
			[FieldOffset(Offset = "0x10")]
			public float dx;

			// Token: 0x040000B6 RID: 182
			[Token(Token = "0x40000B6")]
			[FieldOffset(Offset = "0x14")]
			public float dy;

			// Token: 0x040000B7 RID: 183
			[Token(Token = "0x40000B7")]
			[FieldOffset(Offset = "0x18")]
			public float dz;

			// Token: 0x040000B8 RID: 184
			[Token(Token = "0x40000B8")]
			[FieldOffset(Offset = "0x1C")]
			public int xsb;

			// Token: 0x040000B9 RID: 185
			[Token(Token = "0x40000B9")]
			[FieldOffset(Offset = "0x20")]
			public int ysb;

			// Token: 0x040000BA RID: 186
			[Token(Token = "0x40000BA")]
			[FieldOffset(Offset = "0x24")]
			public int zsb;

			// Token: 0x040000BB RID: 187
			[Token(Token = "0x40000BB")]
			[FieldOffset(Offset = "0x28")]
			public OpenSimplexNoise.Contribution3 Next;
		}

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		private class Contribution4
		{
			// Token: 0x06000052 RID: 82 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2F96AA0", Offset = "0x2F950A0", VA = "0x182F96AA0")]
			public Contribution4(float multiplier, int xsb, int ysb, int zsb, int wsb)
			{
			}

			// Token: 0x040000BC RID: 188
			[Token(Token = "0x40000BC")]
			[FieldOffset(Offset = "0x10")]
			public float dx;

			// Token: 0x040000BD RID: 189
			[Token(Token = "0x40000BD")]
			[FieldOffset(Offset = "0x14")]
			public float dy;

			// Token: 0x040000BE RID: 190
			[Token(Token = "0x40000BE")]
			[FieldOffset(Offset = "0x18")]
			public float dz;

			// Token: 0x040000BF RID: 191
			[Token(Token = "0x40000BF")]
			[FieldOffset(Offset = "0x1C")]
			public float dw;

			// Token: 0x040000C0 RID: 192
			[Token(Token = "0x40000C0")]
			[FieldOffset(Offset = "0x20")]
			public int xsb;

			// Token: 0x040000C1 RID: 193
			[Token(Token = "0x40000C1")]
			[FieldOffset(Offset = "0x24")]
			public int ysb;

			// Token: 0x040000C2 RID: 194
			[Token(Token = "0x40000C2")]
			[FieldOffset(Offset = "0x28")]
			public int zsb;

			// Token: 0x040000C3 RID: 195
			[Token(Token = "0x40000C3")]
			[FieldOffset(Offset = "0x2C")]
			public int wsb;

			// Token: 0x040000C4 RID: 196
			[Token(Token = "0x40000C4")]
			[FieldOffset(Offset = "0x30")]
			public OpenSimplexNoise.Contribution4 Next;
		}
	}
}
