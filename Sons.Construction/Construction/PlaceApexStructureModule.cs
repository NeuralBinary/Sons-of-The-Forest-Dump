using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x0200012F RID: 303
	[Token(Token = "0x200012F")]
	[Serializable]
	public class PlaceApexStructureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0000560C File Offset: 0x0000380C
		[Token(Token = "0x17000266")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00005624 File Offset: 0x00003824
		[Token(Token = "0x17000267")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0xE59A00", Offset = "0xE58000", VA = "0x180E59A00", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x2E587A0", Offset = "0x2E56DA0", VA = "0x182E587A0")]
		public PlaceApexStructureModule(ModuleProfileDatabase apexProfileDatabase, ModuleProfileDatabase oneSidedApexProfileDatabase)
		{
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x2E587C0", Offset = "0x2E56DC0", VA = "0x182E587C0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0000563C File Offset: 0x0000383C
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x2E58E90", Offset = "0x2E57490", VA = "0x182E58E90", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x2E59110", Offset = "0x2E57710", VA = "0x182E59110", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x2E59C80", Offset = "0x2E58280", VA = "0x182E59C80")]
		private ModuleProfile CheckOneSidedApexProfileAndCuttings(TargetInfo targetInfo, ModuleProfile profile, OneSidedApexStructure osa)
		{
			return null;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x2E5A1C0", Offset = "0x2E587C0", VA = "0x182E5A1C0")]
		private void SetupApexFromStructure(TargetInfo targetInfo)
		{
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x2E5A380", Offset = "0x2E58980", VA = "0x182E5A380")]
		private void SetupOneSidedApexFromStructure(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00005654 File Offset: 0x00003854
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x2E5A6A0", Offset = "0x2E58CA0", VA = "0x182E5A6A0", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0000566C File Offset: 0x0000386C
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x2E5A710", Offset = "0x2E58D10", VA = "0x182E5A710")]
		private bool TryGetApexPredictedSnapPointFromApex(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00005684 File Offset: 0x00003884
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x2E5AC30", Offset = "0x2E59230", VA = "0x182E5AC30")]
		private bool TryGetApexPredictedSnapPointFromWall(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0000569C File Offset: 0x0000389C
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x2E5AF10", Offset = "0x2E59510", VA = "0x182E5AF10")]
		private bool TryGetApexPredictedSnapPointFromBeam(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}
	}
}
