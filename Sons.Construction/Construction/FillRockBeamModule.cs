using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	public class FillRockBeamModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x000064C4 File Offset: 0x000046C4
		[Token(Token = "0x1700027C")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x000064DC File Offset: 0x000046DC
		[Token(Token = "0x1700027D")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x22F5170", Offset = "0x22F3770", VA = "0x1822F5170", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x2E72DE0", Offset = "0x2E713E0", VA = "0x182E72DE0")]
		public FillRockBeamModule(ModuleProfileDatabase profileDatabase, ModuleProfileDatabase fakePilarProfileDB)
		{
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x2E83830", Offset = "0x2E81E30", VA = "0x182E83830", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000064F4 File Offset: 0x000046F4
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x2E839A0", Offset = "0x2E81FA0", VA = "0x182E839A0")]
		private static Vector3 GetSnapPointFromNearestInTemplate(TargetInfo targetInfo, ModuleState state)
		{
			return default(Vector3);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0000650C File Offset: 0x0000470C
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x2E83D30", Offset = "0x2E82330", VA = "0x182E83D30", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x2E83E60", Offset = "0x2E82460", VA = "0x182E83E60", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00006524 File Offset: 0x00004724
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x2E850D0", Offset = "0x2E836D0", VA = "0x182E850D0")]
		private bool TryAddFakePilarElement(FakePilarStructure fp, Vector3 snapPos, float beamHeight)
		{
			return default(bool);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0000653C File Offset: 0x0000473C
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x2E853F0", Offset = "0x2E839F0", VA = "0x182E853F0", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00006554 File Offset: 0x00004754
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x2E85410", Offset = "0x2E83A10", VA = "0x182E85410")]
		private bool TryGetPredictedRockBeamSnapPointFromRockBeam(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x68")]
		private ModuleProfileDatabase _fakePilarProfileDB;
	}
}
