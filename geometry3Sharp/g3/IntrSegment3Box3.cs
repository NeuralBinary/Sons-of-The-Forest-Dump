using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200018B RID: 395
	[Token(Token = "0x200018B")]
	public class IntrSegment3Box3
	{
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00008024 File Offset: 0x00006224
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001EC")]
		public Segment3d Segment
		{
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x1B17510", Offset = "0x1B15B10", VA = "0x181B17510")]
			get
			{
				return default(Segment3d);
			}
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x1FFE230", Offset = "0x1FFC830", VA = "0x181FFE230")]
			set
			{
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0000803C File Offset: 0x0000623C
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001ED")]
		public Box3d Box
		{
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x1FFE260", Offset = "0x1FFC860", VA = "0x181FFE260")]
			get
			{
				return default(Box3d);
			}
			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x1FFE2C0", Offset = "0x1FFC8C0", VA = "0x181FFE2C0")]
			set
			{
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x00008054 File Offset: 0x00006254
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001EE")]
		public bool Solid
		{
			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0xA03DA0", Offset = "0xA023A0", VA = "0x180A03DA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x1FFE320", Offset = "0x1FFC920", VA = "0x181FFE320")]
			set
			{
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0000806C File Offset: 0x0000626C
		[Token(Token = "0x170001EF")]
		public bool IsSimpleIntersection
		{
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x1FFE340", Offset = "0x1FFC940", VA = "0x181FFE340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x1FFE360", Offset = "0x1FFC960", VA = "0x181FFE360")]
		public IntrSegment3Box3(Segment3d s, Box3d b, bool solidBox)
		{
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x1FFE490", Offset = "0x1FFCA90", VA = "0x181FFE490")]
		public IntrSegment3Box3 Compute()
		{
			return null;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00008084 File Offset: 0x00006284
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x1FFE630", Offset = "0x1FFCC30", VA = "0x181FFE630")]
		public bool Find()
		{
			return default(bool);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0000809C File Offset: 0x0000629C
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x1FFE7E0", Offset = "0x1FFCDE0", VA = "0x181FFE7E0")]
		public bool Test()
		{
			return default(bool);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x000080B4 File Offset: 0x000062B4
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x1FFEC30", Offset = "0x1FFD230", VA = "0x181FFEC30")]
		public static bool DoClipping(ref double t0, ref double t1, Vector3d origin, Vector3d direction, Box3d box, bool solid, ref int quantity, ref Vector3d point0, ref Vector3d point1, ref IntersectionType intrType)
		{
			return default(bool);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x000080CC File Offset: 0x000062CC
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x1FFF130", Offset = "0x1FFD730", VA = "0x181FFF130")]
		public static bool Clip(double denom, double numer, ref double t0, ref double t1)
		{
			return default(bool);
		}

		// Token: 0x04000620 RID: 1568
		[Token(Token = "0x4000620")]
		[FieldOffset(Offset = "0x10")]
		private Segment3d segment;

		// Token: 0x04000621 RID: 1569
		[Token(Token = "0x4000621")]
		[FieldOffset(Offset = "0x48")]
		private Box3d box;

		// Token: 0x04000622 RID: 1570
		[Token(Token = "0x4000622")]
		[FieldOffset(Offset = "0xC0")]
		private bool solid;

		// Token: 0x04000623 RID: 1571
		[Token(Token = "0x4000623")]
		[FieldOffset(Offset = "0xC4")]
		public int Quantity;

		// Token: 0x04000624 RID: 1572
		[Token(Token = "0x4000624")]
		[FieldOffset(Offset = "0xC8")]
		public IntersectionResult Result;

		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x4000625")]
		[FieldOffset(Offset = "0xCC")]
		public IntersectionType Type;

		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		[FieldOffset(Offset = "0xD0")]
		public double SegmentParam0;

		// Token: 0x04000627 RID: 1575
		[Token(Token = "0x4000627")]
		[FieldOffset(Offset = "0xD8")]
		public double SegmentParam1;

		// Token: 0x04000628 RID: 1576
		[Token(Token = "0x4000628")]
		[FieldOffset(Offset = "0xE0")]
		public Vector3d Point0;

		// Token: 0x04000629 RID: 1577
		[Token(Token = "0x4000629")]
		[FieldOffset(Offset = "0xF8")]
		public Vector3d Point1;
	}
}
