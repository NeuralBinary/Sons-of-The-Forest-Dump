using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200021C RID: 540
	[Token(Token = "0x200021C")]
	[Serializable]
	public class PlaceRampAndStairsStructureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x00009CEC File Offset: 0x00007EEC
		[Token(Token = "0x170003C3")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x600102A")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600102B")]
		[Address(RVA = "0x2F0C590", Offset = "0x2F0AB90", VA = "0x182F0C590")]
		public PlaceRampAndStairsStructureModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600102C")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600102D")]
		[Address(RVA = "0x2F0C610", Offset = "0x2F0AC10", VA = "0x182F0C610", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00009D04 File Offset: 0x00007F04
		[Token(Token = "0x600102E")]
		[Address(RVA = "0x2F0D5D0", Offset = "0x2F0BBD0", VA = "0x182F0D5D0", Slot = "59")]
		protected override bool TryGetStageMessageOverride(ModuleState state, out UiMessages stagedUiMessages)
		{
			return default(bool);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00009D1C File Offset: 0x00007F1C
		[Token(Token = "0x600102F")]
		[Address(RVA = "0x2F0D750", Offset = "0x2F0BD50", VA = "0x182F0D750", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001030")]
		[Address(RVA = "0x2F0E3D0", Offset = "0x2F0C9D0", VA = "0x182F0E3D0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001031")]
		[Address(RVA = "0x2F0E9C0", Offset = "0x2F0CFC0", VA = "0x182F0E9C0")]
		private void SetupRamp(TargetInfo targetInfo, bool creatingStairs)
		{
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00009D34 File Offset: 0x00007F34
		[Token(Token = "0x6001032")]
		[Address(RVA = "0x2F0ECA0", Offset = "0x2F0D2A0", VA = "0x182F0ECA0", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00009D4C File Offset: 0x00007F4C
		[Token(Token = "0x6001033")]
		[Address(RVA = "0x2F0ED00", Offset = "0x2F0D300", VA = "0x182F0ED00")]
		private bool TryGetPredictedRampSnapPointFromSupport(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00009D64 File Offset: 0x00007F64
		[Token(Token = "0x6001034")]
		[Address(RVA = "0x2F0F220", Offset = "0x2F0D820", VA = "0x182F0F220")]
		private bool TryGetPredictedRampSnapPointFromRamp(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00009D7C File Offset: 0x00007F7C
		[Token(Token = "0x6001035")]
		[Address(RVA = "0x2F0F660", Offset = "0x2F0DC60", VA = "0x182F0F660")]
		private Vector3 GetCustomTargetPos(TargetInfo snapPointTargetInfo)
		{
			return default(Vector3);
		}
	}
}
