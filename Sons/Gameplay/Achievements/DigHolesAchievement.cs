using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200088C RID: 2188
	[Token(Token = "0x200088C")]
	public class DigHolesAchievement : Achievement
	{
		// Token: 0x06003E7F RID: 15999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E7F")]
		[Address(RVA = "0x35D2B50", Offset = "0x35D1150", VA = "0x1835D2B50", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E80")]
		[Address(RVA = "0x35D2C30", Offset = "0x35D1230", VA = "0x1835D2C30", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E81")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DigHolesAchievement()
		{
		}

		// Token: 0x04003476 RID: 13430
		[Token(Token = "0x4003476")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _holeCount;
	}
}
