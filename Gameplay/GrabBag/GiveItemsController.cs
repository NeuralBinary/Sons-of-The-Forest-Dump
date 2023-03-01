using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay.GrabBag
{
	// Token: 0x020006F9 RID: 1785
	[Token(Token = "0x20006F9")]
	public class GiveItemsController : MonoBehaviour, IGrabBagInteractionReceiver
	{
		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06002E30 RID: 11824 RVA: 0x0000D200 File Offset: 0x0000B400
		[Token(Token = "0x170005C2")]
		public bool InteractionInProcess
		{
			[Token(Token = "0x6002E30")]
			[Address(RVA = "0x2E088F0", Offset = "0x2E078F0", VA = "0x182E088F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E31")]
		[Address(RVA = "0x2E07960", Offset = "0x2E06960", VA = "0x182E07960", Slot = "9")]
		public List<GrabBagCategory> GetValidGrabBagCategories()
		{
			return null;
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E32")]
		[Address(RVA = "0x2E07530", Offset = "0x2E06530", VA = "0x182E07530")]
		public void BeginInteraction(ReceiveItemsInteractionTrigger receiveItemsInteractionTrigger)
		{
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E33")]
		[Address(RVA = "0x2E074A0", Offset = "0x2E064A0", VA = "0x182E074A0")]
		private IEnumerator ActivateGrabBagOncePlayerIsIdle(ReceiveItemsInteractionTrigger receiveItemsInteractionTrigger)
		{
			return null;
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E34")]
		[Address(RVA = "0x2E077C0", Offset = "0x2E067C0", VA = "0x182E077C0")]
		public void EndInteraction()
		{
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x0000D218 File Offset: 0x0000B418
		[Token(Token = "0x6002E35")]
		[Address(RVA = "0x2E079E0", Offset = "0x2E069E0", VA = "0x182E079E0", Slot = "8")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x0000D230 File Offset: 0x0000B430
		[Token(Token = "0x6002E36")]
		[Address(RVA = "0x2E08000", Offset = "0x2E07000", VA = "0x182E08000")]
		public bool TryGetVailActor(out VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E37")]
		[Address(RVA = "0x2E08250", Offset = "0x2E07250", VA = "0x182E08250")]
		public void Update()
		{
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x0000D248 File Offset: 0x0000B448
		[Token(Token = "0x6002E38")]
		[Address(RVA = "0x2E07D00", Offset = "0x2E06D00", VA = "0x182E07D00", Slot = "7")]
		public bool TryAddItem(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E39")]
		[Address(RVA = "0x2E07B70", Offset = "0x2E06B70", VA = "0x182E07B70")]
		public void RequestItemBack(int itemId)
		{
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E3A")]
		[Address(RVA = "0x2E07A30", Offset = "0x2E06A30", VA = "0x182E07A30", Slot = "4")]
		public void OpenInteractionReceiver(GrabBagController grabBagController)
		{
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E3B")]
		[Address(RVA = "0x2E080B0", Offset = "0x2E070B0", VA = "0x182E080B0", Slot = "5")]
		public void UpdateInteractionReceiver()
		{
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E3C")]
		[Address(RVA = "0x2E077A0", Offset = "0x2E067A0", VA = "0x182E077A0", Slot = "6")]
		public void CloseInteractionReceiver()
		{
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E3D")]
		[Address(RVA = "0x2E07610", Offset = "0x2E06610", VA = "0x182E07610")]
		private void CloseIfLookingAway()
		{
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E3E")]
		[Address(RVA = "0x2DAC330", Offset = "0x2DAB330", VA = "0x182DAC330")]
		public GiveItemsController()
		{
		}

		// Token: 0x040028FD RID: 10493
		[Token(Token = "0x40028FD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxInteractionDistance;

		// Token: 0x040028FE RID: 10494
		[Token(Token = "0x40028FE")]
		[FieldOffset(Offset = "0x28")]
		private ItemInstance _grabBag;

		// Token: 0x040028FF RID: 10495
		[Token(Token = "0x40028FF")]
		[FieldOffset(Offset = "0x30")]
		private GrabBagController _grabBagController;

		// Token: 0x04002900 RID: 10496
		[Token(Token = "0x4002900")]
		[FieldOffset(Offset = "0x38")]
		private ReceiveItemsInteractionTrigger _receiveItemsInteractionTrigger;

		// Token: 0x04002901 RID: 10497
		[Token(Token = "0x4002901")]
		[FieldOffset(Offset = "0x40")]
		public Transform Target;
	}
}
