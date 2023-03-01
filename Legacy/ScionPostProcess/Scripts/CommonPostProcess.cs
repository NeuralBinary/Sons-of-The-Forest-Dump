using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200058C RID: 1420
	[Token(Token = "0x200058C")]
	public struct CommonPostProcess
	{
		// Token: 0x0400212E RID: 8494
		[Token(Token = "0x400212E")]
		[FieldOffset(Offset = "0x0")]
		public float grainIntensity;

		// Token: 0x0400212F RID: 8495
		[Token(Token = "0x400212F")]
		[FieldOffset(Offset = "0x4")]
		public float vignetteIntensity;

		// Token: 0x04002130 RID: 8496
		[Token(Token = "0x4002130")]
		[FieldOffset(Offset = "0x8")]
		public float vignetteScale;

		// Token: 0x04002131 RID: 8497
		[Token(Token = "0x4002131")]
		[FieldOffset(Offset = "0xC")]
		public Color vignetteColor;

		// Token: 0x04002132 RID: 8498
		[Token(Token = "0x4002132")]
		[FieldOffset(Offset = "0x1C")]
		public bool chromaticAberration;

		// Token: 0x04002133 RID: 8499
		[Token(Token = "0x4002133")]
		[FieldOffset(Offset = "0x20")]
		public float chromaticAberrationDistortion;

		// Token: 0x04002134 RID: 8500
		[Token(Token = "0x4002134")]
		[FieldOffset(Offset = "0x24")]
		public float chromaticAberrationIntensity;

		// Token: 0x04002135 RID: 8501
		[Token(Token = "0x4002135")]
		[FieldOffset(Offset = "0x28")]
		public float whitePoint;
	}
}
