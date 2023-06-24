using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	public struct Box2d
	{
		// Token: 0x06000D25 RID: 3365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x2033400", Offset = "0x2031A00", VA = "0x182033400")]
		public Box2d(Vector2d center)
		{
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x1E77570", Offset = "0x1E75B70", VA = "0x181E77570")]
		public Box2d(Vector2d center, Vector2d x, Vector2d y, Vector2d extent)
		{
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x20334A0", Offset = "0x2031AA0", VA = "0x1820334A0")]
		public Box2d(Vector2d center, Vector2d extent)
		{
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x2033540", Offset = "0x2031B40", VA = "0x182033540")]
		public Box2d(AxisAlignedBox2d aaBox)
		{
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D29")]
		[Address(RVA = "0x2033620", Offset = "0x2031C20", VA = "0x182033620")]
		public Box2d(Segment2d seg)
		{
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0000983C File Offset: 0x00007A3C
		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0x2033660", Offset = "0x2031C60", VA = "0x182033660")]
		public Vector2d Axis(int i)
		{
			return default(Vector2d);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x2033680", Offset = "0x2031C80", VA = "0x182033680")]
		public Vector2d[] ComputeVertices()
		{
			return null;
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0x20336E0", Offset = "0x2031CE0", VA = "0x1820336E0")]
		public void ComputeVertices(Vector2d[] vertex)
		{
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0x2033850", Offset = "0x2031E50", VA = "0x182033850")]
		public void ComputeVertices(ref Vector2dTuple4 vertex)
		{
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x00009854 File Offset: 0x00007A54
		[Token(Token = "0x1700024C")]
		public double MaxExtent
		{
			[Token(Token = "0x6000D2E")]
			[Address(RVA = "0x2033980", Offset = "0x2031F80", VA = "0x182033980")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x0000986C File Offset: 0x00007A6C
		[Token(Token = "0x1700024D")]
		public double MinExtent
		{
			[Token(Token = "0x6000D2F")]
			[Address(RVA = "0x2033A30", Offset = "0x2032030", VA = "0x182033A30")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x00009884 File Offset: 0x00007A84
		[Token(Token = "0x1700024E")]
		public Vector2d Diagonal
		{
			[Token(Token = "0x6000D30")]
			[Address(RVA = "0x2033AE0", Offset = "0x20320E0", VA = "0x182033AE0")]
			get
			{
				return default(Vector2d);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0000989C File Offset: 0x00007A9C
		[Token(Token = "0x1700024F")]
		public double Area
		{
			[Token(Token = "0x6000D31")]
			[Address(RVA = "0x2033BD0", Offset = "0x20321D0", VA = "0x182033BD0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x2033BF0", Offset = "0x20321F0", VA = "0x182033BF0")]
		public void Contain(Vector2d v)
		{
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x2033E30", Offset = "0x2032430", VA = "0x182033E30")]
		public void Contain(Box2d o)
		{
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x000098B4 File Offset: 0x00007AB4
		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x2033EE0", Offset = "0x20324E0", VA = "0x182033EE0")]
		public bool Contains(Vector2d v)
		{
			return default(bool);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D35")]
		[Address(RVA = "0x2034010", Offset = "0x2032610", VA = "0x182034010")]
		public void Expand(double f)
		{
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D36")]
		[Address(RVA = "0x20340A0", Offset = "0x20326A0", VA = "0x1820340A0")]
		public void Translate(Vector2d v)
		{
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D37")]
		[Address(RVA = "0x2034120", Offset = "0x2032720", VA = "0x182034120")]
		public void RotateAxes(Matrix2d m)
		{
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000098CC File Offset: 0x00007ACC
		[Token(Token = "0x6000D38")]
		[Address(RVA = "0x2034200", Offset = "0x2032800", VA = "0x182034200")]
		public double DistanceSquared(Vector2d v)
		{
			return 0.0;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x000098E4 File Offset: 0x00007AE4
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x2034320", Offset = "0x2032920", VA = "0x182034320")]
		public Vector2d ClosestPoint(Vector2d v)
		{
			return default(Vector2d);
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x000098FC File Offset: 0x00007AFC
		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0x20344E0", Offset = "0x2032AE0", VA = "0x1820344E0")]
		public static Box2d Merge(ref Box2d box0, ref Box2d box1)
		{
			return default(Box2d);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00009914 File Offset: 0x00007B14
		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0x2034A60", Offset = "0x2033060", VA = "0x182034A60")]
		public static implicit operator Box2d(Box2f v)
		{
			return default(Box2d);
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x0000992C File Offset: 0x00007B2C
		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x2034B70", Offset = "0x2033170", VA = "0x182034B70")]
		public static explicit operator Box2f(Box2d v)
		{
			return default(Box2f);
		}

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		[FieldOffset(Offset = "0x0")]
		public Vector2d Center;

		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		[FieldOffset(Offset = "0x10")]
		public Vector2d AxisX;

		// Token: 0x04000741 RID: 1857
		[Token(Token = "0x4000741")]
		[FieldOffset(Offset = "0x20")]
		public Vector2d AxisY;

		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x4000742")]
		[FieldOffset(Offset = "0x30")]
		public Vector2d Extent;

		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Box2d Empty;
	}
}
