using System;
using System.Collections;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000540 RID: 1344
	[Token(Token = "0x2000540")]
	[Serializable]
	public class SonsClientSteam : GlobalEventListener
	{
		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B6")]
		public static ResourceRequest PrefabDbResource
		{
			[Token(Token = "0x60022E4")]
			[Address(RVA = "0x2D6BBA0", Offset = "0x2D6ABA0", VA = "0x182D6BBA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E5")]
		[Address(RVA = "0x2D6B000", Offset = "0x2D6A000", VA = "0x182D6B000")]
		private void Awake()
		{
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E6")]
		[Address(RVA = "0x2D6B320", Offset = "0x2D6A320", VA = "0x182D6B320")]
		protected BoltConfig GetConfig()
		{
			return null;
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E7")]
		[Address(RVA = "0x2D6B1A0", Offset = "0x2D6A1A0", VA = "0x182D6B1A0")]
		protected void BoltSetup()
		{
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E8")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "348")]
		protected virtual void OnLoadingDone()
		{
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E9")]
		[Address(RVA = "0x2D6B4B0", Offset = "0x2D6A4B0", VA = "0x182D6B4B0")]
		private IEnumerator LoadingDone()
		{
			return null;
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022EA")]
		[Address(RVA = "0x2D6AFF0", Offset = "0x2D69FF0", VA = "0x182D6AFF0")]
		private void AttachLocalPlayer()
		{
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022EB")]
		[Address(RVA = "0x2D6B990", Offset = "0x2D6A990", VA = "0x182D6B990")]
		protected void Update()
		{
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022EC")]
		[Address(RVA = "0x2D6B7D0", Offset = "0x2D6A7D0", VA = "0x182D6B7D0")]
		private void UpdateClientState()
		{
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022ED")]
		[Address(RVA = "0x2D6AE40", Offset = "0x2D69E40", VA = "0x182D6AE40")]
		private void ApplyNewClientState(ClientState clientState)
		{
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022EE")]
		[Address(RVA = "0x2D6B610", Offset = "0x2D6A610", VA = "0x182D6B610")]
		protected void SetupGameEnvironment()
		{
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022EF")]
		[Address(RVA = "0x2D6B770", Offset = "0x2D6A770", VA = "0x182D6B770", Slot = "349")]
		protected virtual void SetupNetworkCallbacks()
		{
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F0")]
		[Address(RVA = "0x2D6B550", Offset = "0x2D6A550", VA = "0x182D6B550")]
		protected static void SetupClientCallbacks()
		{
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F1")]
		[Address(RVA = "0x2D6B520", Offset = "0x2D6A520", VA = "0x182D6B520")]
		private void RefreshLoading()
		{
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F2")]
		[Address(RVA = "0x2D6B780", Offset = "0x2D6A780", VA = "0x182D6B780")]
		private void UpdateAsyncState()
		{
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F3")]
		[Address(RVA = "0x2D6B8B0", Offset = "0x2D6A8B0", VA = "0x182D6B8B0")]
		private void UpdateServerState()
		{
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F4")]
		[Address(RVA = "0x2D6AF20", Offset = "0x2D69F20", VA = "0x182D6AF20")]
		private void ApplyNewServerState(ServerState currentServerState)
		{
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F5")]
		[Address(RVA = "0x2D6B400", Offset = "0x2D6A400", VA = "0x182D6B400")]
		internal void LoadMainScene()
		{
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F6")]
		[Address(RVA = "0x122BAB0", Offset = "0x122AAB0", VA = "0x18122BAB0")]
		public SonsClientSteam()
		{
		}

		// Token: 0x04001F7E RID: 8062
		[Token(Token = "0x4001F7E")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public SonsClientSteam.MapState mapState;

		// Token: 0x04001F7F RID: 8063
		[Token(Token = "0x4001F7F")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public IClientGui gui;

		// Token: 0x04001F80 RID: 8064
		[Token(Token = "0x4001F80")]
		[FieldOffset(Offset = "0x0")]
		private static ResourceRequest _PrefabDbResource;

		// Token: 0x04001F81 RID: 8065
		[Token(Token = "0x4001F81")]
		[FieldOffset(Offset = "0x48")]
		private ServerState _serverState;

		// Token: 0x04001F82 RID: 8066
		[Token(Token = "0x4001F82")]
		[FieldOffset(Offset = "0x4C")]
		private ClientState _clientState;

		// Token: 0x04001F83 RID: 8067
		[Token(Token = "0x4001F83")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _loadMapTarget;

		// Token: 0x04001F84 RID: 8068
		[Token(Token = "0x4001F84")]
		[FieldOffset(Offset = "0x58")]
		private AsyncOperation _async;

		// Token: 0x04001F85 RID: 8069
		[Token(Token = "0x4001F85")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _asyncState;

		// Token: 0x04001F86 RID: 8070
		[Token(Token = "0x4001F86")]
		[FieldOffset(Offset = "0x64")]
		private ClientState _previousClientState;

		// Token: 0x04001F87 RID: 8071
		[Token(Token = "0x4001F87")]
		[FieldOffset(Offset = "0x68")]
		private string _localPlayerAttachName;

		// Token: 0x02000541 RID: 1345
		[Token(Token = "0x2000541")]
		public enum MapState
		{
			// Token: 0x04001F89 RID: 8073
			[Token(Token = "0x4001F89")]
			None,
			// Token: 0x04001F8A RID: 8074
			[Token(Token = "0x4001F8A")]
			Begin,
			// Token: 0x04001F8B RID: 8075
			[Token(Token = "0x4001F8B")]
			Loading,
			// Token: 0x04001F8C RID: 8076
			[Token(Token = "0x4001F8C")]
			Done,
			// Token: 0x04001F8D RID: 8077
			[Token(Token = "0x4001F8D")]
			Playing
		}
	}
}
