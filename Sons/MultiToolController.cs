using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons
{
	// Token: 0x020004CD RID: 1229
	[Token(Token = "0x20004CD")]
	public class MultiToolController : MonoBehaviour
	{
		// Token: 0x0600202F RID: 8239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202F")]
		[Address(RVA = "0x3311B00", Offset = "0x3310100", VA = "0x183311B00")]
		private void Awake()
		{
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002030")]
		[Address(RVA = "0x3311C10", Offset = "0x3310210", VA = "0x183311C10")]
		private void Update()
		{
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002031")]
		[Address(RVA = "0x3311D20", Offset = "0x3310320", VA = "0x183311D20")]
		private void OnEnable()
		{
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002032")]
		[Address(RVA = "0x3311D30", Offset = "0x3310330", VA = "0x183311D30")]
		private void SetActiveEnd(MultiToolController.Slot activeSlot)
		{
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002033")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MultiToolController()
		{
		}

		// Token: 0x04001D97 RID: 7575
		[Token(Token = "0x4001D97")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _frontTool;

		// Token: 0x04001D98 RID: 7576
		[Token(Token = "0x4001D98")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _backTool;

		// Token: 0x04001D99 RID: 7577
		[Token(Token = "0x4001D99")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _frontSlotOffset;

		// Token: 0x04001D9A RID: 7578
		[Token(Token = "0x4001D9A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _backSlotOffset;

		// Token: 0x04001D9B RID: 7579
		[Token(Token = "0x4001D9B")]
		[FieldOffset(Offset = "0x40")]
		private MultiToolController.Slot _activeSlot;

		// Token: 0x04001D9C RID: 7580
		[Token(Token = "0x4001D9C")]
		[FieldOffset(Offset = "0x48")]
		private weaponInfo _frontWeaponInfo;

		// Token: 0x04001D9D RID: 7581
		[Token(Token = "0x4001D9D")]
		[FieldOffset(Offset = "0x50")]
		private weaponInfo _backWeaponInfo;

		// Token: 0x020004CE RID: 1230
		[Token(Token = "0x20004CE")]
		private enum Slot
		{
			// Token: 0x04001D9F RID: 7583
			[Token(Token = "0x4001D9F")]
			Front,
			// Token: 0x04001DA0 RID: 7584
			[Token(Token = "0x4001DA0")]
			Back
		}
	}
}
