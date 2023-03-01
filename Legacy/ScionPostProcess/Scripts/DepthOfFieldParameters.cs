using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200058B RID: 1419
	[Token(Token = "0x200058B")]
	public struct DepthOfFieldParameters
	{
		// Token: 0x04002124 RID: 8484
		[Token(Token = "0x4002124")]
		[FieldOffset(Offset = "0x0")]
		public bool useMedianFilter;

		// Token: 0x04002125 RID: 8485
		[Token(Token = "0x4002125")]
		[FieldOffset(Offset = "0x4")]
		public DepthOfFieldQuality quality;

		// Token: 0x04002126 RID: 8486
		[Token(Token = "0x4002126")]
		[FieldOffset(Offset = "0x8")]
		public DepthFocusMode depthFocusMode;

		// Token: 0x04002127 RID: 8487
		[Token(Token = "0x4002127")]
		[FieldOffset(Offset = "0xC")]
		public float maxCoCRadius;

		// Token: 0x04002128 RID: 8488
		[Token(Token = "0x4002128")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 pointAveragePosition;

		// Token: 0x04002129 RID: 8489
		[Token(Token = "0x4002129")]
		[FieldOffset(Offset = "0x18")]
		public float pointAverageRange;

		// Token: 0x0400212A RID: 8490
		[Token(Token = "0x400212A")]
		[FieldOffset(Offset = "0x1C")]
		public bool visualizePointFocus;

		// Token: 0x0400212B RID: 8491
		[Token(Token = "0x400212B")]
		[FieldOffset(Offset = "0x20")]
		public float depthAdaptionSpeed;

		// Token: 0x0400212C RID: 8492
		[Token(Token = "0x400212C")]
		[FieldOffset(Offset = "0x24")]
		public float focalDistance;

		// Token: 0x0400212D RID: 8493
		[Token(Token = "0x400212D")]
		[FieldOffset(Offset = "0x28")]
		public float focalRange;
	}
}
