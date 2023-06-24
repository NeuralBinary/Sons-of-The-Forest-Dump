using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001FB RID: 507
	[Token(Token = "0x20001FB")]
	public struct Segment2f
	{
		// Token: 0x060010A1 RID: 4257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010A1")]
		[Address(RVA = "0x1E47110", Offset = "0x1E45710", VA = "0x181E47110")]
		public Segment2f(Vector2f p0, Vector2f p1)
		{
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x1E47200", Offset = "0x1E45800", VA = "0x181E47200")]
		public Segment2f(Vector2f center, Vector2f direction, float extent)
		{
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x0000C9BC File Offset: 0x0000ABBC
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002A5")]
		public Vector2f P0
		{
			[Token(Token = "0x60010A3")]
			[Address(RVA = "0x1E47210", Offset = "0x1E45810", VA = "0x181E47210")]
			get
			{
				return default(Vector2f);
			}
			[Token(Token = "0x60010A4")]
			[Address(RVA = "0x1E472B0", Offset = "0x1E458B0", VA = "0x181E472B0")]
			set
			{
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002A6")]
		public Vector2f P1
		{
			[Token(Token = "0x60010A5")]
			[Address(RVA = "0x1E472F0", Offset = "0x1E458F0", VA = "0x181E472F0")]
			get
			{
				return default(Vector2f);
			}
			[Token(Token = "0x60010A6")]
			[Address(RVA = "0x1E47390", Offset = "0x1E45990", VA = "0x181E47390")]
			set
			{
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x0000C9EC File Offset: 0x0000ABEC
		[Token(Token = "0x170002A7")]
		public float Length
		{
			[Token(Token = "0x60010A7")]
			[Address(RVA = "0x1E473D0", Offset = "0x1E459D0", VA = "0x181E473D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0000CA04 File Offset: 0x0000AC04
		[Token(Token = "0x60010A8")]
		[Address(RVA = "0x1E473E0", Offset = "0x1E459E0", VA = "0x181E473E0")]
		public Vector2f PointAt(float d)
		{
			return default(Vector2f);
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0000CA1C File Offset: 0x0000AC1C
		[Token(Token = "0x60010A9")]
		[Address(RVA = "0x1E47480", Offset = "0x1E45A80", VA = "0x181E47480")]
		public Vector2f PointBetween(float t)
		{
			return default(Vector2f);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0000CA34 File Offset: 0x0000AC34
		[Token(Token = "0x60010AA")]
		[Address(RVA = "0x1E47550", Offset = "0x1E45B50", VA = "0x181E47550")]
		public float DistanceSquared(Vector2f p)
		{
			return 0f;
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		[Token(Token = "0x60010AB")]
		[Address(RVA = "0x1E476E0", Offset = "0x1E45CE0", VA = "0x181E476E0")]
		public Vector2f NearestPoint(Vector2f p)
		{
			return default(Vector2f);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0000CA64 File Offset: 0x0000AC64
		[Token(Token = "0x60010AC")]
		[Address(RVA = "0x1E47800", Offset = "0x1E45E00", VA = "0x181E47800")]
		public float Project(Vector2f p)
		{
			return 0f;
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010AD")]
		[Address(RVA = "0x1E47880", Offset = "0x1E45E80", VA = "0x181E47880")]
		private void update_from_endpoints(Vector2f p0, Vector2f p1)
		{
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0000CA7C File Offset: 0x0000AC7C
		[Token(Token = "0x60010AE")]
		[Address(RVA = "0x1E47970", Offset = "0x1E45F70", VA = "0x181E47970")]
		public static float FastDistanceSquared(ref Vector2f a, ref Vector2f b, ref Vector2f pt)
		{
			return 0f;
		}

		// Token: 0x04000823 RID: 2083
		[Token(Token = "0x4000823")]
		[FieldOffset(Offset = "0x0")]
		public Vector2f Center;

		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		[FieldOffset(Offset = "0x8")]
		public Vector2f Direction;

		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		[FieldOffset(Offset = "0x10")]
		public float Extent;
	}
}
