using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.SimpleStateMachine
{
	// Token: 0x02000531 RID: 1329
	[Token(Token = "0x2000531")]
	public abstract class TestSimpleState : SimpleStateUnityObject<GameObject>
	{
		// Token: 0x0600233D RID: 9021
		[Token(Token = "0x600233D")]
		public abstract Color GetColor();

		// Token: 0x0600233E RID: 9022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233E")]
		[Address(RVA = "0x334B3F0", Offset = "0x33499F0", VA = "0x18334B3F0")]
		public TestSimpleState(GameObject gameObject)
		{
		}
	}
}
