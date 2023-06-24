using System;
using Il2CppDummyDll;
using Unity.Mathematics;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public struct GridHash
{
	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x27329D0", Offset = "0x2730FD0", VA = "0x1827329D0")]
	public static int Hash(float3 v, float cellSize)
	{
		return 0;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002068 File Offset: 0x00000268
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2732AC0", Offset = "0x27310C0", VA = "0x182732AC0")]
	public static int3 Quantize(float3 v, float cellSize)
	{
		return default(int3);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002080 File Offset: 0x00000280
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2732B50", Offset = "0x2731150", VA = "0x182732B50")]
	public static int Hash(float2 v, float cellSize)
	{
		return 0;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2732C10", Offset = "0x2731210", VA = "0x182732C10")]
	public static int2 Quantize(float2 v, float cellSize)
	{
		return default(int2);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000020B0 File Offset: 0x000002B0
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2732C70", Offset = "0x2731270", VA = "0x182732C70")]
	public static int Hash(int3 grid)
	{
		return 0;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000020C8 File Offset: 0x000002C8
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2732CA0", Offset = "0x27312A0", VA = "0x182732CA0")]
	public static int Hash(int2 grid)
	{
		return 0;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x000020E0 File Offset: 0x000002E0
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2732CC0", Offset = "0x27312C0", VA = "0x182732CC0")]
	public static ulong Hash(ulong hash, ulong key)
	{
		return 0UL;
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int3[] cellOffsets3D;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int3[] cellOffsets;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x10")]
	public static readonly int2[] cell2DOffsets;
}
