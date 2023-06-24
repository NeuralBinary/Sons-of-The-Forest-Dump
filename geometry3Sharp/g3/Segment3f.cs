using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001FE RID: 510
	[Token(Token = "0x20001FE")]
	public struct Segment3f
	{
		// Token: 0x060010CC RID: 4300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010CC")]
		[Address(RVA = "0x1E48CA0", Offset = "0x1E472A0", VA = "0x181E48CA0")]
		public Segment3f(Vector3f p0, Vector3f p1)
		{
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010CD")]
		[Address(RVA = "0x1E48DD0", Offset = "0x1E473D0", VA = "0x181E48DD0")]
		public Segment3f(Vector3f center, Vector3f direction, float extent)
		{
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010CE")]
		[Address(RVA = "0x1E48E00", Offset = "0x1E47400", VA = "0x181E48E00")]
		public void SetEndpoints(Vector3f p0, Vector3f p1)
		{
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x0000CC5C File Offset: 0x0000AE5C
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002AF")]
		public Vector3f P0
		{
			[Token(Token = "0x60010CF")]
			[Address(RVA = "0x1E48E40", Offset = "0x1E47440", VA = "0x181E48E40")]
			get
			{
				return default(Vector3f);
			}
			[Token(Token = "0x60010D0")]
			[Address(RVA = "0x1E48F20", Offset = "0x1E47520", VA = "0x181E48F20")]
			set
			{
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x0000CC74 File Offset: 0x0000AE74
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002B0")]
		public Vector3f P1
		{
			[Token(Token = "0x60010D1")]
			[Address(RVA = "0x1E48F90", Offset = "0x1E47590", VA = "0x181E48F90")]
			get
			{
				return default(Vector3f);
			}
			[Token(Token = "0x60010D2")]
			[Address(RVA = "0x1E49070", Offset = "0x1E47670", VA = "0x181E49070")]
			set
			{
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x0000CC8C File Offset: 0x0000AE8C
		[Token(Token = "0x170002B1")]
		public float Length
		{
			[Token(Token = "0x60010D3")]
			[Address(RVA = "0x1E490D0", Offset = "0x1E476D0", VA = "0x181E490D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
		[Token(Token = "0x60010D4")]
		[Address(RVA = "0x1E490E0", Offset = "0x1E476E0", VA = "0x181E490E0")]
		public Vector3f PointAt(float d)
		{
			return default(Vector3f);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0000CCBC File Offset: 0x0000AEBC
		[Token(Token = "0x60010D5")]
		[Address(RVA = "0x1E491C0", Offset = "0x1E477C0", VA = "0x181E491C0")]
		public Vector3f PointBetween(float t)
		{
			return default(Vector3f);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0000CCD4 File Offset: 0x0000AED4
		[Token(Token = "0x60010D6")]
		[Address(RVA = "0x1E492C0", Offset = "0x1E478C0", VA = "0x181E492C0")]
		public float DistanceSquared(Vector3f p)
		{
			return 0f;
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0000CCEC File Offset: 0x0000AEEC
		[Token(Token = "0x60010D7")]
		[Address(RVA = "0x1E494C0", Offset = "0x1E47AC0", VA = "0x181E494C0")]
		public Vector3f NearestPoint(Vector3f p)
		{
			return default(Vector3f);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0000CD04 File Offset: 0x0000AF04
		[Token(Token = "0x60010D8")]
		[Address(RVA = "0x1E49670", Offset = "0x1E47C70", VA = "0x181E49670")]
		public float Project(Vector3f p)
		{
			return 0f;
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010D9")]
		[Address(RVA = "0x1E49720", Offset = "0x1E47D20", VA = "0x181E49720")]
		private void update_from_endpoints(Vector3f p0, Vector3f p1)
		{
		}

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		[FieldOffset(Offset = "0x0")]
		public Vector3f Center;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		[FieldOffset(Offset = "0xC")]
		public Vector3f Direction;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[FieldOffset(Offset = "0x18")]
		public float Extent;
	}
}
