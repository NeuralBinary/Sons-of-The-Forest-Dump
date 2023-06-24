using System;
using Il2CppDummyDll;
using Sons.Crafting.Structures;
using TheForest.Player.Actions;

namespace Construction.Anim
{
	// Token: 0x020002DD RID: 733
	[Token(Token = "0x20002DD")]
	public class FreeFormScrewPlacementAction : ISpecialItemPlacementAction, IPlaceActionCompletedReceiver
	{
		// Token: 0x06001668 RID: 5736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001668")]
		[Address(RVA = "0x2E0A580", Offset = "0x2E08B80", VA = "0x182E0A580")]
		public FreeFormScrewPlacementAction(ConstructionManager manager, PlayerBuildingModeAction buildModeAction, PlayerAnimationData playerAnimation)
		{
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001669")]
		[Address(RVA = "0x2E0A6A0", Offset = "0x2E08CA0", VA = "0x182E0A6A0", Slot = "5")]
		public void Cancel()
		{
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600166A")]
		[Address(RVA = "0x2E0A780", Offset = "0x2E08D80", VA = "0x182E0A780", Slot = "4")]
		public void Execute(int ingredientId, int itemCount, StructureCraftingNode structure)
		{
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600166B")]
		[Address(RVA = "0x2E0AA70", Offset = "0x2E09070", VA = "0x182E0AA70", Slot = "6")]
		private void PlaceActionCompletedNoReset()
		{
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600166C")]
		[Address(RVA = "0x2E0AAD0", Offset = "0x2E090D0", VA = "0x182E0AAD0", Slot = "7")]
		private void PlaceActionCompleted()
		{
		}

		// Token: 0x04000AFF RID: 2815
		[Token(Token = "0x4000AFF")]
		[FieldOffset(Offset = "0x10")]
		private readonly ConstructionManager _manager;

		// Token: 0x04000B00 RID: 2816
		[Token(Token = "0x4000B00")]
		[FieldOffset(Offset = "0x18")]
		private readonly PlayerBuildingModeAction _buildModeAction;

		// Token: 0x04000B01 RID: 2817
		[Token(Token = "0x4000B01")]
		[FieldOffset(Offset = "0x20")]
		private readonly PlayerAnimationData _playerAnimation;

		// Token: 0x04000B02 RID: 2818
		[Token(Token = "0x4000B02")]
		[FieldOffset(Offset = "0x28")]
		private int _ingredientId;

		// Token: 0x04000B03 RID: 2819
		[Token(Token = "0x4000B03")]
		[FieldOffset(Offset = "0x2C")]
		private int _itemCount;

		// Token: 0x04000B04 RID: 2820
		[Token(Token = "0x4000B04")]
		[FieldOffset(Offset = "0x30")]
		private StructureCraftingNode _structure;
	}
}
