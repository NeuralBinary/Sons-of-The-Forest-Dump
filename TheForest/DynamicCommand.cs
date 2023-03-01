using System;
using System.Collections;
using Il2CppDummyDll;

namespace TheForest
{
	// Token: 0x02000382 RID: 898
	[Token(Token = "0x2000382")]
	internal class DynamicCommand
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x000073B0 File Offset: 0x000055B0
		[Token(Token = "0x17000326")]
		public bool IsEnumerator
		{
			[Token(Token = "0x600177F")]
			[Address(RVA = "0x1DBF0E0", Offset = "0x1DBE0E0", VA = "0x181DBF0E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001780")]
		[Address(RVA = "0x2CB23E0", Offset = "0x2CB13E0", VA = "0x182CB23E0")]
		public DynamicCommand(object sender, Func<string, bool> commandAction)
		{
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001781")]
		[Address(RVA = "0x2CB2480", Offset = "0x2CB1480", VA = "0x182CB2480")]
		public DynamicCommand(object sender, Func<string, IEnumerator> enumeratorCommandAction)
		{
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x000073C8 File Offset: 0x000055C8
		[Token(Token = "0x17000327")]
		public bool Alive
		{
			[Token(Token = "0x6001782")]
			[Address(RVA = "0x2CB2520", Offset = "0x2CB1520", VA = "0x182CB2520")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x000073E0 File Offset: 0x000055E0
		[Token(Token = "0x6001783")]
		[Address(RVA = "0x2CB2350", Offset = "0x2CB1350", VA = "0x182CB2350")]
		public bool Execute(string arguments)
		{
			return default(bool);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001784")]
		[Address(RVA = "0x2CB22C0", Offset = "0x2CB12C0", VA = "0x182CB22C0")]
		public IEnumerator ExecuteEnumerator(string args)
		{
			return null;
		}

		// Token: 0x04001698 RID: 5784
		[Token(Token = "0x4001698")]
		[FieldOffset(Offset = "0x10")]
		private Func<string, bool> _action;

		// Token: 0x04001699 RID: 5785
		[Token(Token = "0x4001699")]
		[FieldOffset(Offset = "0x18")]
		private Func<string, IEnumerator> _enumeratorAction;

		// Token: 0x0400169A RID: 5786
		[Token(Token = "0x400169A")]
		[FieldOffset(Offset = "0x20")]
		private WeakReference<object> _object;
	}
}
