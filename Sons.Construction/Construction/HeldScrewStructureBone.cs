using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000128 RID: 296
	[Token(Token = "0x2000128")]
	[AddComponentMenu("Sons/Actions/HeldScrewStructureBone")]
	public class HeldScrewStructureBone : MonoBehaviour
	{
		// Token: 0x0600081D RID: 2077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public HeldScrewStructureBone()
		{
		}

		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HeldScrewStructure _heldScrewStructure;
	}
}
