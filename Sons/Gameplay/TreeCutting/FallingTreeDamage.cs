using System;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using Sons.Items.Core;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x02000828 RID: 2088
	[Token(Token = "0x2000828")]
	public class FallingTreeDamage : MonoBehaviour, IImpactSender
	{
		// Token: 0x06003ACA RID: 15050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACA")]
		[Address(RVA = "0x357DC70", Offset = "0x357C270", VA = "0x18357DC70")]
		private void OnEnable()
		{
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACB")]
		[Address(RVA = "0x357DD70", Offset = "0x357C370", VA = "0x18357DD70")]
		public static void SetTreeFallContactInfo(bool value)
		{
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACC")]
		[Address(RVA = "0x357DDD0", Offset = "0x357C3D0", VA = "0x18357DDD0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACD")]
		[Address(RVA = "0x357DF00", Offset = "0x357C500", VA = "0x18357DF00", Slot = "10")]
		protected virtual void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x00012000 File Offset: 0x00010200
		[Token(Token = "0x6003ACE")]
		[Address(RVA = "0x357E5B0", Offset = "0x357CBB0", VA = "0x18357E5B0")]
		private Vector3 CalculateImpactVelocity(Collision collision)
		{
			return default(Vector3);
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x00012018 File Offset: 0x00010218
		[Token(Token = "0x6003ACF")]
		[Address(RVA = "0x357E900", Offset = "0x357CF00", VA = "0x18357E900")]
		private bool VerifyRigidBody()
		{
			return default(bool);
		}

		// Token: 0x06003AD0 RID: 15056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD0")]
		[Address(RVA = "0x357EAE0", Offset = "0x357D0E0", VA = "0x18357EAE0")]
		private void LogImpactInfo(object message)
		{
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD1")]
		[Address(RVA = "0x357EB40", Offset = "0x357D140", VA = "0x18357EB40")]
		public MeleeImpactData GetData()
		{
			return null;
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD2")]
		[Address(RVA = "0x357ECB0", Offset = "0x357D2B0", VA = "0x18357ECB0")]
		private MeleeImpactData GetNewImpactData()
		{
			return null;
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD3")]
		[Address(RVA = "0x357EE00", Offset = "0x357D400", VA = "0x18357EE00")]
		protected void DoImpact(FallingTreeDamageReceiver impactReceiver, float impactMultiplier, Vector3 velocity)
		{
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		private void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD5")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "8")]
		private MonoBehaviour GetSourceStimuli()
		{
			return null;
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD6")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "7")]
		public Transform GetRootTransform()
		{
			return null;
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD7")]
		[Address(RVA = "0x357F3A0", Offset = "0x357D9A0", VA = "0x18357F3A0")]
		public FallingTreeDamage()
		{
		}

		// Token: 0x04003211 RID: 12817
		[Token(Token = "0x4003211")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _fallingTreeRoot;

		// Token: 0x04003212 RID: 12818
		[Token(Token = "0x4003212")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _damage;

		// Token: 0x04003213 RID: 12819
		[Token(Token = "0x4003213")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _delay;

		// Token: 0x04003214 RID: 12820
		[Token(Token = "0x4003214")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeleeWeaponData _meleeWeaponData;

		// Token: 0x04003215 RID: 12821
		[Token(Token = "0x4003215")]
		[FieldOffset(Offset = "0x38")]
		private float _minImpactForce;

		// Token: 0x04003216 RID: 12822
		[Token(Token = "0x4003216")]
		[FieldOffset(Offset = "0x40")]
		private MeleeImpactData _cachedImpactData;

		// Token: 0x04003217 RID: 12823
		[Token(Token = "0x4003217")]
		private const ImpactMeleeType ImpactType = ImpactMeleeType.Blunt;

		// Token: 0x04003218 RID: 12824
		[Token(Token = "0x4003218")]
		private const AudioImpactMaterial ImpactAudioMaterial = AudioImpactMaterial.Wood;

		// Token: 0x04003219 RID: 12825
		[Token(Token = "0x4003219")]
		[FieldOffset(Offset = "0x0")]
		private static bool _logContactInfo;

		// Token: 0x0400321A RID: 12826
		[Token(Token = "0x400321A")]
		[FieldOffset(Offset = "0x48")]
		private AutoTimer _delayTimer;

		// Token: 0x0400321B RID: 12827
		[Token(Token = "0x400321B")]
		[FieldOffset(Offset = "0x50")]
		private Rigidbody _cachedRigidbody;

		// Token: 0x0400321C RID: 12828
		[Token(Token = "0x400321C")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _lastVelocity;
	}
}
