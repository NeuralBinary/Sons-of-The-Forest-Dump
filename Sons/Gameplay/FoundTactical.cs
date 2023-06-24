using System;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000774 RID: 1908
	[Token(Token = "0x2000774")]
	public class FoundTactical : MonoBehaviour
	{
		// Token: 0x0600337B RID: 13179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600337B")]
		[Address(RVA = "0x34BAC10", Offset = "0x34B9210", VA = "0x1834BAC10")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600337C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public FoundTactical()
		{
		}

		// Token: 0x04002C9B RID: 11419
		[Token(Token = "0x4002C9B")]
		[FieldOffset(Offset = "0x20")]
		[EventRef]
		[SerializeField]
		private string _foundSting;
	}
}
