using System;
using Il2CppDummyDll;

namespace Ballistics
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class BulletBallistics
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x9053E0", Offset = "0x9039E0", VA = "0x1809053E0")]
		public static float calculateZeroingAngle(float distance, ref BulletInfo bulletInfo, bool useDrag = true, float airDensity = 1.22f, int iterations = 4, float deltaDist = 1f, float simulationTimeStep = 0.015f, int simulationIterations = 1000)
		{
			return 0f;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x905840", Offset = "0x903E40", VA = "0x180905840")]
		public static float simulateFlightPath(float angle, ref BulletInfo info, float airDensity = 1.22f, float simulationTimeStep = 0.015f, int maxIterations = 1000)
		{
			return 0f;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BulletBallistics()
		{
		}
	}
}
