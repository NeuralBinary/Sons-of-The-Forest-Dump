using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x0200020C RID: 524
	[Token(Token = "0x200020C")]
	public class ReinforceBreakableStructureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x000098FC File Offset: 0x00007AFC
		[Token(Token = "0x170003AB")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000FC9")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00009914 File Offset: 0x00007B14
		[Token(Token = "0x170003AC")]
		public override bool AllowInCaves
		{
			[Token(Token = "0x6000FCA")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x0000992C File Offset: 0x00007B2C
		[Token(Token = "0x170003AD")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000FCB")]
			[Address(RVA = "0xE59BC0", Offset = "0xE581C0", VA = "0x180E59BC0", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0x2F04C10", Offset = "0x2F03210", VA = "0x182F04C10")]
		public ReinforceBreakableStructureModule(ModuleProfileDatabase reinforcementDb)
		{
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FCD")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x2F04C90", Offset = "0x2F03290", VA = "0x182F04C90", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x2F05060", Offset = "0x2F03660", VA = "0x182F05060", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00009944 File Offset: 0x00007B44
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x2F05170", Offset = "0x2F03770", VA = "0x182F05170", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0000995C File Offset: 0x00007B5C
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x2F05190", Offset = "0x2F03790", VA = "0x182F05190")]
		private bool TryGetPredictedSnapPointFromFencePost(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}
	}
}
