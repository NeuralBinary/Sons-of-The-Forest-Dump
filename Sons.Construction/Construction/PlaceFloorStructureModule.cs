using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x0200018D RID: 397
	[Token(Token = "0x200018D")]
	[Serializable]
	public class PlaceFloorStructureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00007CF4 File Offset: 0x00005EF4
		[Token(Token = "0x170002EF")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000C1E")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00007D0C File Offset: 0x00005F0C
		[Token(Token = "0x170002F0")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000C1F")]
			[Address(RVA = "0x2EBBF20", Offset = "0x2EBA520", VA = "0x182EBBF20", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x2EBBF30", Offset = "0x2EBA530", VA = "0x182EBBF30")]
		public PlaceFloorStructureModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00007D24 File Offset: 0x00005F24
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x2EBBFB0", Offset = "0x2EBA5B0", VA = "0x182EBBFB0", Slot = "59")]
		protected override bool TryGetStageMessageOverride(ModuleState state, out UiMessages stagedUiMessages)
		{
			return default(bool);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x2EBC0D0", Offset = "0x2EBA6D0", VA = "0x182EBC0D0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00007D3C File Offset: 0x00005F3C
		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x2EBCBE0", Offset = "0x2EBB1E0", VA = "0x182EBCBE0", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x2EBD280", Offset = "0x2EBB880", VA = "0x182EBD280", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x2EBDDA0", Offset = "0x2EBC3A0", VA = "0x182EBDDA0")]
		private void SetupFloor(TargetInfo targetInfo, ModuleProfile profile)
		{
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x2EBE1A0", Offset = "0x2EBC7A0", VA = "0x182EBE1A0")]
		private void ProcessFloorLinking(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x2EBE200", Offset = "0x2EBC800", VA = "0x182EBE200")]
		private List<WallStructure> GetAboveWalls(IWallSupport wallSupport)
		{
			return null;
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x2EBE470", Offset = "0x2EBCA70", VA = "0x182EBE470")]
		private void LinkFloorToNearbyWalls(List<WallStructure> wallList, IWallSupport wallSupport)
		{
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00007D54 File Offset: 0x00005F54
		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x2EBE8A0", Offset = "0x2EBCEA0", VA = "0x182EBE8A0", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00007D6C File Offset: 0x00005F6C
		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x2EBE900", Offset = "0x2EBCF00", VA = "0x182EBE900")]
		private bool TryGetPredictedFloorSnapPointsFromSupport(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00007D84 File Offset: 0x00005F84
		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x2EBF410", Offset = "0x2EBDA10", VA = "0x182EBF410")]
		private static int CalcPreferredPlacementMode(IFloorSupport targetFloorSupport)
		{
			return 0;
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00007D9C File Offset: 0x00005F9C
		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x2EBF580", Offset = "0x2EBDB80", VA = "0x182EBF580")]
		private bool TryGetPredictedFloorSnapPointsFromFloor(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Directions[] SupportingWallDirs;

		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] FloorDirs;
	}
}
