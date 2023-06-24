using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000187 RID: 391
	[Token(Token = "0x2000187")]
	public class IntrRay3Box3
	{
		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00007E2C File Offset: 0x0000602C
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001DE")]
		public Ray3d Ray
		{
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x1B19AA0", Offset = "0x1B180A0", VA = "0x181B19AA0")]
			get
			{
				return default(Ray3d);
			}
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x1FFACD0", Offset = "0x1FF92D0", VA = "0x181FFACD0")]
			set
			{
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x00007E44 File Offset: 0x00006044
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001DF")]
		public Box3d Box
		{
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x1FFAD00", Offset = "0x1FF9300", VA = "0x181FFAD00")]
			get
			{
				return default(Box3d);
			}
			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x1FFAD60", Offset = "0x1FF9360", VA = "0x181FFAD60")]
			set
			{
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00007E5C File Offset: 0x0000605C
		[Token(Token = "0x170001E0")]
		public bool IsSimpleIntersection
		{
			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x1FFADC0", Offset = "0x1FF93C0", VA = "0x181FFADC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x1FFC340", Offset = "0x1FFA940", VA = "0x181FFC340")]
		public IntrRay3Box3(Ray3d r, Box3d b)
		{
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x1FFC450", Offset = "0x1FFAA50", VA = "0x181FFC450")]
		public IntrRay3Box3 Compute()
		{
			return null;
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00007E74 File Offset: 0x00006074
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x1FFC5E0", Offset = "0x1FFABE0", VA = "0x181FFC5E0")]
		public bool Find()
		{
			return default(bool);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00007E8C File Offset: 0x0000608C
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x1FFC780", Offset = "0x1FFAD80", VA = "0x181FFC780")]
		public bool Test()
		{
			return default(bool);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00007EA4 File Offset: 0x000060A4
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x1FFC7A0", Offset = "0x1FFADA0", VA = "0x181FFC7A0")]
		public static bool Intersects(ref Ray3d ray, ref Box3d box, double expandExtents = 0.0)
		{
			return default(bool);
		}

		// Token: 0x040005FC RID: 1532
		[Token(Token = "0x40005FC")]
		[FieldOffset(Offset = "0x10")]
		private Ray3d ray;

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x40005FD")]
		[FieldOffset(Offset = "0x40")]
		private Box3d box;

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40005FE")]
		[FieldOffset(Offset = "0xB8")]
		public int Quantity;

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		[FieldOffset(Offset = "0xBC")]
		public IntersectionResult Result;

		// Token: 0x04000600 RID: 1536
		[Token(Token = "0x4000600")]
		[FieldOffset(Offset = "0xC0")]
		public IntersectionType Type;

		// Token: 0x04000601 RID: 1537
		[Token(Token = "0x4000601")]
		[FieldOffset(Offset = "0xC8")]
		public double RayParam0;

		// Token: 0x04000602 RID: 1538
		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0xD0")]
		public double RayParam1;

		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0xD8")]
		public Vector3d Point0;

		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		[FieldOffset(Offset = "0xF0")]
		public Vector3d Point1;
	}
}
