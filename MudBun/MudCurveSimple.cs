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
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	[BurstCompile]
	public class MudCurveSimple : MudSolid
	{
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x000043C8 File Offset: 0x000025C8
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BC")]
		public float Elongation
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x23A8C00", Offset = "0x23A7200", VA = "0x1823A8C00")]
			set
			{
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x000043E0 File Offset: 0x000025E0
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BD")]
		public float RadiusA
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x23C2610", Offset = "0x23C0C10", VA = "0x1823C2610")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x23C2620", Offset = "0x23C0C20", VA = "0x1823C2620")]
			set
			{
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x000043F8 File Offset: 0x000025F8
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BE")]
		public float ControlPointRadius
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x2403E60", Offset = "0x2402460", VA = "0x182403E60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x2403E70", Offset = "0x2402470", VA = "0x182403E70")]
			set
			{
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00004410 File Offset: 0x00002610
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BF")]
		public float RadiusB
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x23C2640", Offset = "0x23C0C40", VA = "0x1823C2640")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x23C2650", Offset = "0x23C0C50", VA = "0x1823C2650")]
			set
			{
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00004428 File Offset: 0x00002628
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C0")]
		public float SmoothStepBlend
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x6124A0", Offset = "0x610AA0", VA = "0x1806124A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x2403E80", Offset = "0x2402480", VA = "0x182403E80")]
			set
			{
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00004440 File Offset: 0x00002640
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C1")]
		public bool EnableNoise
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x9ABDB0", Offset = "0x9AA3B0", VA = "0x1809ABDB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x2403E90", Offset = "0x2402490", VA = "0x182403E90")]
			set
			{
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00004458 File Offset: 0x00002658
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C2")]
		public float NoiseOffset
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x23BB730", Offset = "0x23B9D30", VA = "0x1823BB730")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x23BB740", Offset = "0x23B9D40", VA = "0x1823BB740")]
			set
			{
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00004470 File Offset: 0x00002670
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C3")]
		public Vector2 NoiseBaseOctaveSize
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x179D830", Offset = "0x179BE30", VA = "0x18179D830")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x2403EA0", Offset = "0x24024A0", VA = "0x182403EA0")]
			set
			{
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00004488 File Offset: 0x00002688
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C4")]
		public float NoiseThreshold
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x2403EB0", Offset = "0x24024B0", VA = "0x182403EB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x2403EC0", Offset = "0x24024C0", VA = "0x182403EC0")]
			set
			{
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x000044A0 File Offset: 0x000026A0
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C5")]
		public float NoiseThresholdFade
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x728300", Offset = "0x726900", VA = "0x180728300")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x2403ED0", Offset = "0x24024D0", VA = "0x182403ED0")]
			set
			{
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x000044B8 File Offset: 0x000026B8
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C6")]
		public float NoiseThresholdCoreBias
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x728320", Offset = "0x726920", VA = "0x180728320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x2403EE0", Offset = "0x24024E0", VA = "0x182403EE0")]
			set
			{
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x000044D0 File Offset: 0x000026D0
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C7")]
		public int NoiseNumOctaves
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0xA03D80", Offset = "0xA02380", VA = "0x180A03D80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x2403EF0", Offset = "0x24024F0", VA = "0x182403EF0")]
			set
			{
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x000044E8 File Offset: 0x000026E8
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C8")]
		public float NoiseOctaveOffsetFactor
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x727F30", Offset = "0x726530", VA = "0x180727F30")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x2403F00", Offset = "0x2402500", VA = "0x182403F00")]
			set
			{
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00004500 File Offset: 0x00002700
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C9")]
		public float NoiseTwist
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x2403F10", Offset = "0x2402510", VA = "0x182403F10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x2403F20", Offset = "0x2402520", VA = "0x182403F20")]
			set
			{
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00004518 File Offset: 0x00002718
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CA")]
		public float NoiseTwistOffset
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x2403F30", Offset = "0x2402530", VA = "0x182403F30")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x2403F40", Offset = "0x2402540", VA = "0x182403F40")]
			set
			{
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x170000CB")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x2403F50", Offset = "0x2402550", VA = "0x182403F50", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x2404B20", Offset = "0x2403120", VA = "0x182404B20", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x2404B80", Offset = "0x2403180", VA = "0x182404B80")]
		private void Update()
		{
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x2405070", Offset = "0x2403670", VA = "0x182405070", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x24063C0", Offset = "0x24049C0", VA = "0x1824063C0", Slot = "20")]
		public override void FillBrushData(ref SdfBrush brush, int iBrush)
		{
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x2341F10", Offset = "0x2340510", VA = "0x182341F10", Slot = "25")]
		internal override bool IsSelected()
		{
			return default(bool);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x24065B0", Offset = "0x2404BB0", VA = "0x1824065B0", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x2406BB0", Offset = "0x24051B0", VA = "0x182406BB0")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.CurveSimple)]
		[BurstCompile]
		public unsafe static float EvaluateSdf(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x2406C30", Offset = "0x2405230", VA = "0x182406C30", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x24079F0", Offset = "0x2405FF0", VA = "0x1824079F0")]
		public MudCurveSimple()
		{
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x2407B10", Offset = "0x2406110", VA = "0x182407B10")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.CurveSimple)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x50")]
		[Header("Shape")]
		[SerializeField]
		private float m_elongation;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x58")]
		public Transform PointA;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x60")]
		public Transform ControlPoint;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x68")]
		public Transform PointB;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float m_radiusA;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float m_radiusControlPoint;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float m_radiusB;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_smoothStepBlend;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Header("Noise")]
		private bool m_enableNoise;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float m_noiseOffset;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Vector2 m_noiseBaseOctaveSize;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_noiseThreshold;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x94")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_noiseThresholdFade;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Range(-1f, 1f)]
		private float m_noiseThresholdCoreBias;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[Range(1f, 3f)]
		private int m_noiseNumOctaves;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float m_noiseOctaveOffsetFactor;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float m_noiseTwist;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float m_noiseTwistOffset;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0xB0")]
		private Transform[] m_aPoint;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0xB8")]
		public Matrix4x4 m_basis;

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000445 RID: 1093
		[Token(Token = "0x200009B")]
		public unsafe delegate float EvaluateSdf_000002C1$PostfixBurstDelegate(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x0200009C RID: 156
		[Token(Token = "0x200009C")]
		internal static class EvaluateSdf_000002C1$BurstDirectCall
		{
			// Token: 0x06000448 RID: 1096 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x2409000", Offset = "0x2407600", VA = "0x182409000")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000449 RID: 1097 RVA: 0x000045A8 File Offset: 0x000027A8
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x2409130", Offset = "0x2407730", VA = "0x182409130")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x2409290", Offset = "0x2407890", VA = "0x182409290")]
			public static void Constructor()
			{
			}

			// Token: 0x0600044B RID: 1099 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600044D RID: 1101 RVA: 0x000045C0 File Offset: 0x000027C0
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x2409340", Offset = "0x2407940", VA = "0x182409340")]
			public unsafe static float Invoke(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x0400033D RID: 829
			[Token(Token = "0x400033D")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400033E RID: 830
			[Token(Token = "0x400033E")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
