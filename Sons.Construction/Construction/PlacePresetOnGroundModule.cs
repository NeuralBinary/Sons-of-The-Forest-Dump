using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000201 RID: 513
	[Token(Token = "0x2000201")]
	[Serializable]
	public class PlacePresetOnGroundModule : PlaceOnGroundModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x000095E4 File Offset: 0x000077E4
		[Token(Token = "0x17000394")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000F64")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x000095FC File Offset: 0x000077FC
		[Token(Token = "0x17000395")]
		public override bool AllowInCaves
		{
			[Token(Token = "0x6000F65")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x00009614 File Offset: 0x00007814
		[Token(Token = "0x17000396")]
		protected override bool AllowPlacingOnBuiltGround
		{
			[Token(Token = "0x6000F66")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F67")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlacePresetOnGroundModule(ModuleProfileDatabase db)
		{
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F68")]
		[Address(RVA = "0x2EFD590", Offset = "0x2EFBB90", VA = "0x182EFD590", Slot = "83")]
		protected override void GetOverlapCheckSize(ModuleState state, TargetInfo targetInfo, out Vector3 structureProximitySize, out Vector3 sceneryOverlapSize, out Vector3 offset, out Quaternion rot)
		{
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0000962C File Offset: 0x0000782C
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x2EB25B0", Offset = "0x2EB0BB0", VA = "0x182EB25B0", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x2EFD7E0", Offset = "0x2EFBDE0", VA = "0x182EFD7E0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x2EFD250", Offset = "0x2EFB850", VA = "0x182EFD250")]
		private void CreatePresetStructure(TargetInfo targetInfo, ModuleProfile profile)
		{
		}
	}
}
