using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Utils
{
	// Token: 0x020004E2 RID: 1250
	[Token(Token = "0x20004E2")]
	[ExecuteInEditMode]
	public class AutoReplacePrefab : MonoBehaviour
	{
		// Token: 0x060020C9 RID: 8393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C9")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetReplaceSource(GameObject replacementPrefab)
		{
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CA")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public GameObject GetReplaceSource()
		{
			return null;
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CB")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AutoReplacePrefab()
		{
		}

		// Token: 0x04001E7B RID: 7803
		[Token(Token = "0x4001E7B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _replaceSource;
	}
}
