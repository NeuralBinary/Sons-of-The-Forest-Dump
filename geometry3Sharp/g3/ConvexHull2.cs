using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	public class ConvexHull2
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x1700001D")]
		public int Dimension
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x1700001E")]
		public int NumSimplices
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700001F")]
		public int[] HullIndices
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1E24120", Offset = "0x1E22720", VA = "0x181E24120")]
		public ConvexHull2(IList<Vector2d> vertices, double epsilon, QueryNumberType queryType)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1E24B80", Offset = "0x1E23180", VA = "0x181E24B80")]
		public void Get1DHullInfo(out Vector2d origin, out Vector2d direction)
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1E24B90", Offset = "0x1E23190", VA = "0x181E24B90")]
		public Polygon2d GetHullPolygon()
		{
			return null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1E24DD0", Offset = "0x1E233D0", VA = "0x181E24DD0")]
		private bool Update(ref ConvexHull2.Edge hull, int i)
		{
			return default(bool);
		}

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x10")]
		private IList<Vector2d> mVertices;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x18")]
		private int mNumVertices;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x1C")]
		private int mDimension;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x20")]
		private int mNumSimplices;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x28")]
		private double mEpsilon;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x30")]
		private Vector2d[] mSVertices;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x38")]
		private int[] mIndices;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x40")]
		private Query2 mQuery;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x48")]
		private Vector2d mLineOrigin;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x58")]
		private Vector2d mLineDirection;

		// Token: 0x02000053 RID: 83
		[Token(Token = "0x2000053")]
		protected class Edge
		{
			// Token: 0x06000181 RID: 385 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x1E25110", Offset = "0x1E23710", VA = "0x181E25110")]
			public Edge(int v0, int v1)
			{
			}

			// Token: 0x06000182 RID: 386 RVA: 0x00002E7C File Offset: 0x0000107C
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x1E251D0", Offset = "0x1E237D0", VA = "0x181E251D0")]
			public int GetSign(int i, Query2 query)
			{
				return 0;
			}

			// Token: 0x06000183 RID: 387 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1E25250", Offset = "0x1E23850", VA = "0x181E25250")]
			public void Insert(ConvexHull2.Edge adj0, ConvexHull2.Edge adj1)
			{
			}

			// Token: 0x06000184 RID: 388 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x1E253E0", Offset = "0x1E239E0", VA = "0x181E253E0")]
			public void DeleteSelf()
			{
			}

			// Token: 0x06000185 RID: 389 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x1E254B0", Offset = "0x1E23AB0", VA = "0x181E254B0")]
			public void GetIndices(ref int numIndices, ref int[] indices)
			{
			}

			// Token: 0x040001B6 RID: 438
			[Token(Token = "0x40001B6")]
			[FieldOffset(Offset = "0x10")]
			public Vector2i V;

			// Token: 0x040001B7 RID: 439
			[Token(Token = "0x40001B7")]
			[FieldOffset(Offset = "0x18")]
			public ConvexHull2.Edge E0;

			// Token: 0x040001B8 RID: 440
			[Token(Token = "0x40001B8")]
			[FieldOffset(Offset = "0x20")]
			public ConvexHull2.Edge E1;

			// Token: 0x040001B9 RID: 441
			[Token(Token = "0x40001B9")]
			[FieldOffset(Offset = "0x28")]
			public int Sign;

			// Token: 0x040001BA RID: 442
			[Token(Token = "0x40001BA")]
			[FieldOffset(Offset = "0x2C")]
			public int Time;
		}
	}
}
