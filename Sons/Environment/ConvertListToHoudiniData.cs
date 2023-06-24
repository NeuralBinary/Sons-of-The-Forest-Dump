using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x0200064D RID: 1613
	[Token(Token = "0x200064D")]
	public class ConvertListToHoudiniData : MonoBehaviour
	{
		// Token: 0x060029B9 RID: 10681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B9")]
		[Address(RVA = "0x33F02A0", Offset = "0x33EE8A0", VA = "0x1833F02A0")]
		public ConvertListToHoudiniData()
		{
		}

		// Token: 0x04002527 RID: 9511
		[Token(Token = "0x4002527")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _outputFileName;

		// Token: 0x04002528 RID: 9512
		[Token(Token = "0x4002528")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _gameObjects;

		// Token: 0x04002529 RID: 9513
		[Token(Token = "0x4002529")]
		[FieldOffset(Offset = "0x30")]
		private string _outputFileKey;

		// Token: 0x0400252A RID: 9514
		[Token(Token = "0x400252A")]
		[FieldOffset(Offset = "0x38")]
		private List<GameObject> _managedObjects;
	}
}
