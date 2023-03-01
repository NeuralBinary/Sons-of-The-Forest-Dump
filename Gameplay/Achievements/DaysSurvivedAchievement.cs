using System;
using Il2CppDummyDll;
using Sons.Environment;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200072F RID: 1839
	[Token(Token = "0x200072F")]
	public class DaysSurvivedAchievement : Achievement, ITimeOfDayReceiver
	{
		// Token: 0x06003008 RID: 12296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003008")]
		[Address(RVA = "0x2E29150", Offset = "0x2E28150", VA = "0x182E29150")]
		private void Awake()
		{
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003009")]
		[Address(RVA = "0x2E29240", Offset = "0x2E28240", VA = "0x182E29240")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600300A")]
		[Address(RVA = "0x2E291A0", Offset = "0x2E281A0", VA = "0x182E291A0", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600300B")]
		[Address(RVA = "0x2E29290", Offset = "0x2E28290", VA = "0x182E29290", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600300C")]
		[Address(RVA = "0x2E293F0", Offset = "0x2E283F0", VA = "0x182E293F0", Slot = "7")]
		public void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x0000DC68 File Offset: 0x0000BE68
		[Token(Token = "0x600300D")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "8")]
		public bool ShouldRun()
		{
			return default(bool);
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x0000DC80 File Offset: 0x0000BE80
		[Token(Token = "0x600300E")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "9")]
		public bool ShouldRunTimeSliced()
		{
			return default(bool);
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600300F")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "10")]
		public void SetLastUpdate(int frame, float time)
		{
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003010")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public DaysSurvivedAchievement()
		{
		}

		// Token: 0x04002A45 RID: 10821
		[Token(Token = "0x4002A45")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _targetDay;

		// Token: 0x04002A46 RID: 10822
		[Token(Token = "0x4002A46")]
		[FieldOffset(Offset = "0x3C")]
		private int _day;

		// Token: 0x04002A47 RID: 10823
		[Token(Token = "0x4002A47")]
		[FieldOffset(Offset = "0x40")]
		private bool _isInitialized;
	}
}
