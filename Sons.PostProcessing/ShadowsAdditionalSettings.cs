using System;
using Il2CppDummyDll;

namespace Sons.PostProcessing
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[Serializable]
	public struct ShadowsAdditionalSettings
	{
		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x0")]
		public float _verySmallShadowCaster;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x4")]
		public float _smallShadowCaster;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x8")]
		public float _terrainShadowCaster;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0xC")]
		public int _shadowMapResolution;
	}
}
