using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001CA RID: 458
	[Token(Token = "0x20001CA")]
	public struct Box2f
	{
		// Token: 0x06000D3E RID: 3390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x2034D90", Offset = "0x2033390", VA = "0x182034D90")]
		public Box2f(Vector2f center)
		{
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x2034E50", Offset = "0x2033450", VA = "0x182034E50")]
		public Box2f(Vector2f center, Vector2f x, Vector2f y, Vector2f extent)
		{
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x2034E70", Offset = "0x2033470", VA = "0x182034E70")]
		public Box2f(Vector2f center, Vector2f extent)
		{
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x2034F20", Offset = "0x2033520", VA = "0x182034F20")]
		public Box2f(AxisAlignedBox2f aaBox)
		{
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00009944 File Offset: 0x00007B44
		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x2035010", Offset = "0x2033610", VA = "0x182035010")]
		public Vector2f Axis(int i)
		{
			return default(Vector2f);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x2035040", Offset = "0x2033640", VA = "0x182035040")]
		public Vector2f[] ComputeVertices()
		{
			return null;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x20350A0", Offset = "0x20336A0", VA = "0x1820350A0")]
		public void ComputeVertices(Vector2f[] vertex)
		{
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0000995C File Offset: 0x00007B5C
		[Token(Token = "0x17000250")]
		public double MaxExtent
		{
			[Token(Token = "0x6000D45")]
			[Address(RVA = "0x2035210", Offset = "0x2033810", VA = "0x182035210")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x00009974 File Offset: 0x00007B74
		[Token(Token = "0x17000251")]
		public double MinExtent
		{
			[Token(Token = "0x6000D46")]
			[Address(RVA = "0x20352A0", Offset = "0x20338A0", VA = "0x1820352A0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0000998C File Offset: 0x00007B8C
		[Token(Token = "0x17000252")]
		public Vector2f Diagonal
		{
			[Token(Token = "0x6000D47")]
			[Address(RVA = "0x2035330", Offset = "0x2033930", VA = "0x182035330")]
			get
			{
				return default(Vector2f);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x000099A4 File Offset: 0x00007BA4
		[Token(Token = "0x17000253")]
		public double Area
		{
			[Token(Token = "0x6000D48")]
			[Address(RVA = "0x2035410", Offset = "0x2033A10", VA = "0x182035410")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x2035430", Offset = "0x2033A30", VA = "0x182035430")]
		public void Contain(Vector2f v)
		{
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x20356A0", Offset = "0x2033CA0", VA = "0x1820356A0")]
		public void Contain(Box2f o)
		{
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000099BC File Offset: 0x00007BBC
		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x2035750", Offset = "0x2033D50", VA = "0x182035750")]
		public bool Contains(Vector2f v)
		{
			return default(bool);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x2035870", Offset = "0x2033E70", VA = "0x182035870")]
		public void Expand(float f)
		{
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x2035900", Offset = "0x2033F00", VA = "0x182035900")]
		public void Translate(Vector2f v)
		{
		}

		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		[FieldOffset(Offset = "0x0")]
		public Vector2f Center;

		// Token: 0x04000745 RID: 1861
		[Token(Token = "0x4000745")]
		[FieldOffset(Offset = "0x8")]
		public Vector2f AxisX;

		// Token: 0x04000746 RID: 1862
		[Token(Token = "0x4000746")]
		[FieldOffset(Offset = "0x10")]
		public Vector2f AxisY;

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		[FieldOffset(Offset = "0x18")]
		public Vector2f Extent;

		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x4000748")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Box2f Empty;
	}
}
