using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class ComputeManager
	{
		// Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x23B3850", Offset = "0x23B1E50", VA = "0x1823B3850")]
		public static void Reset()
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x23B39C0", Offset = "0x23B1FC0", VA = "0x1823B39C0")]
		public static void RegisterShader(ComputeShader shader)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x23B3AF0", Offset = "0x23B20F0", VA = "0x1823B3AF0")]
		public static int RegisterKernel(ComputeShader shader, string kernelName)
		{
			return 0;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x23B3D60", Offset = "0x23B2360", VA = "0x1823B3D60")]
		public static void RegisterConstantId(ComputeShader shader, int id)
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x23B3EF0", Offset = "0x23B24F0", VA = "0x1823B3EF0")]
		public static void ActivateAllShaders()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x23B40A0", Offset = "0x23B26A0", VA = "0x1823B40A0")]
		public static void DeactivateAllShaders()
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x23B4240", Offset = "0x23B2840", VA = "0x1823B4240")]
		public static void Activate(ComputeShader shader)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x23B42D0", Offset = "0x23B28D0", VA = "0x1823B42D0")]
		public static void Deactivate(ComputeShader shader)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x23B4350", Offset = "0x23B2950", VA = "0x1823B4350")]
		public static void Dispatch(ComputeShader shader, int kernel, int x, int y, int z)
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x23B4380", Offset = "0x23B2980", VA = "0x1823B4380")]
		public static void DispatchIndirect(ComputeShader shader, int kernel, ComputeBuffer indirectArgs)
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x23B4540", Offset = "0x23B2B40", VA = "0x1823B4540")]
		public static void SetBool(int id, bool value)
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x23B47A0", Offset = "0x23B2DA0", VA = "0x1823B47A0")]
		public static void SetInt(int id, int value)
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x23B49B0", Offset = "0x23B2FB0", VA = "0x1823B49B0")]
		public static void SetInts(int id, int[] value)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x23B4BC0", Offset = "0x23B31C0", VA = "0x1823B4BC0")]
		public static void SetFloat(int id, float value)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x23B4DD0", Offset = "0x23B33D0", VA = "0x1823B4DD0")]
		public static void SetFloats(int id, float[] value)
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x23B4FE0", Offset = "0x23B35E0", VA = "0x1823B4FE0")]
		public static void SetVector(int id, Vector4 value)
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x23B5240", Offset = "0x23B3840", VA = "0x1823B5240")]
		public static void SetMatrix(int id, Matrix4x4 value)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x23B54C0", Offset = "0x23B3AC0", VA = "0x1823B54C0")]
		public static void SetBuffer(int id, ComputeBuffer value)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x23B58B0", Offset = "0x23B3EB0", VA = "0x1823B58B0")]
		public static void SetTexture(int id, Texture value)
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ComputeManager()
		{
		}

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x0")]
		private static HashSet<ComputeShader> s_shaderSet;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x8")]
		private static HashSet<ComputeShader> s_activeShaderSet;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<ComputeShader, List<int>> s_shaderKernelMap;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<int, HashSet<ComputeShader>> s_constantShaderMap;
	}
}
