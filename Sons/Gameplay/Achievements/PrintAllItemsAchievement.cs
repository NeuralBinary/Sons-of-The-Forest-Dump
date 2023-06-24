using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x02000897 RID: 2199
	[Token(Token = "0x2000897")]
	public class PrintAllItemsAchievement : Achievement
	{
		// Token: 0x06003EAE RID: 16046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAE")]
		[Address(RVA = "0x35D4AB0", Offset = "0x35D30B0", VA = "0x1835D4AB0", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAF")]
		[Address(RVA = "0x35D4B90", Offset = "0x35D3190", VA = "0x1835D4B90")]
		private void OnItemPrinted(object eventParameter)
		{
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB0")]
		[Address(RVA = "0x35D4DD0", Offset = "0x35D33D0", VA = "0x1835D4DD0", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB1")]
		[Address(RVA = "0x35D4ED0", Offset = "0x35D34D0", VA = "0x1835D4ED0", Slot = "7")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB2")]
		[Address(RVA = "0x35D4FB0", Offset = "0x35D35B0", VA = "0x1835D4FB0")]
		public PrintAllItemsAchievement()
		{
		}

		// Token: 0x0400347A RID: 13434
		[Token(Token = "0x400347A")]
		[FieldOffset(Offset = "0x38")]
		[ItemIdPicker(true)]
		[SerializeField]
		private List<int> _requiredPrints;
	}
}
