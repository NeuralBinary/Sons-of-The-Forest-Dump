using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay.GrabBag
{
	// Token: 0x02000847 RID: 2119
	[Token(Token = "0x2000847")]
	public class GiveItemsController : MonoBehaviour, IGrabBagInteractionReceiver
	{
		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06003C25 RID: 15397 RVA: 0x00012498 File Offset: 0x00010698
		[Token(Token = "0x170007C5")]
		public bool InteractionInProcess
		{
			[Token(Token = "0x6003C25")]
			[Address(RVA = "0x359A320", Offset = "0x3598920", VA = "0x18359A320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C26")]
		[Address(RVA = "0x359A360", Offset = "0x3598960", VA = "0x18359A360", Slot = "9")]
		public List<GrabBagCategory> GetValidGrabBagCategories()
		{
			return null;
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C27")]
		[Address(RVA = "0x359A440", Offset = "0x3598A40", VA = "0x18359A440")]
		public void BeginInteraction(ReceiveItemsInteractionTrigger receiveItemsInteractionTrigger)
		{
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C28")]
		[Address(RVA = "0x359A5A0", Offset = "0x3598BA0", VA = "0x18359A5A0")]
		private IEnumerator ActivateGrabBagOncePlayerIsIdle(ReceiveItemsInteractionTrigger receiveItemsInteractionTrigger)
		{
			return null;
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C29")]
		[Address(RVA = "0x359A6A0", Offset = "0x3598CA0", VA = "0x18359A6A0")]
		public void EndInteraction()
		{
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x000124B0 File Offset: 0x000106B0
		[Token(Token = "0x6003C2A")]
		[Address(RVA = "0x359A920", Offset = "0x3598F20", VA = "0x18359A920", Slot = "8")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x000124C8 File Offset: 0x000106C8
		[Token(Token = "0x6003C2B")]
		[Address(RVA = "0x359A9E0", Offset = "0x3598FE0", VA = "0x18359A9E0")]
		public bool TryGetVailActor(out VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C2C")]
		[Address(RVA = "0x359AB30", Offset = "0x3599130", VA = "0x18359AB30")]
		public void Update()
		{
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x000124E0 File Offset: 0x000106E0
		[Token(Token = "0x6003C2D")]
		[Address(RVA = "0x359B250", Offset = "0x3599850", VA = "0x18359B250", Slot = "7")]
		public bool TryAddItem(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x000124F8 File Offset: 0x000106F8
		[Token(Token = "0x6003C2E")]
		[Address(RVA = "0x359B750", Offset = "0x3599D50", VA = "0x18359B750")]
		private bool TryGiveNpcItemOfflineOrServer(VailActor actor, ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C2F")]
		[Address(RVA = "0x359B920", Offset = "0x3599F20", VA = "0x18359B920")]
		public void RequestItemBack(int itemId)
		{
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C30")]
		[Address(RVA = "0x359C020", Offset = "0x359A620", VA = "0x18359C020")]
		private void GiveLocalPlayerItem(int itemId, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C31")]
		[Address(RVA = "0x359C160", Offset = "0x359A760", VA = "0x18359C160", Slot = "4")]
		public void OpenInteractionReceiver(GrabBagController grabBagController)
		{
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C32")]
		[Address(RVA = "0x359C2F0", Offset = "0x359A8F0", VA = "0x18359C2F0", Slot = "5")]
		public void UpdateInteractionReceiver()
		{
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C33")]
		[Address(RVA = "0x359C310", Offset = "0x359A910", VA = "0x18359C310", Slot = "6")]
		public void CloseInteractionReceiver()
		{
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C34")]
		[Address(RVA = "0x359C330", Offset = "0x359A930", VA = "0x18359C330")]
		private void CloseIfLookingAway()
		{
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C35")]
		[Address(RVA = "0x349A710", Offset = "0x3498D10", VA = "0x18349A710")]
		public GiveItemsController()
		{
		}

		// Token: 0x040032E2 RID: 13026
		[Token(Token = "0x40032E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxInteractionDistance;

		// Token: 0x040032E3 RID: 13027
		[Token(Token = "0x40032E3")]
		[FieldOffset(Offset = "0x28")]
		private ItemInstance _grabBag;

		// Token: 0x040032E4 RID: 13028
		[Token(Token = "0x40032E4")]
		[FieldOffset(Offset = "0x30")]
		private GrabBagController _grabBagController;

		// Token: 0x040032E5 RID: 13029
		[Token(Token = "0x40032E5")]
		[FieldOffset(Offset = "0x38")]
		private ReceiveItemsInteractionTrigger _receiveItemsInteractionTrigger;

		// Token: 0x040032E6 RID: 13030
		[Token(Token = "0x40032E6")]
		[FieldOffset(Offset = "0x40")]
		public Transform Target;
	}
}
