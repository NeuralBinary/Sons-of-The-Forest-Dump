using System;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	[Serializable]
	public class DamageStatAdjustment
	{
		// Token: 0x06000686 RID: 1670 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x2B3EF90", Offset = "0x2B3D590", VA = "0x182B3EF90")]
		private static ValueDropdownList<string> GetInfluenceChoices()
		{
			return null;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public string GetStatId()
		{
			return null;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00005040 File Offset: 0x00003240
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x2B3EFB0", Offset = "0x2B3D5B0", VA = "0x182B3EFB0")]
		public float GetAdjustment(float damage)
		{
			return 0f;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DamageStatAdjustment()
		{
		}

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x10")]
		[SerializeReference]
		private string _influenceId;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _adjustmentBase;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _adjustmentDamageScaled;
	}
}
