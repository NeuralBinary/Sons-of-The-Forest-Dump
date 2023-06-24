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
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	[BurstCompile]
	public class MudTorus : MudSolid
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00004860 File Offset: 0x00002A60
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D8")]
		public float Elongation
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x23A8C00", Offset = "0x23A7200", VA = "0x1823A8C00")]
			set
			{
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00004878 File Offset: 0x00002A78
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D9")]
		public float Radius
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x240EE70", Offset = "0x240D470", VA = "0x18240EE70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x240EF40", Offset = "0x240D540", VA = "0x18240EF40")]
			set
			{
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00004890 File Offset: 0x00002A90
		[Token(Token = "0x170000DA")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x240F1A0", Offset = "0x240D7A0", VA = "0x18240F1A0", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x23A90A0", Offset = "0x23A76A0", VA = "0x1823A90A0", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x240F630", Offset = "0x240DC30", VA = "0x18240F630", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x240F870", Offset = "0x240DE70", VA = "0x18240F870")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Torus)]
		[BurstCompile]
		public unsafe static float EvaluateSdf(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x240F8F0", Offset = "0x240DEF0", VA = "0x18240F8F0", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x240FD40", Offset = "0x240E340", VA = "0x18240FD40", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x23A9900", Offset = "0x23A7F00", VA = "0x1823A9900")]
		public MudTorus()
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x000048D8 File Offset: 0x00002AD8
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x2410190", Offset = "0x240E790", VA = "0x182410190")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.Torus)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_elongation;

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x060004A1 RID: 1185
		[Token(Token = "0x20000A7")]
		public unsafe delegate float EvaluateSdf_000002F0$PostfixBurstDelegate(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x020000A8 RID: 168
		[Token(Token = "0x20000A8")]
		internal static class EvaluateSdf_000002F0$BurstDirectCall
		{
			// Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x24104A0", Offset = "0x240EAA0", VA = "0x1824104A0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060004A5 RID: 1189 RVA: 0x000048F0 File Offset: 0x00002AF0
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x24105D0", Offset = "0x240EBD0", VA = "0x1824105D0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060004A6 RID: 1190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x2410730", Offset = "0x240ED30", VA = "0x182410730")]
			public static void Constructor()
			{
			}

			// Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060004A9 RID: 1193 RVA: 0x00004908 File Offset: 0x00002B08
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x24107E0", Offset = "0x240EDE0", VA = "0x1824107E0")]
			public unsafe static float Invoke(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x0400034F RID: 847
			[Token(Token = "0x400034F")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000350 RID: 848
			[Token(Token = "0x4000350")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
