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
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	[BurstCompile]
	public class MudCylinder : MudSolid
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x000045D8 File Offset: 0x000027D8
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CC")]
		public float Radius
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x23A8C00", Offset = "0x23A7200", VA = "0x1823A8C00")]
			set
			{
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x000045F0 File Offset: 0x000027F0
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CD")]
		public float TopRadiusOffset
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x23FC6E0", Offset = "0x23FACE0", VA = "0x1823FC6E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x23FC6F0", Offset = "0x23FACF0", VA = "0x1823FC6F0")]
			set
			{
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00004608 File Offset: 0x00002808
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CE")]
		public float Round
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x23BFBF0", Offset = "0x23BE1F0", VA = "0x1823BFBF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x23BFC00", Offset = "0x23BE200", VA = "0x1823BFC00")]
			set
			{
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x170000CF")]
		public Vector3 PivotShiftOffset
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x2409550", Offset = "0x2407B50", VA = "0x182409550")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x170000D0")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x2409720", Offset = "0x2407D20", VA = "0x182409720", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x2409C60", Offset = "0x2408260", VA = "0x182409C60", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x2409C90", Offset = "0x2408290", VA = "0x182409C90", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x2409EE0", Offset = "0x24084E0", VA = "0x182409EE0")]
		[BurstCompile]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Cylinder)]
		public unsafe static float EvaluateSdf(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x2409F60", Offset = "0x2408560", VA = "0x182409F60", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x240B720", Offset = "0x2409D20", VA = "0x18240B720", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x23FF5C0", Offset = "0x23FDBC0", VA = "0x1823FF5C0")]
		public MudCylinder()
		{
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x240BAE0", Offset = "0x240A0E0", VA = "0x18240BAE0")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Cylinder)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_radius;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_topRadiusOffset;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_round;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x5C")]
		[Range(-1f, 1f)]
		public float PivotShift;

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x0600045E RID: 1118
		[Token(Token = "0x200009E")]
		public unsafe delegate float EvaluateSdf_000002CE$PostfixBurstDelegate(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x0200009F RID: 159
		[Token(Token = "0x200009F")]
		internal static class EvaluateSdf_000002CE$BurstDirectCall
		{
			// Token: 0x06000461 RID: 1121 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x240BE80", Offset = "0x240A480", VA = "0x18240BE80")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x00004698 File Offset: 0x00002898
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x240BFB0", Offset = "0x240A5B0", VA = "0x18240BFB0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x240C110", Offset = "0x240A710", VA = "0x18240C110")]
			public static void Constructor()
			{
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x000046B0 File Offset: 0x000028B0
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x240C1C0", Offset = "0x240A7C0", VA = "0x18240C1C0")]
			public unsafe static float Invoke(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x04000343 RID: 835
			[Token(Token = "0x4000343")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000344 RID: 836
			[Token(Token = "0x4000344")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
