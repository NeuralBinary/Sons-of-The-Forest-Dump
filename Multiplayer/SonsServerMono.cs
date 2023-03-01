using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000543 RID: 1347
	[Token(Token = "0x2000543")]
	public class SonsServerMono : MonoBehaviour
	{
		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B9")]
		private static string ServerName
		{
			[Token(Token = "0x60022FD")]
			[Address(RVA = "0x2D6CCD0", Offset = "0x2D6BCD0", VA = "0x182D6CCD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x0000A200 File Offset: 0x00008400
		[Token(Token = "0x170004BA")]
		private static int MemberLimit
		{
			[Token(Token = "0x60022FE")]
			[Address(RVA = "0x2D6CC90", Offset = "0x2D6BC90", VA = "0x182D6CC90")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x0000A218 File Offset: 0x00008418
		[Token(Token = "0x170004BB")]
		private static bool IsPrivate
		{
			[Token(Token = "0x60022FF")]
			[Address(RVA = "0x2D6CC50", Offset = "0x2D6BC50", VA = "0x182D6CC50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x0000A230 File Offset: 0x00008430
		[Token(Token = "0x170004BC")]
		public bool IsCreated
		{
			[Token(Token = "0x6002300")]
			[Address(RVA = "0x1B7A100", Offset = "0x1B79100", VA = "0x181B7A100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002301")]
		[Address(RVA = "0x2D6C540", Offset = "0x2D6B540", VA = "0x182D6C540")]
		private void SpawnPrefab()
		{
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06002302 RID: 8962 RVA: 0x0000A248 File Offset: 0x00008448
		[Token(Token = "0x170004BD")]
		private bool IsNewGame
		{
			[Token(Token = "0x6002302")]
			[Address(RVA = "0x2D6CC40", Offset = "0x2D6BC40", VA = "0x182D6CC40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002303")]
		[Address(RVA = "0x2D6BEF0", Offset = "0x2D6AEF0", VA = "0x182D6BEF0")]
		public void CreateServer(Action successCallback, Action<string> failureCallback)
		{
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002304")]
		[Address(RVA = "0x2D6C740", Offset = "0x2D6B740", VA = "0x182D6C740")]
		public void StartServer()
		{
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002305")]
		[Address(RVA = "0x2D6C6C0", Offset = "0x2D6B6C0", VA = "0x182D6C6C0")]
		public IEnumerator StartServerDelayed(float delay)
		{
			return null;
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002306")]
		[Address(RVA = "0x2D6C340", Offset = "0x2D6B340", VA = "0x182D6C340")]
		private void StartLoadMainScene()
		{
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002307")]
		[Address(RVA = "0x2D6C340", Offset = "0x2D6B340", VA = "0x182D6C340")]
		private void LoadMap()
		{
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002308")]
		[Address(RVA = "0x2D6CA40", Offset = "0x2D6BA40", VA = "0x182D6CA40")]
		public void StopServer()
		{
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002309")]
		[Address(RVA = "0x2D6C9D0", Offset = "0x2D6B9D0", VA = "0x182D6C9D0")]
		private void Start()
		{
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230A")]
		[Address(RVA = "0x2D6BC40", Offset = "0x2D6AC40", VA = "0x182D6BC40")]
		private void Awake()
		{
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230B")]
		[Address(RVA = "0x2D6C400", Offset = "0x2D6B400", VA = "0x182D6C400")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x0000A260 File Offset: 0x00008460
		[Token(Token = "0x600230C")]
		[Address(RVA = "0x2D6BDE0", Offset = "0x2D6ADE0", VA = "0x182D6BDE0")]
		private bool CheckStartServer()
		{
			return default(bool);
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x0000A278 File Offset: 0x00008478
		[Token(Token = "0x600230D")]
		[Address(RVA = "0x2D6C260", Offset = "0x2D6B260", VA = "0x182D6C260")]
		private static bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230E")]
		[Address(RVA = "0x2D6C640", Offset = "0x2D6B640", VA = "0x182D6C640")]
		private void StartFailure(string result)
		{
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230F")]
		[Address(RVA = "0x2D6C7F0", Offset = "0x2D6B7F0", VA = "0x182D6C7F0")]
		private void StartSuccess()
		{
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002310")]
		[Address(RVA = "0x2D6BE90", Offset = "0x2D6AE90", VA = "0x182D6BE90")]
		private void CreateFailure()
		{
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002311")]
		[Address(RVA = "0x2D6C110", Offset = "0x2D6B110", VA = "0x182D6C110")]
		private void CreateSuccess()
		{
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002312")]
		[Address(RVA = "0x2D6CAE0", Offset = "0x2D6BAE0", VA = "0x182D6CAE0")]
		private void Update()
		{
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002313")]
		[Address(RVA = "0x2D6C2A0", Offset = "0x2D6B2A0", VA = "0x182D6C2A0")]
		private void LinkServerToLobby()
		{
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002314")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SonsServerMono()
		{
		}

		// Token: 0x04001F91 RID: 8081
		[Token(Token = "0x4001F91")]
		[FieldOffset(Offset = "0x0")]
		private static SonsServerMono _instance;

		// Token: 0x04001F92 RID: 8082
		[Token(Token = "0x4001F92")]
		[FieldOffset(Offset = "0x20")]
		[SerializeReference]
		private SonsServerSteam _server;

		// Token: 0x04001F93 RID: 8083
		[Token(Token = "0x4001F93")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _continueGame;

		// Token: 0x04001F94 RID: 8084
		[Token(Token = "0x4001F94")]
		[FieldOffset(Offset = "0x30")]
		private SteamPlatform _steamPlatform;

		// Token: 0x04001F95 RID: 8085
		[Token(Token = "0x4001F95")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ServerStarterSteam _serverStarter;

		// Token: 0x04001F96 RID: 8086
		[Token(Token = "0x4001F96")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ServerState _state;

		// Token: 0x04001F97 RID: 8087
		[Token(Token = "0x4001F97")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _spawnPrefab;

		// Token: 0x04001F98 RID: 8088
		[Token(Token = "0x4001F98")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _autoStart;

		// Token: 0x04001F99 RID: 8089
		[Token(Token = "0x4001F99")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _delay;
	}
}
