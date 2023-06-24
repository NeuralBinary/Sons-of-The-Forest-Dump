using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000185 RID: 389
	[Token(Token = "0x2000185")]
	public class IntrLine3Box3
	{
		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00007CDC File Offset: 0x00005EDC
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D8")]
		public Line3d Line
		{
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x1B19AA0", Offset = "0x1B180A0", VA = "0x181B19AA0")]
			get
			{
				return default(Line3d);
			}
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x1FFACD0", Offset = "0x1FF92D0", VA = "0x181FFACD0")]
			set
			{
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00007CF4 File Offset: 0x00005EF4
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D9")]
		public Box3d Box
		{
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x1FFAD00", Offset = "0x1FF9300", VA = "0x181FFAD00")]
			get
			{
				return default(Box3d);
			}
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x1FFAD60", Offset = "0x1FF9360", VA = "0x181FFAD60")]
			set
			{
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00007D0C File Offset: 0x00005F0C
		[Token(Token = "0x170001DA")]
		public bool IsSimpleIntersection
		{
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x1FFADC0", Offset = "0x1FF93C0", VA = "0x181FFADC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x1FFADE0", Offset = "0x1FF93E0", VA = "0x181FFADE0")]
		public IntrLine3Box3(Line3d l, Box3d b)
		{
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x1FFAEF0", Offset = "0x1FF94F0", VA = "0x181FFAEF0")]
		public IntrLine3Box3 Compute()
		{
			return null;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00007D24 File Offset: 0x00005F24
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x1FFB090", Offset = "0x1FF9690", VA = "0x181FFB090")]
		public bool Find()
		{
			return default(bool);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00007D3C File Offset: 0x00005F3C
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x1FFB240", Offset = "0x1FF9840", VA = "0x181FFB240")]
		public bool Test()
		{
			return default(bool);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00007D54 File Offset: 0x00005F54
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x1FFB530", Offset = "0x1FF9B30", VA = "0x181FFB530")]
		public static bool DoClipping(ref double t0, ref double t1, Vector3d origin, Vector3d direction, Box3d box, bool solid, ref int quantity, ref Vector3d point0, ref Vector3d point1, ref IntersectionType intrType)
		{
			return default(bool);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00007D6C File Offset: 0x00005F6C
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x1FFAC40", Offset = "0x1FF9240", VA = "0x181FFAC40")]
		public static bool Clip(double denom, double numer, ref double t0, ref double t1)
		{
			return default(bool);
		}

		// Token: 0x040005EA RID: 1514
		[Token(Token = "0x40005EA")]
		[FieldOffset(Offset = "0x10")]
		private Line3d line;

		// Token: 0x040005EB RID: 1515
		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0x40")]
		private Box3d box;

		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0xB8")]
		public int Quantity;

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0xBC")]
		public IntersectionResult Result;

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0xC0")]
		public IntersectionType Type;

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0xC8")]
		public double LineParam0;

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0xD0")]
		public double LineParam1;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0xD8")]
		public Vector3d Point0;

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0xF0")]
		public Vector3d Point1;
	}
}
