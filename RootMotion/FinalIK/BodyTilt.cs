using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	public class BodyTilt : OffsetModifier
	{
		// Token: 0x060005CD RID: 1485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x298FB50", Offset = "0x298E150", VA = "0x18298FB50", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x298FC50", Offset = "0x298E250", VA = "0x18298FC50", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2990000", Offset = "0x298E600", VA = "0x182990000")]
		public BodyTilt()
		{
		}

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x50")]
		private float tiltAngle;

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 lastForward;
	}
}
