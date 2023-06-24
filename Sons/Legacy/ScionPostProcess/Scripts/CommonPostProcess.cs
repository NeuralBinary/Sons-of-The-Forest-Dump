using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200059C RID: 1436
	[Token(Token = "0x200059C")]
	public struct CommonPostProcess
	{
		// Token: 0x04002202 RID: 8706
		[Token(Token = "0x4002202")]
		[FieldOffset(Offset = "0x0")]
		public float grainIntensity;

		// Token: 0x04002203 RID: 8707
		[Token(Token = "0x4002203")]
		[FieldOffset(Offset = "0x4")]
		public float vignetteIntensity;

		// Token: 0x04002204 RID: 8708
		[Token(Token = "0x4002204")]
		[FieldOffset(Offset = "0x8")]
		public float vignetteScale;

		// Token: 0x04002205 RID: 8709
		[Token(Token = "0x4002205")]
		[FieldOffset(Offset = "0xC")]
		public Color vignetteColor;

		// Token: 0x04002206 RID: 8710
		[Token(Token = "0x4002206")]
		[FieldOffset(Offset = "0x1C")]
		public bool chromaticAberration;

		// Token: 0x04002207 RID: 8711
		[Token(Token = "0x4002207")]
		[FieldOffset(Offset = "0x20")]
		public float chromaticAberrationDistortion;

		// Token: 0x04002208 RID: 8712
		[Token(Token = "0x4002208")]
		[FieldOffset(Offset = "0x24")]
		public float chromaticAberrationIntensity;

		// Token: 0x04002209 RID: 8713
		[Token(Token = "0x4002209")]
		[FieldOffset(Offset = "0x28")]
		public float whitePoint;
	}
}
