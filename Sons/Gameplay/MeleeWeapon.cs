using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Items.Core;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x0200078F RID: 1935
	[Token(Token = "0x200078F")]
	public class MeleeWeapon : MonoBehaviour, IMeleeWeapon, IImpactSender
	{
		// Token: 0x0600340F RID: 13327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340F")]
		[Address(RVA = "0x34C3E20", Offset = "0x34C2420", VA = "0x1834C3E20", Slot = "11")]
		protected virtual void OnValidate()
		{
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003410")]
		[Address(RVA = "0x34C3F50", Offset = "0x34C2550", VA = "0x1834C3F50", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003411")]
		[Address(RVA = "0x34C3FB0", Offset = "0x34C25B0", VA = "0x1834C3FB0", Slot = "13")]
		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003412")]
		[Address(RVA = "0x34C46A0", Offset = "0x34C2CA0", VA = "0x1834C46A0", Slot = "4")]
		public MeleeImpactData GetData()
		{
			return null;
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003413")]
		[Address(RVA = "0x34C46C0", Offset = "0x34C2CC0", VA = "0x1834C46C0")]
		private MeleeImpactData GetNewImpactData()
		{
			return null;
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x0000F948 File Offset: 0x0000DB48
		[Token(Token = "0x6003414")]
		[Address(RVA = "0x34C4920", Offset = "0x34C2F20", VA = "0x1834C4920")]
		private bool IsWeaponMissing()
		{
			return default(bool);
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x0000F960 File Offset: 0x0000DB60
		[Token(Token = "0x6003415")]
		[Address(RVA = "0x34C4B10", Offset = "0x34C3110", VA = "0x1834C4B10")]
		private float GetDamage()
		{
			return 0f;
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003416")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "8")]
		public Transform GetRootTransform()
		{
			return null;
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003417")]
		[Address(RVA = "0x34C4C10", Offset = "0x34C3210", VA = "0x1834C4C10", Slot = "14")]
		public virtual MonoBehaviour GetSourceStimuli()
		{
			return null;
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x0000F978 File Offset: 0x0000DB78
		[Token(Token = "0x6003418")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
		public virtual bool IsThrownLog()
		{
			return default(bool);
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003419")]
		[Address(RVA = "0x34C4CF0", Offset = "0x34C32F0", VA = "0x1834C4CF0")]
		protected void DoImpact(IImpactReceiver impactReceiver, Vector3 impactVelocity)
		{
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600341A")]
		[Address(RVA = "0x34C4E60", Offset = "0x34C3460", VA = "0x1834C4E60", Slot = "5")]
		public void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600341B")]
		[Address(RVA = "0x34C5000", Offset = "0x34C3600", VA = "0x1834C5000")]
		private void PlayDamageNodeEvent(DamageNode damageNode)
		{
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600341C")]
		[Address(RVA = "0x34C50D0", Offset = "0x34C36D0", VA = "0x1834C50D0")]
		private void PlayImpactEvent(string impactEvent, Transform hitTr)
		{
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600341D")]
		[Address(RVA = "0x34C52C0", Offset = "0x34C38C0", VA = "0x1834C52C0", Slot = "6")]
		public void OnAttackParried(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600341E")]
		[Address(RVA = "0x2F3C320", Offset = "0x2F3A920", VA = "0x182F3C320")]
		public MeleeWeapon()
		{
		}

		// Token: 0x04002CEE RID: 11502
		[Token(Token = "0x4002CEE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ImpactMeleeType _type;

		// Token: 0x04002CEF RID: 11503
		[Token(Token = "0x4002CEF")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _damage;

		// Token: 0x04002CF0 RID: 11504
		[Token(Token = "0x4002CF0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isSiegeDamage;

		// Token: 0x04002CF1 RID: 11505
		[Token(Token = "0x4002CF1")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _structureDamageMult;

		// Token: 0x04002CF2 RID: 11506
		[Token(Token = "0x4002CF2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _isDemonic;

		// Token: 0x04002CF3 RID: 11507
		[Token(Token = "0x4002CF3")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _forceFinalDeath;

		// Token: 0x04002CF4 RID: 11508
		[Token(Token = "0x4002CF4")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		private bool _doAchievementCheck;

		// Token: 0x04002CF5 RID: 11509
		[Token(Token = "0x4002CF5")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private AudioImpactMaterial _impactAudioMaterial;

		// Token: 0x04002CF6 RID: 11510
		[Token(Token = "0x4002CF6")]
		[FieldOffset(Offset = "0x38")]
		[EventRef]
		[SerializeField]
		private string _hitFleshEvent;

		// Token: 0x04002CF7 RID: 11511
		[Token(Token = "0x4002CF7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[EventRef]
		private string _hitFleshEventNoWeapon;

		// Token: 0x04002CF8 RID: 11512
		[Token(Token = "0x4002CF8")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("_hitWoodEvent")]
		[SerializeField]
		[EventRef]
		private string _hitStructureEvent;

		// Token: 0x04002CF9 RID: 11513
		[Token(Token = "0x4002CF9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MeleeWeaponData _meleeWeaponData;

		// Token: 0x04002CFA RID: 11514
		[Token(Token = "0x4002CFA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private VailActor _ownerActor;

		// Token: 0x04002CFB RID: 11515
		[Token(Token = "0x4002CFB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _hasHeldWeapon;

		// Token: 0x04002CFC RID: 11516
		[Token(Token = "0x4002CFC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _heldWeapon;

		// Token: 0x04002CFD RID: 11517
		[Token(Token = "0x4002CFD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _missingWeaponDamage;

		// Token: 0x04002CFE RID: 11518
		[Token(Token = "0x4002CFE")]
		[FieldOffset(Offset = "0x78")]
		private MeleeImpactData _cachedImpactData;

		// Token: 0x04002CFF RID: 11519
		[Token(Token = "0x4002CFF")]
		[FieldOffset(Offset = "0x80")]
		private float _lastImpactEvent;
	}
}
