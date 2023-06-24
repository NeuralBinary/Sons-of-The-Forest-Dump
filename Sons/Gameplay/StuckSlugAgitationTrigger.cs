using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007FE RID: 2046
	[Token(Token = "0x20007FE")]
	[AddComponentMenu("Sons/Gameplay/StuckSlugAgitationTrigger")]
	public class StuckSlugAgitationTrigger : MonoBehaviour
	{
		// Token: 0x0600373D RID: 14141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373D")]
		[Address(RVA = "0x353B740", Offset = "0x3539D40", VA = "0x18353B740")]
		private void OnEnable()
		{
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373E")]
		[Address(RVA = "0x353B800", Offset = "0x3539E00", VA = "0x18353B800")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373F")]
		[Address(RVA = "0x353B970", Offset = "0x3539F70", VA = "0x18353B970")]
		private void Update()
		{
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003740")]
		[Address(RVA = "0x353BB30", Offset = "0x353A130", VA = "0x18353BB30")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003741")]
		[Address(RVA = "0x2655880", Offset = "0x2653E80", VA = "0x182655880")]
		public StuckSlugAgitationTrigger()
		{
		}

		// Token: 0x04002FB3 RID: 12211
		[Token(Token = "0x4002FB3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002FB4 RID: 12212
		[Token(Token = "0x4002FB4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask _agitationLayers;

		// Token: 0x04002FB5 RID: 12213
		[Token(Token = "0x4002FB5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeleeWeapon _damageWeapon;

		// Token: 0x04002FB6 RID: 12214
		[Token(Token = "0x4002FB6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _attackCooldown;

		// Token: 0x04002FB7 RID: 12215
		[Token(Token = "0x4002FB7")]
		[FieldOffset(Offset = "0x3C")]
		private int _agitationCount;

		// Token: 0x04002FB8 RID: 12216
		[Token(Token = "0x4002FB8")]
		[FieldOffset(Offset = "0x40")]
		private float _nextAttackToggleTime;
	}
}
