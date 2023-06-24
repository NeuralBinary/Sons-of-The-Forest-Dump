using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007EC RID: 2028
	[Token(Token = "0x20007EC")]
	public class SeasonSleepLinker : MonoBehaviour, ISleepingReceiver
	{
		// Token: 0x060036C5 RID: 14021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C5")]
		[Address(RVA = "0x3532600", Offset = "0x3530C00", VA = "0x183532600")]
		private void OnEnable()
		{
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C6")]
		[Address(RVA = "0x3532650", Offset = "0x3530C50", VA = "0x183532650")]
		private void OnDisable()
		{
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void OnWentToSleep()
		{
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void OnWokeUp()
		{
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C9")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SeasonSleepLinker()
		{
		}
	}
}
