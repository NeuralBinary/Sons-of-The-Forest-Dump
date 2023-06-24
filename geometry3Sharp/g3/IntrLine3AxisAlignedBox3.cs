using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000184 RID: 388
	[Token(Token = "0x2000184")]
	public class IntrLine3AxisAlignedBox3
	{
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00007C34 File Offset: 0x00005E34
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D5")]
		public Line3d Line
		{
			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x1B19AA0", Offset = "0x1B180A0", VA = "0x181B19AA0")]
			get
			{
				return default(Line3d);
			}
			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x1FF9F60", Offset = "0x1FF8560", VA = "0x181FF9F60")]
			set
			{
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00007C4C File Offset: 0x00005E4C
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D6")]
		public AxisAlignedBox3d Box
		{
			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x1FE4D20", Offset = "0x1FE3320", VA = "0x181FE4D20")]
			get
			{
				return default(AxisAlignedBox3d);
			}
			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x1FF9F80", Offset = "0x1FF8580", VA = "0x181FF9F80")]
			set
			{
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00007C64 File Offset: 0x00005E64
		[Token(Token = "0x170001D7")]
		public bool IsSimpleIntersection
		{
			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x1FF9FA0", Offset = "0x1FF85A0", VA = "0x181FF9FA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x1FF9FC0", Offset = "0x1FF85C0", VA = "0x181FF9FC0")]
		public IntrLine3AxisAlignedBox3(Line3d l, AxisAlignedBox3d b)
		{
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x1FFA0A0", Offset = "0x1FF86A0", VA = "0x181FFA0A0")]
		public IntrLine3AxisAlignedBox3 Compute()
		{
			return null;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00007C7C File Offset: 0x00005E7C
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x1FFA1B0", Offset = "0x1FF87B0", VA = "0x181FFA1B0")]
		public bool Find()
		{
			return default(bool);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00007C94 File Offset: 0x00005E94
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x1FFA2C0", Offset = "0x1FF88C0", VA = "0x181FFA2C0")]
		public bool Test()
		{
			return default(bool);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00007CAC File Offset: 0x00005EAC
		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x1FFA660", Offset = "0x1FF8C60", VA = "0x181FFA660")]
		public static bool DoClipping(ref double t0, ref double t1, ref Vector3d origin, ref Vector3d direction, ref AxisAlignedBox3d box, bool solid, ref int quantity, ref Vector3d point0, ref Vector3d point1, ref IntersectionType intrType)
		{
			return default(bool);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00007CC4 File Offset: 0x00005EC4
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x1FFAC40", Offset = "0x1FF9240", VA = "0x181FFAC40")]
		public static bool Clip(double denom, double numer, ref double t0, ref double t1)
		{
			return default(bool);
		}

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0x10")]
		private Line3d line;

		// Token: 0x040005E2 RID: 1506
		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0x40")]
		private AxisAlignedBox3d box;

		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0x70")]
		public int Quantity;

		// Token: 0x040005E4 RID: 1508
		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x74")]
		public IntersectionResult Result;

		// Token: 0x040005E5 RID: 1509
		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x78")]
		public IntersectionType Type;

		// Token: 0x040005E6 RID: 1510
		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x80")]
		public double LineParam0;

		// Token: 0x040005E7 RID: 1511
		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x88")]
		public double LineParam1;

		// Token: 0x040005E8 RID: 1512
		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x90")]
		public Vector3d Point0;

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x40005E9")]
		[FieldOffset(Offset = "0xA8")]
		public Vector3d Point1;
	}
}
