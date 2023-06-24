using System;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace Construction
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	public interface IConstructionModule
	{
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600067A RID: 1658
		// (set) Token: 0x0600067B RID: 1659
		[Token(Token = "0x1700020C")]
		int ID { [Token(Token = "0x600067A")] get; [Token(Token = "0x600067B")] set; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600067C RID: 1660
		[Token(Token = "0x1700020D")]
		string Name { [Token(Token = "0x600067C")] get; }

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600067D RID: 1661
		[Token(Token = "0x1700020E")]
		UiMessages PlacePromptUiMessages { [Token(Token = "0x600067D")] get; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600067E RID: 1662
		[Token(Token = "0x1700020F")]
		bool IsPerformingAnimation { [Token(Token = "0x600067E")] get; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600067F RID: 1663
		[Token(Token = "0x17000210")]
		bool InPlacePromptState { [Token(Token = "0x600067F")] get; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000680 RID: 1664
		[Token(Token = "0x17000211")]
		bool ConsumesProfileItem { [Token(Token = "0x6000680")] get; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000681 RID: 1665
		[Token(Token = "0x17000212")]
		bool AllowInCaves { [Token(Token = "0x6000681")] get; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000682 RID: 1666
		[Token(Token = "0x17000213")]
		IConstructionModule BounceToAfterPlace { [Token(Token = "0x6000682")] get; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000683 RID: 1667
		[Token(Token = "0x17000214")]
		bool AllowsMovementWhenActivated { [Token(Token = "0x6000683")] get; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000684 RID: 1668
		[Token(Token = "0x17000215")]
		bool AllowsStagingWhileFacingEnemies { [Token(Token = "0x6000684")] get; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000685 RID: 1669
		[Token(Token = "0x17000216")]
		bool AllowsPlaceWhenDamaged { [Token(Token = "0x6000685")] get; }

		// Token: 0x06000686 RID: 1670
		[Token(Token = "0x6000686")]
		bool ValidateFilters(TargetInfo targetInfo, ModuleProfile profile);

		// Token: 0x06000687 RID: 1671
		[Token(Token = "0x6000687")]
		bool TryGetValidProfile(ItemData heldItem, int placementMode, out ModuleProfile profile);

		// Token: 0x06000688 RID: 1672
		[Token(Token = "0x6000688")]
		bool ValidateActiveProfileStageDelay(ModuleProfile profile);

		// Token: 0x06000689 RID: 1673
		[Token(Token = "0x6000689")]
		bool TogglePlacementMode(ModuleState state);

		// Token: 0x0600068A RID: 1674
		[Token(Token = "0x600068A")]
		void StagedUpdate(ModuleState state);

		// Token: 0x0600068B RID: 1675
		[Token(Token = "0x600068B")]
		void Staged(ModuleState state);

		// Token: 0x0600068C RID: 1676
		[Token(Token = "0x600068C")]
		void Unstaged(ModuleProfile profile);

		// Token: 0x0600068D RID: 1677
		[Token(Token = "0x600068D")]
		bool TryActivate(ModuleState state);

		// Token: 0x0600068E RID: 1678
		[Token(Token = "0x600068E")]
		void Reset(ModuleState state);

		// Token: 0x0600068F RID: 1679
		[Token(Token = "0x600068F")]
		void Activated(ModuleState state);

		// Token: 0x06000690 RID: 1680
		[Token(Token = "0x6000690")]
		bool TrySecondStepActivation(ModuleState state);

		// Token: 0x06000691 RID: 1681
		[Token(Token = "0x6000691")]
		bool TryBounceTo(ModuleState state);

		// Token: 0x06000692 RID: 1682
		[Token(Token = "0x6000692")]
		bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode);

		// Token: 0x06000693 RID: 1683
		[Token(Token = "0x6000693")]
		void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode);

		// Token: 0x06000694 RID: 1684
		[Token(Token = "0x6000694")]
		void SetManager(ConstructionManager constructionManager);

		// Token: 0x06000695 RID: 1685
		[Token(Token = "0x6000695")]
		void InitState(ModuleState state);

		// Token: 0x06000696 RID: 1686
		[Token(Token = "0x6000696")]
		bool TryValidateProfile(ItemData targetItem, int placementMode, TargetInfo targetInfo, ref ModuleProfile profile);

		// Token: 0x06000697 RID: 1687
		[Token(Token = "0x6000697")]
		void Shutdown();
	}
}
