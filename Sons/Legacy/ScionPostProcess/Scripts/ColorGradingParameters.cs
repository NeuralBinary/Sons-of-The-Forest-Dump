using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200059D RID: 1437
	[Token(Token = "0x200059D")]
	public struct ColorGradingParameters
	{
		// Token: 0x0400220A RID: 8714
		[Token(Token = "0x400220A")]
		[FieldOffset(Offset = "0x0")]
		public ColorGradingMode colorGradingMode;

		// Token: 0x0400220B RID: 8715
		[Token(Token = "0x400220B")]
		[FieldOffset(Offset = "0x4")]
		public ColorGradingCompatibility colorGradingCompatibility;

		// Token: 0x0400220C RID: 8716
		[Token(Token = "0x400220C")]
		[FieldOffset(Offset = "0x8")]
		public Texture2D colorGradingTex1;

		// Token: 0x0400220D RID: 8717
		[Token(Token = "0x400220D")]
		[FieldOffset(Offset = "0x10")]
		public Texture2D colorGradingTex2;

		// Token: 0x0400220E RID: 8718
		[Token(Token = "0x400220E")]
		[FieldOffset(Offset = "0x18")]
		public float colorGradingBlendFactor;
	}
}
