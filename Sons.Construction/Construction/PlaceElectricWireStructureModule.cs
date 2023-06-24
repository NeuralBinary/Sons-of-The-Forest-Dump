using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	[Serializable]
	public class PlaceElectricWireStructureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00007214 File Offset: 0x00005414
		[Token(Token = "0x170002C4")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000B26")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0000722C File Offset: 0x0000542C
		[Token(Token = "0x170002C5")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0xE59A00", Offset = "0xE58000", VA = "0x180E59A00", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x2E587A0", Offset = "0x2E56DA0", VA = "0x182E587A0")]
		public PlaceElectricWireStructureModule(ModuleProfileDatabase beamWiresDB, ModuleProfileDatabase pilarWiresDB)
		{
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x2EA6FD0", Offset = "0x2EA55D0", VA = "0x182EA6FD0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00007244 File Offset: 0x00005444
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x2EA70A0", Offset = "0x2EA56A0", VA = "0x182EA70A0", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x2EA7220", Offset = "0x2EA5820", VA = "0x182EA7220", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x2EA73D0", Offset = "0x2EA59D0", VA = "0x182EA73D0")]
		private void SetupElectricWireFromStructure(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0000725C File Offset: 0x0000545C
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x2EA7600", Offset = "0x2EA5C00", VA = "0x182EA7600", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00007274 File Offset: 0x00005474
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x2EA7620", Offset = "0x2EA5C20", VA = "0x182EA7620")]
		private bool TryGetElectricWirePredictedSnapPointFromSupport(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}
	}
}
