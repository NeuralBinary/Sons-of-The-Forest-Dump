using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200088D RID: 2189
	[Token(Token = "0x200088D")]
	public class EatAllEdiblesAchievement : Achievement
	{
		// Token: 0x06003E83 RID: 16003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E83")]
		[Address(RVA = "0x35D2D10", Offset = "0x35D1310", VA = "0x1835D2D10", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E84")]
		[Address(RVA = "0x35D2DF0", Offset = "0x35D13F0", VA = "0x1835D2DF0")]
		private void OnItemConsumed(object eventParameter)
		{
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E85")]
		[Address(RVA = "0x35D30A0", Offset = "0x35D16A0", VA = "0x1835D30A0", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E86")]
		[Address(RVA = "0x35D31A0", Offset = "0x35D17A0", VA = "0x1835D31A0", Slot = "7")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E87")]
		[Address(RVA = "0x35D3280", Offset = "0x35D1880", VA = "0x1835D3280")]
		public EatAllEdiblesAchievement()
		{
		}

		// Token: 0x04003477 RID: 13431
		[Token(Token = "0x4003477")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[ItemIdPicker(Types.Edible, true)]
		private List<int> _requiredEdibles;
	}
}
