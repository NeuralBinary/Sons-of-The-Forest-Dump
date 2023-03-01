using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006C6 RID: 1734
	[Token(Token = "0x20006C6")]
	[AddComponentMenu("Sons/Gameplay/StuckSlugAgitationTrigger")]
	public class StuckSlugAgitationTrigger : MonoBehaviour
	{
		// Token: 0x06002C6E RID: 11374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6E")]
		[Address(RVA = "0x2DFA270", Offset = "0x2DF9270", VA = "0x182DFA270")]
		private void OnEnable()
		{
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6F")]
		[Address(RVA = "0x2DFA2F0", Offset = "0x2DF92F0", VA = "0x182DFA2F0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C70")]
		[Address(RVA = "0x2DFA480", Offset = "0x2DF9480", VA = "0x182DFA480")]
		private void Update()
		{
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C71")]
		[Address(RVA = "0x2DFA3B0", Offset = "0x2DF93B0", VA = "0x182DFA3B0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C72")]
		[Address(RVA = "0x223A200", Offset = "0x2239200", VA = "0x18223A200")]
		public StuckSlugAgitationTrigger()
		{
		}

		// Token: 0x040027C9 RID: 10185
		[Token(Token = "0x40027C9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x040027CA RID: 10186
		[Token(Token = "0x40027CA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask _agitationLayers;

		// Token: 0x040027CB RID: 10187
		[Token(Token = "0x40027CB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeleeWeapon _damageWeapon;

		// Token: 0x040027CC RID: 10188
		[Token(Token = "0x40027CC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _attackCooldown;

		// Token: 0x040027CD RID: 10189
		[Token(Token = "0x40027CD")]
		[FieldOffset(Offset = "0x3C")]
		private int _agitationCount;

		// Token: 0x040027CE RID: 10190
		[Token(Token = "0x40027CE")]
		[FieldOffset(Offset = "0x40")]
		private float _nextAttackToggleTime;
	}
}
