using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000684 RID: 1668
	[Token(Token = "0x2000684")]
	[AddComponentMenu("Sons/Gameplay/LootSpawner")]
	public class LootSpawner : MonoBehaviour
	{
		// Token: 0x06002A8E RID: 10894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8E")]
		[Address(RVA = "0x2DD2480", Offset = "0x2DD1480", VA = "0x182DD2480")]
		private void OnEnable()
		{
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8F")]
		[Address(RVA = "0x2DD22C0", Offset = "0x2DD12C0", VA = "0x182DD22C0")]
		private static void InstantiateLootPrefab(GameObject prefab, Vector3 position, Quaternion rotation, bool dynamic)
		{
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A90")]
		[Address(RVA = "0x2DD24A0", Offset = "0x2DD14A0", VA = "0x182DD24A0")]
		public void SpawnLoot()
		{
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A91")]
		[Address(RVA = "0x2DD2120", Offset = "0x2DD1120", VA = "0x182DD2120")]
		public static void ClientSpawnLootItem(SpawnLootItemEvent evnt)
		{
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A92")]
		[Address(RVA = "0x2DD26F0", Offset = "0x2DD16F0", VA = "0x182DD26F0")]
		public LootSpawner()
		{
		}

		// Token: 0x0400260E RID: 9742
		[Token(Token = "0x400260E")]
		private const float ClientSpawnMaxDistance = 80f;

		// Token: 0x0400260F RID: 9743
		[Token(Token = "0x400260F")]
		[FieldOffset(Offset = "0x20")]
		[ItemIdPicker(true)]
		public int _itemId;

		// Token: 0x04002610 RID: 9744
		[Token(Token = "0x4002610")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _spawnIsDynamic;

		// Token: 0x04002611 RID: 9745
		[Token(Token = "0x4002611")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _spawnLocation;

		// Token: 0x04002612 RID: 9746
		[Token(Token = "0x4002612")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _spawnChance;

		// Token: 0x04002613 RID: 9747
		[Token(Token = "0x4002613")]
		[FieldOffset(Offset = "0x34")]
		private bool _didSpawnCheck;
	}
}
