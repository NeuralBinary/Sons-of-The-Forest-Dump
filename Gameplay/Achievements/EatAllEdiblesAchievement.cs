using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x02000731 RID: 1841
	[Token(Token = "0x2000731")]
	public class EatAllEdiblesAchievement : Achievement
	{
		// Token: 0x06003015 RID: 12309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003015")]
		[Address(RVA = "0x2E29610", Offset = "0x2E28610", VA = "0x182E29610", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003016")]
		[Address(RVA = "0x2E296F0", Offset = "0x2E286F0", VA = "0x182E296F0")]
		private void OnItemConsumed(object eventParameter)
		{
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003017")]
		[Address(RVA = "0x2E29900", Offset = "0x2E28900", VA = "0x182E29900", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003018")]
		[Address(RVA = "0x2E29AB0", Offset = "0x2E28AB0", VA = "0x182E29AB0")]
		public EatAllEdiblesAchievement()
		{
		}

		// Token: 0x04002A49 RID: 10825
		[Token(Token = "0x4002A49")]
		[FieldOffset(Offset = "0x38")]
		[ItemIdPicker(8, true)]
		[SerializeField]
		private List<int> _requiredEdibles;
	}
}
