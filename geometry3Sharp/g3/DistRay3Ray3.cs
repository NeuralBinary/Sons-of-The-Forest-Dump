using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	public class DistRay3Ray3
	{
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00006EFC File Offset: 0x000050FC
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A3")]
		public Ray3d Ray1
		{
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x1B19AA0", Offset = "0x1B180A0", VA = "0x181B19AA0")]
			get
			{
				return default(Ray3d);
			}
			[Token(Token = "0x600094B")]
			[Address(RVA = "0x1FE4CF0", Offset = "0x1FE32F0", VA = "0x181FE4CF0")]
			set
			{
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x00006F14 File Offset: 0x00005114
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A4")]
		public Ray3d Ray2
		{
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x1FE4D20", Offset = "0x1FE3320", VA = "0x181FE4D20")]
			get
			{
				return default(Ray3d);
			}
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x1FE4D40", Offset = "0x1FE3340", VA = "0x181FE4D40")]
			set
			{
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1FE8860", Offset = "0x1FE6E60", VA = "0x181FE8860")]
		public DistRay3Ray3(Ray3d ray1, Ray3d ray2)
		{
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00006F2C File Offset: 0x0000512C
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x1FE88A0", Offset = "0x1FE6EA0", VA = "0x181FE88A0")]
		public static double MinDistance(Ray3d r1, Ray3d r2)
		{
			return 0.0;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00006F44 File Offset: 0x00005144
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x1FE8990", Offset = "0x1FE6F90", VA = "0x181FE8990")]
		public static double MinDistanceRay2Param(Ray3d r1, Ray3d r2)
		{
			return 0.0;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x1FE8A30", Offset = "0x1FE7030", VA = "0x181FE8A30")]
		public DistRay3Ray3 Compute()
		{
			return null;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00006F5C File Offset: 0x0000515C
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x1FE8A50", Offset = "0x1FE7050", VA = "0x181FE8A50")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00006F74 File Offset: 0x00005174
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x1FE8AD0", Offset = "0x1FE70D0", VA = "0x181FE8AD0")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0x10")]
		private Ray3d ray1;

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x40")]
		private Ray3d ray2;

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x70")]
		public double DistanceSquared;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x78")]
		public Vector3d Ray1Closest;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x90")]
		public double Ray1Parameter;

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x98")]
		public Vector3d Ray2Closest;

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0xB0")]
		public double Ray2Parameter;
	}
}
