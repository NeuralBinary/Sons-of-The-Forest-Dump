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
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	[BurstCompile]
	public class MudFishEye : MudDistortion
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00002AD8 File Offset: 0x00000CD8
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		public float Radius
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x23A5B60", Offset = "0x23A4160", VA = "0x1823A5B60")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00002AF0 File Offset: 0x00000CF0
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		public float Amount
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x23A5B80", Offset = "0x23A4180", VA = "0x1823A5B80")]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x1700001D")]
		public override float MaxDistortion
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320", Slot = "30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x1700001E")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x23B5F60", Offset = "0x23B4560", VA = "0x1823B5F60", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x23B6190", Offset = "0x23B4790", VA = "0x1823B6190", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x23B61F0", Offset = "0x23B47F0", VA = "0x1823B61F0", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x23B6360", Offset = "0x23B4960", VA = "0x1823B6360")]
		[BurstCompile]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.FishEye)]
		public unsafe static float EvaluateSdf(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x23B63E0", Offset = "0x23B49E0", VA = "0x1823B63E0", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x23B66A0", Offset = "0x23B4CA0", VA = "0x1823B66A0", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x23B6960", Offset = "0x23B4F60", VA = "0x1823B6960")]
		public MudFishEye()
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x23B6980", Offset = "0x23B4F80", VA = "0x1823B6980")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.FishEye)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_radius;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 10f)]
		[SerializeField]
		private float m_strength;

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000170 RID: 368
		[Token(Token = "0x200003A")]
		public unsafe delegate float EvaluateSdf_000000A4$PostfixBurstDelegate(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		internal static class EvaluateSdf_000000A4$BurstDirectCall
		{
			// Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x23B6DA0", Offset = "0x23B53A0", VA = "0x1823B6DA0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000174 RID: 372 RVA: 0x00002B80 File Offset: 0x00000D80
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x23B6ED0", Offset = "0x23B54D0", VA = "0x1823B6ED0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x23B7030", Offset = "0x23B5630", VA = "0x1823B7030")]
			public static void Constructor()
			{
			}

			// Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000178 RID: 376 RVA: 0x00002B98 File Offset: 0x00000D98
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x23B70E0", Offset = "0x23B56E0", VA = "0x1823B70E0")]
			public unsafe static float Invoke(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x04000062 RID: 98
			[Token(Token = "0x4000062")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000063 RID: 99
			[Token(Token = "0x4000063")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
