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
	// Token: 0x02000480 RID: 1152
	[Token(Token = "0x2000480")]
	[AddComponentMenu("Sons/Actions/PlayerStructureCraftingAction")]
	public class PlayerStructureCraftingAction : MonoBehaviour
	{
		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x00008748 File Offset: 0x00006948
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000410")]
		public bool InBuildMode
		{
			[Token(Token = "0x6001DBB")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001DBC")]
			[Address(RVA = "0x5FD5D0", Offset = "0x5FBBD0", VA = "0x1805FD5D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBD")]
		[Address(RVA = "0x32E0BE0", Offset = "0x32DF1E0", VA = "0x1832E0BE0")]
		private void Start()
		{
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBE")]
		[Address(RVA = "0x32E0F50", Offset = "0x32DF550", VA = "0x1832E0F50")]
		private void Update()
		{
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DBF")]
		[Address(RVA = "0x32E1040", Offset = "0x32DF640", VA = "0x1832E1040")]
		private void OnStructureComplete()
		{
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC0")]
		[Address(RVA = "0x32E1050", Offset = "0x32DF650", VA = "0x1832E1050")]
		public void EnterBuildMode()
		{
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC1")]
		[Address(RVA = "0x32E12E0", Offset = "0x32DF8E0", VA = "0x1832E12E0")]
		public void ExitBuildMode()
		{
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC2")]
		[Address(RVA = "0x32E1520", Offset = "0x32DFB20", VA = "0x1832E1520")]
		private void OnAddIngredientToStructureAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC3")]
		[Address(RVA = "0x32E1740", Offset = "0x32DFD40", VA = "0x1832E1740")]
		private void OnCancelStructure(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC4")]
		[Address(RVA = "0x32E1840", Offset = "0x32DFE40", VA = "0x1832E1840")]
		public static void Register(PlacementIdentifier identifier, ISpecialItemPlacementAction action, int placeCount)
		{
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00008760 File Offset: 0x00006960
		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0x32E1A20", Offset = "0x32E0020", VA = "0x1832E1A20")]
		private bool TryExecuteSpecialItemPlacement(StructureCraftingNode structure, int itemHeld, int itemNeeded)
		{
			return default(bool);
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00008778 File Offset: 0x00006978
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0x32E1BF0", Offset = "0x32E01F0", VA = "0x1832E1BF0")]
		private static bool TryFindSpecialItemPlacementCount(int itemHeld, int itemNeeded, out int placeCount)
		{
			return default(bool);
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC7")]
		[Address(RVA = "0x32E1CC0", Offset = "0x32E02C0", VA = "0x1832E1CC0")]
		public static void LogConverter(int itemHeld, int itemNeeded, out int countPlaceable)
		{
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00008790 File Offset: 0x00006990
		[Token(Token = "0x6001DC8")]
		[Address(RVA = "0x32E1F80", Offset = "0x32E0580", VA = "0x1832E1F80")]
		public static bool IsALogIngredient(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC9")]
		[Address(RVA = "0x32E1FC0", Offset = "0x32E05C0", VA = "0x1832E1FC0")]
		private void InitDefaultSpecialPlacements()
		{
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DCA")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PlayerStructureCraftingAction()
		{
		}

		// Token: 0x04001C0F RID: 7183
		[Token(Token = "0x4001C0F")]
		[FieldOffset(Offset = "0x20")]
		private SonsInputMapping.StructureCraftingActions _inputMapping;

		// Token: 0x04001C10 RID: 7184
		[Token(Token = "0x4001C10")]
		[FieldOffset(Offset = "0x28")]
		private PlayerInventory _inventory;

		// Token: 0x04001C11 RID: 7185
		[Token(Token = "0x4001C11")]
		[FieldOffset(Offset = "0x30")]
		private StructureCraftingSystem _structureCraftingSystem;

		// Token: 0x04001C13 RID: 7187
		[Token(Token = "0x4001C13")]
		[FieldOffset(Offset = "0x40")]
		private ISpecialItemPlacementAction _activeAction;

		// Token: 0x04001C14 RID: 7188
		[Token(Token = "0x4001C14")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<PlacementIdentifier, PlayerStructureCraftingAction.SpecialItemPlacement> SpecialItemPlacements;

		// Token: 0x02000481 RID: 1153
		[Token(Token = "0x2000481")]
		private class SpecialItemPlacement
		{
			// Token: 0x06001DCC RID: 7628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DCC")]
			[Address(RVA = "0x753680", Offset = "0x751C80", VA = "0x180753680")]
			public SpecialItemPlacement(ISpecialItemPlacementAction action, int placeCount)
			{
			}

			// Token: 0x17000411 RID: 1041
			// (get) Token: 0x06001DCD RID: 7629 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000411")]
			public ISpecialItemPlacementAction Action
			{
				[Token(Token = "0x6001DCD")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000412 RID: 1042
			// (get) Token: 0x06001DCE RID: 7630 RVA: 0x000087A8 File Offset: 0x000069A8
			[Token(Token = "0x17000412")]
			public int PlaceCount
			{
				[Token(Token = "0x6001DCE")]
				[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}
		}
	}
}
