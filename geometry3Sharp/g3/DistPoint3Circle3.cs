using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200014B RID: 331
	[Token(Token = "0x200014B")]
	public class DistPoint3Circle3
	{
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00006DAC File Offset: 0x00004FAC
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700019B")]
		public Vector3d Point
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x718F50", Offset = "0x717550", VA = "0x180718F50")]
			get
			{
				return default(Vector3d);
			}
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x1FE6EA0", Offset = "0x1FE54A0", VA = "0x181FE6EA0")]
			set
			{
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700019C")]
		public Circle3d Circle
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x1FE6EC0", Offset = "0x1FE54C0", VA = "0x181FE6EC0")]
			set
			{
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x1FE6F30", Offset = "0x1FE5530", VA = "0x181FE6F30")]
		public DistPoint3Circle3(Vector3d PointIn, Circle3d circleIn)
		{
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x1FE6FA0", Offset = "0x1FE55A0", VA = "0x181FE6FA0")]
		public DistPoint3Circle3 Compute()
		{
			return null;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00006DC4 File Offset: 0x00004FC4
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x1FE6FC0", Offset = "0x1FE55C0", VA = "0x181FE6FC0")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00006DDC File Offset: 0x00004FDC
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x1FE7040", Offset = "0x1FE5640", VA = "0x181FE7040")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x10")]
		private Vector3d point;

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x28")]
		private Circle3d circle;

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x30")]
		public double DistanceSquared;

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x38")]
		public Vector3d CircleClosest;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x50")]
		public bool AllCirclePointsEquidistant;
	}
}
