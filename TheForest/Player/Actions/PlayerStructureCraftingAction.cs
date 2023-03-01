using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Crafting.Structures;
using Sons.Input;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TheForest.Player.Actions
{
	// Token: 0x0200048E RID: 1166
	[Token(Token = "0x200048E")]
	[AddComponentMenu("Sons/Actions/PlayerStructureCraftingAction")]
	public class PlayerStructureCraftingAction : MonoBehaviour
	{
		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x000084C0 File Offset: 0x000066C0
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000406")]
		public bool InBuildMode
		{
			[Token(Token = "0x6001D77")]
			[Address(RVA = "0x576470", Offset = "0x575470", VA = "0x180576470")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D78")]
			[Address(RVA = "0x5768A0", Offset = "0x5758A0", VA = "0x1805768A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D79")]
		[Address(RVA = "0x2D02700", Offset = "0x2D01700", VA = "0x182D02700")]
		private void Start()
		{
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D7A")]
		[Address(RVA = "0x2D02B70", Offset = "0x2D01B70", VA = "0x182D02B70")]
		private void Update()
		{
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0x2D02580", Offset = "0x2D01580", VA = "0x182D02580")]
		private void OnStructureComplete()
		{
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D7C")]
		[Address(RVA = "0x2D01590", Offset = "0x2D00590", VA = "0x182D01590")]
		public void EnterBuildMode()
		{
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D7D")]
		[Address(RVA = "0x2D01790", Offset = "0x2D00790", VA = "0x182D01790")]
		public void ExitBuildMode()
		{
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D7E")]
		[Address(RVA = "0x2D020D0", Offset = "0x2D010D0", VA = "0x182D020D0")]
		private void OnAddIngredientToStructureAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D7F")]
		[Address(RVA = "0x2D024E0", Offset = "0x2D014E0", VA = "0x182D024E0")]
		private void OnCancelStructure(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D80")]
		[Address(RVA = "0x2D02590", Offset = "0x2D01590", VA = "0x182D02590")]
		public static void Register(PlacementIdentifier identifier, ISpecialItemPlacementAction action, int placeCount)
		{
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x000084D8 File Offset: 0x000066D8
		[Token(Token = "0x6001D81")]
		[Address(RVA = "0x2D02900", Offset = "0x2D01900", VA = "0x182D02900")]
		private bool TryExecuteSpecialItemPlacement(StructureCraftingNode structure, int itemHeld, int itemNeeded)
		{
			return default(bool);
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x000084F0 File Offset: 0x000066F0
		[Token(Token = "0x6001D82")]
		[Address(RVA = "0x2D02A90", Offset = "0x2D01A90", VA = "0x182D02A90")]
		private static bool TryFindSpecialItemPlacementCount(int itemHeld, int itemNeeded, out int placeCount)
		{
			return default(bool);
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D83")]
		[Address(RVA = "0x2D01E10", Offset = "0x2D00E10", VA = "0x182D01E10")]
		public static void LogConverter(int itemHeld, int itemNeeded, out int countPlaceable)
		{
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00008508 File Offset: 0x00006708
		[Token(Token = "0x6001D84")]
		[Address(RVA = "0x2D01DD0", Offset = "0x2D00DD0", VA = "0x182D01DD0")]
		public static bool IsALogIngredient(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D85")]
		[Address(RVA = "0x2D01950", Offset = "0x2D00950", VA = "0x182D01950")]
		private void InitDefaultSpecialPlacements()
		{
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D86")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public PlayerStructureCraftingAction()
		{
		}

		// Token: 0x04001BE5 RID: 7141
		[Token(Token = "0x4001BE5")]
		[FieldOffset(Offset = "0x20")]
		private SonsInputMapping.StructureCraftingActions _inputMapping;

		// Token: 0x04001BE6 RID: 7142
		[Token(Token = "0x4001BE6")]
		[FieldOffset(Offset = "0x28")]
		private PlayerInventory _inventory;

		// Token: 0x04001BE7 RID: 7143
		[Token(Token = "0x4001BE7")]
		[FieldOffset(Offset = "0x30")]
		private StructureCraftingSystem _structureCraftingSystem;

		// Token: 0x04001BE9 RID: 7145
		[Token(Token = "0x4001BE9")]
		[FieldOffset(Offset = "0x40")]
		private ISpecialItemPlacementAction _activeAction;

		// Token: 0x04001BEA RID: 7146
		[Token(Token = "0x4001BEA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<PlacementIdentifier, PlayerStructureCraftingAction.SpecialItemPlacement> SpecialItemPlacements;

		// Token: 0x0200048F RID: 1167
		[Token(Token = "0x200048F")]
		private class SpecialItemPlacement
		{
			// Token: 0x06001D88 RID: 7560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001D88")]
			[Address(RVA = "0x6AD9D0", Offset = "0x6AC9D0", VA = "0x1806AD9D0")]
			public SpecialItemPlacement(ISpecialItemPlacementAction action, int placeCount)
			{
			}

			// Token: 0x17000407 RID: 1031
			// (get) Token: 0x06001D89 RID: 7561 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000407")]
			public ISpecialItemPlacementAction Action
			{
				[Token(Token = "0x6001D89")]
				[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000408 RID: 1032
			// (get) Token: 0x06001D8A RID: 7562 RVA: 0x00008520 File Offset: 0x00006720
			[Token(Token = "0x17000408")]
			public int PlaceCount
			{
				[Token(Token = "0x6001D8A")]
				[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}
		}
	}
}
