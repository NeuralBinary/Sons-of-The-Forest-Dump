using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[AddComponentMenu("Endnight/Build/DestroyGameObjectsOnBuild")]
	public class DestroyGameObjectsOnBuild : MonoBehaviour
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DestroyGameObjectsOnBuild()
		{
		}

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _targets;
	}
}
