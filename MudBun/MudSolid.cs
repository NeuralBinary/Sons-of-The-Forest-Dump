using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	[RequireComponent(typeof(MudMaterial))]
	[ExecuteInEditMode]
	public class MudSolid : MudBrush
	{
		// Token: 0x060003BA RID: 954 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x23F93A0", Offset = "0x23F79A0", VA = "0x1823F93A0")]
		public static Aabb SymmetryBounds(MudSolid.SymmetryMode mode, Aabb bounds)
		{
			return default(Aabb);
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x170000A6")]
		public override Aabb BoundsRs
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x23F9760", Offset = "0x23F7D60", VA = "0x1823F9760", Slot = "4")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00003FF0 File Offset: 0x000021F0
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A7")]
		public SdfBrush.OperatorEnum Operator
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
			get
			{
				return SdfBrush.OperatorEnum.Union;
			}
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x23F97D0", Offset = "0x23F7DD0", VA = "0x1823F97D0")]
			set
			{
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00004008 File Offset: 0x00002208
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A8")]
		public float Blend
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x23A5B80", Offset = "0x23A4180", VA = "0x1823A5B80")]
			set
			{
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00004020 File Offset: 0x00002220
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A9")]
		public MudSolid.SymmetryMode Symmetry
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			get
			{
				return MudSolid.SymmetryMode.None;
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x23C2530", Offset = "0x23C0B30", VA = "0x1823C2530")]
			set
			{
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x170000AA")]
		public override bool CountAsBone
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x23F97E0", Offset = "0x23F7DE0", VA = "0x1823F97E0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x170000AB")]
		public override float BoundsRsPadding
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x170000AC")]
		public override bool ShouldUseAccumulatedBounds
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x23F9840", Offset = "0x23F7E40", VA = "0x1823F9840", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x170000AD")]
		internal override bool UsesMaterial
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x170000AE")]
		internal override int MaterialHash
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x23F9860", Offset = "0x23F7E60", VA = "0x1823F9860", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x23F9980", Offset = "0x23F7F80", VA = "0x1823F9980", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x23F9990", Offset = "0x23F7F90", VA = "0x1823F9990", Slot = "20")]
		public override void FillBrushData(ref SdfBrush brush, int iBrush)
		{
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x23F9B80", Offset = "0x23F8180", VA = "0x1823F9B80", Slot = "23")]
		public override void FillBrushMaterialData(ref SdfBrushMaterial mat)
		{
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x23F9E40", Offset = "0x23F8440", VA = "0x1823F9E40", Slot = "24")]
		public override void ValidateMaterial()
		{
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x23F9F80", Offset = "0x23F8580", VA = "0x1823F9F80")]
		private bool OperatorShouldDrawOutline(SdfBrush.OperatorEnum op)
		{
			return default(bool);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x23FA280", Offset = "0x23F8880", VA = "0x1823FA280", Slot = "27")]
		public override void DrawGizmosRs()
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x23A9900", Offset = "0x23A7F00", VA = "0x1823A9900")]
		public MudSolid()
		{
		}

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SdfBrush.OperatorEnum m_operator;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_blend;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MudSolid.SymmetryMode m_symmetry;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x44")]
		[ConditionalField("m_canCountAsBone", true, null, null, null, null, null)]
		[Tooltip("If checked, this brush will be counted as bone during auto rigging.")]
		[SerializeField]
		public bool m_countAsBone;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x45")]
		[SerializeField]
		[HideInInspector]
		protected bool m_canCountAsBone;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x48")]
		internal MudMaterial m_material;

		// Token: 0x0200008D RID: 141
		[Token(Token = "0x200008D")]
		public enum SymmetryMode
		{
			// Token: 0x0400030C RID: 780
			[Token(Token = "0x400030C")]
			None,
			// Token: 0x0400030D RID: 781
			[Token(Token = "0x400030D")]
			FlipX,
			// Token: 0x0400030E RID: 782
			[Token(Token = "0x400030E")]
			MirrorX,
			// Token: 0x0400030F RID: 783
			[Token(Token = "0x400030F")]
			FlipMirrorX
		}
	}
}
