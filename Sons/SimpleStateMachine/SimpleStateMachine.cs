using System;
using Il2CppDummyDll;

namespace Sons.SimpleStateMachine
{
	// Token: 0x02000526 RID: 1318
	[Token(Token = "0x2000526")]
	[Serializable]
	public class SimpleStateMachine
	{
		// Token: 0x0600230A RID: 8970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230A")]
		[Address(RVA = "0x3349370", Offset = "0x3347970", VA = "0x183349370")]
		public SimpleStateMachine(SimpleState entryState)
		{
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230B")]
		[Address(RVA = "0x3349480", Offset = "0x3347A80", VA = "0x183349480")]
		public void Run()
		{
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230C")]
		[Address(RVA = "0x3349590", Offset = "0x3347B90", VA = "0x183349590")]
		private void DoTransition()
		{
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230D")]
		[Address(RVA = "0x33498F0", Offset = "0x3347EF0", VA = "0x1833498F0")]
		private void LogTransitionExit(SimpleState currentState, SimpleState nextState)
		{
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230E")]
		[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
		public void SetLogging(bool logging)
		{
		}

		// Token: 0x04001FE5 RID: 8165
		[Token(Token = "0x4001FE5")]
		[FieldOffset(Offset = "0x10")]
		private SimpleState _previousState;

		// Token: 0x04001FE6 RID: 8166
		[Token(Token = "0x4001FE6")]
		[FieldOffset(Offset = "0x18")]
		private SimpleState _currentState;

		// Token: 0x04001FE7 RID: 8167
		[Token(Token = "0x4001FE7")]
		[FieldOffset(Offset = "0x20")]
		private SimpleState _nextState;

		// Token: 0x04001FE8 RID: 8168
		[Token(Token = "0x4001FE8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SimpleStateMachine.MachineStart MachineStartState;

		// Token: 0x04001FE9 RID: 8169
		[Token(Token = "0x4001FE9")]
		[FieldOffset(Offset = "0x28")]
		private bool _logging;

		// Token: 0x02000527 RID: 1319
		[Token(Token = "0x2000527")]
		[Serializable]
		public class MachineStart : SimpleState
		{
			// Token: 0x170004BB RID: 1211
			// (get) Token: 0x06002310 RID: 8976 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004BB")]
			public override string Name
			{
				[Token(Token = "0x6002310")]
				[Address(RVA = "0x3349AA0", Offset = "0x33480A0", VA = "0x183349AA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002311 RID: 8977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002311")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public MachineStart()
			{
			}
		}
	}
}
