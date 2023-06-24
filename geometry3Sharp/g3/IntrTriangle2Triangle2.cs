using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200018C RID: 396
	[Token(Token = "0x200018C")]
	public class IntrTriangle2Triangle2
	{
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x000080E4 File Offset: 0x000062E4
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F0")]
		public Triangle2d Triangle0
		{
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x1B19AA0", Offset = "0x1B180A0", VA = "0x181B19AA0")]
			get
			{
				return default(Triangle2d);
			}
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x1FF9F60", Offset = "0x1FF8560", VA = "0x181FF9F60")]
			set
			{
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000080FC File Offset: 0x000062FC
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F1")]
		public Triangle2d Triangle1
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x1FE4D20", Offset = "0x1FE3320", VA = "0x181FE4D20")]
			get
			{
				return default(Triangle2d);
			}
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x1FF9F80", Offset = "0x1FF8580", VA = "0x181FF9F80")]
			set
			{
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x00008114 File Offset: 0x00006314
		[Token(Token = "0x170001F2")]
		public bool IsSimpleIntersection
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x1FF9FA0", Offset = "0x1FF85A0", VA = "0x181FF9FA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x1FFF1A0", Offset = "0x1FFD7A0", VA = "0x181FFF1A0")]
		public IntrTriangle2Triangle2(Triangle2d t0, Triangle2d t1)
		{
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0000812C File Offset: 0x0000632C
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x1FFF230", Offset = "0x1FFD830", VA = "0x181FFF230")]
		public bool Test()
		{
			return default(bool);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x1FFF480", Offset = "0x1FFDA80", VA = "0x181FFF480")]
		public IntrTriangle2Triangle2 Compute()
		{
			return null;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00008144 File Offset: 0x00006344
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x1FFF4A0", Offset = "0x1FFDAA0", VA = "0x181FFF4A0")]
		public bool Find()
		{
			return default(bool);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0000815C File Offset: 0x0000635C
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x1FFF710", Offset = "0x1FFDD10", VA = "0x181FFF710")]
		public static int WhichSide(Triangle2d V, Vector2d P, Vector2d D)
		{
			return 0;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x1FFF8A0", Offset = "0x1FFDEA0", VA = "0x181FFF8A0")]
		public static void ClipConvexPolygonAgainstLine(Vector2d N, double c, ref int quantity, ref Vector2d[] V)
		{
		}

		// Token: 0x0400062A RID: 1578
		[Token(Token = "0x400062A")]
		[FieldOffset(Offset = "0x10")]
		private Triangle2d triangle0;

		// Token: 0x0400062B RID: 1579
		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0x40")]
		private Triangle2d triangle1;

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0x70")]
		public int Quantity;

		// Token: 0x0400062D RID: 1581
		[Token(Token = "0x400062D")]
		[FieldOffset(Offset = "0x74")]
		public IntersectionResult Result;

		// Token: 0x0400062E RID: 1582
		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0x78")]
		public IntersectionType Type;

		// Token: 0x0400062F RID: 1583
		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x80")]
		public Vector2d[] Points;
	}
}
