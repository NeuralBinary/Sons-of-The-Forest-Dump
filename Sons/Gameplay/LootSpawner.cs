using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007A6 RID: 1958
	[Token(Token = "0x20007A6")]
	[AddComponentMenu("Sons/Gameplay/LootSpawner")]
	public class LootSpawner : MonoBehaviour
	{
		// Token: 0x0600349B RID: 13467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349B")]
		[Address(RVA = "0x34CD820", Offset = "0x34CBE20", VA = "0x1834CD820")]
		private void OnEnable()
		{
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349C")]
		[Address(RVA = "0x34CD840", Offset = "0x34CBE40", VA = "0x1834CD840")]
		private static void InstantiateLootPrefab(GameObject prefab, Vector3 position, Quaternion rotation, bool dynamic)
		{
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349D")]
		[Address(RVA = "0x34CDB20", Offset = "0x34CC120", VA = "0x1834CDB20")]
		public void SpawnLoot()
		{
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349E")]
		[Address(RVA = "0x34CE0A0", Offset = "0x34CC6A0", VA = "0x1834CE0A0")]
		public static void ClientSpawnLootItem(SpawnLootItemEvent evnt)
		{
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349F")]
		[Address(RVA = "0x34CE340", Offset = "0x34CC940", VA = "0x1834CE340")]
		public LootSpawner()
		{
		}

		// Token: 0x04002D6F RID: 11631
		[Token(Token = "0x4002D6F")]
		private const float ClientSpawnMaxDistance = 80f;

		// Token: 0x04002D70 RID: 11632
		[Token(Token = "0x4002D70")]
		[FieldOffset(Offset = "0x20")]
		[ItemIdPicker(true)]
		public int _itemId;

		// Token: 0x04002D71 RID: 11633
		[Token(Token = "0x4002D71")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _spawnIsDynamic;

		// Token: 0x04002D72 RID: 11634
		[Token(Token = "0x4002D72")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _spawnLocation;

		// Token: 0x04002D73 RID: 11635
		[Token(Token = "0x4002D73")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _spawnChance;

		// Token: 0x04002D74 RID: 11636
		[Token(Token = "0x4002D74")]
		[FieldOffset(Offset = "0x34")]
		private bool _didSpawnCheck;
	}
}
