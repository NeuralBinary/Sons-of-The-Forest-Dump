using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200014C RID: 332
	[Token(Token = "0x200014C")]
	public class DistPoint3Cylinder3
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00006DF4 File Offset: 0x00004FF4
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700019D")]
		public Vector3d Point
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x718F50", Offset = "0x717550", VA = "0x180718F50")]
			get
			{
				return default(Vector3d);
			}
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x1FE6EA0", Offset = "0x1FE54A0", VA = "0x181FE6EA0")]
			set
			{
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700019E")]
		public Cylinder3d Cylinder
		{
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x1FE6EC0", Offset = "0x1FE54C0", VA = "0x181FE6EC0")]
			set
			{
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00006E0C File Offset: 0x0000500C
		[Token(Token = "0x1700019F")]
		public bool IsInside
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x1FE73E0", Offset = "0x1FE59E0", VA = "0x181FE73E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00006E24 File Offset: 0x00005024
		[Token(Token = "0x170001A0")]
		public double SolidDistance
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x1FE73F0", Offset = "0x1FE59F0", VA = "0x181FE73F0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x1FE6F30", Offset = "0x1FE5530", VA = "0x181FE6F30")]
		public DistPoint3Cylinder3(Vector3d PointIn, Cylinder3d CylinderIn)
		{
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x1FE7410", Offset = "0x1FE5A10", VA = "0x181FE7410")]
		public DistPoint3Cylinder3 Compute()
		{
			return null;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00006E3C File Offset: 0x0000503C
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x1FE7430", Offset = "0x1FE5A30", VA = "0x181FE7430")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00006E54 File Offset: 0x00005054
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x1FE74B0", Offset = "0x1FE5AB0", VA = "0x181FE74B0")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00006E6C File Offset: 0x0000506C
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x1FE7B90", Offset = "0x1FE6190", VA = "0x181FE7B90")]
		public double get_squared_infinite()
		{
			return 0.0;
		}

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x10")]
		private Vector3d point;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x28")]
		private Cylinder3d cylinder;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x30")]
		public double DistanceSquared;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x38")]
		public double SignedDistance;

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x40")]
		public Vector3d CylinderClosest;
	}
}
