using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x02000465 RID: 1125
	[Token(Token = "0x2000465")]
	[AddComponentMenu("Sons/Actions/PlayerConsumeItemAction")]
	public class PlayerConsumeItemAction : MonoBehaviour
	{
		// Token: 0x06001D0D RID: 7437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x32D0070", Offset = "0x32CE670", VA = "0x1832D0070")]
		public void ConsumeItem(ItemInstance itemInstance, bool shouldPlayConsumeAnimation, PlayerConsumeItemAction.OnConsumeComplete onConsumeCompleteCallback)
		{
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x32D0250", Offset = "0x32CE850", VA = "0x1832D0250")]
		private void ConsumeComplete()
		{
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x32D0530", Offset = "0x32CEB30", VA = "0x1832D0530")]
		private IEnumerator ConsumeItemRoutine()
		{
			return null;
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D10")]
		[Address(RVA = "0x32D05C0", Offset = "0x32CEBC0", VA = "0x1832D05C0")]
		public void OnInterrupted()
		{
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D11")]
		[Address(RVA = "0x32D0620", Offset = "0x32CEC20", VA = "0x1832D0620")]
		private void ClearPlayerState()
		{
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D12")]
		[Address(RVA = "0x32D0F20", Offset = "0x32CF520", VA = "0x1832D0F20")]
		private void ApplyStats(ItemInstance itemInstance)
		{
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D13")]
		[Address(RVA = "0x32D1120", Offset = "0x32CF720", VA = "0x1832D1120")]
		private static IEnumerator FadeOutLayer(float blendTime, int targetLayer)
		{
			return null;
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x32D1180", Offset = "0x32CF780", VA = "0x1832D1180")]
		private static IEnumerator FadeInLayer(float blendTime, int targetLayer)
		{
			return null;
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00008580 File Offset: 0x00006780
		[Token(Token = "0x6001D15")]
		[Address(RVA = "0x3150D00", Offset = "0x314F300", VA = "0x183150D00")]
		private static bool IsInInventory()
		{
			return default(bool);
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00008598 File Offset: 0x00006798
		[Token(Token = "0x6001D16")]
		[Address(RVA = "0x32D11E0", Offset = "0x32CF7E0", VA = "0x1832D11E0")]
		private static bool IsDead()
		{
			return default(bool);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D17")]
		[Address(RVA = "0x32D1230", Offset = "0x32CF830", VA = "0x1832D1230")]
		private void InitializeHeldInstance(out GameObject heldInstance, out Animator heldAnimator)
		{
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D18")]
		[Address(RVA = "0x32D13D0", Offset = "0x32CF9D0", VA = "0x1832D13D0")]
		private void InitializeAnimatorConsume(int consumeAnimationValue)
		{
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D19")]
		[Address(RVA = "0x32D19C0", Offset = "0x32CFFC0", VA = "0x1832D19C0")]
		private IEnumerator WaitForIdle()
		{
			return null;
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0x32D1A50", Offset = "0x32D0050", VA = "0x1832D1A50")]
		private IEnumerator WaitForAnimationEnd()
		{
			return null;
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0x32D1AE0", Offset = "0x32D00E0", VA = "0x1832D1AE0")]
		private void Update()
		{
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1C")]
		[Address(RVA = "0x32D1D50", Offset = "0x32D0350", VA = "0x1832D1D50")]
		private void UpdateHeldAnimator()
		{
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1D")]
		[Address(RVA = "0x71EE50", Offset = "0x71D450", VA = "0x18071EE50")]
		public void TriggerDisableItem()
		{
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0x2655D00", Offset = "0x2654300", VA = "0x182655D00")]
		public PlayerConsumeItemAction()
		{
		}

		// Token: 0x04001B7D RID: 7037
		[Token(Token = "0x4001B7D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _inventoryUpperBodyBlendTime;

		// Token: 0x04001B7E RID: 7038
		[Token(Token = "0x4001B7E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _cursorState;

		// Token: 0x04001B7F RID: 7039
		[Token(Token = "0x4001B7F")]
		[FieldOffset(Offset = "0x30")]
		private bool _updateHeldAnimator;

		// Token: 0x04001B80 RID: 7040
		[Token(Token = "0x4001B80")]
		[FieldOffset(Offset = "0x38")]
		private Animator _heldAnimator;

		// Token: 0x04001B81 RID: 7041
		[Token(Token = "0x4001B81")]
		[FieldOffset(Offset = "0x40")]
		private bool _disableItemTriggered;

		// Token: 0x04001B82 RID: 7042
		[Token(Token = "0x4001B82")]
		[FieldOffset(Offset = "0x48")]
		private GameObject _heldInstance;

		// Token: 0x04001B83 RID: 7043
		[Token(Token = "0x4001B83")]
		[FieldOffset(Offset = "0x50")]
		private bool _useCurrentlyEquippedItem;

		// Token: 0x04001B84 RID: 7044
		[Token(Token = "0x4001B84")]
		[FieldOffset(Offset = "0x58")]
		private PlayerConsumeItemAction.OnConsumeComplete _onConsumeComplete;

		// Token: 0x04001B85 RID: 7045
		[Token(Token = "0x4001B85")]
		[FieldOffset(Offset = "0x60")]
		private ItemInstance _itemInstance;

		// Token: 0x04001B86 RID: 7046
		[Token(Token = "0x4001B86")]
		[FieldOffset(Offset = "0x68")]
		private bool _isConsuming;

		// Token: 0x02000466 RID: 1126
		// (Invoke) Token: 0x06001D20 RID: 7456
		[Token(Token = "0x2000466")]
		public delegate void OnConsumeComplete();
	}
}
