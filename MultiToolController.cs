using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons
{
	// Token: 0x020004D8 RID: 1240
	[Token(Token = "0x20004D8")]
	public class MultiToolController : MonoBehaviour
	{
		// Token: 0x06001FCB RID: 8139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCB")]
		[Address(RVA = "0x2D2BD20", Offset = "0x2D2AD20", VA = "0x182D2BD20")]
		private void Awake()
		{
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCC")]
		[Address(RVA = "0x2D2BFB0", Offset = "0x2D2AFB0", VA = "0x182D2BFB0")]
		private void Update()
		{
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCD")]
		[Address(RVA = "0x2D2BDA0", Offset = "0x2D2ADA0", VA = "0x182D2BDA0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCE")]
		[Address(RVA = "0x2D2BDB0", Offset = "0x2D2ADB0", VA = "0x182D2BDB0")]
		private void SetActiveEnd(MultiToolController.Slot activeSlot)
		{
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCF")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public MultiToolController()
		{
		}

		// Token: 0x04001D5B RID: 7515
		[Token(Token = "0x4001D5B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _frontTool;

		// Token: 0x04001D5C RID: 7516
		[Token(Token = "0x4001D5C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _backTool;

		// Token: 0x04001D5D RID: 7517
		[Token(Token = "0x4001D5D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _frontSlotOffset;

		// Token: 0x04001D5E RID: 7518
		[Token(Token = "0x4001D5E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _backSlotOffset;

		// Token: 0x04001D5F RID: 7519
		[Token(Token = "0x4001D5F")]
		[FieldOffset(Offset = "0x40")]
		private MultiToolController.Slot _activeSlot;

		// Token: 0x04001D60 RID: 7520
		[Token(Token = "0x4001D60")]
		[FieldOffset(Offset = "0x48")]
		private weaponInfo _frontWeaponInfo;

		// Token: 0x04001D61 RID: 7521
		[Token(Token = "0x4001D61")]
		[FieldOffset(Offset = "0x50")]
		private weaponInfo _backWeaponInfo;

		// Token: 0x020004D9 RID: 1241
		[Token(Token = "0x20004D9")]
		private enum Slot
		{
			// Token: 0x04001D63 RID: 7523
			[Token(Token = "0x4001D63")]
			Front,
			// Token: 0x04001D64 RID: 7524
			[Token(Token = "0x4001D64")]
			Back
		}
	}
}
