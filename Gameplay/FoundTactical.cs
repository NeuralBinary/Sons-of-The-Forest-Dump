using System;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000656 RID: 1622
	[Token(Token = "0x2000656")]
	public class FoundTactical : MonoBehaviour
	{
		// Token: 0x0600299A RID: 10650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600299A")]
		[Address(RVA = "0x2DCCF90", Offset = "0x2DCBF90", VA = "0x182DCCF90")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600299B")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public FoundTactical()
		{
		}

		// Token: 0x04002553 RID: 9555
		[Token(Token = "0x4002553")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[EventRef]
		private string _foundSting;
	}
}
