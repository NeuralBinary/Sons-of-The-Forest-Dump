using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[AddComponentMenu("Endnight/Build/SetActiveGameObjectsOnBuild")]
	public class SetActiveGameObjectsOnBuild : MonoBehaviour
	{
		// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SetActiveGameObjectsOnBuild()
		{
		}

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<SetActiveGameObjectsOnBuild.BoolObjectPair> _targets;

		// Token: 0x02000052 RID: 82
		[Token(Token = "0x2000052")]
		[Serializable]
		public class BoolObjectPair
		{
			// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public BoolObjectPair()
			{
			}

			// Token: 0x04000126 RID: 294
			[Token(Token = "0x4000126")]
			[FieldOffset(Offset = "0x10")]
			public bool Value;

			// Token: 0x04000127 RID: 295
			[Token(Token = "0x4000127")]
			[FieldOffset(Offset = "0x18")]
			public GameObject Target;
		}
	}
}
