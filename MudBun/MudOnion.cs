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
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[BurstCompile]
	public class MudOnion : MudModifier
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600025F RID: 607 RVA: 0x000033C0 File Offset: 0x000015C0
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000050")]
		public float Thickness
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x23A5B60", Offset = "0x23A4160", VA = "0x1823A5B60")]
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000261 RID: 609 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x17000051")]
		public override float MaxModification
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320", Slot = "30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000262 RID: 610 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x17000052")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x23C4430", Offset = "0x23C2A30", VA = "0x1823C4430", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x23A79C0", Offset = "0x23A5FC0", VA = "0x1823A79C0", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x23C48A0", Offset = "0x23C2EA0", VA = "0x1823C48A0", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x23C4A00", Offset = "0x23C3000", VA = "0x1823C4A00")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Onion)]
		[BurstCompile]
		public unsafe static float EvaluateSdf(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x23C4A80", Offset = "0x23C3080", VA = "0x1823C4A80", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x23C4D70", Offset = "0x23C3370", VA = "0x1823C4D70", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x23A81D0", Offset = "0x23A67D0", VA = "0x1823A81D0")]
		public MudOnion()
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x23C5060", Offset = "0x23C3660", VA = "0x1823C5060")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Onion)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_thickness;

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x0600026B RID: 619
		[Token(Token = "0x2000058")]
		public unsafe delegate float EvaluateSdf_00000131$PostfixBurstDelegate(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x02000059 RID: 89
		[Token(Token = "0x2000059")]
		internal static class EvaluateSdf_00000131$BurstDirectCall
		{
			// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x23C5330", Offset = "0x23C3930", VA = "0x1823C5330")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600026F RID: 623 RVA: 0x00003450 File Offset: 0x00001650
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x23C5460", Offset = "0x23C3A60", VA = "0x1823C5460")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x23C55C0", Offset = "0x23C3BC0", VA = "0x1823C55C0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000273 RID: 627 RVA: 0x00003468 File Offset: 0x00001668
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x23C5670", Offset = "0x23C3C70", VA = "0x1823C5670")]
			public unsafe static float Invoke(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x040000B1 RID: 177
			[Token(Token = "0x40000B1")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x040000B2 RID: 178
			[Token(Token = "0x40000B2")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
