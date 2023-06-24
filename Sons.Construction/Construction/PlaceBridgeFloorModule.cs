using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	[Serializable]
	public class PlaceBridgeFloorModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x000067AC File Offset: 0x000049AC
		[Token(Token = "0x1700028A")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x000067C4 File Offset: 0x000049C4
		[Token(Token = "0x1700028B")]
		public override bool AllowsPlaceWhenDamaged
		{
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000067DC File Offset: 0x000049DC
		[Token(Token = "0x1700028C")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x2E89730", Offset = "0x2E87D30", VA = "0x182E89730")]
		public PlaceBridgeFloorModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000067F4 File Offset: 0x000049F4
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x2E897B0", Offset = "0x2E87DB0", VA = "0x182E897B0", Slot = "80")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0000680C File Offset: 0x00004A0C
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x2E899E0", Offset = "0x2E87FE0", VA = "0x182E899E0")]
		private bool TryGetBridgeRopeSnapPointFromSupport(TargetInfo targetInfo, out BridgeRopeStructure supportBridgeRope, out BridgeFloorStructure editingBridgeFloor)
		{
			return default(bool);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x2E89D10", Offset = "0x2E88310", VA = "0x182E89D10", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x2E8A590", Offset = "0x2E88B90", VA = "0x182E8A590", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x2E8ABE0", Offset = "0x2E891E0", VA = "0x182E8ABE0")]
		private void SetupBridgeFloor(TargetInfo targetInfo)
		{
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00006824 File Offset: 0x00004A24
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x2E8AE70", Offset = "0x2E89470", VA = "0x182E8AE70", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0000683C File Offset: 0x00004A3C
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x2E8B0E0", Offset = "0x2E896E0", VA = "0x182E8B0E0")]
		private bool TryGetPredictedBridgeFloorSnapPointsFromBridgeFloor(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00006854 File Offset: 0x00004A54
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x2E8B240", Offset = "0x2E89840", VA = "0x182E8B240")]
		private bool TryGetPredictedBridgeFloorSnapPointsFromSupport(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x2E8B3B0", Offset = "0x2E899B0", VA = "0x182E8B3B0")]
		private void GenerateAllSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos, BridgeFloorStructure editingBridgeFloor, BridgeRopeStructure support, Directions support1Dir)
		{
		}
	}
}
