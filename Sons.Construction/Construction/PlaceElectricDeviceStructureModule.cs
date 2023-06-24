using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	[Serializable]
	public class PlaceElectricDeviceStructureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x000070DC File Offset: 0x000052DC
		[Token(Token = "0x170002BC")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x000070F4 File Offset: 0x000052F4
		[Token(Token = "0x170002BD")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0xE59A00", Offset = "0xE58000", VA = "0x180E59A00", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlaceElectricDeviceStructureModule(ModuleProfileDatabase mainDb)
		{
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x2EA4D40", Offset = "0x2EA3340", VA = "0x182EA4D40", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0000710C File Offset: 0x0000530C
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x2EA4E50", Offset = "0x2EA3450", VA = "0x182EA4E50", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x2EA4FD0", Offset = "0x2EA35D0", VA = "0x182EA4FD0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x2EA5180", Offset = "0x2EA3780", VA = "0x182EA5180")]
		private void SetupElectricDeviceFromStructure(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00007124 File Offset: 0x00005324
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x2EA53B0", Offset = "0x2EA39B0", VA = "0x182EA53B0", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0000713C File Offset: 0x0000533C
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x2EA53D0", Offset = "0x2EA39D0", VA = "0x182EA53D0")]
		private bool TryGetElectricDevicePredictedSnapPointFromSupport(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}
	}
}
