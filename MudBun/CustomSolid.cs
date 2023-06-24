using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace MudBun
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class CustomSolid : MudSolid
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002220 File Offset: 0x00000420
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		public float Round
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x23A8C00", Offset = "0x23A7200", VA = "0x1823A8C00")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x1700000A")]
		public override Aabb RawBoundsRs
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x23A8C10", Offset = "0x23A7210", VA = "0x1823A8C10", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x23A90A0", Offset = "0x23A76A0", VA = "0x1823A90A0", Slot = "17")]
		public override void SanitizeParameters()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x23A90C0", Offset = "0x23A76C0", VA = "0x1823A90C0", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x23A9320", Offset = "0x23A7920", VA = "0x1823A9320", Slot = "28")]
		public override void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x23A9610", Offset = "0x23A7C10", VA = "0x1823A9610", Slot = "29")]
		public override void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x23A9900", Offset = "0x23A7F00", VA = "0x1823A9900")]
		public CustomSolid()
		{
		}

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int TypeId;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_round;
	}
}
