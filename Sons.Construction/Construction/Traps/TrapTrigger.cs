using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Traps
{
	// Token: 0x020002A0 RID: 672
	[Token(Token = "0x20002A0")]
	[AddComponentMenu("Sons/Construction/Traps/TrapTrigger")]
	public class TrapTrigger : MonoBehaviour
	{
		// Token: 0x0600145A RID: 5210 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600145A")]
		[Address(RVA = "0x2DF0460", Offset = "0x2DEEA60", VA = "0x182DF0460")]
		public IEnumerator OnTriggerEnter(Collider other)
		{
			return null;
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600145B")]
		[Address(RVA = "0x2DF0560", Offset = "0x2DEEB60", VA = "0x182DF0560")]
		private void SwapToReleasedDynamic()
		{
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600145C")]
		[Address(RVA = "0x2DF0840", Offset = "0x2DEEE40", VA = "0x182DF0840")]
		public TrapTrigger()
		{
		}

		// Token: 0x040009E8 RID: 2536
		[Token(Token = "0x40009E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayerMask _hitLayerMask;

		// Token: 0x040009E9 RID: 2537
		[Token(Token = "0x40009E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StructureElement _trapReleasedPrefab;

		// Token: 0x040009EA RID: 2538
		[Token(Token = "0x40009EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StructureElement _replaceTarget;
	}
}
