using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public class CameraControllerFPS : MonoBehaviour
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x28E37B0", Offset = "0x28E1DB0", VA = "0x1828E37B0")]
		private void Awake()
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x28E38A0", Offset = "0x28E1EA0", VA = "0x1828E38A0")]
		public void LateUpdate()
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x28E3630", Offset = "0x28E1C30", VA = "0x1828E3630")]
		private float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x28E3D60", Offset = "0x28E2360", VA = "0x1828E3D60")]
		public CameraControllerFPS()
		{
		}

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x20")]
		public float rotationSensitivity;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x24")]
		public float yMinLimit;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x28")]
		public float yMaxLimit;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x2C")]
		private float x;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x30")]
		private float y;
	}
}
