using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Atmosphere;
using Sons.Gameplay.GrabBag;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay.Gardening
{
	// Token: 0x0200085E RID: 2142
	[Token(Token = "0x200085E")]
	[AddComponentMenu("Sons/Gameplay/Gardening/GardenPlot")]
	public class GardenPlot : EntityBehaviour<IGardenPlotStructureState>, IGrabBagInteractionReceiver, ISeasonsReceiver
	{
		// Token: 0x06003D17 RID: 15639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D17")]
		[Address(RVA = "0x35B60C0", Offset = "0x35B46C0", VA = "0x1835B60C0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D18")]
		[Address(RVA = "0x35B64E0", Offset = "0x35B4AE0", VA = "0x1835B64E0")]
		private void UpdateGrowTime()
		{
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D19")]
		[Address(RVA = "0x35B6580", Offset = "0x35B4B80", VA = "0x1835B6580", Slot = "29")]
		public List<GrabBagCategory> GetValidGrabBagCategories()
		{
			return null;
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x000129C0 File Offset: 0x00010BC0
		[Token(Token = "0x6003D1A")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "28")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D1B")]
		[Address(RVA = "0x35B6650", Offset = "0x35B4C50", VA = "0x1835B6650")]
		private void Awake()
		{
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D1C")]
		[Address(RVA = "0x35B67E0", Offset = "0x35B4DE0", VA = "0x1835B67E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D1D")]
		[Address(RVA = "0x35B6A80", Offset = "0x35B5080", VA = "0x1835B6A80")]
		private void Update()
		{
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D1E")]
		[Address(RVA = "0x35B78D0", Offset = "0x35B5ED0", VA = "0x1835B78D0")]
		private void OnProduceHarvested(PickUp pickup)
		{
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x000129D8 File Offset: 0x00010BD8
		[Token(Token = "0x6003D1F")]
		[Address(RVA = "0x35B7B60", Offset = "0x35B6160", VA = "0x1835B7B60", Slot = "27")]
		public bool TryAddItem(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D20")]
		[Address(RVA = "0x35B7E20", Offset = "0x35B6420", VA = "0x1835B7E20", Slot = "24")]
		public void OpenInteractionReceiver(GrabBagController grabBagController)
		{
		}

		// Token: 0x06003D21 RID: 15649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D21")]
		[Address(RVA = "0x35B8010", Offset = "0x35B6610", VA = "0x1835B8010", Slot = "25")]
		public void UpdateInteractionReceiver()
		{
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D22")]
		[Address(RVA = "0x35B8030", Offset = "0x35B6630", VA = "0x1835B8030", Slot = "26")]
		public void CloseInteractionReceiver()
		{
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D23")]
		[Address(RVA = "0x35B80F0", Offset = "0x35B66F0", VA = "0x1835B80F0", Slot = "30")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x000129F0 File Offset: 0x00010BF0
		[Token(Token = "0x6003D24")]
		[Address(RVA = "0x35B8160", Offset = "0x35B6760", VA = "0x1835B8160")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D25")]
		[Address(RVA = "0x35B82C0", Offset = "0x35B68C0", VA = "0x1835B82C0")]
		public void SetIsBusy(bool isBusy)
		{
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D26")]
		[Address(RVA = "0x35B82D0", Offset = "0x35B68D0", VA = "0x1835B82D0")]
		public void ClearPlot()
		{
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D27")]
		[Address(RVA = "0x35B86F0", Offset = "0x35B6CF0", VA = "0x1835B86F0")]
		public void PlantSeedId(int seedId)
		{
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D28")]
		[Address(RVA = "0x35B8870", Offset = "0x35B6E70", VA = "0x1835B8870")]
		public void PlantSeed(GardenPlotPlantGrowthData plantData)
		{
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D29")]
		[Address(RVA = "0x35B9020", Offset = "0x35B7620", VA = "0x1835B9020")]
		public void InteractWithGardenPlot()
		{
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x00012A08 File Offset: 0x00010C08
		[Token(Token = "0x6003D2A")]
		[Address(RVA = "0x35B9170", Offset = "0x35B7770", VA = "0x1835B9170")]
		public Vector3 GetPlantPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D2B")]
		[Address(RVA = "0x35B9200", Offset = "0x35B7800", VA = "0x1835B9200")]
		public void GrabEnter()
		{
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D2C")]
		[Address(RVA = "0x35B9210", Offset = "0x35B7810", VA = "0x1835B9210")]
		public void GrabExit()
		{
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D2D")]
		[Address(RVA = "0x35B9200", Offset = "0x35B7800", VA = "0x1835B9200")]
		public void GrabStay()
		{
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D2E")]
		[Address(RVA = "0x35B9220", Offset = "0x35B7820", VA = "0x1835B9220")]
		private void SetInteractionState(bool enable)
		{
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D2F")]
		[Address(RVA = "0x35B9580", Offset = "0x35B7B80", VA = "0x1835B9580")]
		private void OnPerformedAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D30")]
		[Address(RVA = "0x35B9810", Offset = "0x35B7E10", VA = "0x1835B9810")]
		public GardenPlot.GardenPlotData GetSerializedData()
		{
			return null;
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D31")]
		[Address(RVA = "0x35B9920", Offset = "0x35B7F20", VA = "0x1835B9920")]
		public void DeserializeData(GardenPlot.GardenPlotData data)
		{
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D32")]
		[Address(RVA = "0x35B9960", Offset = "0x35B7F60", VA = "0x1835B9960")]
		public GardenPlot()
		{
		}

		// Token: 0x040033A1 RID: 13217
		[Token(Token = "0x40033A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GardenPlotPlantGrowthData _plantData;

		// Token: 0x040033A2 RID: 13218
		[Token(Token = "0x40033A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _plantLocator;

		// Token: 0x040033A3 RID: 13219
		[Token(Token = "0x40033A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _dirtPile;

		// Token: 0x040033A4 RID: 13220
		[Token(Token = "0x40033A4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GardenPlotPlantGrowthData> _validPlantData;

		// Token: 0x040033A5 RID: 13221
		[Token(Token = "0x40033A5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _interactionElement;

		// Token: 0x040033A6 RID: 13222
		[Token(Token = "0x40033A6")]
		[FieldOffset(Offset = "0x50")]
		private SeasonProperties _seasonProperties;

		// Token: 0x040033A7 RID: 13223
		[Token(Token = "0x40033A7")]
		[FieldOffset(Offset = "0x58")]
		private GrabBagController _grabBagController;

		// Token: 0x040033A8 RID: 13224
		[Token(Token = "0x40033A8")]
		[FieldOffset(Offset = "0x60")]
		private Transform _growingPlant;

		// Token: 0x040033A9 RID: 13225
		[Token(Token = "0x40033A9")]
		[FieldOffset(Offset = "0x68")]
		private Transform _grownPlant;

		// Token: 0x040033AA RID: 13226
		[Token(Token = "0x40033AA")]
		[FieldOffset(Offset = "0x70")]
		private float _growTimeSecondsRemaining;

		// Token: 0x040033AB RID: 13227
		[Token(Token = "0x40033AB")]
		[FieldOffset(Offset = "0x74")]
		private float _totalGrowTimeSeconds;

		// Token: 0x040033AC RID: 13228
		[Token(Token = "0x40033AC")]
		[FieldOffset(Offset = "0x78")]
		private bool _isGrowing;

		// Token: 0x040033AD RID: 13229
		[Token(Token = "0x40033AD")]
		[FieldOffset(Offset = "0x79")]
		private bool _isBusy;

		// Token: 0x040033AE RID: 13230
		[Token(Token = "0x40033AE")]
		[FieldOffset(Offset = "0x7A")]
		private bool _plotIsOccupied;

		// Token: 0x040033AF RID: 13231
		[Token(Token = "0x40033AF")]
		[FieldOffset(Offset = "0x7B")]
		private bool _pauseGrowth;

		// Token: 0x040033B0 RID: 13232
		[Token(Token = "0x40033B0")]
		[FieldOffset(Offset = "0x7C")]
		private float _growTimeSyncDelay;

		// Token: 0x040033B1 RID: 13233
		[Token(Token = "0x40033B1")]
		[FieldOffset(Offset = "0x80")]
		private float _nextGrowTimeSync;

		// Token: 0x040033B2 RID: 13234
		[Token(Token = "0x40033B2")]
		[FieldOffset(Offset = "0x88")]
		private readonly List<GardenPlot.PickupRespawnTracker> _regrowingPickups;

		// Token: 0x0200085F RID: 2143
		[Token(Token = "0x200085F")]
		private class PickupRespawnTracker
		{
			// Token: 0x06003D34 RID: 15668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D34")]
			[Address(RVA = "0x24033C0", Offset = "0x24019C0", VA = "0x1824033C0")]
			public PickupRespawnTracker(PickUp pickup, float timeUntilRespawn)
			{
			}

			// Token: 0x06003D35 RID: 15669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D35")]
			[Address(RVA = "0x35B9B20", Offset = "0x35B8120", VA = "0x1835B9B20")]
			public void Update()
			{
			}

			// Token: 0x170007E4 RID: 2020
			// (get) Token: 0x06003D36 RID: 15670 RVA: 0x00012A38 File Offset: 0x00010C38
			[Token(Token = "0x170007E4")]
			public bool IsDone
			{
				[Token(Token = "0x6003D36")]
				[Address(RVA = "0x35B9BD0", Offset = "0x35B81D0", VA = "0x1835B9BD0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x040033B3 RID: 13235
			[Token(Token = "0x40033B3")]
			[FieldOffset(Offset = "0x10")]
			private readonly PickUp _pickup;

			// Token: 0x040033B4 RID: 13236
			[Token(Token = "0x40033B4")]
			[FieldOffset(Offset = "0x18")]
			private float _timeRemainingUntilRespawn;
		}

		// Token: 0x02000860 RID: 2144
		[Token(Token = "0x2000860")]
		[Serializable]
		public class GardenPlotData
		{
			// Token: 0x06003D37 RID: 15671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D37")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public GardenPlotData()
			{
			}

			// Token: 0x040033B5 RID: 13237
			[Token(Token = "0x40033B5")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public int SeedId;

			// Token: 0x040033B6 RID: 13238
			[Token(Token = "0x40033B6")]
			[FieldOffset(Offset = "0x14")]
			[JsonProperty]
			public float GrowTimeSecondsRemaining;
		}
	}
}
