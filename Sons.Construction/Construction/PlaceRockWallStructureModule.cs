using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000252 RID: 594
	[Token(Token = "0x2000252")]
	[Serializable]
	public class PlaceRockWallStructureModule : PlaceWallStructureModule
	{
		// Token: 0x06001201 RID: 4609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001201")]
		[Address(RVA = "0x2F31230", Offset = "0x2F2F830", VA = "0x182F31230")]
		public PlaceRockWallStructureModule(ModuleProfileDatabase profileDatabase, ModuleProfileDatabase groundedFakePilarDb, [Optional] IPlacementModeGroup placementModeGroup)
		{
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001202")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001203")]
		[Address(RVA = "0x2F31240", Offset = "0x2F2F840", VA = "0x182F31240", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0000ADFC File Offset: 0x00008FFC
		[Token(Token = "0x6001204")]
		[Address(RVA = "0x2F314A0", Offset = "0x2F2FAA0", VA = "0x182F314A0")]
		private static Vector3 GetSnapPointFromNearestInTemplate(TargetInfo targetInfo, StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001205")]
		[Address(RVA = "0x2F319C0", Offset = "0x2F2FFC0", VA = "0x182F319C0", Slot = "80")]
		protected override void AddElement(TargetInfo targetInfo, ModuleProfile profile, WallStructure editingWallStructure)
		{
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001206")]
		[Address(RVA = "0x2F31AB0", Offset = "0x2F300B0", VA = "0x182F31AB0", Slot = "81")]
		protected override void SetupWallOnSupport(TargetInfo targetInfo)
		{
		}
	}
}
