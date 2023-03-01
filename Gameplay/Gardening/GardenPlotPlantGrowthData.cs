using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay.Gardening
{
	// Token: 0x02000716 RID: 1814
	[Token(Token = "0x2000716")]
	[CreateAssetMenu(fileName = "NewGardenPlotPlantGrowthData", menuName = "Sons/Data/Gardening/GardenPlotPlantGrowthData", order = 0)]
	public class GardenPlotPlantGrowthData : ScriptableObject
	{
		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06002F43 RID: 12099 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		[Token(Token = "0x170005E2")]
		public GardenPlotPlantGrowthData.HarvestType GetHarvestType
		{
			[Token(Token = "0x6002F43")]
			[Address(RVA = "0x63DF30", Offset = "0x63CF30", VA = "0x18063DF30")]
			get
			{
				return GardenPlotPlantGrowthData.HarvestType.EntirePlant;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06002F44 RID: 12100 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		[Token(Token = "0x170005E3")]
		public float ProduceGrowTimeDays
		{
			[Token(Token = "0x6002F44")]
			[Address(RVA = "0x2004010", Offset = "0x2003010", VA = "0x182004010")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06002F45 RID: 12101 RVA: 0x0000D800 File Offset: 0x0000BA00
		[Token(Token = "0x170005E4")]
		public float SeedlingScale
		{
			[Token(Token = "0x6002F45")]
			[Address(RVA = "0x8A27B0", Offset = "0x8A17B0", VA = "0x1808A27B0")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06002F46 RID: 12102 RVA: 0x0000D818 File Offset: 0x0000BA18
		[Token(Token = "0x170005E5")]
		public int SeedItemId
		{
			[Token(Token = "0x6002F46")]
			[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06002F47 RID: 12103 RVA: 0x0000D830 File Offset: 0x0000BA30
		[Token(Token = "0x170005E6")]
		public float GrowTimeGameDays
		{
			[Token(Token = "0x6002F47")]
			[Address(RVA = "0x5A1700", Offset = "0x5A0700", VA = "0x1805A1700")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06002F48 RID: 12104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E7")]
		public GameObject GrowingPlantPrefab
		{
			[Token(Token = "0x6002F48")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06002F49 RID: 12105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E8")]
		public GameObject GrownPlantPrefab
		{
			[Token(Token = "0x6002F49")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F4A")]
		[Address(RVA = "0x2E31600", Offset = "0x2E30600", VA = "0x182E31600")]
		public GardenPlotPlantGrowthData()
		{
		}

		// Token: 0x040029D1 RID: 10705
		[Token(Token = "0x40029D1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _seedItemId;

		// Token: 0x040029D2 RID: 10706
		[Token(Token = "0x40029D2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _growingPlantPrefab;

		// Token: 0x040029D3 RID: 10707
		[Token(Token = "0x40029D3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _grownPlantPrefab;

		// Token: 0x040029D4 RID: 10708
		[Token(Token = "0x40029D4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Min(0f)]
		private float _seedlingScale;

		// Token: 0x040029D5 RID: 10709
		[Token(Token = "0x40029D5")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Min(0f)]
		private float _timeToGrowGameDays;

		// Token: 0x040029D6 RID: 10710
		[Token(Token = "0x40029D6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GardenPlotPlantGrowthData.HarvestType _harvestType;

		// Token: 0x040029D7 RID: 10711
		[Token(Token = "0x40029D7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _produceGrowTimeDays;

		// Token: 0x02000717 RID: 1815
		[Token(Token = "0x2000717")]
		public enum HarvestType
		{
			// Token: 0x040029D9 RID: 10713
			[Token(Token = "0x40029D9")]
			EntirePlant,
			// Token: 0x040029DA RID: 10714
			[Token(Token = "0x40029DA")]
			Produce
		}
	}
}
