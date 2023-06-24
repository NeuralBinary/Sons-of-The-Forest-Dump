using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	[BurstCompile]
	[ExecuteInEditMode]
	public class MudCurveFull : MudSolid
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00004278 File Offset: 0x00002478
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B9")]
		public int Precision
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x9AF280", Offset = "0x9AD880", VA = "0x1809AF280")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x23BB640", Offset = "0x23B9C40", VA = "0x1823BB640")]
			set
			{
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BA")]
		public ICollection<MudCurveFull.Point> Points
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x23FF5E0", Offset = "0x23FDBE0", VA = "0x1823FF5E0")]
			set
			{
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x23FF840", Offset = "0x23FDE40", VA = "0x1823FF840")]
		public MudCurveFull()
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x170000BB")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x23FFA00", Offset = "0x23FE000", VA = "0x1823FFA00", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x23FFE60", Offset = "0x23FE460", VA = "0x1823FFE60", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x2400070", Offset = "0x23FE670", VA = "0x182400070")]
		private void Update()
		{
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2400510", Offset = "0x23FEB10", VA = "0x182400510", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x2401DF0", Offset = "0x24003F0", VA = "0x182401DF0")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.CurveFull)]
		[BurstCompile]
		public unsafe static float EvaluateSdf(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x2401E70", Offset = "0x2400470", VA = "0x182401E70", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x24025C0", Offset = "0x2400BC0", VA = "0x1824025C0", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x2402DE0", Offset = "0x24013E0", VA = "0x182402DE0")]
		[RegisterSdfBrushEvalFunc(SdfBrush.TypeEnum.CurveFull)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float EvaluateSdf$BurstManaged(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(1f, 16f)]
		[SerializeField]
		[Header("Shape")]
		private int m_precision;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform HeadControlPoint;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform TailControlPoint;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<MudCurveFull.Point> m_points;

		// Token: 0x02000096 RID: 150
		[Token(Token = "0x2000096")]
		[Serializable]
		public class Point
		{
			// Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x24033C0", Offset = "0x24019C0", VA = "0x1824033C0")]
			public Point([Optional] Transform transform, float radius = 0.2f)
			{
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x2403420", Offset = "0x2401A20", VA = "0x182403420")]
			public Point(GameObject go, float radius = 0.2f)
			{
			}

			// Token: 0x0400031F RID: 799
			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Transform;

			// Token: 0x04000320 RID: 800
			[Token(Token = "0x4000320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float Radius;
		}

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x06000412 RID: 1042
		[Token(Token = "0x2000098")]
		public unsafe delegate float EvaluateSdf_00000297$PostfixBurstDelegate(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x02000099 RID: 153
		[Token(Token = "0x2000099")]
		internal static class EvaluateSdf_00000297$BurstDirectCall
		{
			// Token: 0x06000415 RID: 1045 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x2403910", Offset = "0x2401F10", VA = "0x182403910")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x00004398 File Offset: 0x00002598
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x2403A40", Offset = "0x2402040", VA = "0x182403A40")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x2403BA0", Offset = "0x24021A0", VA = "0x182403BA0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x000043B0 File Offset: 0x000025B0
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x2403C50", Offset = "0x2402250", VA = "0x182403C50")]
			public unsafe static float Invoke(float resDummy, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x04000327 RID: 807
			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000328 RID: 808
			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
