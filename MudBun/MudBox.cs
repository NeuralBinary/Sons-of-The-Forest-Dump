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
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	[BurstCompile]
	public class MudBox : MudSolid
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00004128 File Offset: 0x00002328
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B1")]
		public float Round
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x23A8C00", Offset = "0x23A7200", VA = "0x1823A8C00")]
			set
			{
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x170000B2")]
		public Vector3 PivotShiftOffset
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x23FABF0", Offset = "0x23F91F0", VA = "0x1823FABF0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x170000B3")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x23FADC0", Offset = "0x23F93C0", VA = "0x1823FADC0", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x23A90A0", Offset = "0x23A76A0", VA = "0x1823A90A0", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x23FB2D0", Offset = "0x23F98D0", VA = "0x1823FB2D0", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x23FB510", Offset = "0x23F9B10", VA = "0x1823FB510")]
		[BurstCompile]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Box)]
		public unsafe static float EvaluateSdf(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x23FB590", Offset = "0x23F9B90", VA = "0x1823FB590", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x23FB970", Offset = "0x23F9F70", VA = "0x1823FB970", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x23A9900", Offset = "0x23A7F00", VA = "0x1823A9900")]
		public MudBox()
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x23FBD50", Offset = "0x23FA350", VA = "0x1823FBD50")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Box)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_round;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x54")]
		[Range(-1f, 1f)]
		public float PivotShift;

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060003E4 RID: 996
		[Token(Token = "0x2000092")]
		public unsafe delegate float EvaluateSdf_0000027E$PostfixBurstDelegate(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x2000093")]
		internal static class EvaluateSdf_0000027E$BurstDirectCall
		{
			// Token: 0x060003E7 RID: 999 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x23FC010", Offset = "0x23FA610", VA = "0x1823FC010")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x000041B8 File Offset: 0x000023B8
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x23FC140", Offset = "0x23FA740", VA = "0x1823FC140")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060003E9 RID: 1001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x23FC2A0", Offset = "0x23FA8A0", VA = "0x1823FC2A0")]
			public static void Constructor()
			{
			}

			// Token: 0x060003EA RID: 1002 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x000041D0 File Offset: 0x000023D0
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x23FC350", Offset = "0x23FA950", VA = "0x1823FC350")]
			public unsafe static float Invoke(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x04000316 RID: 790
			[Token(Token = "0x4000316")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000317 RID: 791
			[Token(Token = "0x4000317")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
