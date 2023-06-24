using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	public class DistPoint2Circle2
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00006D64 File Offset: 0x00004F64
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000199")]
		public Vector2d Point
		{
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x74B700", Offset = "0x749D00", VA = "0x18074B700")]
			get
			{
				return default(Vector2d);
			}
			[Token(Token = "0x6000927")]
			[Address(RVA = "0x1FE6AB0", Offset = "0x1FE50B0", VA = "0x181FE6AB0")]
			set
			{
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700019A")]
		public Circle2d Circle
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x1FE6AD0", Offset = "0x1FE50D0", VA = "0x181FE6AD0")]
			set
			{
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092A")]
		[Address(RVA = "0x1FE6B40", Offset = "0x1FE5140", VA = "0x181FE6B40")]
		public DistPoint2Circle2(Vector2d PointIn, Circle2d circleIn)
		{
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x1FE6BB0", Offset = "0x1FE51B0", VA = "0x181FE6BB0")]
		public DistPoint2Circle2 Compute()
		{
			return null;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00006D7C File Offset: 0x00004F7C
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x1FE6BD0", Offset = "0x1FE51D0", VA = "0x181FE6BD0")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00006D94 File Offset: 0x00004F94
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x1FE6C50", Offset = "0x1FE5250", VA = "0x181FE6C50")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x10")]
		private Vector2d point;

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x20")]
		private Circle2d circle;

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x28")]
		public double DistanceSquared;

		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x30")]
		public Vector2d CircleClosest;

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x40")]
		public bool AllCirclePointsEquidistant;
	}
}
