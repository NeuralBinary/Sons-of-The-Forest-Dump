using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000215 RID: 533
	[Token(Token = "0x2000215")]
	[Serializable]
	public class PlaceSingleStepStructureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00009ADC File Offset: 0x00007CDC
		[Token(Token = "0x170003B5")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000FFA")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x2F09110", Offset = "0x2F07710", VA = "0x182F09110")]
		public PlaceSingleStepStructureModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FFC")]
		[Address(RVA = "0x2F09190", Offset = "0x2F07790", VA = "0x182F09190", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00009AF4 File Offset: 0x00007CF4
		[Token(Token = "0x6000FFD")]
		[Address(RVA = "0x2F09420", Offset = "0x2F07A20", VA = "0x182F09420", Slot = "59")]
		protected override bool TryGetStageMessageOverride(ModuleState state, out UiMessages stagedUiMessages)
		{
			return default(bool);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00009B0C File Offset: 0x00007D0C
		[Token(Token = "0x6000FFE")]
		[Address(RVA = "0x2F095A0", Offset = "0x2F07BA0", VA = "0x182F095A0", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x2F09680", Offset = "0x2F07C80", VA = "0x182F09680", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001000")]
		[Address(RVA = "0x2F09800", Offset = "0x2F07E00", VA = "0x182F09800")]
		private void SetupSingleStepSupport(TargetInfo targetInfo, bool creatingStairs)
		{
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00009B24 File Offset: 0x00007D24
		[Token(Token = "0x6001001")]
		[Address(RVA = "0x2F09AE0", Offset = "0x2F080E0", VA = "0x182F09AE0", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00009B3C File Offset: 0x00007D3C
		[Token(Token = "0x6001002")]
		[Address(RVA = "0x2F09B00", Offset = "0x2F08100", VA = "0x182F09B00")]
		private bool TryGetPredictedRampSnapPointFromSupport(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4000871")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Directions[] RampDirs;
	}
}
