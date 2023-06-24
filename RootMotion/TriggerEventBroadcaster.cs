using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		// Token: 0x060000FA RID: 250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x28F4E60", Offset = "0x28F3460", VA = "0x1828F4E60")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x28F4F70", Offset = "0x28F3570", VA = "0x1828F4F70")]
		private void OnTriggerStay(Collider collider)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x28F5080", Offset = "0x28F3680", VA = "0x1828F5080")]
		private void OnTriggerExit(Collider collider)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TriggerEventBroadcaster()
		{
		}

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x20")]
		public GameObject target;
	}
}
