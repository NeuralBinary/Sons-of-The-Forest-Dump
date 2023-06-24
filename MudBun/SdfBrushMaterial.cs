using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using UnityEngine;

namespace MudBun
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	[BurstCompile]
	[Serializable]
	public struct SdfBrushMaterial
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x170000DC")]
		public static SdfBrushMaterial New
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x2410BB0", Offset = "0x240F1B0", VA = "0x182410BB0")]
			get
			{
				return default(SdfBrushMaterial);
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2410C70", Offset = "0x240F270", VA = "0x182410C70")]
		[BurstCompile]
		public static void Lerp(in SdfBrushMaterial a, in SdfBrushMaterial b, float t, out SdfBrushMaterial ret)
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2410D30", Offset = "0x240F330", VA = "0x182410D30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Lerp$BurstManaged(in SdfBrushMaterial a, in SdfBrushMaterial b, float t, out SdfBrushMaterial ret)
		{
		}

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Stride;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x0")]
		public Color Color;

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x10")]
		public Color EmissionHash;

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x20")]
		public Vector4 MetallicSmoothnessSizeTightness;

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x30")]
		public Vector4 TextureWeight;

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x40")]
		public int BrushIndex;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x44")]
		public int Padding0;

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x48")]
		public int Padding1;

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x4C")]
		public int Padding2;

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x060004B2 RID: 1202
		[Token(Token = "0x20000AB")]
		public delegate void Lerp_000002F8$PostfixBurstDelegate(in SdfBrushMaterial a, in SdfBrushMaterial b, float t, out SdfBrushMaterial ret);

		// Token: 0x020000AC RID: 172
		[Token(Token = "0x20000AC")]
		internal static class Lerp_000002F8$BurstDirectCall
		{
			// Token: 0x060004B5 RID: 1205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x24110F0", Offset = "0x240F6F0", VA = "0x1824110F0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060004B6 RID: 1206 RVA: 0x00004950 File Offset: 0x00002B50
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x2411220", Offset = "0x240F820", VA = "0x182411220")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060004B7 RID: 1207 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x2411380", Offset = "0x240F980", VA = "0x182411380")]
			public static void Constructor()
			{
			}

			// Token: 0x060004B8 RID: 1208 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060004BA RID: 1210 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x2411430", Offset = "0x240FA30", VA = "0x182411430")]
			public static void Invoke(in SdfBrushMaterial a, in SdfBrushMaterial b, float t, out SdfBrushMaterial ret)
			{
			}

			// Token: 0x0400035B RID: 859
			[Token(Token = "0x400035B")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400035C RID: 860
			[Token(Token = "0x400035C")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
