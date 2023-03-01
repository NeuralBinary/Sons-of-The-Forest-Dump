using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.SimpleStateMachine
{
	// Token: 0x02000522 RID: 1314
	[Token(Token = "0x2000522")]
	public class SimpleStateMachineTester : MonoBehaviour
	{
		// Token: 0x06002229 RID: 8745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002229")]
		[Address(RVA = "0x2D68FD0", Offset = "0x2D67FD0", VA = "0x182D68FD0")]
		private void Awake()
		{
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600222A")]
		[Address(RVA = "0x2D69180", Offset = "0x2D68180", VA = "0x182D69180")]
		private void Update()
		{
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600222B")]
		[Address(RVA = "0x2D69330", Offset = "0x2D68330", VA = "0x182D69330")]
		public SimpleStateMachineTester()
		{
		}

		// Token: 0x04001F38 RID: 7992
		[Token(Token = "0x4001F38")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<SimpleStateMachine> _stateMachine;

		// Token: 0x04001F39 RID: 7993
		[Token(Token = "0x4001F39")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _logging;
	}
}
