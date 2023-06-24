using System;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000802 RID: 2050
	[Token(Token = "0x2000802")]
	public class TriggerSluggieKilledEvent : MonoBehaviour
	{
		// Token: 0x06003752 RID: 14162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003752")]
		[Address(RVA = "0x353D520", Offset = "0x353BB20", VA = "0x18353D520")]
		private void Start()
		{
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003753")]
		[Address(RVA = "0x353D5B0", Offset = "0x353BBB0", VA = "0x18353D5B0")]
		private void OnBreak(IBreakSender obj, IImpactData impactData)
		{
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003754")]
		[Address(RVA = "0x675200", Offset = "0x673800", VA = "0x180675200")]
		public TriggerSluggieKilledEvent()
		{
		}

		// Token: 0x04002FC7 RID: 12231
		[Token(Token = "0x4002FC7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DamageNode _damageNode;

		// Token: 0x04002FC8 RID: 12232
		[Token(Token = "0x4002FC8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minimumRange;

		// Token: 0x04002FC9 RID: 12233
		[Token(Token = "0x4002FC9")]
		[FieldOffset(Offset = "0x30")]
		public Action OnSluggieKilled;
	}
}
