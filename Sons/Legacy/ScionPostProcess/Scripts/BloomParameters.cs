using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x02000597 RID: 1431
	[Token(Token = "0x2000597")]
	public struct BloomParameters
	{
		// Token: 0x040021E5 RID: 8677
		[Token(Token = "0x40021E5")]
		[FieldOffset(Offset = "0x0")]
		public float intensity;

		// Token: 0x040021E6 RID: 8678
		[Token(Token = "0x40021E6")]
		[FieldOffset(Offset = "0x4")]
		public float brightness;

		// Token: 0x040021E7 RID: 8679
		[Token(Token = "0x40021E7")]
		[FieldOffset(Offset = "0x8")]
		public int downsamples;
	}
}
