using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.StatSystem
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[Serializable]
	public class StatsManager
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000003")]
		public List<Stat> Stats
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			set
			{
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public void SetOverrideProfile(StatOverrideSet overrideSet)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x31468F0", Offset = "0x3144EF0", VA = "0x1831468F0")]
		private void BeginListItem(int opt)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x3146960", Offset = "0x3144F60", VA = "0x183146960")]
		private void EndListItem(int opt)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C7")]
		public void SetStatValue<T>(float value) where T : Stat
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C8")]
		public void AdjustStat<T>(float amount, float multiplier = 1f) where T : Stat
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x31469D0", Offset = "0x3144FD0", VA = "0x1831469D0")]
		public void AdjustStat(StatAdjustment amount, float multiplier)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x3146A40", Offset = "0x3145040", VA = "0x183146A40")]
		public void AdjustStat(Type statType, float amount)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000CB")]
		public T GetStat<T>() where T : Stat
		{
			return null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x3146C90", Offset = "0x3145290", VA = "0x183146C90")]
		public Stat GetStat(Type targetType)
		{
			return null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x3146E20", Offset = "0x3145420", VA = "0x183146E20")]
		public void Apply(List<StatAdjustment> adjustments, float multiplier)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x3146FA0", Offset = "0x31455A0", VA = "0x183146FA0")]
		public void Apply(IEnumerable<StatAdjustment> adjustments, float multiplier)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000CF")]
		public static List<T> ValidateStats<T>(List<T> existing, List<T> source) where T : Stat
		{
			return null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x31471B0", Offset = "0x31457B0", VA = "0x1831471B0")]
		public void OnValidate()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x31473B0", Offset = "0x31459B0", VA = "0x1831473B0")]
		public void UpdateStats(Vector3 worldPosition, float deltaTime)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x3147680", Offset = "0x3145C80", VA = "0x183147680")]
		public void CloneStatsFrom(StatsManager sourceStats)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public StatsManager()
		{
		}

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private StatOverrideSet _overrides;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x18")]
		[SerializeReference]
		private List<Stat> _stats;
	}
}
