using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x02000473 RID: 1139
	[Token(Token = "0x2000473")]
	[AddComponentMenu("Sons/Actions/PlayerConsumeItemAction")]
	public class PlayerConsumeItemAction : MonoBehaviour
	{
		// Token: 0x06001CCD RID: 7373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x2CFADA0", Offset = "0x2CF9DA0", VA = "0x182CFADA0")]
		public void ConsumeItem(ItemInstance itemInstance, bool shouldPlayConsumeAnimation, PlayerConsumeItemAction.OnConsumeComplete onConsumeCompleteCallback)
		{
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCE")]
		[Address(RVA = "0x2CFABF0", Offset = "0x2CF9BF0", VA = "0x182CFABF0")]
		private void ConsumeComplete()
		{
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCF")]
		[Address(RVA = "0x2CFAD30", Offset = "0x2CF9D30", VA = "0x182CFAD30")]
		private IEnumerator ConsumeItemRoutine()
		{
			return null;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD0")]
		[Address(RVA = "0x2CFB430", Offset = "0x2CFA430", VA = "0x182CFB430")]
		public void OnInterrupted()
		{
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD1")]
		[Address(RVA = "0x2CFA520", Offset = "0x2CF9520", VA = "0x182CFA520")]
		private void ClearPlayerState()
		{
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD2")]
		[Address(RVA = "0x2CFA4F0", Offset = "0x2CF94F0", VA = "0x182CFA4F0")]
		private static void ApplyStats(ItemInstance itemInstance)
		{
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD3")]
		[Address(RVA = "0x2CFAF00", Offset = "0x2CF9F00", VA = "0x182CFAF00")]
		private static IEnumerator FadeOutLayer(float blendTime, int targetLayer)
		{
			return null;
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD4")]
		[Address(RVA = "0x2CFAE90", Offset = "0x2CF9E90", VA = "0x182CFAE90")]
		private static IEnumerator FadeInLayer(float blendTime, int targetLayer)
		{
			return null;
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x6001CD5")]
		[Address(RVA = "0x2CCD9E0", Offset = "0x2CCC9E0", VA = "0x182CCD9E0")]
		private static bool IsInInventory()
		{
			return default(bool);
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00008310 File Offset: 0x00006510
		[Token(Token = "0x6001CD6")]
		[Address(RVA = "0x2CFB3E0", Offset = "0x2CFA3E0", VA = "0x182CFB3E0")]
		private static bool IsDead()
		{
			return default(bool);
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD7")]
		[Address(RVA = "0x2CFB360", Offset = "0x2CFA360", VA = "0x182CFB360")]
		private void InitializeHeldInstance(out GameObject heldInstance, out Animator heldAnimator)
		{
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD8")]
		[Address(RVA = "0x2CFAF70", Offset = "0x2CF9F70", VA = "0x182CFAF70")]
		private void InitializeAnimatorConsume(int consumeAnimationValue)
		{
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD9")]
		[Address(RVA = "0x2CFB9F0", Offset = "0x2CFA9F0", VA = "0x182CFB9F0")]
		private IEnumerator WaitForIdle()
		{
			return null;
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDA")]
		[Address(RVA = "0x2CFB980", Offset = "0x2CFA980", VA = "0x182CFB980")]
		private IEnumerator WaitForAnimationEnd()
		{
			return null;
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDB")]
		[Address(RVA = "0x2CFB7B0", Offset = "0x2CFA7B0", VA = "0x182CFB7B0")]
		private void Update()
		{
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDC")]
		[Address(RVA = "0x2CFB450", Offset = "0x2CFA450", VA = "0x182CFB450")]
		private void UpdateHeldAnimator()
		{
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDD")]
		[Address(RVA = "0x683D30", Offset = "0x682D30", VA = "0x180683D30")]
		public void TriggerDisableItem()
		{
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDE")]
		[Address(RVA = "0x2227850", Offset = "0x2226850", VA = "0x182227850")]
		public PlayerConsumeItemAction()
		{
		}

		// Token: 0x04001B59 RID: 7001
		[Token(Token = "0x4001B59")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _inventoryUpperBodyBlendTime;

		// Token: 0x04001B5A RID: 7002
		[Token(Token = "0x4001B5A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _cursorState;

		// Token: 0x04001B5B RID: 7003
		[Token(Token = "0x4001B5B")]
		[FieldOffset(Offset = "0x30")]
		private bool _updateHeldAnimator;

		// Token: 0x04001B5C RID: 7004
		[Token(Token = "0x4001B5C")]
		[FieldOffset(Offset = "0x38")]
		private Animator _heldAnimator;

		// Token: 0x04001B5D RID: 7005
		[Token(Token = "0x4001B5D")]
		[FieldOffset(Offset = "0x40")]
		private bool _disableItemTriggered;

		// Token: 0x04001B5E RID: 7006
		[Token(Token = "0x4001B5E")]
		[FieldOffset(Offset = "0x48")]
		private GameObject _heldInstance;

		// Token: 0x04001B5F RID: 7007
		[Token(Token = "0x4001B5F")]
		[FieldOffset(Offset = "0x50")]
		private PlayerConsumeItemAction.OnConsumeComplete _onConsumeComplete;

		// Token: 0x04001B60 RID: 7008
		[Token(Token = "0x4001B60")]
		[FieldOffset(Offset = "0x58")]
		private ItemInstance _itemInstance;

		// Token: 0x04001B61 RID: 7009
		[Token(Token = "0x4001B61")]
		[FieldOffset(Offset = "0x60")]
		private bool _isConsuming;

		// Token: 0x02000474 RID: 1140
		// (Invoke) Token: 0x06001CE0 RID: 7392
		[Token(Token = "0x2000474")]
		public delegate void OnConsumeComplete();
	}
}
