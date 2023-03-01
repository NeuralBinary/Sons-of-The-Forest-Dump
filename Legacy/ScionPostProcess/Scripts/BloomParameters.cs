using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x02000587 RID: 1415
	[Token(Token = "0x2000587")]
	public struct BloomParameters
	{
		// Token: 0x04002111 RID: 8465
		[Token(Token = "0x4002111")]
		[FieldOffset(Offset = "0x0")]
		public float intensity;

		// Token: 0x04002112 RID: 8466
		[Token(Token = "0x4002112")]
		[FieldOffset(Offset = "0x4")]
		public float brightness;

		// Token: 0x04002113 RID: 8467
		[Token(Token = "0x4002113")]
		[FieldOffset(Offset = "0x8")]
		public int downsamples;
	}
}
