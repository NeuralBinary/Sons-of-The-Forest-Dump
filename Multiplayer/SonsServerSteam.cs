using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000546 RID: 1350
	[Token(Token = "0x2000546")]
	[Serializable]
	public class SonsServerSteam : IGameServer
	{
		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x0000A2A8 File Offset: 0x000084A8
		// (set) Token: 0x0600231F RID: 8991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C0")]
		public bool IsConnectedToSteam
		{
			[Token(Token = "0x600231E")]
			[Address(RVA = "0x5829E0", Offset = "0x5819E0", VA = "0x1805829E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600231F")]
			[Address(RVA = "0x580620", Offset = "0x57F620", VA = "0x180580620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x0000A2C0 File Offset: 0x000084C0
		[Token(Token = "0x170004C1")]
		public CSteamID SteamId
		{
			[Token(Token = "0x6002320")]
			[Address(RVA = "0x2D6D980", Offset = "0x2D6C980", VA = "0x182D6D980")]
			get
			{
				return default(CSteamID);
			}
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[Token(Token = "0x6002321")]
		[Address(RVA = "0x2D6D360", Offset = "0x2D6C360", VA = "0x182D6D360", Slot = "6")]
		public bool Start(Action connected, Action<string> failed)
		{
			return default(bool);
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002322")]
		[Address(RVA = "0x2D6D800", Offset = "0x2D6C800", VA = "0x182D6D800", Slot = "5")]
		public void Update()
		{
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002323")]
		[Address(RVA = "0x2D6D140", Offset = "0x2D6C140", VA = "0x182D6D140", Slot = "4")]
		public void Shutdown()
		{
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002324")]
		[Address(RVA = "0x2D6CD10", Offset = "0x2D6BD10", VA = "0x182D6CD10")]
		private void Initialize()
		{
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002325")]
		[Address(RVA = "0x2D6D500", Offset = "0x2D6C500", VA = "0x182D6D500")]
		private void SteamIPCFailure(IPCFailure_t param)
		{
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002326")]
		[Address(RVA = "0x2D6D0C0", Offset = "0x2D6C0C0", VA = "0x182D6D0C0")]
		private void P2PSessionState(P2PSessionState_t param)
		{
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002327")]
		[Address(RVA = "0x2D6CF50", Offset = "0x2D6BF50", VA = "0x182D6CF50")]
		private void P2PSessionRequest(P2PSessionRequest_t param)
		{
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002328")]
		[Address(RVA = "0x2D6D5A0", Offset = "0x2D6C5A0", VA = "0x182D6D5A0")]
		private void SteamServerConnectFailure(SteamServerConnectFailure_t param)
		{
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002329")]
		[Address(RVA = "0x2D6D700", Offset = "0x2D6C700", VA = "0x182D6D700")]
		private void SteamServersDisconnected(SteamServersDisconnected_t param)
		{
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600232A")]
		[Address(RVA = "0x2D6D660", Offset = "0x2D6C660", VA = "0x182D6D660")]
		private void SteamServersConnected(SteamServersConnected_t param)
		{
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600232B")]
		[Address(RVA = "0x2D6D970", Offset = "0x2D6C970", VA = "0x182D6D970")]
		public SonsServerSteam()
		{
		}

		// Token: 0x04001FA1 RID: 8097
		[Token(Token = "0x4001FA1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _connected;

		// Token: 0x04001FA2 RID: 8098
		[Token(Token = "0x4001FA2")]
		[FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool _failed;

		// Token: 0x04001FA3 RID: 8099
		[Token(Token = "0x4001FA3")]
		[FieldOffset(Offset = "0x12")]
		[SerializeField]
		private bool _uninitialized;

		// Token: 0x04001FA4 RID: 8100
		[Token(Token = "0x4001FA4")]
		[FieldOffset(Offset = "0x18")]
		private Action Connected;

		// Token: 0x04001FA5 RID: 8101
		[Token(Token = "0x4001FA5")]
		[FieldOffset(Offset = "0x20")]
		private Action<string> Failed;

		// Token: 0x04001FA6 RID: 8102
		[Token(Token = "0x4001FA6")]
		[FieldOffset(Offset = "0x28")]
		private Callback<P2PSessionRequest_t> P2PSessionRequest_Callback;

		// Token: 0x04001FA7 RID: 8103
		[Token(Token = "0x4001FA7")]
		[FieldOffset(Offset = "0x30")]
		private Callback<SteamServerConnectFailure_t> SteamServerConnectFailure_Callback;

		// Token: 0x04001FA8 RID: 8104
		[Token(Token = "0x4001FA8")]
		[FieldOffset(Offset = "0x38")]
		private Callback<SteamServersConnected_t> SteamServersConnected_Callback;

		// Token: 0x04001FA9 RID: 8105
		[Token(Token = "0x4001FA9")]
		[FieldOffset(Offset = "0x40")]
		private Callback<SteamServersDisconnected_t> SteamServersDisconnected_Callback;

		// Token: 0x04001FAA RID: 8106
		[Token(Token = "0x4001FAA")]
		[FieldOffset(Offset = "0x48")]
		private Callback<IPCFailure_t> IPCFailure_Callback;
	}
}
