using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000550 RID: 1360
	[Token(Token = "0x2000550")]
	[Serializable]
	public class SonsServerSteam : IGameServer
	{
		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06002412 RID: 9234 RVA: 0x0000A908 File Offset: 0x00008B08
		// (set) Token: 0x06002413 RID: 9235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D4")]
		public bool IsConnectedToSteam
		{
			[Token(Token = "0x6002412")]
			[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002413")]
			[Address(RVA = "0x5F2110", Offset = "0x5F0710", VA = "0x1805F2110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06002414 RID: 9236 RVA: 0x0000A920 File Offset: 0x00008B20
		[Token(Token = "0x170004D5")]
		public CSteamID SteamId
		{
			[Token(Token = "0x6002414")]
			[Address(RVA = "0x33802A0", Offset = "0x337E8A0", VA = "0x1833802A0")]
			get
			{
				return default(CSteamID);
			}
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x0000A938 File Offset: 0x00008B38
		[Token(Token = "0x6002415")]
		[Address(RVA = "0x33802B0", Offset = "0x337E8B0", VA = "0x1833802B0", Slot = "6")]
		public bool Start(Action connected, Action<string> failed)
		{
			return default(bool);
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002416")]
		[Address(RVA = "0x3380820", Offset = "0x337EE20", VA = "0x183380820", Slot = "5")]
		public void Update()
		{
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002417")]
		[Address(RVA = "0x3380930", Offset = "0x337EF30", VA = "0x183380930", Slot = "4")]
		public void Shutdown()
		{
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002418")]
		[Address(RVA = "0x3380FB0", Offset = "0x337F5B0", VA = "0x183380FB0")]
		private void Initialize()
		{
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002419")]
		[Address(RVA = "0x33814B0", Offset = "0x337FAB0", VA = "0x1833814B0")]
		private static void ValidateAuthTicketResponse(ValidateAuthTicketResponse_t param)
		{
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241A")]
		[Address(RVA = "0x33817A0", Offset = "0x337FDA0", VA = "0x1833817A0")]
		private void SteamIPCFailure(IPCFailure_t param)
		{
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241B")]
		[Address(RVA = "0x3381850", Offset = "0x337FE50", VA = "0x183381850")]
		private void P2PSessionState(P2PSessionState_t param)
		{
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241C")]
		[Address(RVA = "0x33818D0", Offset = "0x337FED0", VA = "0x1833818D0")]
		private void P2PSessionRequest(P2PSessionRequest_t param)
		{
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241D")]
		[Address(RVA = "0x3381AB0", Offset = "0x33800B0", VA = "0x183381AB0")]
		private void SteamServerConnectFailure(SteamServerConnectFailure_t param)
		{
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241E")]
		[Address(RVA = "0x3381C00", Offset = "0x3380200", VA = "0x183381C00")]
		private void SteamServersDisconnected(SteamServersDisconnected_t param)
		{
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241F")]
		[Address(RVA = "0x3381D80", Offset = "0x3380380", VA = "0x183381D80")]
		private void SteamServersConnected(SteamServersConnected_t param)
		{
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002420")]
		[Address(RVA = "0x3381EC0", Offset = "0x33804C0", VA = "0x183381EC0")]
		public SonsServerSteam()
		{
		}

		// Token: 0x0400205A RID: 8282
		[Token(Token = "0x400205A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _connected;

		// Token: 0x0400205B RID: 8283
		[Token(Token = "0x400205B")]
		[FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool _failed;

		// Token: 0x0400205C RID: 8284
		[Token(Token = "0x400205C")]
		[FieldOffset(Offset = "0x12")]
		[SerializeField]
		private bool _uninitialized;

		// Token: 0x0400205D RID: 8285
		[Token(Token = "0x400205D")]
		[FieldOffset(Offset = "0x18")]
		private Action Connected;

		// Token: 0x0400205E RID: 8286
		[Token(Token = "0x400205E")]
		[FieldOffset(Offset = "0x20")]
		private Action<string> Failed;

		// Token: 0x0400205F RID: 8287
		[Token(Token = "0x400205F")]
		[FieldOffset(Offset = "0x28")]
		private Callback<P2PSessionRequest_t> P2PSessionRequest_Callback;

		// Token: 0x04002060 RID: 8288
		[Token(Token = "0x4002060")]
		[FieldOffset(Offset = "0x30")]
		private Callback<SteamServerConnectFailure_t> SteamServerConnectFailure_Callback;

		// Token: 0x04002061 RID: 8289
		[Token(Token = "0x4002061")]
		[FieldOffset(Offset = "0x38")]
		private Callback<SteamServersConnected_t> SteamServersConnected_Callback;

		// Token: 0x04002062 RID: 8290
		[Token(Token = "0x4002062")]
		[FieldOffset(Offset = "0x40")]
		private Callback<SteamServersDisconnected_t> SteamServersDisconnected_Callback;

		// Token: 0x04002063 RID: 8291
		[Token(Token = "0x4002063")]
		[FieldOffset(Offset = "0x48")]
		private Callback<IPCFailure_t> IPCFailure_Callback;

		// Token: 0x04002064 RID: 8292
		[Token(Token = "0x4002064")]
		[FieldOffset(Offset = "0x0")]
		private static Callback<ValidateAuthTicketResponse_t> ValidateAuthTicketResponse_Callback;
	}
}
