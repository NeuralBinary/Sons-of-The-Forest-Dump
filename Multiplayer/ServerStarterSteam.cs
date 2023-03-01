using System;
using System.Collections;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x0200053C RID: 1340
	[Token(Token = "0x200053C")]
	public class ServerStarterSteam : SonsClientSteam
	{
		// Token: 0x060022C2 RID: 8898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C2")]
		[Address(RVA = "0x2D68C80", Offset = "0x2D67C80", VA = "0x182D68C80")]
		protected void OnEnable()
		{
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C3")]
		[Address(RVA = "0x2D68C10", Offset = "0x2D67C10", VA = "0x182D68C10")]
		private IEnumerator DoStart()
		{
			return null;
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C4")]
		[Address(RVA = "0x2D68B40", Offset = "0x2D67B40", VA = "0x182D68B40", Slot = "23")]
		public override void Connected(BoltConnection connection)
		{
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C5")]
		[Address(RVA = "0x2D68A00", Offset = "0x2D67A00", VA = "0x182D68A00", Slot = "13")]
		public override void BoltStartDone()
		{
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C6")]
		[Address(RVA = "0x2D68ED0", Offset = "0x2D67ED0", VA = "0x182D68ED0", Slot = "349")]
		protected override void SetupNetworkCallbacks()
		{
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C7")]
		[Address(RVA = "0x2D68F50", Offset = "0x2D67F50", VA = "0x182D68F50")]
		private static void SetupServerCallbacks()
		{
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C8")]
		[Address(RVA = "0x2D68D00", Offset = "0x2D67D00", VA = "0x182D68D00", Slot = "348")]
		protected override void OnLoadingDone()
		{
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C9")]
		[Address(RVA = "0x692A50", Offset = "0x691A50", VA = "0x180692A50")]
		public void SetGui(IClientGui sourceGui)
		{
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CA")]
		[Address(RVA = "0x656140", Offset = "0x655140", VA = "0x180656140")]
		public void SetSuccessCallback(Action action)
		{
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CB")]
		[Address(RVA = "0x122BAB0", Offset = "0x122AAB0", VA = "0x18122BAB0")]
		public ServerStarterSteam()
		{
		}

		// Token: 0x04001F77 RID: 8055
		[Token(Token = "0x4001F77")]
		[FieldOffset(Offset = "0x70")]
		private Action _success;
	}
}
