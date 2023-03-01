using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.MethodStateMachineSystem
{
	// Token: 0x02000570 RID: 1392
	[Token(Token = "0x2000570")]
	[Serializable]
	public class MethodStateMachine<T>
	{
		// Token: 0x06002426 RID: 9254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002426")]
		private void AddState(KeyValuePair<T, Func<T>> eachPair)
		{
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002427")]
		public void AddState(T stateId, Func<T> stateFunc)
		{
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002428")]
		public MethodStateMachine(T entryState, [Optional] Dictionary<T, Func<T>> states, [Optional] T defaultState)
		{
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002429")]
		public void Run()
		{
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242A")]
		private void DoTransition()
		{
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242B")]
		private void LogTransitionExit(T currentState, T nextState)
		{
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242C")]
		public void SetLogging(bool logging)
		{
		}

		// Token: 0x0400207E RID: 8318
		[Token(Token = "0x400207E")]
		[FieldOffset(Offset = "0x0")]
		private T _defaultStateValue;

		// Token: 0x0400207F RID: 8319
		[Token(Token = "0x400207F")]
		[FieldOffset(Offset = "0x0")]
		private T _previousState;

		// Token: 0x04002080 RID: 8320
		[Token(Token = "0x4002080")]
		[FieldOffset(Offset = "0x0")]
		private T _currentState;

		// Token: 0x04002081 RID: 8321
		[Token(Token = "0x4002081")]
		[FieldOffset(Offset = "0x0")]
		private T _nextState;

		// Token: 0x04002082 RID: 8322
		[Token(Token = "0x4002082")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<T, Func<T>> _states;

		// Token: 0x04002083 RID: 8323
		[Token(Token = "0x4002083")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _logging;
	}
}
