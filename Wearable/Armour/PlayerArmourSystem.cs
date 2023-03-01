using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Save;
using Sons.Wearable.Clothing;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons.Wearable.Armour
{
	// Token: 0x020005C6 RID: 1478
	[Token(Token = "0x20005C6")]
	[AddComponentMenu("Sons/Wearable/Armour/PlayerArmourSystem")]
	public class PlayerArmourSystem : MonoBehaviour, ISaveGameSerializer<PlayerArmourSystem.PlayerArmourSaveData>
	{
		// Token: 0x060025D8 RID: 9688 RVA: 0x0000B220 File Offset: 0x00009420
		[Token(Token = "0x60025D8")]
		[Address(RVA = "0x2DA91C0", Offset = "0x2DA81C0", VA = "0x182DA91C0")]
		private bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D9")]
		[Address(RVA = "0x2DAA850", Offset = "0x2DA9850", VA = "0x182DAA850")]
		public void SwitchToThirdPerson()
		{
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DA")]
		[Address(RVA = "0x2DAA840", Offset = "0x2DA9840", VA = "0x182DAA840")]
		public void SwitchToFirstPerson()
		{
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x0000B238 File Offset: 0x00009438
		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x2DA93B0", Offset = "0x2DA83B0", VA = "0x182DA93B0")]
		public bool IsWearingGoldenArmour()
		{
			return default(bool);
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x0000B250 File Offset: 0x00009450
		[Token(Token = "0x1700051B")]
		public bool IsWearingFullTechArmour
		{
			[Token(Token = "0x60025DC")]
			[Address(RVA = "0x1E52250", Offset = "0x1E51250", VA = "0x181E52250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DD")]
		[Address(RVA = "0x2DAA720", Offset = "0x2DA9720", VA = "0x182DAA720")]
		public void Start()
		{
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DE")]
		[Address(RVA = "0x2DA93F0", Offset = "0x2DA83F0", VA = "0x182DA93F0")]
		private void OnClothingEquippedEvent(int itemId)
		{
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DF")]
		[Address(RVA = "0x2DA9590", Offset = "0x2DA8590", VA = "0x182DA9590")]
		private void OnValidate()
		{
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E0")]
		[Address(RVA = "0x2DA8F60", Offset = "0x2DA7F60", VA = "0x182DA8F60")]
		private ArmourPiece GetArmourPieceById(int itemId)
		{
			return null;
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x0000B268 File Offset: 0x00009468
		[Token(Token = "0x60025E1")]
		[Address(RVA = "0x2DA8660", Offset = "0x2DA7660", VA = "0x182DA8660")]
		public bool EquipToNextAvailableSlot(ArmourPiece armourPiece)
		{
			return default(bool);
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x0000B280 File Offset: 0x00009480
		[Token(Token = "0x60025E2")]
		[Address(RVA = "0x2DA8DE0", Offset = "0x2DA7DE0", VA = "0x182DA8DE0")]
		public bool EquipToSlot(int itemId, WearableSlots slot)
		{
			return default(bool);
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x0000B298 File Offset: 0x00009498
		[Token(Token = "0x60025E3")]
		[Address(RVA = "0x2DA8720", Offset = "0x2DA7720", VA = "0x182DA8720")]
		private bool EquipToSlot(ArmourPiece armourPiece, WearableSlots slot)
		{
			return default(bool);
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[Token(Token = "0x60025E4")]
		[Address(RVA = "0x2DAA8E0", Offset = "0x2DA98E0", VA = "0x182DAA8E0")]
		public bool TryUnequipSlot(WearableSlots slot, bool destroyArmourPiece = false)
		{
			return default(bool);
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x0000B2C8 File Offset: 0x000094C8
		[Token(Token = "0x60025E5")]
		[Address(RVA = "0x2DA7F60", Offset = "0x2DA6F60", VA = "0x182DA7F60")]
		public float CalculateRemainingDamageAfterArmourHit(float initialDamage, bool isDemonic)
		{
			return default(float);
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E6")]
		[Address(RVA = "0x2DA9090", Offset = "0x2DA8090", VA = "0x182DA9090")]
		private PlayerArmourSystem.ArmourSlotData GetTopmostArmourSlotData()
		{
			return null;
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x0000B2E0 File Offset: 0x000094E0
		[Token(Token = "0x60025E7")]
		[Address(RVA = "0x2DA9260", Offset = "0x2DA8260", VA = "0x182DA9260")]
		public bool IsWearingAnyArmour()
		{
			return default(bool);
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x0000B2F8 File Offset: 0x000094F8
		[Token(Token = "0x60025E8")]
		[Address(RVA = "0x2DAA860", Offset = "0x2DA9860", VA = "0x182DAA860")]
		public bool TryGetArmourSlotData(WearableSlots slot, out PlayerArmourSystem.ArmourSlotData armourSlotData)
		{
			return default(bool);
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E9")]
		[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
		public List<WearableSlots> GetSlotOrder()
		{
			return null;
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EA")]
		[Address(RVA = "0x2DA9030", Offset = "0x2DA8030", VA = "0x182DA9030")]
		public PlayerArmourSystem.ArmourSlotData GetArmourSlotData(WearableSlots slot)
		{
			return null;
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EB")]
		[Address(RVA = "0x2DA9D80", Offset = "0x2DA8D80", VA = "0x182DA9D80")]
		public void RemapSkinnedMeshes(Transform animationRoot, Transform armourInstance)
		{
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EC")]
		[Address(RVA = "0x2DAA040", Offset = "0x2DA9040", VA = "0x182DAA040")]
		private void SetShadowCastingMode(ShadowCastingMode mode)
		{
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025ED")]
		[Address(RVA = "0x2DA8340", Offset = "0x2DA7340", VA = "0x182DA8340")]
		public void CheckForTechArmour()
		{
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EE")]
		[Address(RVA = "0x2DA9970", Offset = "0x2DA8970", VA = "0x182DA9970")]
		public void RefreshBlendShapes()
		{
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EF")]
		[Address(RVA = "0x2DA7EF0", Offset = "0x2DA6EF0", VA = "0x182DA7EF0")]
		private void Awake()
		{
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F0")]
		[Address(RVA = "0x2DA9520", Offset = "0x2DA8520", VA = "0x182DA9520")]
		private void OnDestroy()
		{
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051C")]
		public string SerializedName
		{
			[Token(Token = "0x60025F1")]
			[Address(RVA = "0x2DAAD40", Offset = "0x2DA9D40", VA = "0x182DAAD40", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x0000B310 File Offset: 0x00009510
		[Token(Token = "0x1700051D")]
		private bool UniqueFile
		{
			[Token(Token = "0x60025F2")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x0000B328 File Offset: 0x00009528
		[Token(Token = "0x1700051E")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x60025F3")]
			[Address(RVA = "0x58ECD0", Offset = "0x58DCD0", VA = "0x18058ECD0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x0000B340 File Offset: 0x00009540
		[Token(Token = "0x1700051F")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x60025F4")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F5")]
		[Address(RVA = "0x2DAA470", Offset = "0x2DA9470", VA = "0x182DAA470", Slot = "5")]
		private PlayerArmourSystem.PlayerArmourSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F6")]
		[Address(RVA = "0x2DAA190", Offset = "0x2DA9190", VA = "0x182DAA190", Slot = "6")]
		private void OnDeserialize(PlayerArmourSystem.PlayerArmourSaveData data)
		{
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F7")]
		[Address(RVA = "0x2DAACB0", Offset = "0x2DA9CB0", VA = "0x182DAACB0")]
		public PlayerArmourSystem()
		{
		}

		// Token: 0x04002230 RID: 8752
		[Token(Token = "0x4002230")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<WearableSlots> _armourSlotOrder;

		// Token: 0x04002231 RID: 8753
		[Token(Token = "0x4002231")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _nextAvailableArmourSlotIndex;

		// Token: 0x04002232 RID: 8754
		[Token(Token = "0x4002232")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<PlayerArmourSystem.ArmourSlotData> _armourSlotData;

		// Token: 0x04002233 RID: 8755
		[Token(Token = "0x4002233")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _animationRoot;

		// Token: 0x04002234 RID: 8756
		[Token(Token = "0x4002234")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<ArmourPiece> _armourPieces;

		// Token: 0x04002235 RID: 8757
		[Token(Token = "0x4002235")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _goldenArmourDemonicDamageMultiplier;

		// Token: 0x04002236 RID: 8758
		[Token(Token = "0x4002236")]
		[FieldOffset(Offset = "0x50")]
		public Action<ArmourPiece, WearableSlots> OnArmourEquipped;

		// Token: 0x04002237 RID: 8759
		[Token(Token = "0x4002237")]
		[FieldOffset(Offset = "0x58")]
		public Action<ArmourPiece, WearableSlots> OnArmourUnequipped;

		// Token: 0x04002238 RID: 8760
		[Token(Token = "0x4002238")]
		[FieldOffset(Offset = "0x60")]
		public Action<ArmourPiece, WearableSlots> OnArmourBroken;

		// Token: 0x04002239 RID: 8761
		[Token(Token = "0x4002239")]
		[FieldOffset(Offset = "0x68")]
		private bool _techArmourComplete;

		// Token: 0x0400223A RID: 8762
		[Token(Token = "0x400223A")]
		[FieldOffset(Offset = "0x70")]
		private PlayerClothingSystem _clothingSystem;

		// Token: 0x0400223B RID: 8763
		[Token(Token = "0x400223B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _shouldSerialize;

		// Token: 0x020005C7 RID: 1479
		[Token(Token = "0x20005C7")]
		[Serializable]
		public class ArmourSlotData
		{
			// Token: 0x060025F8 RID: 9720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025F8")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public ArmourSlotData()
			{
			}

			// Token: 0x0400223C RID: 8764
			[Token(Token = "0x400223C")]
			[FieldOffset(Offset = "0x10")]
			public WearableSlots Slot;

			// Token: 0x0400223D RID: 8765
			[Token(Token = "0x400223D")]
			[FieldOffset(Offset = "0x18")]
			public Transform ArmourInstance;

			// Token: 0x0400223E RID: 8766
			[Token(Token = "0x400223E")]
			[FieldOffset(Offset = "0x20")]
			public ArmourPiece ArmourPiece;

			// Token: 0x0400223F RID: 8767
			[Token(Token = "0x400223F")]
			[FieldOffset(Offset = "0x28")]
			public float RemainingArmourpoints;
		}

		// Token: 0x020005C8 RID: 1480
		[Token(Token = "0x20005C8")]
		[Serializable]
		internal class PlayerArmourSaveData
		{
			// Token: 0x060025F9 RID: 9721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025F9")]
			[Address(RVA = "0x2DA7E50", Offset = "0x2DA6E50", VA = "0x182DA7E50")]
			public PlayerArmourSaveData()
			{
			}

			// Token: 0x04002240 RID: 8768
			[Token(Token = "0x4002240")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x04002241 RID: 8769
			[Token(Token = "0x4002241")]
			[FieldOffset(Offset = "0x18")]
			public List<PlayerArmourSystem.PlayerArmourSaveData.ArmourPiece> ArmourPieces;

			// Token: 0x020005C9 RID: 1481
			[Token(Token = "0x20005C9")]
			[Serializable]
			public class ArmourPiece
			{
				// Token: 0x060025FA RID: 9722 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60025FA")]
				[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
				public ArmourPiece()
				{
				}

				// Token: 0x04002242 RID: 8770
				[Token(Token = "0x4002242")]
				[FieldOffset(Offset = "0x10")]
				public int ItemId;

				// Token: 0x04002243 RID: 8771
				[Token(Token = "0x4002243")]
				[FieldOffset(Offset = "0x14")]
				public WearableSlots Slot;

				// Token: 0x04002244 RID: 8772
				[Token(Token = "0x4002244")]
				[FieldOffset(Offset = "0x18")]
				public float RemainingArmourpoints;
			}
		}
	}
}
