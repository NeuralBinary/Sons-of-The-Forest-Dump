using System;
using System.Collections;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.Multiplayer
{
	// Token: 0x0200053B RID: 1339
	[Token(Token = "0x200053B")]
	[Serializable]
	public class ClientStarterSteam : SonsClientSteam
	{
		// Token: 0x06002387 RID: 9095 RVA: 0x0000A758 File Offset: 0x00008958
		[Token(Token = "0x6002387")]
		[Address(RVA = "0x3350C70", Offset = "0x334F270", VA = "0x183350C70")]
		public int GetMaxConnectionAttempts()
		{
			return 0;
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x0000A770 File Offset: 0x00008970
		[Token(Token = "0x6002388")]
		[Address(RVA = "0x3350CD0", Offset = "0x334F2D0", VA = "0x183350CD0")]
		public float GetConnectionTimeout()
		{
			return 0f;
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002389")]
		[Address(RVA = "0x3350D70", Offset = "0x334F370", VA = "0x183350D70")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238A")]
		[Address(RVA = "0x3350E00", Offset = "0x334F400", VA = "0x183350E00")]
		protected new void Update()
		{
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238B")]
		[Address(RVA = "0x3350EE0", Offset = "0x334F4E0", VA = "0x183350EE0", Slot = "27")]
		public override void ConnectAttempt(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238C")]
		[Address(RVA = "0x3351070", Offset = "0x334F670", VA = "0x183351070")]
		private void CancelOnDisconnected()
		{
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238D")]
		[Address(RVA = "0x33511A0", Offset = "0x334F7A0", VA = "0x1833511A0")]
		public void OnDisconnected()
		{
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238E")]
		[Address(RVA = "0x33514E0", Offset = "0x334FAE0", VA = "0x1833514E0")]
		private IEnumerator RetryConnectingRoutine()
		{
			return null;
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238F")]
		[Address(RVA = "0x3351570", Offset = "0x334FB70", VA = "0x183351570", Slot = "13")]
		public override void BoltStartDone()
		{
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002390")]
		[Address(RVA = "0x3351760", Offset = "0x334FD60", VA = "0x183351760")]
		private void InitBolt()
		{
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002391")]
		[Address(RVA = "0x3351A00", Offset = "0x3350000", VA = "0x183351A00")]
		private void Connect()
		{
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002392")]
		[Address(RVA = "0x3351ED0", Offset = "0x33504D0", VA = "0x183351ED0", Slot = "24")]
		public override void ConnectFailed(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002393")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "31")]
		public override void EntityAttached(BoltEntity entity)
		{
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x0000A788 File Offset: 0x00008988
		[Token(Token = "0x6002394")]
		[Address(RVA = "0x3352380", Offset = "0x3350980", VA = "0x183352380")]
		private UdpEndPoint ToEndpoint(string address, ushort port)
		{
			return default(UdpEndPoint);
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002395")]
		[Address(RVA = "0x144EB80", Offset = "0x144D180", VA = "0x18144EB80")]
		public ClientStarterSteam()
		{
		}

		// Token: 0x04002015 RID: 8213
		[Token(Token = "0x4002015")]
		private const string BoltMaxConnectionAttemptsKey = "Bolt.MaxConnectionAttempts";

		// Token: 0x04002016 RID: 8214
		[Token(Token = "0x4002016")]
		private const string BoltConnectionTimeoutKey = "Bolt.ConnectionTimeout";

		// Token: 0x04002017 RID: 8215
		[Token(Token = "0x4002017")]
		[FieldOffset(Offset = "0x70")]
		public int _connectionAttempts;

		// Token: 0x04002018 RID: 8216
		[Token(Token = "0x4002018")]
		[FieldOffset(Offset = "0x0")]
		public static bool Retrying;
	}
}
