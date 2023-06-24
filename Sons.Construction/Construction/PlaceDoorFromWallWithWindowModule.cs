using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000164 RID: 356
	[Token(Token = "0x2000164")]
	public class PlaceDoorFromWallWithWindowModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00006EB4 File Offset: 0x000050B4
		[Token(Token = "0x170002AD")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00006ECC File Offset: 0x000050CC
		[Token(Token = "0x170002AE")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x2E9D320", Offset = "0x2E9B920", VA = "0x182E9D320", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlaceDoorFromWallWithWindowModule(ModuleProfileDatabase doorProfileDb)
		{
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x2E9D330", Offset = "0x2E9B930", VA = "0x182E9D330", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x2E9D3E0", Offset = "0x2E9B9E0", VA = "0x182E9D3E0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x2E9D5B0", Offset = "0x2E9BBB0", VA = "0x182E9D5B0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00006EE4 File Offset: 0x000050E4
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x2E9DB00", Offset = "0x2E9C100", VA = "0x182E9DB00")]
		private static bool IsPlacingCompatibleElement(ModuleProfile profile, DoorStructure editingDoor)
		{
			return default(bool);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00006EFC File Offset: 0x000050FC
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x2E9DD20", Offset = "0x2E9C320", VA = "0x182E9DD20")]
		private static bool IsPlacingDoorLock(ModuleProfile profile, DoorStructure editingDoor)
		{
			return default(bool);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x2E9DF40", Offset = "0x2E9C540", VA = "0x182E9DF40")]
		private void SetupDoorFromWall(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00006F14 File Offset: 0x00005114
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x2E9E280", Offset = "0x2E9C880", VA = "0x182E9E280", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00006F2C File Offset: 0x0000512C
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x2E9E2E0", Offset = "0x2E9C8E0", VA = "0x182E9E2E0")]
		private bool TryGetPredictedSnapPointFromWall(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00006F44 File Offset: 0x00005144
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x2E9E800", Offset = "0x2E9CE00", VA = "0x182E9E800")]
		private bool TryGetPredictedSnapPointFromDoor(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x2E9EC50", Offset = "0x2E9D250", VA = "0x182E9EC50")]
		[CompilerGenerated]
		internal static void <ShowStagedPreview>g__ShowDoorPlankPreview|6_0(ref PlaceDoorFromWallWithWindowModule.<>c__DisplayClass6_0 A_0)
		{
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x2E9F6A0", Offset = "0x2E9DCA0", VA = "0x182E9F6A0")]
		[CompilerGenerated]
		internal static void <ShowStagedPreview>g__ShowDoorLockPreview|6_1(ref PlaceDoorFromWallWithWindowModule.<>c__DisplayClass6_0 A_0)
		{
		}
	}
}
