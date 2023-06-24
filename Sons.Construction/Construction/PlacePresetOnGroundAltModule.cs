using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000200 RID: 512
	[Token(Token = "0x2000200")]
	public class PlacePresetOnGroundAltModule : PlaceOnGroundModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x0000953C File Offset: 0x0000773C
		[Token(Token = "0x1700038F")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000F58")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x00009554 File Offset: 0x00007754
		[Token(Token = "0x17000390")]
		public override bool AllowInCaves
		{
			[Token(Token = "0x6000F59")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x0000956C File Offset: 0x0000776C
		[Token(Token = "0x17000391")]
		protected override bool AllowPlacingOnBuiltGround
		{
			[Token(Token = "0x6000F5A")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x00009584 File Offset: 0x00007784
		[Token(Token = "0x17000392")]
		protected override bool OnFlatGroundOnly
		{
			[Token(Token = "0x6000F5B")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x0000959C File Offset: 0x0000779C
		[Token(Token = "0x17000393")]
		protected override float FlatGroundMinDot
		{
			[Token(Token = "0x6000F5C")]
			[Address(RVA = "0x2EF98A0", Offset = "0x2EF7EA0", VA = "0x182EF98A0", Slot = "81")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x2EF98B0", Offset = "0x2EF7EB0", VA = "0x182EF98B0")]
		public PlacePresetOnGroundAltModule(ModuleProfileDatabase profileDatabase, ConstructionModule bounceTo, IPlacementModeGroup placementModeGroup)
		{
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x000095B4 File Offset: 0x000077B4
		[Token(Token = "0x6000F5E")]
		[Address(RVA = "0x2EFCF70", Offset = "0x2EFB570", VA = "0x182EFCF70", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F5F")]
		[Address(RVA = "0x2EFCF80", Offset = "0x2EFB580", VA = "0x182EFCF80", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F60")]
		[Address(RVA = "0x2EFD250", Offset = "0x2EFB850", VA = "0x182EFD250")]
		private void CreatePresetStructure(TargetInfo targetInfo, ModuleProfile profile)
		{
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F61")]
		[Address(RVA = "0x2EFA000", Offset = "0x2EF8600", VA = "0x182EFA000")]
		private static void PhysicallyGroundStructure(TargetInfo targetInfo, ModuleProfile profile, Structure presetStructure)
		{
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x000095CC File Offset: 0x000077CC
		[Token(Token = "0x6000F62")]
		[Address(RVA = "0x2EFA1C0", Offset = "0x2EF87C0", VA = "0x182EFA1C0", Slot = "73")]
		protected override Quaternion GetStructureRotation(TargetInfo targetInfo)
		{
			return default(Quaternion);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x2EFD380", Offset = "0x2EFB980", VA = "0x182EFD380", Slot = "76")]
		protected override void CalcRendererWorldOffset(TargetInfo targetInfo, StructureElement prefab, out Vector3 worldPos, out Quaternion worldRot)
		{
		}
	}
}
