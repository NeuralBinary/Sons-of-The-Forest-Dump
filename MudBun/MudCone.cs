using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	public class MudCone : MudSolid
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x000041E8 File Offset: 0x000023E8
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B4")]
		public float Radius
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x23A8C00", Offset = "0x23A7200", VA = "0x1823A8C00")]
			set
			{
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00004200 File Offset: 0x00002400
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B5")]
		public float Round
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x23FC6E0", Offset = "0x23FACE0", VA = "0x1823FC6E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x23FC6F0", Offset = "0x23FACF0", VA = "0x1823FC6F0")]
			set
			{
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x170000B6")]
		public Vector3 PivotShiftOffset
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x23FC700", Offset = "0x23FAD00", VA = "0x1823FC700")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x170000B7")]
		public Vector3 CenterOffset
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x23FC8D0", Offset = "0x23FAED0", VA = "0x1823FC8D0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x170000B8")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x23FCA80", Offset = "0x23FB080", VA = "0x1823FCA80", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x23FCFA0", Offset = "0x23FB5A0", VA = "0x1823FCFA0", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x23FCFD0", Offset = "0x23FB5D0", VA = "0x1823FCFD0", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x23FD220", Offset = "0x23FB820", VA = "0x1823FD220", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x23FF0E0", Offset = "0x23FD6E0", VA = "0x1823FF0E0", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x23FF5C0", Offset = "0x23FDBC0", VA = "0x1823FF5C0")]
		public MudCone()
		{
		}

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_radius;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_round;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x58")]
		[Range(-1f, 1f)]
		public float PivotShift;
	}
}
