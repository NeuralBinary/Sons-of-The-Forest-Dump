using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.MethodStateMachineSystem
{
	// Token: 0x02000580 RID: 1408
	[Token(Token = "0x2000580")]
	[Serializable]
	public class MethodStateMachine<T>
	{
		// Token: 0x06002525 RID: 9509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002525")]
		private void AddState(KeyValuePair<T, Func<T>> eachPair)
		{
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002526")]
		public void AddState(T stateId, Func<T> stateFunc)
		{
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002527")]
		public MethodStateMachine(T entryState, [Optional] Dictionary<T, Func<T>> states, [Optional] T defaultState)
		{
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002528")]
		public void Run()
		{
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002529")]
		private void DoTransition()
		{
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252A")]
		private void LogTransitionExit(T currentState, T nextState)
		{
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252B")]
		public void SetLogging(bool logging)
		{
		}

		// Token: 0x04002152 RID: 8530
		[Token(Token = "0x4002152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T _defaultStateValue;

		// Token: 0x04002153 RID: 8531
		[Token(Token = "0x4002153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T _previousState;

		// Token: 0x04002154 RID: 8532
		[Token(Token = "0x4002154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T _currentState;

		// Token: 0x04002155 RID: 8533
		[Token(Token = "0x4002155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T _nextState;

		// Token: 0x04002156 RID: 8534
		[Token(Token = "0x4002156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<T, Func<T>> _states;

		// Token: 0x04002157 RID: 8535
		[Token(Token = "0x4002157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _logging;
	}
}
