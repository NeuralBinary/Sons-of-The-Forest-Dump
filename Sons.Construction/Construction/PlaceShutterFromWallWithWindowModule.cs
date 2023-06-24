using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x0200020F RID: 527
	[Token(Token = "0x200020F")]
	public class PlaceShutterFromWallWithWindowModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x000099BC File Offset: 0x00007BBC
		[Token(Token = "0x170003AE")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000FD7")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x000099D4 File Offset: 0x00007BD4
		[Token(Token = "0x170003AF")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000FD8")]
			[Address(RVA = "0x2E9D320", Offset = "0x2E9B920", VA = "0x182E9D320", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlaceShutterFromWallWithWindowModule(ModuleProfileDatabase shutterProfileDb)
		{
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x2E9D330", Offset = "0x2E9B930", VA = "0x182E9D330", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x2F05C30", Offset = "0x2F04230", VA = "0x182F05C30", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x2F05D70", Offset = "0x2F04370", VA = "0x182F05D70", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x000099EC File Offset: 0x00007BEC
		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x2F062C0", Offset = "0x2F048C0", VA = "0x182F062C0")]
		private static bool IsPlacingCompatibleElement(ModuleProfile profile, ShutterStructure editingShutter)
		{
			return default(bool);
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FDE")]
		[Address(RVA = "0x2F064E0", Offset = "0x2F04AE0", VA = "0x182F064E0")]
		private void SetupShutterFromWall(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00009A04 File Offset: 0x00007C04
		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0x2F06820", Offset = "0x2F04E20", VA = "0x182F06820", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x00009A1C File Offset: 0x00007C1C
		[Token(Token = "0x6000FE0")]
		[Address(RVA = "0x2F06880", Offset = "0x2F04E80", VA = "0x182F06880")]
		private bool TryGetPredictedSnapPointFromWall(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00009A34 File Offset: 0x00007C34
		[Token(Token = "0x6000FE1")]
		[Address(RVA = "0x2F06DF0", Offset = "0x2F053F0", VA = "0x182F06DF0")]
		private bool TryGetPredictedSnapPointFromShutter(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FE2")]
		[Address(RVA = "0x2F07240", Offset = "0x2F05840", VA = "0x182F07240")]
		[CompilerGenerated]
		internal static void <ShowStagedPreview>g__ShowShutterPlankPreview|6_0(ref PlaceShutterFromWallWithWindowModule.<>c__DisplayClass6_0 A_0)
		{
		}
	}
}
