using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x02000806 RID: 2054
	[Token(Token = "0x2000806")]
	public sealed class VirtualProjectileWeapon : MonoBehaviour, IImpactSender
	{
		// Token: 0x06003762 RID: 14178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003762")]
		[Address(RVA = "0x353E2A0", Offset = "0x353C8A0", VA = "0x18353E2A0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003763")]
		[Address(RVA = "0x353E3D0", Offset = "0x353C9D0", VA = "0x18353E3D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003764")]
		[Address(RVA = "0x353E430", Offset = "0x353CA30", VA = "0x18353E430")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003765")]
		[Address(RVA = "0x353EA40", Offset = "0x353D040", VA = "0x18353EA40")]
		public ProjectileImpactData GetData()
		{
			return null;
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003766")]
		[Address(RVA = "0x353EA60", Offset = "0x353D060", VA = "0x18353EA60")]
		private ProjectileImpactData GetNewImpactData()
		{
			return null;
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x00010800 File Offset: 0x0000EA00
		[Token(Token = "0x6003767")]
		[Address(RVA = "0x353EC60", Offset = "0x353D260", VA = "0x18353EC60")]
		private float GetDamage()
		{
			return 0f;
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003768")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "7")]
		public Transform GetRootTransform()
		{
			return null;
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003769")]
		[Address(RVA = "0x353ED50", Offset = "0x353D350", VA = "0x18353ED50", Slot = "8")]
		public MonoBehaviour GetSourceStimuli()
		{
			return null;
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x00010818 File Offset: 0x0000EA18
		[Token(Token = "0x600376A")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
		public bool IsThrownLog()
		{
			return default(bool);
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600376B")]
		[Address(RVA = "0x353EE30", Offset = "0x353D430", VA = "0x18353EE30")]
		private void DoImpact(IImpactReceiver impactReceiver, Vector3 impactVelocity)
		{
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600376C")]
		[Address(RVA = "0x353EEC0", Offset = "0x353D4C0", VA = "0x18353EEC0", Slot = "4")]
		public void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600376D")]
		[Address(RVA = "0x353F050", Offset = "0x353D650", VA = "0x18353F050")]
		private void PlayDamageNodeEvent(DamageNode damageNode)
		{
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600376E")]
		[Address(RVA = "0x353F110", Offset = "0x353D710", VA = "0x18353F110")]
		private void PlayImpactEvent(string impactEvent, Transform hitTr)
		{
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600376F")]
		[Address(RVA = "0x353F300", Offset = "0x353D900", VA = "0x18353F300", Slot = "5")]
		public void OnAttackParried(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003770")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VirtualProjectileWeapon()
		{
		}

		// Token: 0x04002FCD RID: 12237
		[Token(Token = "0x4002FCD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ImpactProjectileType _type;

		// Token: 0x04002FCE RID: 12238
		[Token(Token = "0x4002FCE")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _damage;

		// Token: 0x04002FCF RID: 12239
		[Token(Token = "0x4002FCF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _weight;

		// Token: 0x04002FD0 RID: 12240
		[Token(Token = "0x4002FD0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _dismember;

		// Token: 0x04002FD1 RID: 12241
		[Token(Token = "0x4002FD1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private IReadOnlyList<StatusEffect> _statusEffects;

		// Token: 0x04002FD2 RID: 12242
		[Token(Token = "0x4002FD2")]
		[FieldOffset(Offset = "0x38")]
		[EventRef]
		[SerializeField]
		private string _hitFleshEvent;

		// Token: 0x04002FD3 RID: 12243
		[Token(Token = "0x4002FD3")]
		[FieldOffset(Offset = "0x40")]
		[EventRef]
		[SerializeField]
		[FormerlySerializedAs("_hitWoodEvent")]
		private string _hitStructureEvent;

		// Token: 0x04002FD4 RID: 12244
		[Token(Token = "0x4002FD4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private VailActor _ownerActor;

		// Token: 0x04002FD5 RID: 12245
		[Token(Token = "0x4002FD5")]
		[FieldOffset(Offset = "0x50")]
		private ProjectileImpactData _cachedImpactData;

		// Token: 0x04002FD6 RID: 12246
		[Token(Token = "0x4002FD6")]
		[FieldOffset(Offset = "0x58")]
		private float _lastImpactEvent;
	}
}
