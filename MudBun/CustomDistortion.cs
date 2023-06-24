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
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[BurstCompile]
	public class CustomDistortion : MudDistortion
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002070 File Offset: 0x00000270
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public float CellSize
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x23A5B60", Offset = "0x23A4160", VA = "0x1823A5B60")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002088 File Offset: 0x00000288
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public float Strength
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x23A5B80", Offset = "0x23A4180", VA = "0x1823A5B80")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020A0 File Offset: 0x000002A0
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public float Fade
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x23A5B90", Offset = "0x23A4190", VA = "0x1823A5B90")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x17000004")]
		public override float MaxDistortion
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320", Slot = "30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x17000005")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x23A5BA0", Offset = "0x23A41A0", VA = "0x1823A5BA0", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x23A6030", Offset = "0x23A4630", VA = "0x1823A6030", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x23A6070", Offset = "0x23A4670", VA = "0x1823A6070", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x23A6210", Offset = "0x23A4810", VA = "0x1823A6210")]
		[RegisterSdfBrushEvalFunc(901)]
		[BurstCompile]
		public unsafe static float EvaluateSdf(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x23A6290", Offset = "0x23A4890", VA = "0x1823A6290", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x23A6580", Offset = "0x23A4B80", VA = "0x1823A6580", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x23A6870", Offset = "0x23A4E70", VA = "0x1823A6870")]
		public CustomDistortion()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x23A68D0", Offset = "0x23A4ED0", VA = "0x1823A68D0")]
		[RegisterSdfBrushEvalFunc(901)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int TypeId;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_cellSize;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Range(1f, 10f)]
		private float m_strength;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_fade;

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000017 RID: 23
		[Token(Token = "0x2000008")]
		public unsafe delegate float EvaluateSdf_00000010$PostfixBurstDelegate(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		internal static class EvaluateSdf_00000010$BurstDirectCall
		{
			// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x23A6FE0", Offset = "0x23A55E0", VA = "0x1823A6FE0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600001B RID: 27 RVA: 0x00002130 File Offset: 0x00000330
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x23A7110", Offset = "0x23A5710", VA = "0x1823A7110")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x23A7270", Offset = "0x23A5870", VA = "0x1823A7270")]
			public static void Constructor()
			{
			}

			// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600001F RID: 31 RVA: 0x00002148 File Offset: 0x00000348
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x23A7320", Offset = "0x23A5920", VA = "0x1823A7320")]
			public unsafe static float Invoke(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x0400000A RID: 10
			[Token(Token = "0x400000A")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400000B RID: 11
			[Token(Token = "0x400000B")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
