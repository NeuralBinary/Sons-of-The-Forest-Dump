using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnitySampleAssets.Characters.FirstPerson
{
	// Token: 0x02000362 RID: 866
	[Token(Token = "0x2000362")]
	[Serializable]
	public class MouseLook
	{
		// Token: 0x06001525 RID: 5413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001525")]
		[Address(RVA = "0x2CB4EB0", Offset = "0x2CB3EB0", VA = "0x182CB4EB0")]
		public void Init(Transform character, Transform camera)
		{
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001526")]
		[Address(RVA = "0x2CB4F10", Offset = "0x2CB3F10", VA = "0x182CB4F10")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00006DF8 File Offset: 0x00004FF8
		[Token(Token = "0x6001527")]
		[Address(RVA = "0x2CB4DF0", Offset = "0x2CB3DF0", VA = "0x182CB4DF0")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001528")]
		[Address(RVA = "0x2CB5570", Offset = "0x2CB4570", VA = "0x182CB5570")]
		public MouseLook()
		{
		}

		// Token: 0x040015B6 RID: 5558
		[Token(Token = "0x40015B6")]
		[FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		// Token: 0x040015B7 RID: 5559
		[Token(Token = "0x40015B7")]
		[FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		// Token: 0x040015B8 RID: 5560
		[Token(Token = "0x40015B8")]
		[FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		// Token: 0x040015B9 RID: 5561
		[Token(Token = "0x40015B9")]
		[FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		// Token: 0x040015BA RID: 5562
		[Token(Token = "0x40015BA")]
		[FieldOffset(Offset = "0x20")]
		public float MaximumX;

		// Token: 0x040015BB RID: 5563
		[Token(Token = "0x40015BB")]
		[FieldOffset(Offset = "0x24")]
		public bool smooth;

		// Token: 0x040015BC RID: 5564
		[Token(Token = "0x40015BC")]
		[FieldOffset(Offset = "0x28")]
		public float smoothTime;

		// Token: 0x040015BD RID: 5565
		[Token(Token = "0x40015BD")]
		[FieldOffset(Offset = "0x2C")]
		private Quaternion m_CharacterTargetRot;

		// Token: 0x040015BE RID: 5566
		[Token(Token = "0x40015BE")]
		[FieldOffset(Offset = "0x3C")]
		private Quaternion m_CameraTargetRot;
	}
}
