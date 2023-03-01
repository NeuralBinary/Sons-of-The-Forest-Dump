using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.MethodStateMachineSystem
{
	// Token: 0x02000571 RID: 1393
	[Token(Token = "0x2000571")]
	public class MethodStateMachineTester : MonoBehaviour
	{
		// Token: 0x0600242D RID: 9261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242D")]
		[Address(RVA = "0x2D85200", Offset = "0x2D84200", VA = "0x182D85200")]
		private void Awake()
		{
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x0000A608 File Offset: 0x00008808
		[Token(Token = "0x600242E")]
		[Address(RVA = "0x2D85490", Offset = "0x2D84490", VA = "0x182D85490")]
		private MethodStateMachineTester.TestStates RunTestC()
		{
			return MethodStateMachineTester.TestStates.None;
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x0000A620 File Offset: 0x00008820
		[Token(Token = "0x600242F")]
		[Address(RVA = "0x2D85450", Offset = "0x2D84450", VA = "0x182D85450")]
		private MethodStateMachineTester.TestStates RunTestB()
		{
			return MethodStateMachineTester.TestStates.None;
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x0000A638 File Offset: 0x00008838
		[Token(Token = "0x6002430")]
		[Address(RVA = "0x2D85410", Offset = "0x2D84410", VA = "0x182D85410")]
		private MethodStateMachineTester.TestStates RunTestA()
		{
			return MethodStateMachineTester.TestStates.None;
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002431")]
		[Address(RVA = "0x2D854D0", Offset = "0x2D844D0", VA = "0x182D854D0")]
		private void Update()
		{
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002432")]
		[Address(RVA = "0x2D855F0", Offset = "0x2D845F0", VA = "0x182D855F0")]
		public MethodStateMachineTester()
		{
		}

		// Token: 0x04002084 RID: 8324
		[Token(Token = "0x4002084")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<MethodStateMachine<MethodStateMachineTester.TestStates>> _stateMachines;

		// Token: 0x02000572 RID: 1394
		[Token(Token = "0x2000572")]
		private enum TestStates
		{
			// Token: 0x04002086 RID: 8326
			[Token(Token = "0x4002086")]
			None,
			// Token: 0x04002087 RID: 8327
			[Token(Token = "0x4002087")]
			TestA,
			// Token: 0x04002088 RID: 8328
			[Token(Token = "0x4002088")]
			TestB,
			// Token: 0x04002089 RID: 8329
			[Token(Token = "0x4002089")]
			TestC
		}
	}
}
