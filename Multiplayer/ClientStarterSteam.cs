using System;
using System.Collections;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.Multiplayer
{
	// Token: 0x02000532 RID: 1330
	[Token(Token = "0x2000532")]
	[Serializable]
	public class ClientStarterSteam : SonsClientSteam
	{
		// Token: 0x06002294 RID: 8852 RVA: 0x0000A110 File Offset: 0x00008310
		[Token(Token = "0x6002294")]
		[Address(RVA = "0x2D5D330", Offset = "0x2D5C330", VA = "0x182D5D330")]
		public int GetMaxConnectionAttempts()
		{
			return default(int);
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x0000A128 File Offset: 0x00008328
		[Token(Token = "0x6002295")]
		[Address(RVA = "0x2D5D290", Offset = "0x2D5C290", VA = "0x182D5D290")]
		public float GetConnectionTimeout()
		{
			return default(float);
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002296")]
		[Address(RVA = "0x2D5D820", Offset = "0x2D5C820", VA = "0x182D5D820")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002297")]
		[Address(RVA = "0x2D5D890", Offset = "0x2D5C890", VA = "0x182D5D890")]
		protected new void Update()
		{
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002298")]
		[Address(RVA = "0x2D5CA30", Offset = "0x2D5BA30", VA = "0x182D5CA30", Slot = "27")]
		public override void ConnectAttempt(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002299")]
		[Address(RVA = "0x2D5C9A0", Offset = "0x2D5B9A0", VA = "0x182D5C9A0")]
		private void CancelOnDisconnected()
		{
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600229A")]
		[Address(RVA = "0x2D5D570", Offset = "0x2D5C570", VA = "0x182D5D570")]
		public void OnDisconnected()
		{
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600229B")]
		[Address(RVA = "0x2D5D7B0", Offset = "0x2D5C7B0", VA = "0x182D5D7B0")]
		private IEnumerator RetryConnectingRoutine()
		{
			return null;
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600229C")]
		[Address(RVA = "0x2D5C7D0", Offset = "0x2D5B7D0", VA = "0x182D5C7D0", Slot = "13")]
		public override void BoltStartDone()
		{
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600229D")]
		[Address(RVA = "0x2D5D390", Offset = "0x2D5C390", VA = "0x182D5D390")]
		private void InitBolt()
		{
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600229E")]
		[Address(RVA = "0x2D5CF80", Offset = "0x2D5BF80", VA = "0x182D5CF80")]
		private void Connect()
		{
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600229F")]
		[Address(RVA = "0x2D5CBB0", Offset = "0x2D5BBB0", VA = "0x182D5CBB0", Slot = "24")]
		public override void ConnectFailed(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A0")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "31")]
		public override void EntityAttached(BoltEntity entity)
		{
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A1")]
		[Address(RVA = "0x122BAB0", Offset = "0x122AAB0", VA = "0x18122BAB0")]
		public ClientStarterSteam()
		{
		}

		// Token: 0x04001F60 RID: 8032
		[Token(Token = "0x4001F60")]
		private const string BoltMaxConnectionAttemptsKey = "Bolt.MaxConnectionAttempts";

		// Token: 0x04001F61 RID: 8033
		[Token(Token = "0x4001F61")]
		private const string BoltConnectionTimeoutKey = "Bolt.ConnectionTimeout";

		// Token: 0x04001F62 RID: 8034
		[Token(Token = "0x4001F62")]
		[FieldOffset(Offset = "0x70")]
		public int _connectionAttempts;

		// Token: 0x04001F63 RID: 8035
		[Token(Token = "0x4001F63")]
		[FieldOffset(Offset = "0x0")]
		public static bool Retrying;
	}
}
