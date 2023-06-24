using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess.Scripts
{
	// Token: 0x02000599 RID: 1433
	[Token(Token = "0x2000599")]
	public struct CameraParameters
	{
		// Token: 0x040021EA RID: 8682
		[Token(Token = "0x40021EA")]
		[FieldOffset(Offset = "0x0")]
		public CameraMode cameraMode;

		// Token: 0x040021EB RID: 8683
		[Token(Token = "0x40021EB")]
		[FieldOffset(Offset = "0x4")]
		public float focalLength;

		// Token: 0x040021EC RID: 8684
		[Token(Token = "0x40021EC")]
		[FieldOffset(Offset = "0x8")]
		public float apertureDiameter;

		// Token: 0x040021ED RID: 8685
		[Token(Token = "0x40021ED")]
		[FieldOffset(Offset = "0xC")]
		public float fNumber;

		// Token: 0x040021EE RID: 8686
		[Token(Token = "0x40021EE")]
		[FieldOffset(Offset = "0x10")]
		public float ISO;

		// Token: 0x040021EF RID: 8687
		[Token(Token = "0x40021EF")]
		[FieldOffset(Offset = "0x14")]
		public float shutterSpeed;

		// Token: 0x040021F0 RID: 8688
		[Token(Token = "0x40021F0")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 minMaxExposure;

		// Token: 0x040021F1 RID: 8689
		[Token(Token = "0x40021F1")]
		[FieldOffset(Offset = "0x20")]
		public float exposureCompensation;

		// Token: 0x040021F2 RID: 8690
		[Token(Token = "0x40021F2")]
		[FieldOffset(Offset = "0x24")]
		public float fieldOfView;

		// Token: 0x040021F3 RID: 8691
		[Token(Token = "0x40021F3")]
		[FieldOffset(Offset = "0x28")]
		public float adaptionSpeed;

		// Token: 0x040021F4 RID: 8692
		[Token(Token = "0x40021F4")]
		[FieldOffset(Offset = "0x2C")]
		public float aspect;

		// Token: 0x040021F5 RID: 8693
		[Token(Token = "0x40021F5")]
		[FieldOffset(Offset = "0x30")]
		public float nearPlane;

		// Token: 0x040021F6 RID: 8694
		[Token(Token = "0x40021F6")]
		[FieldOffset(Offset = "0x34")]
		public float farPlane;
	}
}
