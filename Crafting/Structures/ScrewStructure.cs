using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Multiplayer;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007C3 RID: 1987
	[Token(Token = "0x20007C3")]
	[AddComponentMenu("Sons/Crafting/Structures/ScrewStructure")]
	public class ScrewStructure : BoltEntityBehaviourWrapper<IScrewStructureWithStorageState>
	{
		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x0600346F RID: 13423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AB")]
		public StructureRecipe Recipe
		{
			[Token(Token = "0x600346F")]
			[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003470")]
		[Address(RVA = "0x2E67DD0", Offset = "0x2E66DD0", VA = "0x182E67DD0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003471")]
		[Address(RVA = "0x2E68370", Offset = "0x2E67370", VA = "0x182E68370", Slot = "24")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003472")]
		[Address(RVA = "0x2E68EE0", Offset = "0x2E67EE0", VA = "0x182E68EE0")]
		private void Start()
		{
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003473")]
		[Address(RVA = "0x2E68ED0", Offset = "0x2E67ED0", VA = "0x182E68ED0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003474")]
		[Address(RVA = "0x2E68EC0", Offset = "0x2E67EC0", VA = "0x182E68EC0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003475")]
		[Address(RVA = "0x541250", Offset = "0x540250", VA = "0x180541250")]
		public void SetRecipe(StructureRecipe recipe)
		{
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003476")]
		[Address(RVA = "0x2E684B0", Offset = "0x2E674B0", VA = "0x182E684B0")]
		private void HostUpdateStorageState(StructureStorage storage, int itemId, int count, int stateIndex)
		{
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003477")]
		[Address(RVA = "0x2E689F0", Offset = "0x2E679F0", VA = "0x182E689F0", Slot = "25")]
		public virtual void ModifyItemCountFromClientRequest(ItemInstance itemInstance, int count, int storageIndex, BoltConnection sender)
		{
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003478")]
		[Address(RVA = "0x2E68FD0", Offset = "0x2E67FD0", VA = "0x182E68FD0")]
		private void StorageChangedOnHost()
		{
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003479")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "26")]
		protected virtual void OnSlotAvailabilityChangedMP()
		{
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347A")]
		[Address(RVA = "0x2E69450", Offset = "0x2E68450", VA = "0x182E69450")]
		public ScrewStructure()
		{
		}

		// Token: 0x04002D50 RID: 11600
		[Token(Token = "0x4002D50")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StructureRecipe _recipe;

		// Token: 0x04002D51 RID: 11601
		[Token(Token = "0x4002D51")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected List<StructureStorage> _storageSlots;
	}
}
