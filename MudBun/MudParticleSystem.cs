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
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[ExecuteInEditMode]
	[BurstCompile]
	public class MudParticleSystem : MudSolid
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000216 RID: 534 RVA: 0x000030F0 File Offset: 0x000012F0
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003D")]
		public float RadiusMultiplier
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x23BFBF0", Offset = "0x23BE1F0", VA = "0x1823BFBF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x23BFC00", Offset = "0x23BE200", VA = "0x1823BFC00")]
			set
			{
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00003108 File Offset: 0x00001308
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		public float SelfBlend
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x23BB670", Offset = "0x23B9C70", VA = "0x1823BB670")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x23BB680", Offset = "0x23B9C80", VA = "0x1823BB680")]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x1700003F")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x23BFC10", Offset = "0x23BE210", VA = "0x1823BFC10", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x23BFFF0", Offset = "0x23BE5F0", VA = "0x1823BFFF0")]
		private bool ReadParticles()
		{
			return default(bool);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x23C10A0", Offset = "0x23BF6A0", VA = "0x1823C10A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x23C10C0", Offset = "0x23BF6C0", VA = "0x1823C10C0", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x23C10F0", Offset = "0x23BF6F0", VA = "0x1823C10F0", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x23C1490", Offset = "0x23BFA90", VA = "0x1823C1490", Slot = "20")]
		public override void FillBrushData(ref SdfBrush brush, int iBrush)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x23C1500", Offset = "0x23BFB00", VA = "0x1823C1500")]
		[BurstCompile]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.ParticleSystem)]
		public unsafe static float EvaluateSdf(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x23C1580", Offset = "0x23BFB80", VA = "0x1823C1580")]
		public MudParticleSystem()
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x23C18A0", Offset = "0x23BFEA0", VA = "0x1823C18A0")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.ParticleSystem)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x50")]
		public ParticleSystem Particles;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_radiusMultiplier;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_selfBlend;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int InitNumParticles;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x60")]
		private int m_lastReadFrame;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x68")]
		private ParticleSystem.Particle[] m_aParticle;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x70")]
		private int m_numParticles;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x78")]
		private Vector3[] m_aPosWs;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x80")]
		private Vector3[] m_aPosRs;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x88")]
		private float[] m_aRadius;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x90")]
		private float[] m_aSelfBlendMult;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x98")]
		private int m_iStart;

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x06000225 RID: 549
		[Token(Token = "0x2000050")]
		public unsafe delegate float EvaluateSdf_00000102$PostfixBurstDelegate(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x02000051 RID: 81
		[Token(Token = "0x2000051")]
		internal static class EvaluateSdf_00000102$BurstDirectCall
		{
			// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x23C1B90", Offset = "0x23C0190", VA = "0x1823C1B90")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000229 RID: 553 RVA: 0x00003198 File Offset: 0x00001398
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x23C1CC0", Offset = "0x23C02C0", VA = "0x1823C1CC0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x23C1E20", Offset = "0x23C0420", VA = "0x1823C1E20")]
			public static void Constructor()
			{
			}

			// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600022D RID: 557 RVA: 0x000031B0 File Offset: 0x000013B0
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x23C1ED0", Offset = "0x23C04D0", VA = "0x1823C1ED0")]
			public unsafe static float Invoke(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x04000098 RID: 152
			[Token(Token = "0x4000098")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000099 RID: 153
			[Token(Token = "0x4000099")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
