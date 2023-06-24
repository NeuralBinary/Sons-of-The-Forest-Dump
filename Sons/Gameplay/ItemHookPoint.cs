using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay
{
	// Token: 0x02000760 RID: 1888
	[Token(Token = "0x2000760")]
	public abstract class ItemHookPoint : MonoBehaviour
	{
		// Token: 0x06003304 RID: 13060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003304")]
		[Address(RVA = "0x34AE940", Offset = "0x34ACF40", VA = "0x1834AE940")]
		public void BlockInteractions(bool block)
		{
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		[Token(Token = "0x6003305")]
		[Address(RVA = "0x34AE960", Offset = "0x34ACF60", VA = "0x1834AE960", Slot = "4")]
		public virtual bool IsAvailable()
		{
			return default(bool);
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003306")]
		[Address(RVA = "0x34AE970", Offset = "0x34ACF70", VA = "0x1834AE970", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003307")]
		[Address(RVA = "0x34AEA50", Offset = "0x34AD050", VA = "0x1834AEA50", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003308")]
		[Address(RVA = "0x22BAFD0", Offset = "0x22B95D0", VA = "0x1822BAFD0")]
		public void GrabEnter()
		{
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003309")]
		[Address(RVA = "0x22BAFD0", Offset = "0x22B95D0", VA = "0x1822BAFD0")]
		public void GrabStay()
		{
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600330A")]
		[Address(RVA = "0x34AEBD0", Offset = "0x34AD1D0", VA = "0x1834AEBD0")]
		public void GrabExit()
		{
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600330B")]
		[Address(RVA = "0x34AEBF0", Offset = "0x34AD1F0", VA = "0x1834AEBF0", Slot = "7")]
		protected virtual void SetInteractionState(bool enable)
		{
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600330C")]
		[Address(RVA = "0x34AF030", Offset = "0x34AD630", VA = "0x1834AF030", Slot = "8")]
		public virtual void AssignPickup(PickUp pickup)
		{
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x0000F510 File Offset: 0x0000D710
		[Token(Token = "0x600330D")]
		[Address(RVA = "0x34AF1A0", Offset = "0x34AD7A0", VA = "0x1834AF1A0")]
		public Vector3 GetItemAnchorWorldPosition(int itemId)
		{
			return default(Vector3);
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x0000F528 File Offset: 0x0000D728
		[Token(Token = "0x600330E")]
		[Address(RVA = "0x34AF3B0", Offset = "0x34AD9B0", VA = "0x1834AF3B0")]
		public Quaternion GetItemAnchorWorldRotation(int itemId)
		{
			return default(Quaternion);
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x0000F540 File Offset: 0x0000D740
		[Token(Token = "0x600330F")]
		[Address(RVA = "0x34AF640", Offset = "0x34ADC40", VA = "0x1834AF640")]
		private bool TryGetItemAnchorLocalOffsetData(int itemId, out ItemAnchorLocalOffsetData.ItemAnchorLocalOffsetDataElement itemAnchorLocalOffsetDataElement)
		{
			return default(bool);
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003310")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		protected virtual void OnPerformedAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003311")]
		[Address(RVA = "0x34AF660", Offset = "0x34ADC60", VA = "0x1834AF660")]
		protected void OnContentChanged(PickUp pickup)
		{
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003312")]
		[Address(RVA = "0x34AF990", Offset = "0x34ADF90", VA = "0x1834AF990", Slot = "10")]
		protected virtual void Shutdown()
		{
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003313")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected ItemHookPoint()
		{
		}

		// Token: 0x04002C07 RID: 11271
		[Token(Token = "0x4002C07")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected PickUp _attachedPickup;

		// Token: 0x04002C08 RID: 11272
		[Token(Token = "0x4002C08")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _interactionElement;

		// Token: 0x04002C09 RID: 11273
		[Token(Token = "0x4002C09")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected ItemAnchorLocalOffsetData _itemAnchorLocalOffsetData;

		// Token: 0x04002C0A RID: 11274
		[Token(Token = "0x4002C0A")]
		[FieldOffset(Offset = "0x38")]
		public Action<ItemHookPoint> HookPointCleared;

		// Token: 0x04002C0B RID: 11275
		[Token(Token = "0x4002C0B")]
		[FieldOffset(Offset = "0x40")]
		public Action<ItemHookPoint> HookPointUsed;

		// Token: 0x04002C0C RID: 11276
		[Token(Token = "0x4002C0C")]
		[FieldOffset(Offset = "0x48")]
		private bool _blockInteractions;

		// Token: 0x04002C0D RID: 11277
		[Token(Token = "0x4002C0D")]
		[FieldOffset(Offset = "0x49")]
		protected bool _inUse;
	}
}
