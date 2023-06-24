using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.StatSystem
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public interface IStatsManager
	{
		// Token: 0x06000003 RID: 3
		[Token(Token = "0x6000003")]
		void UpdateStats(Vector3 worldPosition, float deltaTime);

		// Token: 0x06000004 RID: 4
		[Token(Token = "0x6000004")]
		void SetStatValue<T>(float value) where T : Stat;

		// Token: 0x06000005 RID: 5
		[Token(Token = "0x6000005")]
		T GetStat<T>() where T : Stat;

		// Token: 0x06000006 RID: 6
		[Token(Token = "0x6000006")]
		void AdjustStat<T>(float amount, float multiplier) where T : Stat;

		// Token: 0x06000007 RID: 7
		[Token(Token = "0x6000007")]
		Stat GetStat(Type targetType);

		// Token: 0x06000008 RID: 8
		[Token(Token = "0x6000008")]
		void Apply(List<StatAdjustment> adjustments, float multiplier);

		// Token: 0x06000009 RID: 9
		[Token(Token = "0x6000009")]
		void Apply(IEnumerable<StatAdjustment> adjustments, float multiplier);
	}
}
