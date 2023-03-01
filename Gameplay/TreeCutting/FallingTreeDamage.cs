using System;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using Sons.Items.Core;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x020006DC RID: 1756
	[Token(Token = "0x20006DC")]
	public class FallingTreeDamage : MonoBehaviour, IImpactSender
	{
		// Token: 0x06002CE7 RID: 11495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE7")]
		[Address(RVA = "0x2E04CA0", Offset = "0x2E03CA0", VA = "0x182E04CA0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE8")]
		[Address(RVA = "0x2E04D20", Offset = "0x2E03D20", VA = "0x182E04D20")]
		public static void SetTreeFallContactInfo(bool value)
		{
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE9")]
		[Address(RVA = "0x2E047E0", Offset = "0x2E037E0", VA = "0x182E047E0", Slot = "9")]
		protected virtual void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		[Token(Token = "0x6002CEA")]
		[Address(RVA = "0x2E03D90", Offset = "0x2E02D90", VA = "0x182E03D90")]
		private Vector3 CalculateImpactVelocity(Collision collision)
		{
			return default(Vector3);
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		[Token(Token = "0x6002CEB")]
		[Address(RVA = "0x2E04D80", Offset = "0x2E03D80", VA = "0x182E04D80")]
		private bool VerifyRigidBody()
		{
			return default(bool);
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CEC")]
		[Address(RVA = "0x2E04780", Offset = "0x2E03780", VA = "0x182E04780")]
		private void LogImpactInfo(object message)
		{
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CED")]
		[Address(RVA = "0x2E044C0", Offset = "0x2E034C0", VA = "0x182E044C0")]
		public MeleeImpactData GetData()
		{
			return null;
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CEE")]
		[Address(RVA = "0x2E04630", Offset = "0x2E03630", VA = "0x182E04630")]
		private MeleeImpactData GetNewImpactData()
		{
			return null;
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CEF")]
		[Address(RVA = "0x2E04050", Offset = "0x2E03050", VA = "0x182E04050")]
		protected void DoImpact(FallingTreeDamageReceiver impactReceiver, float impactMultiplier, Vector3 velocity)
		{
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CF0")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		private void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF1")]
		[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "8")]
		private MonoBehaviour GetSourceStimuli()
		{
			return null;
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF2")]
		[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200", Slot = "7")]
		public Transform GetRootTransform()
		{
			return null;
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CF3")]
		[Address(RVA = "0x2E04EA0", Offset = "0x2E03EA0", VA = "0x182E04EA0")]
		public FallingTreeDamage()
		{
		}

		// Token: 0x04002835 RID: 10293
		[Token(Token = "0x4002835")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _fallingTreeRoot;

		// Token: 0x04002836 RID: 10294
		[Token(Token = "0x4002836")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _damage;

		// Token: 0x04002837 RID: 10295
		[Token(Token = "0x4002837")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _delay;

		// Token: 0x04002838 RID: 10296
		[Token(Token = "0x4002838")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeleeWeaponData _meleeWeaponData;

		// Token: 0x04002839 RID: 10297
		[Token(Token = "0x4002839")]
		[FieldOffset(Offset = "0x38")]
		private float _minImpactForce;

		// Token: 0x0400283A RID: 10298
		[Token(Token = "0x400283A")]
		[FieldOffset(Offset = "0x40")]
		private MeleeImpactData _cachedImpactData;

		// Token: 0x0400283B RID: 10299
		[Token(Token = "0x400283B")]
		private const ImpactMeleeType ImpactType = 3;

		// Token: 0x0400283C RID: 10300
		[Token(Token = "0x400283C")]
		private const AudioImpactMaterial ImpactAudioMaterial = 3;

		// Token: 0x0400283D RID: 10301
		[Token(Token = "0x400283D")]
		[FieldOffset(Offset = "0x0")]
		private static bool _logContactInfo;

		// Token: 0x0400283E RID: 10302
		[Token(Token = "0x400283E")]
		[FieldOffset(Offset = "0x48")]
		private AutoTimer _delayTimer;

		// Token: 0x0400283F RID: 10303
		[Token(Token = "0x400283F")]
		[FieldOffset(Offset = "0x50")]
		private Rigidbody _cachedRigidbody;
	}
}
