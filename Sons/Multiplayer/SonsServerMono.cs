using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x0200054C RID: 1356
	[Token(Token = "0x200054C")]
	public class SonsServerMono : MonoBehaviour
	{
		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CD")]
		private static string ServerName
		{
			[Token(Token = "0x60023F1")]
			[Address(RVA = "0x3357230", Offset = "0x3355830", VA = "0x183357230")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x0000A860 File Offset: 0x00008A60
		[Token(Token = "0x170004CE")]
		private static int MemberLimit
		{
			[Token(Token = "0x60023F2")]
			[Address(RVA = "0x3357270", Offset = "0x3355870", VA = "0x183357270")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0000A878 File Offset: 0x00008A78
		[Token(Token = "0x170004CF")]
		private static bool IsPrivate
		{
			[Token(Token = "0x60023F3")]
			[Address(RVA = "0x33572B0", Offset = "0x33558B0", VA = "0x1833572B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x0000A890 File Offset: 0x00008A90
		[Token(Token = "0x170004D0")]
		public bool IsCreated
		{
			[Token(Token = "0x60023F4")]
			[Address(RVA = "0x1E53230", Offset = "0x1E51830", VA = "0x181E53230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F5")]
		[Address(RVA = "0x33572F0", Offset = "0x33558F0", VA = "0x1833572F0")]
		private void SpawnPrefab()
		{
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		[Token(Token = "0x170004D1")]
		private bool IsNewGame
		{
			[Token(Token = "0x60023F6")]
			[Address(RVA = "0x3357430", Offset = "0x3355A30", VA = "0x183357430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F7")]
		[Address(RVA = "0x3357440", Offset = "0x3355A40", VA = "0x183357440")]
		public void CreateServer(Action successCallback, Action<string> failureCallback)
		{
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F8")]
		[Address(RVA = "0x3357A10", Offset = "0x3356010", VA = "0x183357A10")]
		public void StartServer()
		{
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023F9")]
		[Address(RVA = "0x3357B70", Offset = "0x3356170", VA = "0x183357B70")]
		public IEnumerator StartServerDelayed(float delay)
		{
			return null;
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FA")]
		[Address(RVA = "0x3357C30", Offset = "0x3356230", VA = "0x183357C30")]
		private void StartLoadMainScene()
		{
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FB")]
		[Address(RVA = "0x3357C30", Offset = "0x3356230", VA = "0x183357C30")]
		private void LoadMap()
		{
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FC")]
		[Address(RVA = "0x3357D60", Offset = "0x3356360", VA = "0x183357D60")]
		public void StopServer()
		{
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x3357E20", Offset = "0x3356420", VA = "0x183357E20")]
		private void Start()
		{
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x3357E90", Offset = "0x3356490", VA = "0x183357E90")]
		private void Awake()
		{
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x3358100", Offset = "0x3356700", VA = "0x183358100")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		[Token(Token = "0x6002400")]
		[Address(RVA = "0x33582A0", Offset = "0x33568A0", VA = "0x1833582A0")]
		private bool CheckStartServer()
		{
			return default(bool);
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		[Token(Token = "0x6002401")]
		[Address(RVA = "0x3358380", Offset = "0x3356980", VA = "0x183358380")]
		private static bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002402")]
		[Address(RVA = "0x3358400", Offset = "0x3356A00", VA = "0x183358400")]
		private void StartFailure(string result)
		{
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002403")]
		[Address(RVA = "0x3358480", Offset = "0x3356A80", VA = "0x183358480")]
		private void StartSuccess()
		{
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002404")]
		[Address(RVA = "0x33586A0", Offset = "0x3356CA0", VA = "0x1833586A0")]
		private void CreateFailure()
		{
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002405")]
		[Address(RVA = "0x3358700", Offset = "0x3356D00", VA = "0x183358700")]
		private void CreateSuccess()
		{
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002406")]
		[Address(RVA = "0x3358930", Offset = "0x3356F30", VA = "0x183358930")]
		private void Update()
		{
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002407")]
		[Address(RVA = "0x3358A80", Offset = "0x3357080", VA = "0x183358A80")]
		private void LinkServerToLobby()
		{
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002408")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SonsServerMono()
		{
		}

		// Token: 0x04002047 RID: 8263
		[Token(Token = "0x4002047")]
		[FieldOffset(Offset = "0x0")]
		private static SonsServerMono _instance;

		// Token: 0x04002048 RID: 8264
		[Token(Token = "0x4002048")]
		[FieldOffset(Offset = "0x20")]
		[SerializeReference]
		private SonsServerSteam _server;

		// Token: 0x04002049 RID: 8265
		[Token(Token = "0x4002049")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _continueGame;

		// Token: 0x0400204A RID: 8266
		[Token(Token = "0x400204A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ServerStarterSteam _serverStarter;

		// Token: 0x0400204B RID: 8267
		[Token(Token = "0x400204B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ServerState _state;

		// Token: 0x0400204C RID: 8268
		[Token(Token = "0x400204C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _spawnPrefab;

		// Token: 0x0400204D RID: 8269
		[Token(Token = "0x400204D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _autoStart;

		// Token: 0x0400204E RID: 8270
		[Token(Token = "0x400204E")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _delay;

		// Token: 0x0400204F RID: 8271
		[Token(Token = "0x400204F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SonsServerMono.ServerMode _mode;

		// Token: 0x0200054D RID: 1357
		[Token(Token = "0x200054D")]
		private enum ServerMode
		{
			// Token: 0x04002051 RID: 8273
			[Token(Token = "0x4002051")]
			PeerToPeer,
			// Token: 0x04002052 RID: 8274
			[Token(Token = "0x4002052")]
			Dedicated
		}
	}
}
