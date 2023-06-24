using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public class RainEffectController : MonoBehaviour
	{
		// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2D42E80", Offset = "0x2D41480", VA = "0x182D42E80")]
		private void FindParticleSystems()
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2D42FC0", Offset = "0x2D415C0", VA = "0x182D42FC0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2D43100", Offset = "0x2D41700", VA = "0x182D43100")]
		public void SetActive(bool value)
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2D43120", Offset = "0x2D41720", VA = "0x182D43120")]
		private void DeactivateEffect()
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2D43580", Offset = "0x2D41B80", VA = "0x182D43580")]
		private void ActivateEffect()
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2D43890", Offset = "0x2D41E90", VA = "0x182D43890")]
		private void FadeOutComplete()
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public RainEffectController()
		{
		}

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RainFogController _rainFogController;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ParticleSystem> _rainParticles;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x30")]
		private bool _effectIsActive;
	}
}
