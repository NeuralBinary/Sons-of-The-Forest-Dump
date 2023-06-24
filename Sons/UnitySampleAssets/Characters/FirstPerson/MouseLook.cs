using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnitySampleAssets.Characters.FirstPerson
{
	// Token: 0x02000354 RID: 852
	[Token(Token = "0x2000354")]
	[Serializable]
	public class MouseLook
	{
		// Token: 0x06001550 RID: 5456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001550")]
		[Address(RVA = "0x326E970", Offset = "0x326CF70", VA = "0x18326E970")]
		public void Init(Transform character, Transform camera)
		{
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001551")]
		[Address(RVA = "0x326EA60", Offset = "0x326D060", VA = "0x18326EA60")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00007038 File Offset: 0x00005238
		[Token(Token = "0x6001552")]
		[Address(RVA = "0x326F390", Offset = "0x326D990", VA = "0x18326F390")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001553")]
		[Address(RVA = "0x326F450", Offset = "0x326DA50", VA = "0x18326F450")]
		public MouseLook()
		{
		}

		// Token: 0x040015D4 RID: 5588
		[Token(Token = "0x40015D4")]
		[FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		// Token: 0x040015D5 RID: 5589
		[Token(Token = "0x40015D5")]
		[FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		// Token: 0x040015D6 RID: 5590
		[Token(Token = "0x40015D6")]
		[FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		// Token: 0x040015D7 RID: 5591
		[Token(Token = "0x40015D7")]
		[FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		// Token: 0x040015D8 RID: 5592
		[Token(Token = "0x40015D8")]
		[FieldOffset(Offset = "0x20")]
		public float MaximumX;

		// Token: 0x040015D9 RID: 5593
		[Token(Token = "0x40015D9")]
		[FieldOffset(Offset = "0x24")]
		public bool smooth;

		// Token: 0x040015DA RID: 5594
		[Token(Token = "0x40015DA")]
		[FieldOffset(Offset = "0x28")]
		public float smoothTime;

		// Token: 0x040015DB RID: 5595
		[Token(Token = "0x40015DB")]
		[FieldOffset(Offset = "0x2C")]
		private Quaternion m_CharacterTargetRot;

		// Token: 0x040015DC RID: 5596
		[Token(Token = "0x40015DC")]
		[FieldOffset(Offset = "0x3C")]
		private Quaternion m_CameraTargetRot;
	}
}
