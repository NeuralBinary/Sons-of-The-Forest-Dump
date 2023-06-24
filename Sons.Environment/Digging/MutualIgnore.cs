using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public class MutualIgnore : MonoBehaviour
	{
		// Token: 0x0600015A RID: 346 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2FAF6A0", Offset = "0x2FADCA0", VA = "0x182FAF6A0")]
		private void Awake()
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2FAFA30", Offset = "0x2FAE030", VA = "0x182FAFA30")]
		private static void IgnoreColliders(Collider[] objAColliders, Collider[] objBColliders)
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MutualIgnore()
		{
		}

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _targets;
	}
}
