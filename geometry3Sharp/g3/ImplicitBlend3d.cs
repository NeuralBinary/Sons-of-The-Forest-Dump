using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000170 RID: 368
	[Token(Token = "0x2000170")]
	public class ImplicitBlend3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x0000779C File Offset: 0x0000599C
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BF")]
		public double WeightA
		{
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x1FF2150", Offset = "0x1FF0750", VA = "0x181FF2150")]
			set
			{
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x000077B4 File Offset: 0x000059B4
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C0")]
		public double WeightB
		{
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x1FF21C0", Offset = "0x1FF07C0", VA = "0x181FF21C0")]
			set
			{
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x000077CC File Offset: 0x000059CC
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C1")]
		public double Blend
		{
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x1FE2E00", Offset = "0x1FE1400", VA = "0x181FE2E00")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x1FF2230", Offset = "0x1FF0830", VA = "0x181FF2230")]
			set
			{
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000077E4 File Offset: 0x000059E4
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x1FF22A0", Offset = "0x1FF08A0", VA = "0x181FF22A0", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000077FC File Offset: 0x000059FC
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x1FF2460", Offset = "0x1FF0A60", VA = "0x181FF2460", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x1FF2580", Offset = "0x1FF0B80", VA = "0x181FF2580")]
		public ImplicitBlend3d()
		{
		}

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x10")]
		public BoundedImplicitFunction3d A;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x18")]
		public BoundedImplicitFunction3d B;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x20")]
		private double weightA;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x28")]
		private double weightB;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x30")]
		private double blend;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x38")]
		public double ExpandBounds;
	}
}
