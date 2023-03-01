using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Items.Core;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000670 RID: 1648
	[Token(Token = "0x2000670")]
	public class MeleeWeapon : MonoBehaviour, IMeleeWeapon, IImpactSender
	{
		// Token: 0x06002A12 RID: 10770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A12")]
		[Address(RVA = "0x2DD3610", Offset = "0x2DD2610", VA = "0x182DD3610", Slot = "10")]
		protected virtual void OnValidate()
		{
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A13")]
		[Address(RVA = "0x2DD3310", Offset = "0x2DD2310", VA = "0x182DD3310", Slot = "11")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A14")]
		[Address(RVA = "0x2DD3340", Offset = "0x2DD2340", VA = "0x182DD3340", Slot = "12")]
		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A15")]
		[Address(RVA = "0x2DD2CC0", Offset = "0x2DD1CC0", VA = "0x182DD2CC0", Slot = "4")]
		public MeleeImpactData GetData()
		{
			return null;
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A16")]
		[Address(RVA = "0x2DD2CE0", Offset = "0x2DD1CE0", VA = "0x182DD2CE0")]
		private MeleeImpactData GetNewImpactData()
		{
			return null;
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		[Token(Token = "0x6002A17")]
		[Address(RVA = "0x2DD2F70", Offset = "0x2DD1F70", VA = "0x182DD2F70")]
		private bool IsWeaponMissing()
		{
			return default(bool);
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x0000C210 File Offset: 0x0000A410
		[Token(Token = "0x6002A18")]
		[Address(RVA = "0x2DD2C20", Offset = "0x2DD1C20", VA = "0x182DD2C20")]
		private float GetDamage()
		{
			return default(float);
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A19")]
		[Address(RVA = "0x5E9620", Offset = "0x5E8620", VA = "0x1805E9620", Slot = "8")]
		public Transform GetRootTransform()
		{
			return null;
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A1A")]
		[Address(RVA = "0x2DD2EE0", Offset = "0x2DD1EE0", VA = "0x182DD2EE0", Slot = "13")]
		public virtual MonoBehaviour GetSourceStimuli()
		{
			return null;
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1B")]
		[Address(RVA = "0x2DD2A10", Offset = "0x2DD1A10", VA = "0x182DD2A10")]
		protected void DoImpact(IImpactReceiver impactReceiver)
		{
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1C")]
		[Address(RVA = "0x2DD3180", Offset = "0x2DD2180", VA = "0x182DD3180", Slot = "5")]
		public void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1D")]
		[Address(RVA = "0x2DD3050", Offset = "0x2DD2050", VA = "0x182DD3050", Slot = "6")]
		public void OnAttackParried(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1E")]
		[Address(RVA = "0x286D200", Offset = "0x286C200", VA = "0x18286D200")]
		public MeleeWeapon()
		{
		}

		// Token: 0x04002591 RID: 9617
		[Token(Token = "0x4002591")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ImpactMeleeType _type;

		// Token: 0x04002592 RID: 9618
		[Token(Token = "0x4002592")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _damage;

		// Token: 0x04002593 RID: 9619
		[Token(Token = "0x4002593")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isSiegeDamage;

		// Token: 0x04002594 RID: 9620
		[Token(Token = "0x4002594")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _isDemonic;

		// Token: 0x04002595 RID: 9621
		[Token(Token = "0x4002595")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _forceFinalDeath;

		// Token: 0x04002596 RID: 9622
		[Token(Token = "0x4002596")]
		[FieldOffset(Offset = "0x2B")]
		[SerializeField]
		private bool _doAchievementCheck;

		// Token: 0x04002597 RID: 9623
		[Token(Token = "0x4002597")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private AudioImpactMaterial _impactAudioMaterial;

		// Token: 0x04002598 RID: 9624
		[Token(Token = "0x4002598")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[EventRef]
		private string _hitFleshEvent;

		// Token: 0x04002599 RID: 9625
		[Token(Token = "0x4002599")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[EventRef]
		private string _hitFleshEventNoWeapon;

		// Token: 0x0400259A RID: 9626
		[Token(Token = "0x400259A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MeleeWeaponData _meleeWeaponData;

		// Token: 0x0400259B RID: 9627
		[Token(Token = "0x400259B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private VailActor _ownerActor;

		// Token: 0x0400259C RID: 9628
		[Token(Token = "0x400259C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _hasHeldWeapon;

		// Token: 0x0400259D RID: 9629
		[Token(Token = "0x400259D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _heldWeapon;

		// Token: 0x0400259E RID: 9630
		[Token(Token = "0x400259E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _missingWeaponDamage;

		// Token: 0x0400259F RID: 9631
		[Token(Token = "0x400259F")]
		[FieldOffset(Offset = "0x68")]
		private MeleeImpactData _cachedImpactData;

		// Token: 0x040025A0 RID: 9632
		[Token(Token = "0x40025A0")]
		[FieldOffset(Offset = "0x70")]
		private float _lastImpactEvent;
	}
}
