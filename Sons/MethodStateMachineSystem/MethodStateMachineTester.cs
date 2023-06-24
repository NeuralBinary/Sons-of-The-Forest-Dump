using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.MethodStateMachineSystem
{
	// Token: 0x02000581 RID: 1409
	[Token(Token = "0x2000581")]
	public class MethodStateMachineTester : MonoBehaviour
	{
		// Token: 0x0600252C RID: 9516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252C")]
		[Address(RVA = "0x33986B0", Offset = "0x3396CB0", VA = "0x1833986B0")]
		private void Awake()
		{
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		[Token(Token = "0x600252D")]
		[Address(RVA = "0x3398B50", Offset = "0x3397150", VA = "0x183398B50")]
		private MethodStateMachineTester.TestStates RunTestC()
		{
			return MethodStateMachineTester.TestStates.None;
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		[Token(Token = "0x600252E")]
		[Address(RVA = "0x3398C00", Offset = "0x3397200", VA = "0x183398C00")]
		private MethodStateMachineTester.TestStates RunTestB()
		{
			return MethodStateMachineTester.TestStates.None;
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		[Token(Token = "0x600252F")]
		[Address(RVA = "0x3398CB0", Offset = "0x33972B0", VA = "0x183398CB0")]
		private MethodStateMachineTester.TestStates RunTestA()
		{
			return MethodStateMachineTester.TestStates.None;
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002530")]
		[Address(RVA = "0x3398D60", Offset = "0x3397360", VA = "0x183398D60")]
		private void Update()
		{
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002531")]
		[Address(RVA = "0x3399030", Offset = "0x3397630", VA = "0x183399030")]
		public MethodStateMachineTester()
		{
		}

		// Token: 0x04002158 RID: 8536
		[Token(Token = "0x4002158")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<MethodStateMachine<MethodStateMachineTester.TestStates>> _stateMachines;

		// Token: 0x02000582 RID: 1410
		[Token(Token = "0x2000582")]
		private enum TestStates
		{
			// Token: 0x0400215A RID: 8538
			[Token(Token = "0x400215A")]
			None,
			// Token: 0x0400215B RID: 8539
			[Token(Token = "0x400215B")]
			TestA,
			// Token: 0x0400215C RID: 8540
			[Token(Token = "0x400215C")]
			TestB,
			// Token: 0x0400215D RID: 8541
			[Token(Token = "0x400215D")]
			TestC
		}
	}
}
