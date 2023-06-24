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
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[BurstCompile]
	public class MudNoiseModifier : MudModifier
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000031C8 File Offset: 0x000013C8
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000040")]
		public float Strength
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x23A5B60", Offset = "0x23A4160", VA = "0x1823A5B60")]
			set
			{
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000232 RID: 562 RVA: 0x000031E0 File Offset: 0x000013E0
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000041")]
		public SdfBrush.NoiseTypeEnum NoiseType
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x5FDAB0", Offset = "0x5FC0B0", VA = "0x1805FDAB0")]
			get
			{
				return SdfBrush.NoiseTypeEnum.BakedPerlin;
			}
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x23C2520", Offset = "0x23C0B20", VA = "0x1823C2520")]
			set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000234 RID: 564 RVA: 0x000031F8 File Offset: 0x000013F8
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		public MudNoiseModifier.CoordinateSystemEnum CoordinateSystem
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			get
			{
				return MudNoiseModifier.CoordinateSystemEnum.Cartesian;
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x23C2530", Offset = "0x23C0B30", VA = "0x1823C2530")]
			set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00003210 File Offset: 0x00001410
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		public SdfBrush.BoundaryShapeEnum BoundaryShape
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x76BE00", Offset = "0x76A400", VA = "0x18076BE00")]
			get
			{
				return SdfBrush.BoundaryShapeEnum.Box;
			}
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x23C2540", Offset = "0x23C0B40", VA = "0x1823C2540")]
			set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00003228 File Offset: 0x00001428
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		public float BoundaryBlend
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x5F1D00", Offset = "0x5F0300", VA = "0x1805F1D00")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x23C2550", Offset = "0x23C0B50", VA = "0x1823C2550")]
			set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00003240 File Offset: 0x00001440
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		public float BoundaryRadius
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x5F1D10", Offset = "0x5F0310", VA = "0x1805F1D10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x23C2560", Offset = "0x23C0B60", VA = "0x1823C2560")]
			set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00003258 File Offset: 0x00001458
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		public float BoundaryAngle
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x5F1D10", Offset = "0x5F0310", VA = "0x1805F1D10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x23C2560", Offset = "0x23C0B60", VA = "0x1823C2560")]
			set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00003270 File Offset: 0x00001470
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public Vector3 Offset
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x23C2570", Offset = "0x23C0B70", VA = "0x1823C2570")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x23C2590", Offset = "0x23C0B90", VA = "0x1823C2590")]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00003288 File Offset: 0x00001488
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000048")]
		public Vector3 BaseOctaveSize
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x23C25B0", Offset = "0x23C0BB0", VA = "0x1823C25B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x23C25D0", Offset = "0x23C0BD0", VA = "0x1823C25D0")]
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000242 RID: 578 RVA: 0x000032A0 File Offset: 0x000014A0
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		public float Threshold
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x23C25F0", Offset = "0x23C0BF0", VA = "0x1823C25F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x23C2600", Offset = "0x23C0C00", VA = "0x1823C2600")]
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000244 RID: 580 RVA: 0x000032B8 File Offset: 0x000014B8
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004A")]
		public float ThresholdFade
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x23C2610", Offset = "0x23C0C10", VA = "0x1823C2610")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x23C2620", Offset = "0x23C0C20", VA = "0x1823C2620")]
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000032D0 File Offset: 0x000014D0
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004B")]
		public int NumOctaves
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0xAFDBB0", Offset = "0xAFC1B0", VA = "0x180AFDBB0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x23C2630", Offset = "0x23C0C30", VA = "0x1823C2630")]
			set
			{
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000032E8 File Offset: 0x000014E8
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		public float OctaveOffsetFactor
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x23C2640", Offset = "0x23C0C40", VA = "0x1823C2640")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x23C2650", Offset = "0x23C0C50", VA = "0x1823C2650")]
			set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00003300 File Offset: 0x00001500
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004D")]
		public bool LockPosition
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x23C2660", Offset = "0x23C0C60", VA = "0x1823C2660")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x23C2670", Offset = "0x23C0C70", VA = "0x1823C2670")]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x1700004E")]
		public override float MaxModification
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320", Slot = "30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x1700004F")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x23C2680", Offset = "0x23C0C80", VA = "0x1823C2680", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x23C29F0", Offset = "0x23C0FF0", VA = "0x1823C29F0", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x23C2A50", Offset = "0x23C1050", VA = "0x1823C2A50", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x23C2D90", Offset = "0x23C1390", VA = "0x1823C2D90")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.NoiseModifier)]
		[BurstCompile]
		public unsafe static float EvaluateSdf(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x23C2E10", Offset = "0x23C1410", VA = "0x1823C2E10", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x23C3580", Offset = "0x23C1B80", VA = "0x1823C3580", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x23C3CE0", Offset = "0x23C22E0", VA = "0x1823C3CE0")]
		public MudNoiseModifier()
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x23C3DA0", Offset = "0x23C23A0", VA = "0x1823C3DA0")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.NoiseModifier)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_strength;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private SdfBrush.NoiseTypeEnum m_noiseType;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MudNoiseModifier.CoordinateSystemEnum m_coordinateSystem;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private SdfBrush.BoundaryShapeEnum m_boundaryShape;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_boundaryBlend;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[ConditionalField("m_boundaryShape", SdfBrush.BoundaryShapeEnum.Sphere, SdfBrush.BoundaryShapeEnum.Cylinder, SdfBrush.BoundaryShapeEnum.Torus, SdfBrush.BoundaryShapeEnum.SolidAngle, null, null)]
		private float m_boundaryRadius;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x50")]
		[ConditionalField("m_boundaryShape", SdfBrush.BoundaryShapeEnum.SolidAngle, null, null, null, null, null)]
		[SerializeField]
		private float m_boundaryAngle;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector3 m_offset;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector3 m_baseOctaveSize;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_threshold;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_thresholdFade;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x74")]
		[Range(1f, 3f)]
		[SerializeField]
		private int m_numOctaves;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float m_octaveOffsetFactor;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private bool m_lockPosition;

		// Token: 0x02000054 RID: 84
		[Token(Token = "0x2000054")]
		public enum CoordinateSystemEnum
		{
			// Token: 0x040000AC RID: 172
			[Token(Token = "0x40000AC")]
			Cartesian,
			// Token: 0x040000AD RID: 173
			[Token(Token = "0x40000AD")]
			Spherical
		}

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000256 RID: 598
		[Token(Token = "0x2000055")]
		public unsafe delegate float EvaluateSdf_00000127$PostfixBurstDelegate(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x02000056 RID: 86
		[Token(Token = "0x2000056")]
		internal static class EvaluateSdf_00000127$BurstDirectCall
		{
			// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x23C3ED0", Offset = "0x23C24D0", VA = "0x1823C3ED0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600025A RID: 602 RVA: 0x00003390 File Offset: 0x00001590
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x23C4000", Offset = "0x23C2600", VA = "0x1823C4000")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x23C4160", Offset = "0x23C2760", VA = "0x1823C4160")]
			public static void Constructor()
			{
			}

			// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600025E RID: 606 RVA: 0x000033A8 File Offset: 0x000015A8
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x23C4210", Offset = "0x23C2810", VA = "0x1823C4210")]
			public unsafe static float Invoke(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x040000AE RID: 174
			[Token(Token = "0x40000AE")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x040000AF RID: 175
			[Token(Token = "0x40000AF")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
