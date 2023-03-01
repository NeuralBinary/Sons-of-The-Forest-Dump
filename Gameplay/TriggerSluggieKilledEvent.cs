using System;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006CA RID: 1738
	[Token(Token = "0x20006CA")]
	public class TriggerSluggieKilledEvent : MonoBehaviour
	{
		// Token: 0x06002C80 RID: 11392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C80")]
		[Address(RVA = "0x2DFB680", Offset = "0x2DFA680", VA = "0x182DFB680")]
		private void Start()
		{
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C81")]
		[Address(RVA = "0x2DFB410", Offset = "0x2DFA410", VA = "0x182DFB410")]
		private void OnBreak(IBreakSender obj, IImpactData impactData)
		{
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C82")]
		[Address(RVA = "0x2DFB710", Offset = "0x2DFA710", VA = "0x182DFB710")]
		public TriggerSluggieKilledEvent()
		{
		}

		// Token: 0x040027D8 RID: 10200
		[Token(Token = "0x40027D8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DamageNode _damageNode;

		// Token: 0x040027D9 RID: 10201
		[Token(Token = "0x40027D9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minimumRange;

		// Token: 0x040027DA RID: 10202
		[Token(Token = "0x40027DA")]
		[FieldOffset(Offset = "0x30")]
		public Action OnSluggieKilled;
	}
}
