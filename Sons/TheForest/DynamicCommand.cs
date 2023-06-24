using System;
using System.Collections;
using Il2CppDummyDll;

namespace TheForest
{
	// Token: 0x02000374 RID: 884
	[Token(Token = "0x2000374")]
	internal class DynamicCommand
	{
		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x00007620 File Offset: 0x00005820
		[Token(Token = "0x1700032E")]
		public bool IsEnumerator
		{
			[Token(Token = "0x60017BA")]
			[Address(RVA = "0x210C2D0", Offset = "0x210A8D0", VA = "0x18210C2D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x3274D40", Offset = "0x3273340", VA = "0x183274D40")]
		public DynamicCommand(object sender, Func<string, bool> commandAction)
		{
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x3274E80", Offset = "0x3273480", VA = "0x183274E80")]
		public DynamicCommand(object sender, Func<string, IEnumerator> enumeratorCommandAction)
		{
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x00007638 File Offset: 0x00005838
		[Token(Token = "0x1700032F")]
		public bool Alive
		{
			[Token(Token = "0x60017BD")]
			[Address(RVA = "0x3274FC0", Offset = "0x32735C0", VA = "0x183274FC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00007650 File Offset: 0x00005850
		[Token(Token = "0x60017BE")]
		[Address(RVA = "0x3275020", Offset = "0x3273620", VA = "0x183275020")]
		public bool Execute(string arguments)
		{
			return default(bool);
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BF")]
		[Address(RVA = "0x32750B0", Offset = "0x32736B0", VA = "0x1832750B0")]
		public IEnumerator ExecuteEnumerator(string args)
		{
			return null;
		}

		// Token: 0x040016B7 RID: 5815
		[Token(Token = "0x40016B7")]
		[FieldOffset(Offset = "0x10")]
		private Func<string, bool> _action;

		// Token: 0x040016B8 RID: 5816
		[Token(Token = "0x40016B8")]
		[FieldOffset(Offset = "0x18")]
		private Func<string, IEnumerator> _enumeratorAction;

		// Token: 0x040016B9 RID: 5817
		[Token(Token = "0x40016B9")]
		[FieldOffset(Offset = "0x20")]
		private WeakReference<object> _object;
	}
}
