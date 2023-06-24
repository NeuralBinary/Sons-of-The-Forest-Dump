using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using Sons.StatSystem;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	[AddComponentMenu("Sons/Ai/Vail Stats Manager")]
	public class VailStatsManager : MonoBehaviour, IStatsManager
	{
		// Token: 0x06000843 RID: 2115 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x2B18420", Offset = "0x2B16A20", VA = "0x182B18420")]
		public static ValueDropdownList<string> GetAllChoices()
		{
			return null;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x2B680C0", Offset = "0x2B666C0", VA = "0x182B680C0")]
		public static ValueDropdownList<string> GetStatChoices()
		{
			return null;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x2B315F0", Offset = "0x2B2FBF0", VA = "0x182B315F0")]
		public static ValueDropdownList<string> GetStatAndTraitChoices()
		{
			return null;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x2B68190", Offset = "0x2B66790", VA = "0x182B68190")]
		public static ValueDropdownList<string> GetTraitChoices()
		{
			return null;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x2B3EF90", Offset = "0x2B3D590", VA = "0x182B3EF90")]
		public static ValueDropdownList<string> GetStatAndInfluenceChoices()
		{
			return null;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x2B68260", Offset = "0x2B66860", VA = "0x182B68260")]
		public static ValueDropdownList<string> GetInfluenceChoices()
		{
			return null;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x2B68330", Offset = "0x2B66930", VA = "0x182B68330")]
		public static ValueDropdownList<string> GetTraitAndInfluenceChoices()
		{
			return null;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x2B68350", Offset = "0x2B66950", VA = "0x182B68350")]
		public static void CacheStatNames()
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x2B68DA0", Offset = "0x2B673A0", VA = "0x182B68DA0")]
		public static ValueDropdownList<string> GetChoices(bool includeStats, bool includeTraits, bool includeInfluences)
		{
			return null;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		public StatsManager GetStatsManager()
		{
			return null;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetStatsManager(StatsManager statsManager)
		{
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x2B68F20", Offset = "0x2B67520", VA = "0x182B68F20")]
		public void Initialize()
		{
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x2B69220", Offset = "0x2B67820", VA = "0x182B69220")]
		private void OnValidate()
		{
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x2B692E0", Offset = "0x2B678E0", VA = "0x182B692E0")]
		private void ValidateStats()
		{
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x2B69380", Offset = "0x2B67980", VA = "0x182B69380")]
		public void CloneStatsFrom(StatsManager statsManager)
		{
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x2B693A0", Offset = "0x2B679A0", VA = "0x182B693A0")]
		public void AdjustStat(Type statType, float amount)
		{
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x2B693C0", Offset = "0x2B679C0", VA = "0x182B693C0")]
		public string GetReadout()
		{
			return null;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x2B69570", Offset = "0x2B67B70", VA = "0x182B69570")]
		public static List<Stat> GetDefaults()
		{
			return null;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x2B69EC0", Offset = "0x2B684C0", VA = "0x182B69EC0")]
		public static bool GetMatchingValue(string id, out Stat result)
		{
			return default(bool);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x2B6A080", Offset = "0x2B68680", VA = "0x182B6A080")]
		private static bool MatchAssignedValue(string relatedStatOrTraitId, IEnumerable<Stat> source, out Stat target)
		{
			return default(bool);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x2B6A2A0", Offset = "0x2B688A0", VA = "0x182B6A2A0")]
		public static Type GetStatType(string statId)
		{
			return null;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x2B6A2F0", Offset = "0x2B688F0", VA = "0x182B6A2F0", Slot = "4")]
		public void UpdateStats(Vector3 worldPosition, float deltaTime)
		{
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000859")]
		public void SetStatValue<T>(float value) where T : Stat
		{
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600085A")]
		public T GetStat<T>() where T : Stat
		{
			return null;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085B")]
		public void AdjustStat<T>(float amount, float multiplier = 1f) where T : Stat
		{
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x2B6A320", Offset = "0x2B68920", VA = "0x182B6A320", Slot = "8")]
		public Stat GetStat(Type targetType)
		{
			return null;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085D")]
		public void ApplyMinAmount<T>(float minAmount) where T : Stat
		{
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x2B6A340", Offset = "0x2B68940", VA = "0x182B6A340", Slot = "9")]
		public void Apply(List<StatAdjustment> adjustments, float multiplier)
		{
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x2B6A360", Offset = "0x2B68960", VA = "0x182B6A360", Slot = "10")]
		public void Apply(IEnumerable<StatAdjustment> adjustments, float multiplier)
		{
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x2B6A380", Offset = "0x2B68980", VA = "0x182B6A380")]
		public void Apply(IReadOnlyList<StatAdjustment> adjustments, float multiplier, VailActor actor)
		{
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x2B6A6F0", Offset = "0x2B68CF0", VA = "0x182B6A6F0")]
		public VailStatsManager()
		{
		}

		// Token: 0x040006AF RID: 1711
		[Token(Token = "0x40006AF")]
		public const string StatsPrefix = "Stats/";

		// Token: 0x040006B0 RID: 1712
		[Token(Token = "0x40006B0")]
		public const string TraitsPrefix = "Traits/";

		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x40006B1")]
		public const string InfluencesPrefix = "Influences/";

		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0x0")]
		private static ValueDropdownList<string> _cachedStatNames;

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0x8")]
		private static ValueDropdownList<string> _cachedTraitNames;

		// Token: 0x040006B4 RID: 1716
		[Token(Token = "0x40006B4")]
		[FieldOffset(Offset = "0x10")]
		private static ValueDropdownList<string> _cachedInfluenceNames;

		// Token: 0x040006B5 RID: 1717
		[Token(Token = "0x40006B5")]
		private const float RandomizePercentOffset = 0.1f;

		// Token: 0x040006B6 RID: 1718
		[Token(Token = "0x40006B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _randomizedOnInitialize;

		// Token: 0x040006B7 RID: 1719
		[Token(Token = "0x40006B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StatsManager _statsManager;
	}
}
