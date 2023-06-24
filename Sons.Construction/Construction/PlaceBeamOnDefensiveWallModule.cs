using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200013B RID: 315
	[Token(Token = "0x200013B")]
	[Serializable]
	public class PlaceBeamOnDefensiveWallModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x0000608C File Offset: 0x0000428C
		[Token(Token = "0x17000270")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x000060A4 File Offset: 0x000042A4
		[Token(Token = "0x17000271")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x22F5170", Offset = "0x22F3770", VA = "0x1822F5170", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x2E72DE0", Offset = "0x2E713E0", VA = "0x182E72DE0")]
		public PlaceBeamOnDefensiveWallModule(ModuleProfileDatabase beamDb, ModuleProfileDatabase fakePilarDb)
		{
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000060BC File Offset: 0x000042BC
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x2E72E60", Offset = "0x2E71460", VA = "0x182E72E60", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x2E73030", Offset = "0x2E71630", VA = "0x182E73030", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000060D4 File Offset: 0x000042D4
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x2E73510", Offset = "0x2E71B10", VA = "0x182E73510")]
		private bool TryGetGateSnapPointFromDefensiveWall(TargetInfo targetInfo, out Vector3 snapPos, out Directions snapDir, out DefensiveWallStructure editingDw)
		{
			return default(bool);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x2E73790", Offset = "0x2E71D90", VA = "0x182E73790", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x2E73AA0", Offset = "0x2E720A0", VA = "0x182E73AA0")]
		private void SetupBeamFromDefensiveWall(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x2E73D30", Offset = "0x2E72330", VA = "0x182E73D30")]
		private void CreateFakePilars(TargetInfo targetInfo, StructureElement prefab)
		{
		}

		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		[FieldOffset(Offset = "0x68")]
		private ModuleProfileDatabase _fakePilarDb;
	}
}
