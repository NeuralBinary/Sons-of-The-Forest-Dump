using System;
using System.Collections;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x02000545 RID: 1349
	[Token(Token = "0x2000545")]
	public class ServerStarterSteam : SonsClientSteam
	{
		// Token: 0x060023B6 RID: 9142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B6")]
		[Address(RVA = "0x3353370", Offset = "0x3351970", VA = "0x183353370")]
		protected new void OnEnable()
		{
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B7")]
		[Address(RVA = "0x33534D0", Offset = "0x3351AD0", VA = "0x1833534D0")]
		private IEnumerator DoStart()
		{
			return null;
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B8")]
		[Address(RVA = "0x3353560", Offset = "0x3351B60", VA = "0x183353560", Slot = "23")]
		public override void Connected(BoltConnection connection)
		{
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B9")]
		[Address(RVA = "0x3353740", Offset = "0x3351D40", VA = "0x183353740", Slot = "13")]
		public override void BoltStartDone()
		{
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BA")]
		[Address(RVA = "0x3353AA0", Offset = "0x33520A0", VA = "0x183353AA0", Slot = "385")]
		protected override void SetupNetworkCallbacks()
		{
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BB")]
		[Address(RVA = "0x3353BD0", Offset = "0x33521D0", VA = "0x183353BD0")]
		private static void SetupServerCallbacks()
		{
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BC")]
		[Address(RVA = "0x3353D00", Offset = "0x3352300", VA = "0x183353D00", Slot = "384")]
		protected override void OnLoadingDone()
		{
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BD")]
		[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
		public void SetGui(IClientGui sourceGui)
		{
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BE")]
		[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
		public void SetSuccessCallback(Action action)
		{
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BF")]
		[Address(RVA = "0x144EB80", Offset = "0x144D180", VA = "0x18144EB80")]
		public ServerStarterSteam()
		{
		}

		// Token: 0x0400202C RID: 8236
		[Token(Token = "0x400202C")]
		[FieldOffset(Offset = "0x70")]
		private Action _success;
	}
}
