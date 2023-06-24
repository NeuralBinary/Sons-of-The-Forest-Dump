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
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	[BurstCompile]
	public class MudSphere : MudSolid
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x000047A0 File Offset: 0x000029A0
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D5")]
		public float Radius
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x23A8C00", Offset = "0x23A7200", VA = "0x1823A8C00")]
			set
			{
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x170000D6")]
		public Vector3 PivotShiftOffset
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x23FABF0", Offset = "0x23F91F0", VA = "0x1823FABF0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x170000D7")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x240D6F0", Offset = "0x240BCF0", VA = "0x18240D6F0", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x23A90A0", Offset = "0x23A76A0", VA = "0x1823A90A0", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x240DB60", Offset = "0x240C160", VA = "0x18240DB60", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x240DDA0", Offset = "0x240C3A0", VA = "0x18240DDA0")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Sphere)]
		[BurstCompile]
		public unsafe static float EvaluateSdf(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x240DE20", Offset = "0x240C420", VA = "0x18240DE20", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x240E1A0", Offset = "0x240C7A0", VA = "0x18240E1A0", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x23FF5C0", Offset = "0x23FDBC0", VA = "0x1823FF5C0")]
		public MudSphere()
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00004818 File Offset: 0x00002A18
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x240E520", Offset = "0x240CB20", VA = "0x18240E520")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Sphere)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_radius;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x54")]
		[Range(-1f, 1f)]
		public float PivotShift;

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x0600048B RID: 1163
		[Token(Token = "0x20000A4")]
		public unsafe delegate float EvaluateSdf_000002E5$PostfixBurstDelegate(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x020000A5 RID: 165
		[Token(Token = "0x20000A5")]
		internal static class EvaluateSdf_000002E5$BurstDirectCall
		{
			// Token: 0x0600048E RID: 1166 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x240E7B0", Offset = "0x240CDB0", VA = "0x18240E7B0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600048F RID: 1167 RVA: 0x00004830 File Offset: 0x00002A30
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x240E8E0", Offset = "0x240CEE0", VA = "0x18240E8E0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000490 RID: 1168 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x240EA40", Offset = "0x240D040", VA = "0x18240EA40")]
			public static void Constructor()
			{
			}

			// Token: 0x06000491 RID: 1169 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000493 RID: 1171 RVA: 0x00004848 File Offset: 0x00002A48
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x240EAF0", Offset = "0x240D0F0", VA = "0x18240EAF0")]
			public unsafe static float Invoke(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x0400034C RID: 844
			[Token(Token = "0x400034C")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400034D RID: 845
			[Token(Token = "0x400034D")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
