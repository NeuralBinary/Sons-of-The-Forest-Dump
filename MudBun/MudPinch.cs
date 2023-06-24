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
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[BurstCompile]
	public class MudPinch : MudDistortion
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00002BB0 File Offset: 0x00000DB0
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public float Radius
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x23A5B60", Offset = "0x23A4160", VA = "0x1823A5B60")]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00002BC8 File Offset: 0x00000DC8
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		public float Depth
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x23A5B80", Offset = "0x23A4180", VA = "0x1823A5B80")]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00002BE0 File Offset: 0x00000DE0
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		public float Amount
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x23A5B90", Offset = "0x23A4190", VA = "0x1823A5B90")]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00002BF8 File Offset: 0x00000DF8
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		public float Strength
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x23B72F0", Offset = "0x23B58F0", VA = "0x1823B72F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x23B7300", Offset = "0x23B5900", VA = "0x1823B7300")]
			set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x17000023")]
		public override float MaxDistortion
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70", Slot = "30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x17000024")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x23B7310", Offset = "0x23B5910", VA = "0x1823B7310", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x23B75E0", Offset = "0x23B5BE0", VA = "0x1823B75E0", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x23B7620", Offset = "0x23B5C20", VA = "0x1823B7620", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x23B7770", Offset = "0x23B5D70", VA = "0x1823B7770")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Pinch)]
		[BurstCompile]
		public unsafe static float EvaluateSdf(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x23B77F0", Offset = "0x23B5DF0", VA = "0x1823B77F0", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x23B7B50", Offset = "0x23B6150", VA = "0x1823B7B50", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x23B7EB0", Offset = "0x23B64B0", VA = "0x1823B7EB0")]
		public MudPinch()
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x23B7EE0", Offset = "0x23B64E0", VA = "0x1823B7EE0")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Pinch)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_radius;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_depth;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_amount;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Range(1f, 10f)]
		private float m_strength;

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x0600018B RID: 395
		[Token(Token = "0x200003D")]
		public unsafe delegate float EvaluateSdf_000000B4$PostfixBurstDelegate(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x200003E")]
		internal static class EvaluateSdf_000000B4$BurstDirectCall
		{
			// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x23B8350", Offset = "0x23B6950", VA = "0x1823B8350")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600018F RID: 399 RVA: 0x00002C88 File Offset: 0x00000E88
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x23B8480", Offset = "0x23B6A80", VA = "0x1823B8480")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x23B85E0", Offset = "0x23B6BE0", VA = "0x1823B85E0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000193 RID: 403 RVA: 0x00002CA0 File Offset: 0x00000EA0
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x23B8690", Offset = "0x23B6C90", VA = "0x1823B8690")]
			public unsafe static float Invoke(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x04000068 RID: 104
			[Token(Token = "0x4000068")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000069 RID: 105
			[Token(Token = "0x4000069")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
