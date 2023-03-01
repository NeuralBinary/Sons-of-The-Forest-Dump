using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x02000589 RID: 1417
	[Token(Token = "0x2000589")]
	public struct CameraParameters
	{
		// Token: 0x04002116 RID: 8470
		[Token(Token = "0x4002116")]
		[FieldOffset(Offset = "0x0")]
		public CameraMode cameraMode;

		// Token: 0x04002117 RID: 8471
		[Token(Token = "0x4002117")]
		[FieldOffset(Offset = "0x4")]
		public float focalLength;

		// Token: 0x04002118 RID: 8472
		[Token(Token = "0x4002118")]
		[FieldOffset(Offset = "0x8")]
		public float apertureDiameter;

		// Token: 0x04002119 RID: 8473
		[Token(Token = "0x4002119")]
		[FieldOffset(Offset = "0xC")]
		public float fNumber;

		// Token: 0x0400211A RID: 8474
		[Token(Token = "0x400211A")]
		[FieldOffset(Offset = "0x10")]
		public float ISO;

		// Token: 0x0400211B RID: 8475
		[Token(Token = "0x400211B")]
		[FieldOffset(Offset = "0x14")]
		public float shutterSpeed;

		// Token: 0x0400211C RID: 8476
		[Token(Token = "0x400211C")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 minMaxExposure;

		// Token: 0x0400211D RID: 8477
		[Token(Token = "0x400211D")]
		[FieldOffset(Offset = "0x20")]
		public float exposureCompensation;

		// Token: 0x0400211E RID: 8478
		[Token(Token = "0x400211E")]
		[FieldOffset(Offset = "0x24")]
		public float fieldOfView;

		// Token: 0x0400211F RID: 8479
		[Token(Token = "0x400211F")]
		[FieldOffset(Offset = "0x28")]
		public float adaptionSpeed;

		// Token: 0x04002120 RID: 8480
		[Token(Token = "0x4002120")]
		[FieldOffset(Offset = "0x2C")]
		public float aspect;

		// Token: 0x04002121 RID: 8481
		[Token(Token = "0x4002121")]
		[FieldOffset(Offset = "0x30")]
		public float nearPlane;

		// Token: 0x04002122 RID: 8482
		[Token(Token = "0x4002122")]
		[FieldOffset(Offset = "0x34")]
		public float farPlane;
	}
}
