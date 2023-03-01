using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x02000743 RID: 1859
	[Token(Token = "0x2000743")]
	public class ConvertListToHoudiniData : MonoBehaviour
	{
		// Token: 0x0600305E RID: 12382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600305E")]
		[Address(RVA = "0x2E23AE0", Offset = "0x2E22AE0", VA = "0x182E23AE0")]
		public ConvertListToHoudiniData()
		{
		}

		// Token: 0x04002A61 RID: 10849
		[Token(Token = "0x4002A61")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _outputFileName;

		// Token: 0x04002A62 RID: 10850
		[Token(Token = "0x4002A62")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _gameObjects;

		// Token: 0x04002A63 RID: 10851
		[Token(Token = "0x4002A63")]
		[FieldOffset(Offset = "0x30")]
		private string _outputFileKey;

		// Token: 0x04002A64 RID: 10852
		[Token(Token = "0x4002A64")]
		[FieldOffset(Offset = "0x38")]
		private List<GameObject> _managedObjects;
	}
}
