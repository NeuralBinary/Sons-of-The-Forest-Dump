using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000186 RID: 390
	[Token(Token = "0x2000186")]
	public class IntrRay3AxisAlignedBox3
	{
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00007D84 File Offset: 0x00005F84
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001DB")]
		public Ray3d Ray
		{
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x1B19AA0", Offset = "0x1B180A0", VA = "0x181B19AA0")]
			get
			{
				return default(Ray3d);
			}
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x1FF9F60", Offset = "0x1FF8560", VA = "0x181FF9F60")]
			set
			{
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00007D9C File Offset: 0x00005F9C
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001DC")]
		public AxisAlignedBox3d Box
		{
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x1FE4D20", Offset = "0x1FE3320", VA = "0x181FE4D20")]
			get
			{
				return default(AxisAlignedBox3d);
			}
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x1FF9F80", Offset = "0x1FF8580", VA = "0x181FF9F80")]
			set
			{
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00007DB4 File Offset: 0x00005FB4
		[Token(Token = "0x170001DD")]
		public bool IsSimpleIntersection
		{
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x1FF9FA0", Offset = "0x1FF85A0", VA = "0x181FF9FA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x1FFBB80", Offset = "0x1FFA180", VA = "0x181FFBB80")]
		public IntrRay3AxisAlignedBox3(Ray3d r, AxisAlignedBox3d b)
		{
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x1FFBC60", Offset = "0x1FFA260", VA = "0x181FFBC60")]
		public IntrRay3AxisAlignedBox3 Compute()
		{
			return null;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00007DCC File Offset: 0x00005FCC
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x1FFBD60", Offset = "0x1FFA360", VA = "0x181FFBD60")]
		public bool Find()
		{
			return default(bool);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00007DE4 File Offset: 0x00005FE4
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x1FFBE70", Offset = "0x1FFA470", VA = "0x181FFBE70")]
		public bool Test()
		{
			return default(bool);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00007DFC File Offset: 0x00005FFC
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x1FFBE90", Offset = "0x1FFA490", VA = "0x181FFBE90")]
		public static bool Intersects(ref Ray3d ray, ref AxisAlignedBox3d box, double expandExtents = 0.0)
		{
			return default(bool);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00007E14 File Offset: 0x00006014
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x1FFC1F0", Offset = "0x1FFA7F0", VA = "0x181FFC1F0")]
		public static bool FindRayIntersectT(ref Ray3d ray, ref AxisAlignedBox3d box, out double RayParam)
		{
			return default(bool);
		}

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x10")]
		private Ray3d ray;

		// Token: 0x040005F4 RID: 1524
		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0x40")]
		private AxisAlignedBox3d box;

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x70")]
		public int Quantity;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x74")]
		public IntersectionResult Result;

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x78")]
		public IntersectionType Type;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x80")]
		public double RayParam0;

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x88")]
		public double RayParam1;

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0x90")]
		public Vector3d Point0;

		// Token: 0x040005FB RID: 1531
		[Token(Token = "0x40005FB")]
		[FieldOffset(Offset = "0xA8")]
		public Vector3d Point1;
	}
}
