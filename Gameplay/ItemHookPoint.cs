using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay
{
	// Token: 0x02000643 RID: 1603
	[Token(Token = "0x2000643")]
	public abstract class ItemHookPoint : MonoBehaviour
	{
		// Token: 0x06002925 RID: 10533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002925")]
		[Address(RVA = "0x2DBB430", Offset = "0x2DBA430", VA = "0x182DBB430")]
		public void BlockInteractions(bool block)
		{
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x0000BE38 File Offset: 0x0000A038
		[Token(Token = "0x6002926")]
		[Address(RVA = "0x2DBB790", Offset = "0x2DBA790", VA = "0x182DBB790", Slot = "4")]
		public virtual bool IsAvailable()
		{
			return default(bool);
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002927")]
		[Address(RVA = "0x2DBBCD0", Offset = "0x2DBACD0", VA = "0x182DBBCD0", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002928")]
		[Address(RVA = "0x2DBB8E0", Offset = "0x2DBA8E0", VA = "0x182DBB8E0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002929")]
		[Address(RVA = "0x2DBB770", Offset = "0x2DBA770", VA = "0x182DBB770")]
		public void GrabEnter()
		{
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292A")]
		[Address(RVA = "0x2DBB780", Offset = "0x2DBA780", VA = "0x182DBB780")]
		public void GrabExit()
		{
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292B")]
		[Address(RVA = "0x2DBB9F0", Offset = "0x2DBA9F0", VA = "0x182DBB9F0")]
		private void SetInteractionState(bool enable)
		{
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292C")]
		[Address(RVA = "0x2DBB330", Offset = "0x2DBA330", VA = "0x182DBB330", Slot = "7")]
		public virtual void AssignPickup(PickUp pickup)
		{
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x0000BE50 File Offset: 0x0000A050
		[Token(Token = "0x600292D")]
		[Address(RVA = "0x2DBB450", Offset = "0x2DBA450", VA = "0x182DBB450")]
		public Vector3 GetItemAnchorWorldPosition(int itemId)
		{
			return default(Vector3);
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x0000BE68 File Offset: 0x0000A068
		[Token(Token = "0x600292E")]
		[Address(RVA = "0x2DBB560", Offset = "0x2DBA560", VA = "0x182DBB560")]
		public Quaternion GetItemAnchorWorldRotation(int itemId)
		{
			return default(Quaternion);
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x0000BE80 File Offset: 0x0000A080
		[Token(Token = "0x600292F")]
		[Address(RVA = "0x2DBBCB0", Offset = "0x2DBACB0", VA = "0x182DBBCB0")]
		private bool TryGetItemAnchorLocalOffsetData(int itemId, out ItemAnchorLocalOffsetData.ItemAnchorLocalOffsetDataElement itemAnchorLocalOffsetDataElement)
		{
			return default(bool);
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002930")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "8")]
		protected virtual void OnPerformedAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002931")]
		[Address(RVA = "0x2DBB7A0", Offset = "0x2DBA7A0", VA = "0x182DBB7A0")]
		protected void OnContentChanged(PickUp pickup)
		{
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002932")]
		[Address(RVA = "0x2DBBC90", Offset = "0x2DBAC90", VA = "0x182DBBC90", Slot = "9")]
		protected virtual void Shutdown()
		{
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002933")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		protected ItemHookPoint()
		{
		}

		// Token: 0x040024C3 RID: 9411
		[Token(Token = "0x40024C3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected PickUp _attachedPickup;

		// Token: 0x040024C4 RID: 9412
		[Token(Token = "0x40024C4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _interactionElement;

		// Token: 0x040024C5 RID: 9413
		[Token(Token = "0x40024C5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected ItemAnchorLocalOffsetData _itemAnchorLocalOffsetData;

		// Token: 0x040024C6 RID: 9414
		[Token(Token = "0x40024C6")]
		[FieldOffset(Offset = "0x38")]
		public Action<ItemHookPoint> HookPointCleared;

		// Token: 0x040024C7 RID: 9415
		[Token(Token = "0x40024C7")]
		[FieldOffset(Offset = "0x40")]
		public Action<ItemHookPoint> HookPointUsed;

		// Token: 0x040024C8 RID: 9416
		[Token(Token = "0x40024C8")]
		[FieldOffset(Offset = "0x48")]
		private bool _blockInteractions;

		// Token: 0x040024C9 RID: 9417
		[Token(Token = "0x40024C9")]
		[FieldOffset(Offset = "0x49")]
		protected bool _inUse;
	}
}
