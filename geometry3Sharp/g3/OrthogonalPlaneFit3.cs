using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	public class OrthogonalPlaneFit3
	{
		// Token: 0x06000121 RID: 289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1E1CE90", Offset = "0x1E1B490", VA = "0x181E1CE90")]
		public OrthogonalPlaneFit3(IEnumerable<Vector3d> points)
		{
		}

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x10")]
		public Vector3d Origin;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x28")]
		public Vector3d Normal;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x40")]
		public bool ResultValid;
	}
}
