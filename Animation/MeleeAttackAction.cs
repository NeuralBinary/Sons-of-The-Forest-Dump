using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x020008B5 RID: 2229
	[Token(Token = "0x20008B5")]
	public class MeleeAttackAction : MonoBehaviour
	{
		// Token: 0x06003C14 RID: 15380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C14")]
		[Address(RVA = "0x2F20820", Offset = "0x2F1F820", VA = "0x182F20820")]
		private void Update()
		{
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C15")]
		[Address(RVA = "0x2F20820", Offset = "0x2F1F820", VA = "0x182F20820")]
		private void UpdateLifeTime()
		{
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C16")]
		[Address(RVA = "0x2F205F0", Offset = "0x2F1F5F0", VA = "0x182F205F0")]
		internal void OnEnable()
		{
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C17")]
		[Address(RVA = "0x2F20520", Offset = "0x2F1F520", VA = "0x182F20520")]
		private void OnDisable()
		{
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C18")]
		[Address(RVA = "0x2F20790", Offset = "0x2F1F790", VA = "0x182F20790")]
		private void OnMeleeAttackEvent()
		{
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C19")]
		[Address(RVA = "0x2F20710", Offset = "0x2F1F710", VA = "0x182F20710")]
		private void OnMeleeAttackEnd()
		{
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C1A")]
		[Address(RVA = "0x2F208E0", Offset = "0x2F1F8E0", VA = "0x182F208E0")]
		public MeleeAttackAction()
		{
		}

		// Token: 0x04004057 RID: 16471
		[Token(Token = "0x4004057")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationEventReceiver _animationEventReceiver;

		// Token: 0x04004058 RID: 16472
		[Token(Token = "0x4004058")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _enableGameObject;

		// Token: 0x04004059 RID: 16473
		[Token(Token = "0x4004059")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _lifeTime;

		// Token: 0x0400405A RID: 16474
		[Token(Token = "0x400405A")]
		[FieldOffset(Offset = "0x34")]
		private float _fireTime;
	}
}
