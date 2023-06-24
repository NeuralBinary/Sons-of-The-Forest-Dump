using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000780 RID: 1920
	[Token(Token = "0x2000780")]
	[AddComponentMenu("Sons/Gameplay/FishTrapFishSpawner")]
	public class FishTrapFishSpawner : MonoBehaviour, ISeasonsReceiver
	{
		// Token: 0x060033C2 RID: 13250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C2")]
		[Address(RVA = "0x34BE4A0", Offset = "0x34BCAA0", VA = "0x1834BE4A0")]
		private void OnEnable()
		{
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C3")]
		[Address(RVA = "0x34BE5B0", Offset = "0x34BCBB0", VA = "0x1834BE5B0")]
		private void ResetSpawnTime()
		{
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C4")]
		[Address(RVA = "0x34BE6E0", Offset = "0x34BCCE0", VA = "0x1834BE6E0")]
		private void OnDisable()
		{
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C5")]
		[Address(RVA = "0x34BE730", Offset = "0x34BCD30", VA = "0x1834BE730")]
		private void Update()
		{
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C6")]
		[Address(RVA = "0x34BE800", Offset = "0x34BCE00", VA = "0x1834BE800")]
		private void SpawnFish()
		{
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C7")]
		[Address(RVA = "0x34BEA70", Offset = "0x34BD070", VA = "0x1834BEA70", Slot = "4")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C8")]
		[Address(RVA = "0x34BEAF0", Offset = "0x34BD0F0", VA = "0x1834BEAF0")]
		public FishTrapFishSpawner()
		{
		}

		// Token: 0x04002CC6 RID: 11462
		[Token(Token = "0x4002CC6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InWorldLayoutItemGroup _inWorldLayoutItemGroup;

		// Token: 0x04002CC7 RID: 11463
		[Token(Token = "0x4002CC7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _waterDetectionTransform;

		// Token: 0x04002CC8 RID: 11464
		[Token(Token = "0x4002CC8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _timeToSpawnInGameMinutes;

		// Token: 0x04002CC9 RID: 11465
		[Token(Token = "0x4002CC9")]
		[FieldOffset(Offset = "0x38")]
		private System.Random _random;

		// Token: 0x04002CCA RID: 11466
		[Token(Token = "0x4002CCA")]
		[FieldOffset(Offset = "0x40")]
		private float _timeRemainingUntilSpawn;

		// Token: 0x04002CCB RID: 11467
		[Token(Token = "0x4002CCB")]
		[FieldOffset(Offset = "0x44")]
		private bool _allowSpawning;
	}
}
