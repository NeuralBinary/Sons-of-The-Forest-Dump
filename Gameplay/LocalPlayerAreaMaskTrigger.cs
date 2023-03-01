using System;
using Il2CppDummyDll;
using Sons.Areas;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200066B RID: 1643
	[Token(Token = "0x200066B")]
	public class LocalPlayerAreaMaskTrigger : MonoBehaviour
	{
		// Token: 0x060029FE RID: 10750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FE")]
		[Address(RVA = "0x2DD19F0", Offset = "0x2DD09F0", VA = "0x182DD19F0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FF")]
		[Address(RVA = "0x2DD1AF0", Offset = "0x2DD0AF0", VA = "0x182DD1AF0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A00")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public LocalPlayerAreaMaskTrigger()
		{
		}

		// Token: 0x04002585 RID: 9605
		[Token(Token = "0x4002585")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AreaMask _areaMask;

		// Token: 0x04002586 RID: 9606
		[Token(Token = "0x4002586")]
		[FieldOffset(Offset = "0x24")]
		private AreaMask _previousMask;
	}
}
