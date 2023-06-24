using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	public class GaussPointsFit3
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1E1B930", Offset = "0x1E19F30", VA = "0x181E1B930")]
		public GaussPointsFit3(IEnumerable<Vector3d> points)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1E1C0F0", Offset = "0x1E1A6F0", VA = "0x181E1C0F0")]
		public GaussPointsFit3(IEnumerable<Vector3d> points, IEnumerable<double> weights)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1E1CB50", Offset = "0x1E1B150", VA = "0x181E1CB50")]
		private void do_solve(double sumXX, double sumXY, double sumXZ, double sumYY, double sumYZ, double sumZZ, double invSumMultiplier)
		{
		}

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x10")]
		public Box3d Box;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x88")]
		public bool ResultValid;
	}
}
