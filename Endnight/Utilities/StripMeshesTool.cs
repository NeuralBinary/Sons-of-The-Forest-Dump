using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	public class StripMeshesTool : MonoBehaviour
	{
		// Token: 0x0600020A RID: 522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020A")]
		[Address(RVA = "0xA8C420", Offset = "0xA8AA20", VA = "0x180A8C420")]
		public StripMeshesTool()
		{
		}

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _targetRoot;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Transform> _whiteList;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _stripMeshes;
	}
}
