using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020007F1 RID: 2033
	[Token(Token = "0x20007F1")]
	[Serializable]
	public class CharacterVariation
	{
		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060035B2 RID: 13746 RVA: 0x0000F780 File Offset: 0x0000D980
		[Token(Token = "0x170006EA")]
		public int SpawnChance
		{
			[Token(Token = "0x60035B2")]
			[Address(RVA = "0x5CEF60", Offset = "0x5CDF60", VA = "0x1805CEF60")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060035B3 RID: 13747 RVA: 0x0000F798 File Offset: 0x0000D998
		[Token(Token = "0x170006EB")]
		public int ForceCount
		{
			[Token(Token = "0x60035B3")]
			[Address(RVA = "0x5ED0E0", Offset = "0x5EC0E0", VA = "0x1805ED0E0")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060035B4 RID: 13748 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		[Token(Token = "0x170006EC")]
		public bool SkipRandom
		{
			[Token(Token = "0x60035B4")]
			[Address(RVA = "0x5BA880", Offset = "0x5B9880", VA = "0x1805BA880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B5")]
		[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		[Token(Token = "0x60035B6")]
		[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
		public int GetVariationId()
		{
			return default(int);
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		[Token(Token = "0x60035B7")]
		[Address(RVA = "0x6C5570", Offset = "0x6C4570", VA = "0x1806C5570")]
		public VariationSet.Subset GetVariationSubset()
		{
			return VariationSet.Subset.Any;
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B8")]
		[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
		public GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B9")]
		[Address(RVA = "0x2E90150", Offset = "0x2E8F150", VA = "0x182E90150")]
		public VailActor GetActorPrefab()
		{
			return null;
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BA")]
		[Address(RVA = "0x2E901A0", Offset = "0x2E8F1A0", VA = "0x182E901A0")]
		public CharacterVariation()
		{
		}

		// Token: 0x04002E07 RID: 11783
		[Token(Token = "0x4002E07")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _id;

		// Token: 0x04002E08 RID: 11784
		[Token(Token = "0x4002E08")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x04002E09 RID: 11785
		[Token(Token = "0x4002E09")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _variationId;

		// Token: 0x04002E0A RID: 11786
		[Token(Token = "0x4002E0A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private VariationSet.Subset _subset;

		// Token: 0x04002E0B RID: 11787
		[Token(Token = "0x4002E0B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _skipInRandom;

		// Token: 0x04002E0C RID: 11788
		[Token(Token = "0x4002E0C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _forceCount;

		// Token: 0x04002E0D RID: 11789
		[Token(Token = "0x4002E0D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Min(1f)]
		private int _spawnChance;
	}
}
