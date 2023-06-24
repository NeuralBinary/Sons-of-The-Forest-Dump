using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Wearable.Clothing;
using Sons.Wearable.Race;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007B2 RID: 1970
	[Token(Token = "0x20007B2")]
	public class PlayerActorManager : SingletonBehaviour<PlayerActorManager>
	{
		// Token: 0x06003524 RID: 13604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003524")]
		[Address(RVA = "0x34D9200", Offset = "0x34D7800", VA = "0x1834D9200")]
		private void Update()
		{
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06003525 RID: 13605 RVA: 0x0000FE88 File Offset: 0x0000E088
		[Token(Token = "0x170006B4")]
		private bool IsActive
		{
			[Token(Token = "0x6003525")]
			[Address(RVA = "0x34D9290", Offset = "0x34D7890", VA = "0x1834D9290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003526")]
		[Address(RVA = "0x34D9320", Offset = "0x34D7920", VA = "0x1834D9320")]
		public static void OnPlayerConnected(BoltEntity playerEntity)
		{
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003527")]
		[Address(RVA = "0x34D9470", Offset = "0x34D7A70", VA = "0x1834D9470")]
		public static void OnPlayerActivated(BoltEntity playerEntity)
		{
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003528")]
		[Address(RVA = "0x34D94E0", Offset = "0x34D7AE0", VA = "0x1834D94E0")]
		private static void SendSpawnPositionEvent(ulong steamId, Vector3 spawnPos, Quaternion spawnRot, PlayerRace.Race race)
		{
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003529")]
		[Address(RVA = "0x34D97F0", Offset = "0x34D7DF0", VA = "0x1834D97F0")]
		public static void OnSetSpawnPointEvent(SetPlayerSpawnPoint evnt)
		{
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352A")]
		[Address(RVA = "0x34D9C30", Offset = "0x34D8230", VA = "0x1834D9C30")]
		public void GetPlayerSpawn(ref Vector3 spawnPos, ref Quaternion spawnRot, ref PlayerRace.Race race)
		{
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352B")]
		[Address(RVA = "0x34D9C60", Offset = "0x34D8260", VA = "0x1834D9C60")]
		public static void OnCrashIntroComplete(Vector3 crashPos)
		{
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352C")]
		[Address(RVA = "0x34D9CE0", Offset = "0x34D82E0", VA = "0x1834D9CE0")]
		public static void OnPlayerDisconnected(BoltEntity playerEntity)
		{
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352D")]
		[Address(RVA = "0x34D9D80", Offset = "0x34D8380", VA = "0x1834D9D80")]
		public static void SetPlayerActorCount(int targetCount)
		{
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352E")]
		[Address(RVA = "0x34D9E10", Offset = "0x34D8410", VA = "0x1834D9E10")]
		private void SpawnPlayerActor(Vector3 position, ulong steamId, PlayerRaceSystem playerRace, PlayerClothingSystem playerClothing)
		{
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352F")]
		[Address(RVA = "0x34DA490", Offset = "0x34D8A90", VA = "0x1834DA490")]
		private void RemovePlayerActor(PlayerActorManager.PlayerActor actorData)
		{
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		[Token(Token = "0x6003530")]
		[Address(RVA = "0x34DA530", Offset = "0x34D8B30", VA = "0x1834DA530")]
		private bool RemovePlayerActor(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003531")]
		[Address(RVA = "0x34DA690", Offset = "0x34D8C90", VA = "0x1834DA690")]
		private void RemoveClosestPlayerActor(Vector3 position)
		{
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		[Token(Token = "0x6003532")]
		[Address(RVA = "0x34DA9B0", Offset = "0x34D8FB0", VA = "0x1834DA9B0")]
		private int CurrentPlayerCount()
		{
			return 0;
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003533")]
		[Address(RVA = "0x34DAA00", Offset = "0x34D9000", VA = "0x1834DAA00")]
		private void SpawnPlayerActors(int newActors, Vector3 spawnCenter)
		{
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003534")]
		[Address(RVA = "0x34DAB90", Offset = "0x34D9190", VA = "0x1834DAB90")]
		private void SetPlayerActorCountInternal(int targetCount)
		{
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003535")]
		[Address(RVA = "0x34DABD0", Offset = "0x34D91D0", VA = "0x1834DABD0")]
		private void OnUpdatedPlayerActorSettings(bool allowSpawn)
		{
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		[Token(Token = "0x6003536")]
		[Address(RVA = "0x34DB140", Offset = "0x34D9740", VA = "0x1834DB140")]
		private bool GetPlayerActorPosition(ulong steamId, out Vector3 position, out Quaternion spawnRot, out PlayerRace.Race race)
		{
			return default(bool);
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003537")]
		[Address(RVA = "0x34DB3A0", Offset = "0x34D99A0", VA = "0x1834DB3A0")]
		private void OnPlayerActivatedInternal(BoltEntity playerEntity)
		{
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003538")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnPlayerConnectedInternal(BoltEntity playerEntity)
		{
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003539")]
		[Address(RVA = "0x34DB5E0", Offset = "0x34D9BE0", VA = "0x1834DB5E0")]
		private void OnPlayerDisconnectedInternal(BoltEntity playerEntity)
		{
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		[Token(Token = "0x600353A")]
		[Address(RVA = "0x34DBDD0", Offset = "0x34DA3D0", VA = "0x1834DBDD0")]
		private Vector3 GetClosestShelter(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353B")]
		[Address(RVA = "0x34DC050", Offset = "0x34DA650", VA = "0x1834DC050")]
		public PlayerActorManager()
		{
		}

		// Token: 0x04002DD3 RID: 11731
		[Token(Token = "0x4002DD3")]
		private const int MaxPlayers = 16;

		// Token: 0x04002DD4 RID: 11732
		[Token(Token = "0x4002DD4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VailActor _playerActorPrefab;

		// Token: 0x04002DD5 RID: 11733
		[Token(Token = "0x4002DD5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _playerActorsActive;

		// Token: 0x04002DD6 RID: 11734
		[Token(Token = "0x4002DD6")]
		[FieldOffset(Offset = "0x34")]
		private int _targetPlayerCount;

		// Token: 0x04002DD7 RID: 11735
		[Token(Token = "0x4002DD7")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<PlayerActorManager.PlayerActor> _playerActors;

		// Token: 0x04002DD8 RID: 11736
		[Token(Token = "0x4002DD8")]
		[FieldOffset(Offset = "0x40")]
		private bool _hasPlayerSpawnPoint;

		// Token: 0x04002DD9 RID: 11737
		[Token(Token = "0x4002DD9")]
		[FieldOffset(Offset = "0x44")]
		private PlayerRace.Race _localPlayerRace;

		// Token: 0x04002DDA RID: 11738
		[Token(Token = "0x4002DDA")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 _localPlayerSpawnPos;

		// Token: 0x04002DDB RID: 11739
		[Token(Token = "0x4002DDB")]
		[FieldOffset(Offset = "0x54")]
		private Quaternion _localPlayerSpawnRot;

		// Token: 0x04002DDC RID: 11740
		[Token(Token = "0x4002DDC")]
		[FieldOffset(Offset = "0x64")]
		private bool _gameStarted;

		// Token: 0x04002DDD RID: 11741
		[Token(Token = "0x4002DDD")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 _openingCrashPosition;

		// Token: 0x04002DDE RID: 11742
		[Token(Token = "0x4002DDE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<Type> ShelterStimuliList;

		// Token: 0x020007B3 RID: 1971
		[Token(Token = "0x20007B3")]
		[Serializable]
		private class PlayerActor
		{
			// Token: 0x0600353D RID: 13629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600353D")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PlayerActor()
			{
			}

			// Token: 0x04002DDF RID: 11743
			[Token(Token = "0x4002DDF")]
			[FieldOffset(Offset = "0x10")]
			public VailActor _actor;

			// Token: 0x04002DE0 RID: 11744
			[Token(Token = "0x4002DE0")]
			[FieldOffset(Offset = "0x18")]
			public ulong _steamId;

			// Token: 0x04002DE1 RID: 11745
			[Token(Token = "0x4002DE1")]
			[FieldOffset(Offset = "0x20")]
			public PlayerRace.Race _race;

			// Token: 0x04002DE2 RID: 11746
			[Token(Token = "0x4002DE2")]
			[FieldOffset(Offset = "0x28")]
			public List<int> _clothingList;
		}
	}
}
