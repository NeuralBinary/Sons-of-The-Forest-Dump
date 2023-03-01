using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000636 RID: 1590
	[Token(Token = "0x2000636")]
	[CreateAssetMenu(fileName = "NewContainerItemSpawnerData", menuName = "Sons/ContainerItemSpawnerData")]
	public class ContainerItemSpawnerData : ScriptableObject
	{
		// Token: 0x060028D0 RID: 10448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D0")]
		[Address(RVA = "0x2DB2780", Offset = "0x2DB1780", VA = "0x182DB2780")]
		private void SortItemsByChance()
		{
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060028D1 RID: 10449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700055F")]
		private static Random SharedRandom
		{
			[Token(Token = "0x60028D1")]
			[Address(RVA = "0x2DB3450", Offset = "0x2DB2450", VA = "0x182DB3450")]
			get
			{
				return null;
			}
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x0000BD18 File Offset: 0x00009F18
		[Token(Token = "0x60028D2")]
		[Address(RVA = "0x2DB23C0", Offset = "0x2DB13C0", VA = "0x182DB23C0")]
		public int GetSeed()
		{
			return default(int);
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D3")]
		[Address(RVA = "0x2DB24D0", Offset = "0x2DB14D0", VA = "0x182DB24D0")]
		private void OnValidate()
		{
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D4")]
		[Address(RVA = "0x2DB2280", Offset = "0x2DB1280", VA = "0x182DB2280")]
		public IEnumerable<int> GetRandomizedContents()
		{
			return null;
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D5")]
		[Address(RVA = "0x2DB1CE0", Offset = "0x2DB0CE0", VA = "0x182DB1CE0")]
		private IEnumerable<GameObject> GetItemsToSpawn(int contentsSeed = -1)
		{
			return null;
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D6")]
		[Address(RVA = "0x2DB1E20", Offset = "0x2DB0E20", VA = "0x182DB1E20")]
		private IEnumerable<ContainerItemSpawnerData.PickupItemAndSpawnWeight> GetRandomizedContentsInternal(int contentsSeed = -1)
		{
			return null;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D7")]
		[Address(RVA = "0x2DB29B0", Offset = "0x2DB19B0", VA = "0x182DB29B0")]
		public void SpawnItems(Vector3 position)
		{
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D8")]
		[Address(RVA = "0x2DB28A0", Offset = "0x2DB18A0", VA = "0x182DB28A0")]
		public void SpawnItems(Transform spawnLocator, out List<GameObject> result, Vector3 randomOffset, Vector3 randomRotation, int contentsSeed = -1)
		{
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D9")]
		[Address(RVA = "0x2DB2AA0", Offset = "0x2DB1AA0", VA = "0x182DB2AA0")]
		public void SpawnItems(Vector3 position, Quaternion rotation, out List<GameObject> result, Vector3 randomOffset, Vector3 randomRotation, int contentsSeed = -1, bool setDynamic = true)
		{
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x0000BD30 File Offset: 0x00009F30
		[Token(Token = "0x60028DA")]
		[Address(RVA = "0x2DB2430", Offset = "0x2DB1430", VA = "0x182DB2430")]
		private bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028DB")]
		[Address(RVA = "0x2DB3390", Offset = "0x2DB2390", VA = "0x182DB3390")]
		public ContainerItemSpawnerData()
		{
		}

		// Token: 0x04002481 RID: 9345
		[Token(Token = "0x4002481")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 _randomOffset;

		// Token: 0x04002482 RID: 9346
		[Token(Token = "0x4002482")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 _randomRotation;

		// Token: 0x04002483 RID: 9347
		[Token(Token = "0x4002483")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _spawnDynamic;

		// Token: 0x04002484 RID: 9348
		[Token(Token = "0x4002484")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 100f)]
		[SerializeField]
		private float _emptyChance;

		// Token: 0x04002485 RID: 9349
		[Token(Token = "0x4002485")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _doNotAllowDuplicates;

		// Token: 0x04002486 RID: 9350
		[Token(Token = "0x4002486")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector2Int _countRange;

		// Token: 0x04002487 RID: 9351
		[Token(Token = "0x4002487")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int _maxWeight;

		// Token: 0x04002488 RID: 9352
		[Token(Token = "0x4002488")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<ContainerItemSpawnerData.PickupItemAndSpawnWeight> _items;

		// Token: 0x04002489 RID: 9353
		[Token(Token = "0x4002489")]
		[FieldOffset(Offset = "0x0")]
		private static Random _random;

		// Token: 0x02000637 RID: 1591
		[Token(Token = "0x2000637")]
		[Serializable]
		private class PickupItemAndSpawnWeight
		{
			// Token: 0x060028DD RID: 10461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60028DD")]
			[Address(RVA = "0x5ED130", Offset = "0x5EC130", VA = "0x1805ED130")]
			public void SetMaxWeight(int value)
			{
			}

			// Token: 0x060028DE RID: 10462 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60028DE")]
			[Address(RVA = "0x2DC21D0", Offset = "0x2DC11D0", VA = "0x182DC21D0")]
			public string SetChanceReadOut(string value)
			{
				return null;
			}

			// Token: 0x060028DF RID: 10463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60028DF")]
			[Address(RVA = "0x2DC21F0", Offset = "0x2DC11F0", VA = "0x182DC21F0")]
			public PickupItemAndSpawnWeight()
			{
			}

			// Token: 0x0400248A RID: 9354
			[Token(Token = "0x400248A")]
			[FieldOffset(Offset = "0x10")]
			[ItemIdPicker(true)]
			public int _id;

			// Token: 0x0400248B RID: 9355
			[Token(Token = "0x400248B")]
			[FieldOffset(Offset = "0x18")]
			public GameObject _item;

			// Token: 0x0400248C RID: 9356
			[Token(Token = "0x400248C")]
			[FieldOffset(Offset = "0x20")]
			private string _chanceReadOut;

			// Token: 0x0400248D RID: 9357
			[Token(Token = "0x400248D")]
			[FieldOffset(Offset = "0x28")]
			[Range(1f, 1000f)]
			public int _weight;

			// Token: 0x0400248E RID: 9358
			[Token(Token = "0x400248E")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			[HideInInspector]
			private int _maxWeight;
		}
	}
}
