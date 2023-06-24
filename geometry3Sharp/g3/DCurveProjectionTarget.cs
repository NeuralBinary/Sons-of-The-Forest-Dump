using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000357 RID: 855
	[Token(Token = "0x2000357")]
	public class DCurveProjectionTarget : IProjectionTarget
	{
		// Token: 0x06001C39 RID: 7225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C39")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public DCurveProjectionTarget(DCurve3 curve)
		{
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00013FF4 File Offset: 0x000121F4
		[Token(Token = "0x6001C3A")]
		[Address(RVA = "0x1F68FF0", Offset = "0x1F675F0", VA = "0x181F68FF0", Slot = "4")]
		public Vector3d Project(Vector3d vPoint, int identifier = -1)
		{
			return default(Vector3d);
		}

		// Token: 0x04000F0B RID: 3851
		[Token(Token = "0x4000F0B")]
		[FieldOffset(Offset = "0x10")]
		public DCurve3 Curve;
	}
}
