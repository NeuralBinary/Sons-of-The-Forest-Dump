using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200073B RID: 1851
	[Token(Token = "0x200073B")]
	public class PrintAllItemsAchievement : Achievement
	{
		// Token: 0x0600303D RID: 12349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600303D")]
		[Address(RVA = "0x2E37000", Offset = "0x2E36000", VA = "0x182E37000", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600303E")]
		[Address(RVA = "0x2E370E0", Offset = "0x2E360E0", VA = "0x182E370E0")]
		private void OnItemPrinted(object eventParameter)
		{
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600303F")]
		[Address(RVA = "0x2E37280", Offset = "0x2E36280", VA = "0x182E37280", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003040")]
		[Address(RVA = "0x2E37420", Offset = "0x2E36420", VA = "0x182E37420")]
		public PrintAllItemsAchievement()
		{
		}

		// Token: 0x04002A4C RID: 10828
		[Token(Token = "0x4002A4C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[ItemIdPicker(true)]
		private List<int> _requiredPrints;
	}
}
