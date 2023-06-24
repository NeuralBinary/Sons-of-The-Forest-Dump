using System;
using System.Collections;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000549 RID: 1353
	[Token(Token = "0x2000549")]
	[Serializable]
	public class SonsClientSteam : GlobalEventListener
	{
		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060023D8 RID: 9176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CA")]
		public static ResourceRequest PrefabDbResource
		{
			[Token(Token = "0x60023D8")]
			[Address(RVA = "0x33556C0", Offset = "0x3353CC0", VA = "0x1833556C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D9")]
		[Address(RVA = "0x33557A0", Offset = "0x3353DA0", VA = "0x1833557A0")]
		private void Awake()
		{
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DA")]
		[Address(RVA = "0x33559A0", Offset = "0x3353FA0", VA = "0x1833559A0")]
		protected BoltConfig GetConfig()
		{
			return null;
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DB")]
		[Address(RVA = "0x3355AD0", Offset = "0x33540D0", VA = "0x183355AD0")]
		protected void BoltSetup()
		{
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "384")]
		protected virtual void OnLoadingDone()
		{
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DD")]
		[Address(RVA = "0x3355C80", Offset = "0x3354280", VA = "0x183355C80")]
		private IEnumerator LoadingDone()
		{
			return null;
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x3355D10", Offset = "0x3354310", VA = "0x183355D10")]
		private void AttachLocalPlayer()
		{
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x3355EC0", Offset = "0x33544C0", VA = "0x183355EC0")]
		protected void Update()
		{
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E0")]
		[Address(RVA = "0x33560C0", Offset = "0x33546C0", VA = "0x1833560C0")]
		private void UpdateClientState()
		{
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E1")]
		[Address(RVA = "0x33561A0", Offset = "0x33547A0", VA = "0x1833561A0")]
		private void ApplyNewClientState(ClientState clientState)
		{
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E2")]
		[Address(RVA = "0x3356280", Offset = "0x3354880", VA = "0x183356280")]
		protected void SetupGameEnvironment()
		{
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E3")]
		[Address(RVA = "0x33564D0", Offset = "0x3354AD0", VA = "0x1833564D0", Slot = "385")]
		protected virtual void SetupNetworkCallbacks()
		{
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E4")]
		[Address(RVA = "0x33564E0", Offset = "0x3354AE0", VA = "0x1833564E0")]
		protected static void SetupClientCallbacks()
		{
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E5")]
		[Address(RVA = "0x33565A0", Offset = "0x3354BA0", VA = "0x1833565A0")]
		private void RefreshLoading()
		{
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E6")]
		[Address(RVA = "0x3356620", Offset = "0x3354C20", VA = "0x183356620")]
		private void UpdateAsyncState()
		{
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E7")]
		[Address(RVA = "0x33566F0", Offset = "0x3354CF0", VA = "0x1833566F0")]
		private void UpdateServerState()
		{
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E8")]
		[Address(RVA = "0x3356980", Offset = "0x3354F80", VA = "0x183356980")]
		private void ApplyNewServerState(ServerState currentServerState)
		{
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E9")]
		[Address(RVA = "0x3356A80", Offset = "0x3355080", VA = "0x183356A80")]
		internal void LoadMainScene()
		{
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EA")]
		[Address(RVA = "0x144EB80", Offset = "0x144D180", VA = "0x18144EB80")]
		public SonsClientSteam()
		{
		}

		// Token: 0x04002034 RID: 8244
		[Token(Token = "0x4002034")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public SonsClientSteam.MapState mapState;

		// Token: 0x04002035 RID: 8245
		[Token(Token = "0x4002035")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public IClientGui gui;

		// Token: 0x04002036 RID: 8246
		[Token(Token = "0x4002036")]
		[FieldOffset(Offset = "0x0")]
		private static ResourceRequest _PrefabDbResource;

		// Token: 0x04002037 RID: 8247
		[Token(Token = "0x4002037")]
		[FieldOffset(Offset = "0x48")]
		private ServerState _serverState;

		// Token: 0x04002038 RID: 8248
		[Token(Token = "0x4002038")]
		[FieldOffset(Offset = "0x4C")]
		private ClientState _clientState;

		// Token: 0x04002039 RID: 8249
		[Token(Token = "0x4002039")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _loadMapTarget;

		// Token: 0x0400203A RID: 8250
		[Token(Token = "0x400203A")]
		[FieldOffset(Offset = "0x58")]
		private AsyncOperation _async;

		// Token: 0x0400203B RID: 8251
		[Token(Token = "0x400203B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _asyncState;

		// Token: 0x0400203C RID: 8252
		[Token(Token = "0x400203C")]
		[FieldOffset(Offset = "0x64")]
		private ClientState _previousClientState;

		// Token: 0x0400203D RID: 8253
		[Token(Token = "0x400203D")]
		[FieldOffset(Offset = "0x68")]
		private string _localPlayerAttachName;

		// Token: 0x0200054A RID: 1354
		[Token(Token = "0x200054A")]
		public enum MapState
		{
			// Token: 0x0400203F RID: 8255
			[Token(Token = "0x400203F")]
			None,
			// Token: 0x04002040 RID: 8256
			[Token(Token = "0x4002040")]
			Begin,
			// Token: 0x04002041 RID: 8257
			[Token(Token = "0x4002041")]
			Loading,
			// Token: 0x04002042 RID: 8258
			[Token(Token = "0x4002042")]
			Done,
			// Token: 0x04002043 RID: 8259
			[Token(Token = "0x4002043")]
			Playing
		}
	}
}
