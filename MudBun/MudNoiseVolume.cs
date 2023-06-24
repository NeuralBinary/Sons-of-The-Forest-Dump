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
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[BurstCompile]
	public class MudNoiseVolume : MudSolid
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00002E98 File Offset: 0x00001098
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		public SdfBrush.NoiseTypeEnum NoiseType
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x9AF280", Offset = "0x9AD880", VA = "0x1809AF280")]
			get
			{
				return SdfBrush.NoiseTypeEnum.BakedPerlin;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x23BB640", Offset = "0x23B9C40", VA = "0x1823BB640")]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002EB0 File Offset: 0x000010B0
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000030")]
		public MudNoiseVolume.CoordinateSystemEnum CoordinateSystem
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x6FF7C0", Offset = "0x6FDDC0", VA = "0x1806FF7C0")]
			get
			{
				return MudNoiseVolume.CoordinateSystemEnum.Cartesian;
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x23BB650", Offset = "0x23B9C50", VA = "0x1823BB650")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00002EC8 File Offset: 0x000010C8
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		public SdfBrush.BoundaryShapeEnum BoundaryShape
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x8F47A0", Offset = "0x8F2DA0", VA = "0x1808F47A0")]
			get
			{
				return SdfBrush.BoundaryShapeEnum.Box;
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x23BB660", Offset = "0x23B9C60", VA = "0x1823BB660")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00002EE0 File Offset: 0x000010E0
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		public float BoundaryBlend
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x23BB670", Offset = "0x23B9C70", VA = "0x1823BB670")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x23BB680", Offset = "0x23B9C80", VA = "0x1823BB680")]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00002EF8 File Offset: 0x000010F8
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		public float BoundaryRadius
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x1F3D0A0", Offset = "0x1F3B6A0", VA = "0x181F3D0A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x23BB690", Offset = "0x23B9C90", VA = "0x1823BB690")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00002F10 File Offset: 0x00001110
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public float BoundaryAngle
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x1F3D0A0", Offset = "0x1F3B6A0", VA = "0x181F3D0A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x23BB690", Offset = "0x23B9C90", VA = "0x1823BB690")]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00002F28 File Offset: 0x00001128
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		public Vector3 Offset
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x23BB6A0", Offset = "0x23B9CA0", VA = "0x1823BB6A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x23BB6C0", Offset = "0x23B9CC0", VA = "0x1823BB6C0")]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00002F40 File Offset: 0x00001140
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		public Vector3 BaseOctaveSize
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x23BB6E0", Offset = "0x23B9CE0", VA = "0x1823BB6E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x23BB700", Offset = "0x23B9D00", VA = "0x1823BB700")]
			set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00002F58 File Offset: 0x00001158
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		public float Threshold
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x6124C0", Offset = "0x610AC0", VA = "0x1806124C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x23BB720", Offset = "0x23B9D20", VA = "0x1823BB720")]
			set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00002F70 File Offset: 0x00001170
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000038")]
		public float ThresholdFade
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x23BB730", Offset = "0x23B9D30", VA = "0x1823BB730")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x23BB740", Offset = "0x23B9D40", VA = "0x1823BB740")]
			set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00002F88 File Offset: 0x00001188
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		public int NumOctaves
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xAFF2D0", Offset = "0xAFD8D0", VA = "0x180AFF2D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x23BB750", Offset = "0x23B9D50", VA = "0x1823BB750")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00002FA0 File Offset: 0x000011A0
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public float OctaveOffsetFactor
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x7282C0", Offset = "0x7268C0", VA = "0x1807282C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x23BB760", Offset = "0x23B9D60", VA = "0x1823BB760")]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00002FB8 File Offset: 0x000011B8
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		public bool LockPosition
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x7282E0", Offset = "0x7268E0", VA = "0x1807282E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x23BB770", Offset = "0x23B9D70", VA = "0x1823BB770")]
			set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x1700003C")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x23BB780", Offset = "0x23B9D80", VA = "0x1823BB780", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x23BBAF0", Offset = "0x23BA0F0", VA = "0x1823BBAF0", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x23BBB50", Offset = "0x23BA150", VA = "0x1823BBB50", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x23BBEA0", Offset = "0x23BA4A0", VA = "0x1823BBEA0")]
		[BurstCompile]
		private static float SdfBoundary(in float3 pRel, in SdfBrush b, int shape, ref float fadeDist)
		{
			return 0f;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x23BBF20", Offset = "0x23BA520", VA = "0x1823BBF20")]
		[BurstCompile]
		private static void CartesianToSpherical(in float3 p, out float3 ret)
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x23BBF80", Offset = "0x23BA580", VA = "0x1823BBF80")]
		[BurstCompile]
		private static void SphericalToCartesian(in float3 p, out float3 ret)
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x23BBFE0", Offset = "0x23BA5E0", VA = "0x1823BBFE0")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.UniformNoise)]
		[BurstCompile]
		public unsafe static float EvaluateSdf(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x23BC060", Offset = "0x23BA660", VA = "0x1823BC060", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x23BC7D0", Offset = "0x23BADD0", VA = "0x1823BC7D0", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x23BCF30", Offset = "0x23BB530", VA = "0x1823BCF30")]
		public MudNoiseVolume()
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x23BCFF0", Offset = "0x23BB5F0", VA = "0x1823BCFF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SdfBoundary$BurstManaged(in float3 pRel, in SdfBrush b, int shape, ref float fadeDist)
		{
			return 0f;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x23BD650", Offset = "0x23BBC50", VA = "0x1823BD650")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CartesianToSpherical$BurstManaged(in float3 p, out float3 ret)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x23BD700", Offset = "0x23BBD00", VA = "0x1823BD700")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SphericalToCartesian$BurstManaged(in float3 p, out float3 ret)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x23BD7C0", Offset = "0x23BBDC0", VA = "0x1823BD7C0")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.UniformNoise)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SdfBrush.NoiseTypeEnum m_noiseType;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private MudNoiseVolume.CoordinateSystemEnum m_coordinateSystem;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SdfBrush.BoundaryShapeEnum m_boundaryShape;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_boundaryBlend;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x60")]
		[ConditionalField("m_boundaryShape", SdfBrush.BoundaryShapeEnum.Sphere, SdfBrush.BoundaryShapeEnum.Cylinder, SdfBrush.BoundaryShapeEnum.Torus, SdfBrush.BoundaryShapeEnum.SolidAngle, null, null)]
		[SerializeField]
		private float m_boundaryRadius;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[ConditionalField("m_boundaryShape", SdfBrush.BoundaryShapeEnum.SolidAngle, null, null, null, null, null)]
		private float m_boundaryAngle;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector3 m_offset;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Vector3 m_baseOctaveSize;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_threshold;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_thresholdFade;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x88")]
		[Range(1f, 3f)]
		[SerializeField]
		private int m_numOctaves;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float m_octaveOffsetFactor;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool m_lockPosition;

		// Token: 0x02000046 RID: 70
		[Token(Token = "0x2000046")]
		public enum CoordinateSystemEnum
		{
			// Token: 0x04000082 RID: 130
			[Token(Token = "0x4000082")]
			Cartesian,
			// Token: 0x04000083 RID: 131
			[Token(Token = "0x4000083")]
			Spherical
		}

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x060001EF RID: 495
		[Token(Token = "0x2000047")]
		public delegate float SdfBoundary_000000F1$PostfixBurstDelegate(in float3 pRel, in SdfBrush b, int shape, ref float fadeDist);

		// Token: 0x02000048 RID: 72
		[Token(Token = "0x2000048")]
		internal static class SdfBoundary_000000F1$BurstDirectCall
		{
			// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x23BE2B0", Offset = "0x23BC8B0", VA = "0x1823BE2B0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x00003060 File Offset: 0x00001260
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x23BE3E0", Offset = "0x23BC9E0", VA = "0x1823BE3E0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x23BE540", Offset = "0x23BCB40", VA = "0x1823BE540")]
			public static void Constructor()
			{
			}

			// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060001F7 RID: 503 RVA: 0x00003078 File Offset: 0x00001278
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x23BE5F0", Offset = "0x23BCBF0", VA = "0x1823BE5F0")]
			public static float Invoke(in float3 pRel, in SdfBrush b, int shape, ref float fadeDist)
			{
				return 0f;
			}

			// Token: 0x04000084 RID: 132
			[Token(Token = "0x4000084")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000085 RID: 133
			[Token(Token = "0x4000085")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x060001F9 RID: 505
		[Token(Token = "0x2000049")]
		public delegate void CartesianToSpherical_000000F2$PostfixBurstDelegate(in float3 p, out float3 ret);

		// Token: 0x0200004A RID: 74
		[Token(Token = "0x200004A")]
		internal static class CartesianToSpherical_000000F2$BurstDirectCall
		{
			// Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x23BE980", Offset = "0x23BCF80", VA = "0x1823BE980")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060001FD RID: 509 RVA: 0x00003090 File Offset: 0x00001290
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x23BEAB0", Offset = "0x23BD0B0", VA = "0x1823BEAB0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x23BEC10", Offset = "0x23BD210", VA = "0x1823BEC10")]
			public static void Constructor()
			{
			}

			// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x23BECC0", Offset = "0x23BD2C0", VA = "0x1823BECC0")]
			public static void Invoke(in float3 p, out float3 ret)
			{
			}

			// Token: 0x04000086 RID: 134
			[Token(Token = "0x4000086")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000087 RID: 135
			[Token(Token = "0x4000087")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x06000203 RID: 515
		[Token(Token = "0x200004B")]
		public delegate void SphericalToCartesian_000000F3$PostfixBurstDelegate(in float3 p, out float3 ret);

		// Token: 0x0200004C RID: 76
		[Token(Token = "0x200004C")]
		internal static class SphericalToCartesian_000000F3$BurstDirectCall
		{
			// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x23BEFE0", Offset = "0x23BD5E0", VA = "0x1823BEFE0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000207 RID: 519 RVA: 0x000030A8 File Offset: 0x000012A8
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x23BF110", Offset = "0x23BD710", VA = "0x1823BF110")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x23BF270", Offset = "0x23BD870", VA = "0x1823BF270")]
			public static void Constructor()
			{
			}

			// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x23BF320", Offset = "0x23BD920", VA = "0x1823BF320")]
			public static void Invoke(in float3 p, out float3 ret)
			{
			}

			// Token: 0x04000088 RID: 136
			[Token(Token = "0x4000088")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000089 RID: 137
			[Token(Token = "0x4000089")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x0600020D RID: 525
		[Token(Token = "0x200004D")]
		public unsafe delegate float EvaluateSdf_000000F4$PostfixBurstDelegate(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x0200004E RID: 78
		[Token(Token = "0x200004E")]
		internal static class EvaluateSdf_000000F4$BurstDirectCall
		{
			// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x23BF6A0", Offset = "0x23BDCA0", VA = "0x1823BF6A0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000211 RID: 529 RVA: 0x000030C0 File Offset: 0x000012C0
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x23BF7D0", Offset = "0x23BDDD0", VA = "0x1823BF7D0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x23BF930", Offset = "0x23BDF30", VA = "0x1823BF930")]
			public static void Constructor()
			{
			}

			// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000215 RID: 533 RVA: 0x000030D8 File Offset: 0x000012D8
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x23BF9E0", Offset = "0x23BDFE0", VA = "0x1823BF9E0")]
			public unsafe static float Invoke(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x0400008A RID: 138
			[Token(Token = "0x400008A")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400008B RID: 139
			[Token(Token = "0x400008B")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
