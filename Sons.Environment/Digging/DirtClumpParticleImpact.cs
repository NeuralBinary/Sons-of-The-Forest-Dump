using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.VFX;

namespace Sons.Environment.Digging
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	public class DirtClumpParticleImpact : DirtClump
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2FAE530", Offset = "0x2FACB30", VA = "0x182FAE530")]
		private void Update()
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
		public void SetVisualEffect(VisualEffect visualEffect)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2FAE5B0", Offset = "0x2FACBB0", VA = "0x182FAE5B0")]
		private void SpawnParticle(Collision collision)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2FAE910", Offset = "0x2FACF10", VA = "0x182FAE910")]
		private void SelfDestruct()
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2FAE9F0", Offset = "0x2FACFF0", VA = "0x182FAE9F0")]
		private void TriggerParticle(Collision collision)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2FAEB90", Offset = "0x2FAD190", VA = "0x182FAEB90")]
		private void TriggerParticleSimple()
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2FAEDC0", Offset = "0x2FAD3C0", VA = "0x182FAEDC0", Slot = "5")]
		internal override Action<Collision> GetCollisionActivateCallBack()
		{
			return null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2FAEE30", Offset = "0x2FAD430", VA = "0x182FAEE30")]
		public DirtClumpParticleImpact()
		{
		}

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _particleEffect;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private VisualEffect _visualEffect;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _visualEffectEventName;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _visualEffectPositionName;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _maxTimeBeforeCrumble;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x94")]
		private float _age;
	}
}
