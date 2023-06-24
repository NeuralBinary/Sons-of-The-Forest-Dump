using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	public class DefaultPrefabPool : IPrefabPool
	{
		// Token: 0x060004E8 RID: 1256 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x8EA2A0", Offset = "0x8E88A0", VA = "0x1808EA2A0", Slot = "5")]
		private GameObject Instantiate(PrefabId prefabId, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x8EA3D0", Offset = "0x8E89D0", VA = "0x1808EA3D0", Slot = "4")]
		private GameObject LoadPrefab(PrefabId prefabId)
		{
			return null;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x8EA3E0", Offset = "0x8E89E0", VA = "0x1808EA3E0", Slot = "6")]
		private void Destroy(GameObject gameObject)
		{
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DefaultPrefabPool()
		{
		}
	}
}
