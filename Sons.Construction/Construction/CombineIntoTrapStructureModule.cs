using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000208 RID: 520
	[Token(Token = "0x2000208")]
	[Serializable]
	public class CombineIntoTrapStructureModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x000097C4 File Offset: 0x000079C4
		[Token(Token = "0x170003A5")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000FAB")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FAC")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public CombineIntoTrapStructureModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x000097DC File Offset: 0x000079DC
		[Token(Token = "0x6000FAD")]
		[Address(RVA = "0x2F01940", Offset = "0x2EFFF40", VA = "0x182F01940", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FAE")]
		[Address(RVA = "0x2F01B10", Offset = "0x2F00110", VA = "0x182F01B10", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000097F4 File Offset: 0x000079F4
		[Token(Token = "0x6000FAF")]
		[Address(RVA = "0x2F01E10", Offset = "0x2F00410", VA = "0x182F01E10")]
		private bool TryGetTrapSnapPointFromBeam(TargetInfo targetInfo, out Vector3 snapPos, out Vector3 placeAxis, out BeamStructure editingBeam)
		{
			return default(bool);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FB0")]
		[Address(RVA = "0x2F022C0", Offset = "0x2F008C0", VA = "0x182F022C0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x2F024D0", Offset = "0x2F00AD0", VA = "0x182F024D0")]
		private void TransformBeamIntoTrap(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0x2F02700", Offset = "0x2F00D00", VA = "0x182F02700")]
		private void LookupGroundedPlacement(TargetInfo targetInfo, out Vector3 placePos, out Vector3 placeAxis)
		{
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0000980C File Offset: 0x00007A0C
		[Token(Token = "0x6000FB3")]
		[Address(RVA = "0x2F02C80", Offset = "0x2F01280", VA = "0x182F02C80")]
		private bool ValidateElement(Ray ray, Collider col)
		{
			return default(bool);
		}
	}
}
