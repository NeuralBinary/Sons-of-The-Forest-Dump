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
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[BurstCompile]
	public class MudQuantize : MudDistortion
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00002CB8 File Offset: 0x00000EB8
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public float CellSize
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x23A5B60", Offset = "0x23A4160", VA = "0x1823A5B60")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00002CD0 File Offset: 0x00000ED0
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public float Strength
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x23A5B80", Offset = "0x23A4180", VA = "0x1823A5B80")]
			set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00002CE8 File Offset: 0x00000EE8
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public float Fade
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x23A5B90", Offset = "0x23A4190", VA = "0x1823A5B90")]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x17000028")]
		public override float MaxDistortion
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320", Slot = "30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x17000029")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x23B88A0", Offset = "0x23B6EA0", VA = "0x1823B88A0", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x23B8D30", Offset = "0x23B7330", VA = "0x1823B8D30", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x23B8D60", Offset = "0x23B7360", VA = "0x1823B8D60", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x23B8ED0", Offset = "0x23B74D0", VA = "0x1823B8ED0")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Quantize)]
		[BurstCompile]
		public unsafe static float EvaluateSdf(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x23B8F50", Offset = "0x23B7550", VA = "0x1823B8F50", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x23B9240", Offset = "0x23B7840", VA = "0x1823B9240", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x23A6870", Offset = "0x23A4E70", VA = "0x1823A6870")]
		public MudQuantize()
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x23B9530", Offset = "0x23B7B30", VA = "0x1823B9530")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Quantize)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_cellSize;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Range(0f, 10f)]
		private float m_strength;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_fade;

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060001A4 RID: 420
		[Token(Token = "0x2000040")]
		public unsafe delegate float EvaluateSdf_000000C2$PostfixBurstDelegate(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x02000041 RID: 65
		[Token(Token = "0x2000041")]
		internal static class EvaluateSdf_000000C2$BurstDirectCall
		{
			// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x23B9B50", Offset = "0x23B8150", VA = "0x1823B9B50")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060001A8 RID: 424 RVA: 0x00002D78 File Offset: 0x00000F78
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x23B9C80", Offset = "0x23B8280", VA = "0x1823B9C80")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x23B9DE0", Offset = "0x23B83E0", VA = "0x1823B9DE0")]
			public static void Constructor()
			{
			}

			// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060001AC RID: 428 RVA: 0x00002D90 File Offset: 0x00000F90
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x23B9E90", Offset = "0x23B8490", VA = "0x1823B9E90")]
			public unsafe static float Invoke(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x0400006D RID: 109
			[Token(Token = "0x400006D")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400006E RID: 110
			[Token(Token = "0x400006E")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
