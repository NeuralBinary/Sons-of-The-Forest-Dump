using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x02000730 RID: 1840
	[Token(Token = "0x2000730")]
	public class DigHolesAchievement : Achievement
	{
		// Token: 0x06003011 RID: 12305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003011")]
		[Address(RVA = "0x2E29450", Offset = "0x2E28450", VA = "0x182E29450", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003012")]
		[Address(RVA = "0x2E29530", Offset = "0x2E28530", VA = "0x182E29530", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003013")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public DigHolesAchievement()
		{
		}

		// Token: 0x04002A48 RID: 10824
		[Token(Token = "0x4002A48")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _holeCount;
	}
}
