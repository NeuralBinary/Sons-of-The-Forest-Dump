using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay.Gardening
{
	// Token: 0x02000864 RID: 2148
	[Token(Token = "0x2000864")]
	[CreateAssetMenu(fileName = "NewGardenPlotPlantGrowthData", menuName = "Sons/Data/Gardening/GardenPlotPlantGrowthData", order = 0)]
	public class GardenPlotPlantGrowthData : ScriptableObject
	{
		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06003D3F RID: 15679 RVA: 0x00012A98 File Offset: 0x00010C98
		[Token(Token = "0x170007E5")]
		public GardenPlotPlantGrowthData.HarvestType GetHarvestType
		{
			[Token(Token = "0x6003D3F")]
			[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
			get
			{
				return GardenPlotPlantGrowthData.HarvestType.EntirePlant;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06003D40 RID: 15680 RVA: 0x00012AB0 File Offset: 0x00010CB0
		[Token(Token = "0x170007E6")]
		public float ProduceGrowTimeDays
		{
			[Token(Token = "0x6003D40")]
			[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06003D41 RID: 15681 RVA: 0x00012AC8 File Offset: 0x00010CC8
		[Token(Token = "0x170007E7")]
		public float SeedlingScale
		{
			[Token(Token = "0x6003D41")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06003D42 RID: 15682 RVA: 0x00012AE0 File Offset: 0x00010CE0
		[Token(Token = "0x170007E8")]
		public int SeedItemId
		{
			[Token(Token = "0x6003D42")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06003D43 RID: 15683 RVA: 0x00012AF8 File Offset: 0x00010CF8
		[Token(Token = "0x170007E9")]
		public float GrowTimeGameDays
		{
			[Token(Token = "0x6003D43")]
			[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06003D44 RID: 15684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007EA")]
		public GameObject GrowingPlantPrefab
		{
			[Token(Token = "0x6003D44")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06003D45 RID: 15685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007EB")]
		public GameObject GrownPlantPrefab
		{
			[Token(Token = "0x6003D45")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D46")]
		[Address(RVA = "0x35B9CE0", Offset = "0x35B82E0", VA = "0x1835B9CE0")]
		public GardenPlotPlantGrowthData()
		{
		}

		// Token: 0x040033BB RID: 13243
		[Token(Token = "0x40033BB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _seedItemId;

		// Token: 0x040033BC RID: 13244
		[Token(Token = "0x40033BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _growingPlantPrefab;

		// Token: 0x040033BD RID: 13245
		[Token(Token = "0x40033BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _grownPlantPrefab;

		// Token: 0x040033BE RID: 13246
		[Token(Token = "0x40033BE")]
		[FieldOffset(Offset = "0x30")]
		[Min(0f)]
		[SerializeField]
		private float _seedlingScale;

		// Token: 0x040033BF RID: 13247
		[Token(Token = "0x40033BF")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Min(0f)]
		private float _timeToGrowGameDays;

		// Token: 0x040033C0 RID: 13248
		[Token(Token = "0x40033C0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GardenPlotPlantGrowthData.HarvestType _harvestType;

		// Token: 0x040033C1 RID: 13249
		[Token(Token = "0x40033C1")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _produceGrowTimeDays;

		// Token: 0x02000865 RID: 2149
		[Token(Token = "0x2000865")]
		public enum HarvestType
		{
			// Token: 0x040033C3 RID: 13251
			[Token(Token = "0x40033C3")]
			EntirePlant,
			// Token: 0x040033C4 RID: 13252
			[Token(Token = "0x40033C4")]
			Produce
		}
	}
}
