using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000177 RID: 375
	[Token(Token = "0x2000177")]
	[Serializable]
	public class PlaceSolarPanelStructureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0000728C File Offset: 0x0000548C
		[Token(Token = "0x170002C6")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000B37")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x000072A4 File Offset: 0x000054A4
		[Token(Token = "0x170002C7")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000B38")]
			[Address(RVA = "0xE59A00", Offset = "0xE58000", VA = "0x180E59A00", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlaceSolarPanelStructureModule(ModuleProfileDatabase mainDb)
		{
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x2EA7A90", Offset = "0x2EA6090", VA = "0x182EA7A90", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x000072BC File Offset: 0x000054BC
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x2EA7C70", Offset = "0x2EA6270", VA = "0x182EA7C70", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x2EA7DF0", Offset = "0x2EA63F0", VA = "0x182EA7DF0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x2EA7FA0", Offset = "0x2EA65A0", VA = "0x182EA7FA0")]
		private void SetupSolarPanelFromStructure(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x000072D4 File Offset: 0x000054D4
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x2EA81E0", Offset = "0x2EA67E0", VA = "0x182EA81E0", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x000072EC File Offset: 0x000054EC
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x2EA8200", Offset = "0x2EA6800", VA = "0x182EA8200")]
		private bool TryGetApexPredictedSnapPointFromBeam(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}
	}
}
