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
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	[BurstCompile]
	public class MudSolidAngle : MudSolid
	{
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x000046C8 File Offset: 0x000028C8
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D1")]
		public float Radius
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x23A8C00", Offset = "0x23A7200", VA = "0x1823A8C00")]
			set
			{
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x000046E0 File Offset: 0x000028E0
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D2")]
		public float Angle
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x23FC6E0", Offset = "0x23FACE0", VA = "0x1823FC6E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x23FC6F0", Offset = "0x23FACF0", VA = "0x1823FC6F0")]
			set
			{
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x000046F8 File Offset: 0x000028F8
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D3")]
		public float Round
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x23BFBF0", Offset = "0x23BE1F0", VA = "0x1823BFBF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x23BFC00", Offset = "0x23BE200", VA = "0x1823BFC00")]
			set
			{
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x170000D4")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x240C3C0", Offset = "0x240A9C0", VA = "0x18240C3C0", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x2409C60", Offset = "0x2408260", VA = "0x182409C60", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x240C6A0", Offset = "0x240ACA0", VA = "0x18240C6A0", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x240C950", Offset = "0x240AF50", VA = "0x18240C950")]
		[BurstCompile]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.SolidAngle)]
		public unsafe static float EvaluateSdf(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x240C9D0", Offset = "0x240AFD0", VA = "0x18240C9D0", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x240CC00", Offset = "0x240B200", VA = "0x18240CC00", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x240CEE0", Offset = "0x240B4E0", VA = "0x18240CEE0")]
		public MudSolidAngle()
		{
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x240CF00", Offset = "0x240B500", VA = "0x18240CF00")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.SolidAngle)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_radius;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Range(0f, 180f)]
		private float m_angle;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_round;

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x06000476 RID: 1142
		[Token(Token = "0x20000A1")]
		public unsafe delegate float EvaluateSdf_000002DB$PostfixBurstDelegate(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x020000A2 RID: 162
		[Token(Token = "0x20000A2")]
		internal static class EvaluateSdf_000002DB$BurstDirectCall
		{
			// Token: 0x06000479 RID: 1145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x240D0E0", Offset = "0x240B6E0", VA = "0x18240D0E0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600047A RID: 1146 RVA: 0x00004770 File Offset: 0x00002970
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x240D210", Offset = "0x240B810", VA = "0x18240D210")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x240D370", Offset = "0x240B970", VA = "0x18240D370")]
			public static void Constructor()
			{
			}

			// Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600047E RID: 1150 RVA: 0x00004788 File Offset: 0x00002988
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x240D420", Offset = "0x240BA20", VA = "0x18240D420")]
			public unsafe static float Invoke(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x04000348 RID: 840
			[Token(Token = "0x4000348")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000349 RID: 841
			[Token(Token = "0x4000349")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
