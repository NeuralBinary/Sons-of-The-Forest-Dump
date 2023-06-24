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
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	[BurstCompile]
	public class MudTwist : MudDistortion
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00002DA8 File Offset: 0x00000FA8
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		public float Radius
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x23A5B60", Offset = "0x23A4160", VA = "0x1823A5B60")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00002DC0 File Offset: 0x00000FC0
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public float Angle
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x23A5B80", Offset = "0x23A4180", VA = "0x1823A5B80")]
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00002DD8 File Offset: 0x00000FD8
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		public float Strength
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x23A5B90", Offset = "0x23A4190", VA = "0x1823A5B90")]
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x1700002D")]
		public override float MaxDistortion
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x23BA0A0", Offset = "0x23B86A0", VA = "0x1823BA0A0", Slot = "30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x1700002E")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x23BA120", Offset = "0x23B8720", VA = "0x1823BA120", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x23BA4E0", Offset = "0x23B8AE0", VA = "0x1823BA4E0", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x23BA4F0", Offset = "0x23B8AF0", VA = "0x1823BA4F0", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x23BA6A0", Offset = "0x23B8CA0", VA = "0x1823BA6A0")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Twist)]
		[BurstCompile]
		public unsafe static float EvaluateSdf(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x23BA720", Offset = "0x23B8D20", VA = "0x1823BA720", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x23BAA20", Offset = "0x23B9020", VA = "0x1823BAA20", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x23BAD30", Offset = "0x23B9330", VA = "0x1823BAD30")]
		public MudTwist()
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x23BAD50", Offset = "0x23B9350", VA = "0x1823BAD50")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Twist)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_radius;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_angle;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(1f, 5f)]
		private float m_strength;

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060001BD RID: 445
		[Token(Token = "0x2000043")]
		public unsafe delegate float EvaluateSdf_000000D0$PostfixBurstDelegate(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x02000044 RID: 68
		[Token(Token = "0x2000044")]
		internal static class EvaluateSdf_000000D0$BurstDirectCall
		{
			// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x23BB0F0", Offset = "0x23B96F0", VA = "0x1823BB0F0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060001C1 RID: 449 RVA: 0x00002E68 File Offset: 0x00001068
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x23BB220", Offset = "0x23B9820", VA = "0x1823BB220")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x23BB380", Offset = "0x23B9980", VA = "0x1823BB380")]
			public static void Constructor()
			{
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060001C5 RID: 453 RVA: 0x00002E80 File Offset: 0x00001080
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x23BB430", Offset = "0x23B9A30", VA = "0x1823BB430")]
			public unsafe static float Invoke(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x04000072 RID: 114
			[Token(Token = "0x4000072")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000073 RID: 115
			[Token(Token = "0x4000073")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
