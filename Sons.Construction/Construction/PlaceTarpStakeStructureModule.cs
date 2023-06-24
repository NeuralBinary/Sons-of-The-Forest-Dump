using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200022E RID: 558
	[Token(Token = "0x200022E")]
	[Serializable]
	public class PlaceTarpStakeStructureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0000A64C File Offset: 0x0000884C
		[Token(Token = "0x170003E8")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x60010FD")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x0000A664 File Offset: 0x00008864
		[Token(Token = "0x170003E9")]
		public override bool AllowInCaves
		{
			[Token(Token = "0x60010FE")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x0000A67C File Offset: 0x0000887C
		[Token(Token = "0x170003EA")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x60010FF")]
			[Address(RVA = "0x2F1AFB0", Offset = "0x2F195B0", VA = "0x182F1AFB0", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x0000A694 File Offset: 0x00008894
		[Token(Token = "0x170003EB")]
		private Directions SleepTriggerDir
		{
			[Token(Token = "0x6001100")]
			[Address(RVA = "0xB51A40", Offset = "0xB50040", VA = "0x180B51A40")]
			get
			{
				return Directions.LeafStructureSupport;
			}
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001101")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlaceTarpStakeStructureModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001102")]
		[Address(RVA = "0x2F1AFC0", Offset = "0x2F195C0", VA = "0x182F1AFC0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0000A6AC File Offset: 0x000088AC
		[Token(Token = "0x6001103")]
		[Address(RVA = "0x2F1B0D0", Offset = "0x2F196D0", VA = "0x182F1B0D0")]
		private static bool CheckIsInvalid(TargetInfo targetInfo)
		{
			return default(bool);
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001104")]
		[Address(RVA = "0x2F1B410", Offset = "0x2F19A10", VA = "0x182F1B410", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0000A6C4 File Offset: 0x000088C4
		[Token(Token = "0x6001105")]
		[Address(RVA = "0x2F1B6C0", Offset = "0x2F19CC0", VA = "0x182F1B6C0", Slot = "64")]
		public override bool TryActivate(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0000A6DC File Offset: 0x000088DC
		[Token(Token = "0x6001106")]
		[Address(RVA = "0x2F1B710", Offset = "0x2F19D10", VA = "0x182F1B710", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001107")]
		[Address(RVA = "0x2F1B780", Offset = "0x2F19D80", VA = "0x182F1B780", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001108")]
		[Address(RVA = "0x2F1BF50", Offset = "0x2F1A550", VA = "0x182F1BF50")]
		private void SetupTarpCornerStake(TargetInfo targetInfo)
		{
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0000A6F4 File Offset: 0x000088F4
		[Token(Token = "0x6001109")]
		[Address(RVA = "0x2F1C0D0", Offset = "0x2F1A6D0", VA = "0x182F1C0D0", Slot = "73")]
		protected override Quaternion GetStructureRotation(TargetInfo targetInfo)
		{
			return default(Quaternion);
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600110A")]
		[Address(RVA = "0x2F1C270", Offset = "0x2F1A870", VA = "0x182F1C270")]
		private void TryLookupAllStructuresForStitching(TargetInfo targetInfo)
		{
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600110B")]
		[Address(RVA = "0x2F1C900", Offset = "0x2F1AF00", VA = "0x182F1C900", Slot = "76")]
		protected override void CalcRendererWorldOffset(TargetInfo targetInfo, StructureElement prefab, out Vector3 worldPos, out Quaternion worldRot)
		{
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0000A70C File Offset: 0x0000890C
		[Token(Token = "0x600110C")]
		[Address(RVA = "0x2F1CC80", Offset = "0x2F1B280", VA = "0x182F1CC80", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0000A724 File Offset: 0x00008924
		[Token(Token = "0x600110D")]
		[Address(RVA = "0x2F1CCA0", Offset = "0x2F1B2A0", VA = "0x182F1CCA0")]
		private bool TryGetStakePredictedSnapPointFromTarp(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600110E")]
		[Address(RVA = "0x2F1D170", Offset = "0x2F1B770", VA = "0x182F1D170")]
		private static void SearchSiblingTarps(TarpStructure targetTarp, TarpStructure exceptTarp, Vector3 snapPos, TargetInfo targetInfo, ref int nextSupportNum)
		{
		}

		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly TarpDirections[] TarpStakeDirs;

		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly TarpDirections[] SiblingTarpDirs;
	}
}
