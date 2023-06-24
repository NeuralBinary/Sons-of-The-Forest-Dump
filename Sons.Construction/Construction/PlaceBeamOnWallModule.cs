using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000140 RID: 320
	[Token(Token = "0x2000140")]
	public class PlaceBeamOnWallModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00006224 File Offset: 0x00004424
		[Token(Token = "0x17000277")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0000623C File Offset: 0x0000443C
		[Token(Token = "0x17000278")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x22F5170", Offset = "0x22F3770", VA = "0x1822F5170", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlaceBeamOnWallModule(ModuleProfileDatabase leaningBeamDb)
		{
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x2E799A0", Offset = "0x2E77FA0", VA = "0x182E799A0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00006254 File Offset: 0x00004454
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x2E799C0", Offset = "0x2E77FC0", VA = "0x182E799C0", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x2E79BD0", Offset = "0x2E781D0", VA = "0x182E79BD0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x2E79E00", Offset = "0x2E78400", VA = "0x182E79E00")]
		private void SetupBeamFromWall(TargetInfo targetInfo, bool isRockStructure)
		{
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0000626C File Offset: 0x0000446C
		[Token(Token = "0x6000969")]
		[Address(RVA = "0x2E79FE0", Offset = "0x2E785E0", VA = "0x182E79FE0", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00006284 File Offset: 0x00004484
		[Token(Token = "0x600096A")]
		[Address(RVA = "0x2E7A000", Offset = "0x2E78600", VA = "0x182E7A000")]
		private bool TryGetBeamPredictedSnapPointFromWall(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}
	}
}
