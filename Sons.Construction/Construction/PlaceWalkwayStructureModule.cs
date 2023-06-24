using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000248 RID: 584
	[Token(Token = "0x2000248")]
	[Serializable]
	public class PlaceWalkwayStructureModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x060011CD RID: 4557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x2F2A390", Offset = "0x2F28990", VA = "0x182F2A390")]
		public PlaceWalkwayStructureModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0000AC04 File Offset: 0x00008E04
		[Token(Token = "0x60011CE")]
		[Address(RVA = "0x2F2A3D0", Offset = "0x2F289D0", VA = "0x182F2A3D0", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0000AC1C File Offset: 0x00008E1C
		[Token(Token = "0x60011CF")]
		[Address(RVA = "0x2F2AA90", Offset = "0x2F29090", VA = "0x182F2AA90")]
		private bool TryGetWalkwaySnapPointFromWall(TargetInfo targetInfo, ModuleState state, out Vector3 snapPos, out Vector3 placeAxis, out WalkwayStructure editingWalkway, out WallStructure supportingWall, out Directions targetDir)
		{
			return default(bool);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0000AC34 File Offset: 0x00008E34
		[Token(Token = "0x60011D0")]
		[Address(RVA = "0x2F2B170", Offset = "0x2F29770", VA = "0x182F2B170")]
		private bool TryGetWalkwaySnapPointFromWalkway(TargetInfo targetInfo, ModuleState state, out Vector3 snapPos, out Vector3 placeAxis, out WalkwayStructure editingWalkway)
		{
			return default(bool);
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011D1")]
		[Address(RVA = "0x2F2B450", Offset = "0x2F29A50", VA = "0x182F2B450", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011D2")]
		[Address(RVA = "0x2F2B8D0", Offset = "0x2F29ED0", VA = "0x182F2B8D0")]
		private void SetupWalkwayFromWall(TargetInfo targetInfo)
		{
		}
	}
}
