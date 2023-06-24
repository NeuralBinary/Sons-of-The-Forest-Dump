using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	public interface IPrefabPool
	{
		// Token: 0x060004E5 RID: 1253
		[Token(Token = "0x60004E5")]
		GameObject LoadPrefab(PrefabId prefabId);

		// Token: 0x060004E6 RID: 1254
		[Token(Token = "0x60004E6")]
		GameObject Instantiate(PrefabId prefabId, Vector3 position, Quaternion rotation);

		// Token: 0x060004E7 RID: 1255
		[Token(Token = "0x60004E7")]
		void Destroy(GameObject gameObject);
	}
}
