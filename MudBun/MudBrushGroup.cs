using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace MudBun
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	public class MudBrushGroup : MudSolid
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x1700005E")]
		public override bool IsBrushGroup
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x23C8060", Offset = "0x23C6660", VA = "0x1823C8060")]
		public MudBrushGroup()
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x23C80E0", Offset = "0x23C66E0", VA = "0x1823C80E0", Slot = "12")]
		public override void UpdateProxies(AabbTree<MudBrushBase> tree, Aabb opBounds)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x23C8280", Offset = "0x23C6880", VA = "0x1823C8280", Slot = "13")]
		public override void DestroyProxies(AabbTree<MudBrushBase> tree)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x23C8330", Offset = "0x23C6930", VA = "0x1823C8330", Slot = "19")]
		public override int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x23C8480", Offset = "0x23C6A80", VA = "0x1823C8480", Slot = "20")]
		public override void FillBrushData(ref SdfBrush brush, int iBrush)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x23C84B0", Offset = "0x23C6AB0", VA = "0x1823C84B0", Slot = "21")]
		public override int FillComputeDataPostChildren(NativeArray<SdfBrush> aBrush, int iStart)
		{
			return 0;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x23C8600", Offset = "0x23C6C00", VA = "0x1823C8600", Slot = "22")]
		public override void FillBrushDataPostChildren(ref SdfBrush brush, int iBrush)
		{
		}

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x50")]
		private int m_iBegin;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x54")]
		private int m_iEnd;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x58")]
		internal int m_iProxyBegin;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x5C")]
		internal int m_iProxyEnd;

		// Token: 0x0200005E RID: 94
		[Token(Token = "0x200005E")]
		public enum TypeEnum
		{
			// Token: 0x040000BF RID: 191
			[Token(Token = "0x40000BF")]
			BeginGroup = -2,
			// Token: 0x040000C0 RID: 192
			[Token(Token = "0x40000C0")]
			EndGroup = -3
		}
	}
}
