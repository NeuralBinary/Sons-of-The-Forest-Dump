using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020001DD RID: 477
	[Token(Token = "0x20001DD")]
	[Serializable]
	public class PlacePilarStructureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00008C54 File Offset: 0x00006E54
		[Token(Token = "0x1700034E")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000E1E")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x00008C6C File Offset: 0x00006E6C
		[Token(Token = "0x1700034F")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000E1F")]
			[Address(RVA = "0x230C2B0", Offset = "0x230A8B0", VA = "0x18230C2B0", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlacePilarStructureModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x2EE4EE0", Offset = "0x2EE34E0", VA = "0x182EE4EE0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00008C84 File Offset: 0x00006E84
		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x2EE5900", Offset = "0x2EE3F00", VA = "0x182EE5900", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E23")]
		[Address(RVA = "0x2EE5B30", Offset = "0x2EE4130", VA = "0x182EE5B30", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E24")]
		[Address(RVA = "0x2EE5D90", Offset = "0x2EE4390", VA = "0x182EE5D90")]
		private void SetupPilarFromSupportingBeam(TargetInfo targetInfo, bool isRockStructure)
		{
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00008C9C File Offset: 0x00006E9C
		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x2EE5FB0", Offset = "0x2EE45B0", VA = "0x182EE5FB0", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00008CB4 File Offset: 0x00006EB4
		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x2EE6010", Offset = "0x2EE4610", VA = "0x182EE6010")]
		private bool TryGetPredictedPilarSnapPointFromPilar(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00008CCC File Offset: 0x00006ECC
		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x2EE65E0", Offset = "0x2EE4BE0", VA = "0x182EE65E0")]
		private bool TryGetPredictedPilarSnapPointFromPilarSupport(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}
	}
}
