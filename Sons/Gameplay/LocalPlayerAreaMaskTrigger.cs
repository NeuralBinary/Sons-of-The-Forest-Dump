using System;
using Il2CppDummyDll;
using Sons.Areas;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200078A RID: 1930
	[Token(Token = "0x200078A")]
	public class LocalPlayerAreaMaskTrigger : MonoBehaviour
	{
		// Token: 0x060033FB RID: 13307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FB")]
		[Address(RVA = "0x34C2F90", Offset = "0x34C1590", VA = "0x1834C2F90")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FC")]
		[Address(RVA = "0x34C3180", Offset = "0x34C1780", VA = "0x1834C3180")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FD")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LocalPlayerAreaMaskTrigger()
		{
		}

		// Token: 0x04002CE2 RID: 11490
		[Token(Token = "0x4002CE2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AreaMask _areaMask;

		// Token: 0x04002CE3 RID: 11491
		[Token(Token = "0x4002CE3")]
		[FieldOffset(Offset = "0x24")]
		private AreaMask _previousMask;
	}
}
