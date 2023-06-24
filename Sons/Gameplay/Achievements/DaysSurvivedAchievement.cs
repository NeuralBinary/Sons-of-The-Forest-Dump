using System;
using Il2CppDummyDll;
using Sons.Environment;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200088B RID: 2187
	[Token(Token = "0x200088B")]
	public class DaysSurvivedAchievement : Achievement, ITimeOfDayReceiver
	{
		// Token: 0x06003E76 RID: 15990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E76")]
		[Address(RVA = "0x35D2860", Offset = "0x35D0E60", VA = "0x1835D2860")]
		private void Awake()
		{
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E77")]
		[Address(RVA = "0x35D28B0", Offset = "0x35D0EB0", VA = "0x1835D28B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E78")]
		[Address(RVA = "0x35D2900", Offset = "0x35D0F00", VA = "0x1835D2900", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E79")]
		[Address(RVA = "0x35D29A0", Offset = "0x35D0FA0", VA = "0x1835D29A0", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E7A")]
		[Address(RVA = "0x35D2B00", Offset = "0x35D1100", VA = "0x1835D2B00", Slot = "8")]
		public void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x00013188 File Offset: 0x00011388
		[Token(Token = "0x6003E7B")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "9")]
		public bool ShouldRun()
		{
			return default(bool);
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x000131A0 File Offset: 0x000113A0
		[Token(Token = "0x6003E7C")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "10")]
		public bool ShouldRunTimeSliced()
		{
			return default(bool);
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E7D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		public void SetLastUpdate(int frame, float time)
		{
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E7E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DaysSurvivedAchievement()
		{
		}

		// Token: 0x04003473 RID: 13427
		[Token(Token = "0x4003473")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _targetDay;

		// Token: 0x04003474 RID: 13428
		[Token(Token = "0x4003474")]
		[FieldOffset(Offset = "0x3C")]
		private int _day;

		// Token: 0x04003475 RID: 13429
		[Token(Token = "0x4003475")]
		[FieldOffset(Offset = "0x40")]
		private bool _isInitialized;
	}
}
