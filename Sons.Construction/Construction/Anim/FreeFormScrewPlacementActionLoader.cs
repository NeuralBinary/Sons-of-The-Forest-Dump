using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002DE RID: 734
	[Token(Token = "0x20002DE")]
	[AddComponentMenu("Sons/Construction/FreeFormScrewPlacementActionLoader")]
	public class FreeFormScrewPlacementActionLoader : MonoBehaviour
	{
		// Token: 0x0600166D RID: 5741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600166D")]
		[Address(RVA = "0x2E0ACC0", Offset = "0x2E092C0", VA = "0x182E0ACC0")]
		private void Awake()
		{
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600166E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public FreeFormScrewPlacementActionLoader()
		{
		}

		// Token: 0x04000B05 RID: 2821
		[Token(Token = "0x4000B05")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ConstructionManager _manager;

		// Token: 0x04000B06 RID: 2822
		[Token(Token = "0x4000B06")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PlayerBuildingModeAction _buildingModeAction;

		// Token: 0x04000B07 RID: 2823
		[Token(Token = "0x4000B07")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PlayerAnimationData _splitLogAnim;
	}
}
