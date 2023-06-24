using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000025 RID: 37
[Token(Token = "0x2000025")]
public class SimplexNoiseGenerator
{
	// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x5DAAA0", Offset = "0x5D90A0", VA = "0x1805DAAA0")]
	public SimplexNoiseGenerator()
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x5DAC70", Offset = "0x5D9270", VA = "0x1805DAC70")]
	public SimplexNoiseGenerator(string seed)
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x5DAED0", Offset = "0x5D94D0", VA = "0x1805DAED0")]
	public SimplexNoiseGenerator(int[] seed)
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x5DAFE0", Offset = "0x5D95E0", VA = "0x1805DAFE0")]
	public string GetSeed()
	{
		return null;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x5DB120", Offset = "0x5D9720", VA = "0x1805DB120")]
	public float coherentNoise(float x, float y, float z, int octaves = 1, int multiplier = 25, float amplitude = 0.5f, float lacunarity = 2f, float persistence = 0.9f)
	{
		return 0f;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x5DB240", Offset = "0x5D9840", VA = "0x1805DB240")]
	public int getDensity(Vector3 loc)
	{
		return 0;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x5DB2D0", Offset = "0x5D98D0", VA = "0x1805DB2D0")]
	public float noise(float x, float y, float z)
	{
		return 0f;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x5DB4B0", Offset = "0x5D9AB0", VA = "0x1805DB4B0")]
	private float kay(int a)
	{
		return 0f;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x5DB700", Offset = "0x5D9D00", VA = "0x1805DB700")]
	private int shuffle(int i, int j, int k)
	{
		return 0;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x5DB8D0", Offset = "0x5D9ED0", VA = "0x1805DB8D0")]
	private int b(int i, int j, int k, int B)
	{
		return 0;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x5DB930", Offset = "0x5D9F30", VA = "0x1805DB930")]
	private int b(int N, int B)
	{
		return 0;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x5DB940", Offset = "0x5D9F40", VA = "0x1805DB940")]
	private int fastfloor(float n)
	{
		return 0;
	}

	// Token: 0x04000139 RID: 313
	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0x10")]
	private int[] A;

	// Token: 0x0400013A RID: 314
	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x18")]
	private float s;

	// Token: 0x0400013B RID: 315
	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x1C")]
	private float u;

	// Token: 0x0400013C RID: 316
	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x20")]
	private float v;

	// Token: 0x0400013D RID: 317
	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x24")]
	private float w;

	// Token: 0x0400013E RID: 318
	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x28")]
	private int i;

	// Token: 0x0400013F RID: 319
	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x2C")]
	private int j;

	// Token: 0x04000140 RID: 320
	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0x30")]
	private int k;

	// Token: 0x04000141 RID: 321
	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0x34")]
	private float onethird;

	// Token: 0x04000142 RID: 322
	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0x38")]
	private float onesixth;

	// Token: 0x04000143 RID: 323
	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0x40")]
	private int[] T;
}
