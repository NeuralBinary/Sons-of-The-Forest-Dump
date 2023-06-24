using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	public abstract class BaseCurve2
	{
		// Token: 0x06000523 RID: 1315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1F93BE0", Offset = "0x1F921E0", VA = "0x181F93BE0")]
		public BaseCurve2(double tmin, double tmax)
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000046C4 File Offset: 0x000028C4
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x5FD5E0", Offset = "0x5FBBE0", VA = "0x1805FD5E0")]
		public double GetMinTime()
		{
			return 0.0;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000046DC File Offset: 0x000028DC
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x5FD5E0", Offset = "0x5FBBE0", VA = "0x1805FD5E0")]
		public double GetMaxTime()
		{
			return 0.0;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1F93BF0", Offset = "0x1F921F0", VA = "0x181F93BF0")]
		public void SetTimeInterval(double tmin, double tmax)
		{
		}

		// Token: 0x06000527 RID: 1319
		[Token(Token = "0x6000527")]
		public abstract Vector2d GetPosition(double t);

		// Token: 0x06000528 RID: 1320
		[Token(Token = "0x6000528")]
		public abstract Vector2d GetFirstDerivative(double t);

		// Token: 0x06000529 RID: 1321
		[Token(Token = "0x6000529")]
		public abstract Vector2d GetSecondDerivative(double t);

		// Token: 0x0600052A RID: 1322
		[Token(Token = "0x600052A")]
		public abstract Vector2d GetThirdDerivative(double t);

		// Token: 0x0600052B RID: 1323 RVA: 0x000046F4 File Offset: 0x000028F4
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1F93C60", Offset = "0x1F92260", VA = "0x181F93C60")]
		public double GetSpeed(double t)
		{
			return 0.0;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0000470C File Offset: 0x0000290C
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1F93D00", Offset = "0x1F92300", VA = "0x181F93D00")]
		private double GetSpeedWithData(double t, object data)
		{
			return 0.0;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00004724 File Offset: 0x00002924
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1F93D90", Offset = "0x1F92390", VA = "0x181F93D90", Slot = "8")]
		public virtual double GetLength(double t0, double t1)
		{
			return 0.0;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0000473C File Offset: 0x0000293C
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1F94090", Offset = "0x1F92690", VA = "0x181F94090")]
		public double GetTotalLength()
		{
			return 0.0;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00004754 File Offset: 0x00002954
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1F940B0", Offset = "0x1F926B0", VA = "0x181F940B0")]
		public Vector2d GetTangent(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0000476C File Offset: 0x0000296C
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1F941D0", Offset = "0x1F927D0", VA = "0x181F941D0")]
		public Vector2d GetNormal(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1F94320", Offset = "0x1F92920", VA = "0x181F94320")]
		public void GetFrame(double t, ref Vector2d position, ref Vector2d tangent, ref Vector2d normal)
		{
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00004784 File Offset: 0x00002984
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1F944A0", Offset = "0x1F92AA0", VA = "0x181F944A0")]
		public double GetCurvature(double t)
		{
			return 0.0;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0000479C File Offset: 0x0000299C
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1F945B0", Offset = "0x1F92BB0", VA = "0x181F945B0", Slot = "9")]
		public virtual double GetTime(double length, int iterations = 32, double tolerance = 1E-06)
		{
			return 0.0;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1F947F0", Offset = "0x1F92DF0", VA = "0x181F947F0")]
		private Vector2d[] SubdivideByTime(int numPoints)
		{
			return null;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1F94960", Offset = "0x1F92F60", VA = "0x181F94960")]
		private Vector2d[] SubdivieByLength(int numPoints)
		{
			return null;
		}

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x10")]
		protected double mTMin;

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x18")]
		protected double mTMax;
	}
}
