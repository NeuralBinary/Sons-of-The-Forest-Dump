using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Utils
{
	// Token: 0x020004EC RID: 1260
	[Token(Token = "0x20004EC")]
	[ExecuteInEditMode]
	public class AutoReplacePrefab : MonoBehaviour
	{
		// Token: 0x06002056 RID: 8278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002056")]
		[Address(RVA = "0x541240", Offset = "0x540240", VA = "0x180541240")]
		public void SetReplaceSource(GameObject replacementPrefab)
		{
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002057")]
		[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
		public GameObject GetReplaceSource()
		{
			return null;
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002058")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public AutoReplacePrefab()
		{
		}

		// Token: 0x04001E20 RID: 7712
		[Token(Token = "0x4001E20")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _replaceSource;
	}
}
