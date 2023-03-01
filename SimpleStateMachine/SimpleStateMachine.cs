using System;
using Il2CppDummyDll;

namespace Sons.SimpleStateMachine
{
	// Token: 0x0200051E RID: 1310
	[Token(Token = "0x200051E")]
	[Serializable]
	public class SimpleStateMachine
	{
		// Token: 0x0600221D RID: 8733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600221D")]
		[Address(RVA = "0x2D697C0", Offset = "0x2D687C0", VA = "0x182D697C0")]
		public SimpleStateMachine(SimpleState entryState)
		{
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600221E")]
		[Address(RVA = "0x2D696A0", Offset = "0x2D686A0", VA = "0x182D696A0")]
		public void Run()
		{
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600221F")]
		[Address(RVA = "0x2D693B0", Offset = "0x2D683B0", VA = "0x182D693B0")]
		private void DoTransition()
		{
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002220")]
		[Address(RVA = "0x2D695A0", Offset = "0x2D685A0", VA = "0x182D695A0")]
		private void LogTransitionExit(SimpleState currentState, SimpleState nextState)
		{
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002221")]
		[Address(RVA = "0x5BA890", Offset = "0x5B9890", VA = "0x1805BA890")]
		public void SetLogging(bool logging)
		{
		}

		// Token: 0x04001F31 RID: 7985
		[Token(Token = "0x4001F31")]
		[FieldOffset(Offset = "0x10")]
		private SimpleState _previousState;

		// Token: 0x04001F32 RID: 7986
		[Token(Token = "0x4001F32")]
		[FieldOffset(Offset = "0x18")]
		private SimpleState _currentState;

		// Token: 0x04001F33 RID: 7987
		[Token(Token = "0x4001F33")]
		[FieldOffset(Offset = "0x20")]
		private SimpleState _nextState;

		// Token: 0x04001F34 RID: 7988
		[Token(Token = "0x4001F34")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SimpleStateMachine.MachineStart MachineStartState;

		// Token: 0x04001F35 RID: 7989
		[Token(Token = "0x4001F35")]
		[FieldOffset(Offset = "0x28")]
		private bool _logging;

		// Token: 0x0200051F RID: 1311
		[Token(Token = "0x200051F")]
		[Serializable]
		public class MachineStart : SimpleState
		{
			// Token: 0x170004A7 RID: 1191
			// (get) Token: 0x06002223 RID: 8739 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004A7")]
			public override string Name
			{
				[Token(Token = "0x6002223")]
				[Address(RVA = "0x2D5F180", Offset = "0x2D5E180", VA = "0x182D5F180", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002224 RID: 8740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002224")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public MachineStart()
			{
			}
		}
	}
}
