using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Atmosphere;
using Sons.Gameplay.GrabBag;
using Sons.Inventory;
using Sons.Multiplayer;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay.Gardening
{
	// Token: 0x02000710 RID: 1808
	[Token(Token = "0x2000710")]
	[AddComponentMenu("Sons/Gameplay/Gardening/GardenPlot")]
	public class GardenPlot : BoltEntityBehaviourWrapper<IGardenPlotStructureState>, IGrabBagInteractionReceiver, ISeasonsReceiver
	{
		// Token: 0x06002F1B RID: 12059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F1B")]
		[Address(RVA = "0x2E32070", Offset = "0x2E31070", VA = "0x182E32070", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F1C")]
		[Address(RVA = "0x2E33960", Offset = "0x2E32960", VA = "0x182E33960")]
		private void UpdateGrowTime()
		{
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1D")]
		[Address(RVA = "0x2E328C0", Offset = "0x2E318C0", VA = "0x182E328C0", Slot = "29")]
		public List<GrabBagCategory> GetValidGrabBagCategories()
		{
			return null;
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		[Token(Token = "0x6002F1E")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "28")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F1F")]
		[Address(RVA = "0x2E32350", Offset = "0x2E31350", VA = "0x182E32350")]
		private void Awake()
		{
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F20")]
		[Address(RVA = "0x2E32A40", Offset = "0x2E31A40", VA = "0x182E32A40")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F21")]
		[Address(RVA = "0x2E339F0", Offset = "0x2E329F0", VA = "0x182E339F0")]
		private void Update()
		{
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F22")]
		[Address(RVA = "0x2E32C80", Offset = "0x2E31C80", VA = "0x182E32C80")]
		private void OnProduceHarvested(PickUp pickup)
		{
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x0000D710 File Offset: 0x0000B910
		[Token(Token = "0x6002F23")]
		[Address(RVA = "0x2E33780", Offset = "0x2E32780", VA = "0x182E33780", Slot = "27")]
		public bool TryAddItem(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F24")]
		[Address(RVA = "0x2E32EA0", Offset = "0x2E31EA0", VA = "0x182E32EA0", Slot = "24")]
		public void OpenInteractionReceiver(GrabBagController grabBagController)
		{
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F25")]
		[Address(RVA = "0x2E339D0", Offset = "0x2E329D0", VA = "0x182E339D0", Slot = "25")]
		public void UpdateInteractionReceiver()
		{
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F26")]
		[Address(RVA = "0x2E326C0", Offset = "0x2E316C0", VA = "0x182E326C0", Slot = "26")]
		public void CloseInteractionReceiver()
		{
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F27")]
		[Address(RVA = "0x2E334B0", Offset = "0x2E324B0", VA = "0x182E334B0", Slot = "30")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x0000D728 File Offset: 0x0000B928
		[Token(Token = "0x6002F28")]
		[Address(RVA = "0x2E329B0", Offset = "0x2E319B0", VA = "0x182E329B0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F29")]
		[Address(RVA = "0x2E33770", Offset = "0x2E32770", VA = "0x182E33770")]
		public void SetIsBusy(bool isBusy)
		{
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F2A")]
		[Address(RVA = "0x2E32500", Offset = "0x2E31500", VA = "0x182E32500")]
		public void ClearPlot()
		{
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F2B")]
		[Address(RVA = "0x2E32F70", Offset = "0x2E31F70", VA = "0x182E32F70")]
		public void PlantSeedId(int seedId)
		{
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F2C")]
		[Address(RVA = "0x2E33090", Offset = "0x2E32090", VA = "0x182E33090")]
		public void PlantSeed(GardenPlotPlantGrowthData plantData)
		{
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F2D")]
		[Address(RVA = "0x2DCF010", Offset = "0x2DCE010", VA = "0x182DCF010")]
		public void InteractWithGardenPlot()
		{
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x0000D740 File Offset: 0x0000B940
		[Token(Token = "0x6002F2E")]
		[Address(RVA = "0x2E327C0", Offset = "0x2E317C0", VA = "0x182E327C0")]
		public Vector3 GetPlantPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F2F")]
		[Address(RVA = "0x2E32990", Offset = "0x2E31990", VA = "0x182E32990")]
		public void GrabEnter()
		{
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F30")]
		[Address(RVA = "0x2E329A0", Offset = "0x2E319A0", VA = "0x182E329A0")]
		public void GrabExit()
		{
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F31")]
		[Address(RVA = "0x2E32990", Offset = "0x2E31990", VA = "0x182E32990")]
		public void GrabStay()
		{
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F32")]
		[Address(RVA = "0x2E33500", Offset = "0x2E32500", VA = "0x182E33500")]
		private void SetInteractionState(bool enable)
		{
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F33")]
		[Address(RVA = "0x2DCF010", Offset = "0x2DCE010", VA = "0x182DCF010")]
		private void OnPerformedAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F34")]
		[Address(RVA = "0x2E32800", Offset = "0x2E31800", VA = "0x182E32800")]
		public GardenPlot.GardenPlotData GetSerializedData()
		{
			return null;
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F35")]
		[Address(RVA = "0x2E32780", Offset = "0x2E31780", VA = "0x182E32780")]
		public void DeserializeData(GardenPlot.GardenPlotData data)
		{
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F36")]
		[Address(RVA = "0x2E343B0", Offset = "0x2E333B0", VA = "0x182E343B0")]
		public GardenPlot()
		{
		}

		// Token: 0x040029B7 RID: 10679
		[Token(Token = "0x40029B7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GardenPlotPlantGrowthData _plantData;

		// Token: 0x040029B8 RID: 10680
		[Token(Token = "0x40029B8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _plantLocator;

		// Token: 0x040029B9 RID: 10681
		[Token(Token = "0x40029B9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _dirtPile;

		// Token: 0x040029BA RID: 10682
		[Token(Token = "0x40029BA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<GardenPlotPlantGrowthData> _validPlantData;

		// Token: 0x040029BB RID: 10683
		[Token(Token = "0x40029BB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _interactionElement;

		// Token: 0x040029BC RID: 10684
		[Token(Token = "0x40029BC")]
		[FieldOffset(Offset = "0x58")]
		private SeasonProperties _seasonProperties;

		// Token: 0x040029BD RID: 10685
		[Token(Token = "0x40029BD")]
		[FieldOffset(Offset = "0x60")]
		private GrabBagController _grabBagController;

		// Token: 0x040029BE RID: 10686
		[Token(Token = "0x40029BE")]
		[FieldOffset(Offset = "0x68")]
		private Transform _growingPlant;

		// Token: 0x040029BF RID: 10687
		[Token(Token = "0x40029BF")]
		[FieldOffset(Offset = "0x70")]
		private Transform _grownPlant;

		// Token: 0x040029C0 RID: 10688
		[Token(Token = "0x40029C0")]
		[FieldOffset(Offset = "0x78")]
		private float _growTimeSecondsRemaining;

		// Token: 0x040029C1 RID: 10689
		[Token(Token = "0x40029C1")]
		[FieldOffset(Offset = "0x7C")]
		private float _totalGrowTimeSeconds;

		// Token: 0x040029C2 RID: 10690
		[Token(Token = "0x40029C2")]
		[FieldOffset(Offset = "0x80")]
		private bool _isGrowing;

		// Token: 0x040029C3 RID: 10691
		[Token(Token = "0x40029C3")]
		[FieldOffset(Offset = "0x81")]
		private bool _isBusy;

		// Token: 0x040029C4 RID: 10692
		[Token(Token = "0x40029C4")]
		[FieldOffset(Offset = "0x82")]
		private bool _plotIsOccupied;

		// Token: 0x040029C5 RID: 10693
		[Token(Token = "0x40029C5")]
		[FieldOffset(Offset = "0x83")]
		private bool _pauseGrowth;

		// Token: 0x040029C6 RID: 10694
		[Token(Token = "0x40029C6")]
		[FieldOffset(Offset = "0x84")]
		private float _growTimeSyncDelay;

		// Token: 0x040029C7 RID: 10695
		[Token(Token = "0x40029C7")]
		[FieldOffset(Offset = "0x88")]
		private float _nextGrowTimeSync;

		// Token: 0x040029C8 RID: 10696
		[Token(Token = "0x40029C8")]
		[FieldOffset(Offset = "0x90")]
		private readonly List<GardenPlot.PickupRespawnTracker> _regrowingPickups;

		// Token: 0x02000711 RID: 1809
		[Token(Token = "0x2000711")]
		private class PickupRespawnTracker
		{
			// Token: 0x06002F38 RID: 12088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F38")]
			[Address(RVA = "0x2051CE0", Offset = "0x2050CE0", VA = "0x182051CE0")]
			public PickupRespawnTracker(PickUp pickup, float timeUntilRespawn)
			{
			}

			// Token: 0x06002F39 RID: 12089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F39")]
			[Address(RVA = "0x2E36F40", Offset = "0x2E35F40", VA = "0x182E36F40")]
			public void Update()
			{
			}

			// Token: 0x170005E1 RID: 1505
			// (get) Token: 0x06002F3A RID: 12090 RVA: 0x0000D770 File Offset: 0x0000B970
			[Token(Token = "0x170005E1")]
			public bool IsDone
			{
				[Token(Token = "0x6002F3A")]
				[Address(RVA = "0x2E36FF0", Offset = "0x2E35FF0", VA = "0x182E36FF0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x040029C9 RID: 10697
			[Token(Token = "0x40029C9")]
			[FieldOffset(Offset = "0x10")]
			private readonly PickUp _pickup;

			// Token: 0x040029CA RID: 10698
			[Token(Token = "0x40029CA")]
			[FieldOffset(Offset = "0x18")]
			private float _timeRemainingUntilRespawn;
		}

		// Token: 0x02000712 RID: 1810
		[Token(Token = "0x2000712")]
		[Serializable]
		public class GardenPlotData
		{
			// Token: 0x06002F3B RID: 12091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F3B")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public GardenPlotData()
			{
			}

			// Token: 0x040029CB RID: 10699
			[Token(Token = "0x40029CB")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public int SeedId;

			// Token: 0x040029CC RID: 10700
			[Token(Token = "0x40029CC")]
			[FieldOffset(Offset = "0x14")]
			[JsonProperty]
			public float GrowTimeSecondsRemaining;
		}
	}
}
