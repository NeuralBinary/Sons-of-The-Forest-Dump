using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace MudBun
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[BurstCompile]
	public class CustomModifier : MudModifier
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public float Thickness
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x23A5B60", Offset = "0x23A4160", VA = "0x1823A5B60")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x17000007")]
		public override float MaxModification
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320", Slot = "30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x17000008")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x23A7550", Offset = "0x23A5B50", VA = "0x1823A7550", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x23A79C0", Offset = "0x23A5FC0", VA = "0x1823A79C0", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x23A79E0", Offset = "0x23A5FE0", VA = "0x1823A79E0", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x23A7B70", Offset = "0x23A6170", VA = "0x1823A7B70")]
		[RegisterSdfBrushEvalFunc(902)]
		[BurstCompile]
		public unsafe static float EvaluateSdf(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x23A7BF0", Offset = "0x23A61F0", VA = "0x1823A7BF0", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x23A7EE0", Offset = "0x23A64E0", VA = "0x1823A7EE0", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x23A81D0", Offset = "0x23A67D0", VA = "0x1823A81D0")]
		public CustomModifier()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x23A8220", Offset = "0x23A6820", VA = "0x1823A8220")]
		[RegisterSdfBrushEvalFunc(902)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int TypeId;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_thickness;

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600002D RID: 45
		[Token(Token = "0x200000B")]
		public unsafe delegate float EvaluateSdf_0000001B$PostfixBurstDelegate(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		internal static class EvaluateSdf_0000001B$BurstDirectCall
		{
			// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x23A84F0", Offset = "0x23A6AF0", VA = "0x1823A84F0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000031 RID: 49 RVA: 0x000021F0 File Offset: 0x000003F0
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x23A8620", Offset = "0x23A6C20", VA = "0x1823A8620")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x23A8780", Offset = "0x23A6D80", VA = "0x1823A8780")]
			public static void Constructor()
			{
			}

			// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000035 RID: 53 RVA: 0x00002208 File Offset: 0x00000408
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x23A8830", Offset = "0x23A6E30", VA = "0x1823A8830")]
			public unsafe static float Invoke(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
