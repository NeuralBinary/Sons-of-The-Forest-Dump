using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.SimpleStateMachine
{
	// Token: 0x0200052A RID: 1322
	[Token(Token = "0x200052A")]
	public class SimpleStateMachineTester : MonoBehaviour
	{
		// Token: 0x06002316 RID: 8982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002316")]
		[Address(RVA = "0x3349AD0", Offset = "0x33480D0", VA = "0x183349AD0")]
		private void Awake()
		{
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002317")]
		[Address(RVA = "0x3349D20", Offset = "0x3348320", VA = "0x183349D20")]
		private void Update()
		{
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002318")]
		[Address(RVA = "0x3349F70", Offset = "0x3348570", VA = "0x183349F70")]
		public SimpleStateMachineTester()
		{
		}

		// Token: 0x04001FEC RID: 8172
		[Token(Token = "0x4001FEC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<SimpleStateMachine> _stateMachine;

		// Token: 0x04001FED RID: 8173
		[Token(Token = "0x4001FED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _logging;
	}
}
