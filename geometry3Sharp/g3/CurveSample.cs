using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	public struct CurveSample
	{
		// Token: 0x06000515 RID: 1301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1E306B0", Offset = "0x1E2ECB0", VA = "0x181E306B0")]
		public CurveSample(Vector3d p, Vector3d t)
		{
		}

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x0")]
		public Vector3d position;

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x18")]
		public Vector3d tangent;
	}
}
