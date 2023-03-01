using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200058D RID: 1421
	[Token(Token = "0x200058D")]
	public struct ColorGradingParameters
	{
		// Token: 0x04002136 RID: 8502
		[Token(Token = "0x4002136")]
		[FieldOffset(Offset = "0x0")]
		public ColorGradingMode colorGradingMode;

		// Token: 0x04002137 RID: 8503
		[Token(Token = "0x4002137")]
		[FieldOffset(Offset = "0x4")]
		public ColorGradingCompatibility colorGradingCompatibility;

		// Token: 0x04002138 RID: 8504
		[Token(Token = "0x4002138")]
		[FieldOffset(Offset = "0x8")]
		public Texture2D colorGradingTex1;

		// Token: 0x04002139 RID: 8505
		[Token(Token = "0x4002139")]
		[FieldOffset(Offset = "0x10")]
		public Texture2D colorGradingTex2;

		// Token: 0x0400213A RID: 8506
		[Token(Token = "0x400213A")]
		[FieldOffset(Offset = "0x18")]
		public float colorGradingBlendFactor;
	}
}
