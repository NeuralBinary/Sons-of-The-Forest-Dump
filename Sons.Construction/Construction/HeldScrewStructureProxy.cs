using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Crafting.Structures;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	[AddComponentMenu("Sons/Actions/HeldScrewStructureProxy")]
	public class HeldScrewStructureProxy : EntityBehaviour<IPlayerHeldScrewStructure>
	{
		// Token: 0x0600081E RID: 2078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x2E52820", Offset = "0x2E50E20", VA = "0x182E52820", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x2E52B40", Offset = "0x2E51140", VA = "0x182E52B40")]
		private void Update()
		{
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x2E52C60", Offset = "0x2E51260", VA = "0x182E52C60")]
		private void TargetPlayerChanged()
		{
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x2E53060", Offset = "0x2E51660", VA = "0x182E53060")]
		private void StructureRecipeIdChanged()
		{
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x2E53450", Offset = "0x2E51A50", VA = "0x182E53450")]
		public void BeginRelocateStructure(ScrewStructure structure)
		{
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x2E53710", Offset = "0x2E51D10", VA = "0x182E53710")]
		public void ClearRelocateStructure()
		{
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x2E53810", Offset = "0x2E51E10", VA = "0x182E53810")]
		public HeldScrewStructureProxy()
		{
		}

		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StructureRecipeDatabase _recipeDatabase;

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PlayerRelocateScrewStructureAction _localPlayerAction;

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HeldScrewStructure _heldScrewStructure;
	}
}
