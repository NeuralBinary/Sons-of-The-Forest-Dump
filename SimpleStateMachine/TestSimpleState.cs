using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.SimpleStateMachine
{
	// Token: 0x02000529 RID: 1321
	[Token(Token = "0x2000529")]
	public abstract class TestSimpleState : SimpleStateUnityObject<GameObject>
	{
		// Token: 0x06002250 RID: 8784
		[Token(Token = "0x6002250")]
		public abstract Color GetColor();

		// Token: 0x06002251 RID: 8785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002251")]
		[Address(RVA = "0x2D6E6D0", Offset = "0x2D6D6D0", VA = "0x182D6E6D0")]
		public TestSimpleState(GameObject gameObject)
		{
		}
	}
}
