using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x0200059B RID: 1435
	[Token(Token = "0x200059B")]
	public struct DepthOfFieldParameters
	{
		// Token: 0x040021F8 RID: 8696
		[Token(Token = "0x40021F8")]
		[FieldOffset(Offset = "0x0")]
		public bool useMedianFilter;

		// Token: 0x040021F9 RID: 8697
		[Token(Token = "0x40021F9")]
		[FieldOffset(Offset = "0x4")]
		public DepthOfFieldQuality quality;

		// Token: 0x040021FA RID: 8698
		[Token(Token = "0x40021FA")]
		[FieldOffset(Offset = "0x8")]
		public DepthFocusMode depthFocusMode;

		// Token: 0x040021FB RID: 8699
		[Token(Token = "0x40021FB")]
		[FieldOffset(Offset = "0xC")]
		public float maxCoCRadius;

		// Token: 0x040021FC RID: 8700
		[Token(Token = "0x40021FC")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 pointAveragePosition;

		// Token: 0x040021FD RID: 8701
		[Token(Token = "0x40021FD")]
		[FieldOffset(Offset = "0x18")]
		public float pointAverageRange;

		// Token: 0x040021FE RID: 8702
		[Token(Token = "0x40021FE")]
		[FieldOffset(Offset = "0x1C")]
		public bool visualizePointFocus;

		// Token: 0x040021FF RID: 8703
		[Token(Token = "0x40021FF")]
		[FieldOffset(Offset = "0x20")]
		public float depthAdaptionSpeed;

		// Token: 0x04002200 RID: 8704
		[Token(Token = "0x4002200")]
		[FieldOffset(Offset = "0x24")]
		public float focalDistance;

		// Token: 0x04002201 RID: 8705
		[Token(Token = "0x4002201")]
		[FieldOffset(Offset = "0x28")]
		public float focalRange;
	}
}
