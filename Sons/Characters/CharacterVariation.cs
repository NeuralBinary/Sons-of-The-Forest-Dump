using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020006FE RID: 1790
	[Token(Token = "0x20006FE")]
	[Serializable]
	public class CharacterVariation
	{
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002F52 RID: 12114 RVA: 0x0000E208 File Offset: 0x0000C408
		[Token(Token = "0x1700065F")]
		public int SpawnChance
		{
			[Token(Token = "0x6002F52")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002F53 RID: 12115 RVA: 0x0000E220 File Offset: 0x0000C420
		[Token(Token = "0x17000660")]
		public int ForceCount
		{
			[Token(Token = "0x6002F53")]
			[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06002F54 RID: 12116 RVA: 0x0000E238 File Offset: 0x0000C438
		[Token(Token = "0x17000661")]
		public bool SkipRandom
		{
			[Token(Token = "0x6002F54")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F55")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x0000E250 File Offset: 0x0000C450
		[Token(Token = "0x6002F56")]
		[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
		public int GetVariationId()
		{
			return 0;
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x0000E268 File Offset: 0x0000C468
		[Token(Token = "0x6002F57")]
		[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
		public VariationSet.Subset GetVariationSubset()
		{
			return VariationSet.Subset.Any;
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F58")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		public GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F59")]
		[Address(RVA = "0x345E750", Offset = "0x345CD50", VA = "0x18345E750")]
		public VailActor GetActorPrefab()
		{
			return null;
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F5A")]
		[Address(RVA = "0x345E7A0", Offset = "0x345CDA0", VA = "0x18345E7A0")]
		public CharacterVariation()
		{
		}

		// Token: 0x040028F3 RID: 10483
		[Token(Token = "0x40028F3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _id;

		// Token: 0x040028F4 RID: 10484
		[Token(Token = "0x40028F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x040028F5 RID: 10485
		[Token(Token = "0x40028F5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _variationId;

		// Token: 0x040028F6 RID: 10486
		[Token(Token = "0x40028F6")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private VariationSet.Subset _subset;

		// Token: 0x040028F7 RID: 10487
		[Token(Token = "0x40028F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _skipInRandom;

		// Token: 0x040028F8 RID: 10488
		[Token(Token = "0x40028F8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _forceCount;

		// Token: 0x040028F9 RID: 10489
		[Token(Token = "0x40028F9")]
		[FieldOffset(Offset = "0x30")]
		[Min(1f)]
		[SerializeField]
		private int _spawnChance;
	}
}
