using System;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000646 RID: 1606
	[Token(Token = "0x2000646")]
	public class WorldItemSaver : MonoBehaviour
	{
		// Token: 0x0600299A RID: 10650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600299A")]
		[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
		public void SetOnSerializeCallback(Action<WorldItemState> callback)
		{
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600299B")]
		[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
		public void SetOnDeserializeCallback(Action<WorldItemState> onDeserialize)
		{
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600299C RID: 10652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000575")]
		public WorldItemState ItemState
		{
			[Token(Token = "0x600299C")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600299D")]
		[Address(RVA = "0x33EE880", Offset = "0x33ECE80", VA = "0x1833EE880")]
		private void Awake()
		{
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600299E")]
		[Address(RVA = "0x33EE910", Offset = "0x33ECF10", VA = "0x1833EE910")]
		private void Rename()
		{
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299F")]
		[Address(RVA = "0x33EEA60", Offset = "0x33ED060", VA = "0x1833EEA60")]
		private string SanitizeName()
		{
			return null;
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A0")]
		[Address(RVA = "0x33EEB20", Offset = "0x33ED120", VA = "0x1833EEB20")]
		private void ForceRefreshState()
		{
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A1")]
		[Address(RVA = "0x33EEB30", Offset = "0x33ED130", VA = "0x1833EEB30")]
		private void OnValidate()
		{
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A2")]
		[Address(RVA = "0x33EF0B0", Offset = "0x33ED6B0", VA = "0x1833EF0B0")]
		public void SetSaveActive(bool saveActive)
		{
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A3")]
		[Address(RVA = "0x33EF0C0", Offset = "0x33ED6C0", VA = "0x1833EF0C0")]
		public void UpdateState(WorldItemState saveDataWorldItemState)
		{
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A4")]
		[Address(RVA = "0x33EF3B0", Offset = "0x33ED9B0", VA = "0x1833EF3B0")]
		private void RefreshState()
		{
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A5")]
		[Address(RVA = "0x33EF3E0", Offset = "0x33ED9E0", VA = "0x1833EF3E0")]
		public void DoDestroy()
		{
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A6")]
		[Address(RVA = "0x33EF530", Offset = "0x33EDB30", VA = "0x1833EF530")]
		private void OnDestroy()
		{
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A7")]
		[Address(RVA = "0x33EF590", Offset = "0x33EDB90", VA = "0x1833EF590")]
		public void OnSerialize()
		{
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A8")]
		[Address(RVA = "0x33EF7A0", Offset = "0x33EDDA0", VA = "0x1833EF7A0")]
		public WorldItemSaver()
		{
		}

		// Token: 0x04002504 RID: 9476
		[Token(Token = "0x4002504")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PickUp _pickUpComponent;

		// Token: 0x04002505 RID: 9477
		[Token(Token = "0x4002505")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _destroyTarget;

		// Token: 0x04002506 RID: 9478
		[Token(Token = "0x4002506")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _ignorePosition;

		// Token: 0x04002507 RID: 9479
		[Token(Token = "0x4002507")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _ignoreRotation;

		// Token: 0x04002508 RID: 9480
		[Token(Token = "0x4002508")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		private bool _saveActive;

		// Token: 0x04002509 RID: 9481
		[Token(Token = "0x4002509")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private WorldItemState _itemState;

		// Token: 0x0400250A RID: 9482
		[Token(Token = "0x400250A")]
		[FieldOffset(Offset = "0x40")]
		private bool _selfDestructFromState;

		// Token: 0x0400250B RID: 9483
		[Token(Token = "0x400250B")]
		[FieldOffset(Offset = "0x48")]
		private Action<WorldItemState> _onSerializeCallback;

		// Token: 0x0400250C RID: 9484
		[Token(Token = "0x400250C")]
		[FieldOffset(Offset = "0x50")]
		private Action<WorldItemState> _onDeserializeCallback;
	}
}
