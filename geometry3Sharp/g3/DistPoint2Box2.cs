using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	public class DistPoint2Box2
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00006D04 File Offset: 0x00004F04
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000197")]
		public Vector2d Point
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x74B700", Offset = "0x749D00", VA = "0x18074B700")]
			get
			{
				return default(Vector2d);
			}
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x1FE66E0", Offset = "0x1FE4CE0", VA = "0x181FE66E0")]
			set
			{
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00006D1C File Offset: 0x00004F1C
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000198")]
		public Box2d Box
		{
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x1FE6700", Offset = "0x1FE4D00", VA = "0x181FE6700")]
			get
			{
				return default(Box2d);
			}
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x1FE6730", Offset = "0x1FE4D30", VA = "0x181FE6730")]
			set
			{
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x1FE6760", Offset = "0x1FE4D60", VA = "0x181FE6760")]
		public DistPoint2Box2(Vector2d PointIn, Box2d boxIn)
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x1FE67A0", Offset = "0x1FE4DA0", VA = "0x181FE67A0")]
		public DistPoint2Box2 Compute()
		{
			return null;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00006D34 File Offset: 0x00004F34
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x1FE67C0", Offset = "0x1FE4DC0", VA = "0x181FE67C0")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00006D4C File Offset: 0x00004F4C
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x1FE6840", Offset = "0x1FE4E40", VA = "0x181FE6840")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x10")]
		private Vector2d point;

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x20")]
		private Box2d box;

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x60")]
		public double DistanceSquared;

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x68")]
		public Vector2d BoxClosest;
	}
}
