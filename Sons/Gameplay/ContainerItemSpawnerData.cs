using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000752 RID: 1874
	[Token(Token = "0x2000752")]
	[CreateAssetMenu(fileName = "NewContainerItemSpawnerData", menuName = "Sons/ContainerItemSpawnerData")]
	public class ContainerItemSpawnerData : ScriptableObject
	{
		// Token: 0x060032AC RID: 12972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032AC")]
		[Address(RVA = "0x34A8330", Offset = "0x34A6930", VA = "0x1834A8330")]
		private void SortItemsByChance()
		{
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060032AD RID: 12973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068B")]
		private static System.Random SharedRandom
		{
			[Token(Token = "0x60032AD")]
			[Address(RVA = "0x34A8490", Offset = "0x34A6A90", VA = "0x1834A8490")]
			get
			{
				return null;
			}
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		[Token(Token = "0x60032AE")]
		[Address(RVA = "0x34A8610", Offset = "0x34A6C10", VA = "0x1834A8610")]
		public int GetSeed()
		{
			return 0;
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032AF")]
		[Address(RVA = "0x34A8680", Offset = "0x34A6C80", VA = "0x1834A8680")]
		private void OnValidate()
		{
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B0")]
		[Address(RVA = "0x34A8A10", Offset = "0x34A7010", VA = "0x1834A8A10")]
		public IEnumerable<int> GetRandomizedContents()
		{
			return null;
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B1")]
		[Address(RVA = "0x34A8C00", Offset = "0x34A7200", VA = "0x1834A8C00")]
		private IEnumerable<GameObject> GetItemsToSpawn(int contentsSeed = -1)
		{
			return null;
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B2")]
		[Address(RVA = "0x34A8DF0", Offset = "0x34A73F0", VA = "0x1834A8DF0")]
		private IEnumerable<ContainerItemSpawnerData.PickupItemAndSpawnWeight> GetRandomizedContentsInternal(int contentsSeed = -1)
		{
			return null;
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032B3")]
		[Address(RVA = "0x34A9380", Offset = "0x34A7980", VA = "0x1834A9380")]
		public void SpawnItems(Vector3 position)
		{
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032B4")]
		[Address(RVA = "0x34A9470", Offset = "0x34A7A70", VA = "0x1834A9470")]
		public void SpawnItems(Transform spawnLocator, out List<GameObject> result, Vector3 randomOffset, Vector3 randomRotation, int contentsSeed = -1)
		{
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032B5")]
		[Address(RVA = "0x34A9610", Offset = "0x34A7C10", VA = "0x1834A9610")]
		public void SpawnItems(Vector3 position, Quaternion rotation, out List<GameObject> result, Vector3 randomOffset, Vector3 randomRotation, int contentsSeed = -1, bool setDynamic = true)
		{
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		[Token(Token = "0x60032B6")]
		[Address(RVA = "0x34AA1E0", Offset = "0x34A87E0", VA = "0x1834AA1E0")]
		private bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032B7")]
		[Address(RVA = "0x34AA280", Offset = "0x34A8880", VA = "0x1834AA280")]
		public ContainerItemSpawnerData()
		{
		}

		// Token: 0x04002BC4 RID: 11204
		[Token(Token = "0x4002BC4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 _randomOffset;

		// Token: 0x04002BC5 RID: 11205
		[Token(Token = "0x4002BC5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 _randomRotation;

		// Token: 0x04002BC6 RID: 11206
		[Token(Token = "0x4002BC6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _spawnDynamic;

		// Token: 0x04002BC7 RID: 11207
		[Token(Token = "0x4002BC7")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Range(0f, 100f)]
		private float _emptyChance;

		// Token: 0x04002BC8 RID: 11208
		[Token(Token = "0x4002BC8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _doNotAllowDuplicates;

		// Token: 0x04002BC9 RID: 11209
		[Token(Token = "0x4002BC9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector2Int _countRange;

		// Token: 0x04002BCA RID: 11210
		[Token(Token = "0x4002BCA")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int _maxWeight;

		// Token: 0x04002BCB RID: 11211
		[Token(Token = "0x4002BCB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<ContainerItemSpawnerData.PickupItemAndSpawnWeight> _items;

		// Token: 0x04002BCC RID: 11212
		[Token(Token = "0x4002BCC")]
		[FieldOffset(Offset = "0x0")]
		private static System.Random _random;

		// Token: 0x02000753 RID: 1875
		[Token(Token = "0x2000753")]
		[Serializable]
		private class PickupItemAndSpawnWeight
		{
			// Token: 0x060032B9 RID: 12985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60032B9")]
			[Address(RVA = "0x674030", Offset = "0x672630", VA = "0x180674030")]
			public void SetMaxWeight(int value)
			{
			}

			// Token: 0x060032BA RID: 12986 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60032BA")]
			[Address(RVA = "0x34AA470", Offset = "0x34A8A70", VA = "0x1834AA470")]
			public string SetChanceReadOut(string value)
			{
				return null;
			}

			// Token: 0x060032BB RID: 12987 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60032BB")]
			[Address(RVA = "0x34AA4D0", Offset = "0x34A8AD0", VA = "0x1834AA4D0")]
			public PickupItemAndSpawnWeight()
			{
			}

			// Token: 0x04002BCD RID: 11213
			[Token(Token = "0x4002BCD")]
			[FieldOffset(Offset = "0x10")]
			[ItemIdPicker(true)]
			public int _id;

			// Token: 0x04002BCE RID: 11214
			[Token(Token = "0x4002BCE")]
			[FieldOffset(Offset = "0x18")]
			public GameObject _item;

			// Token: 0x04002BCF RID: 11215
			[Token(Token = "0x4002BCF")]
			[FieldOffset(Offset = "0x20")]
			private string _chanceReadOut;

			// Token: 0x04002BD0 RID: 11216
			[Token(Token = "0x4002BD0")]
			[FieldOffset(Offset = "0x28")]
			[Range(1f, 1000f)]
			public int _weight;

			// Token: 0x04002BD1 RID: 11217
			[Token(Token = "0x4002BD1")]
			[FieldOffset(Offset = "0x2C")]
			[HideInInspector]
			[SerializeField]
			private int _maxWeight;
		}
	}
}
