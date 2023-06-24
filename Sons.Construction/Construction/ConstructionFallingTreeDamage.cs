using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using Sons.Weapon;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public class ConstructionFallingTreeDamage : MonoBehaviour, IImpactSender
	{
		// Token: 0x0600033A RID: 826 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x2DBEEE0", Offset = "0x2DBD4E0", VA = "0x182DBEEE0")]
		public MeleeImpactData GetData()
		{
			return null;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2DBEF00", Offset = "0x2DBD500", VA = "0x182DBEF00")]
		private MeleeImpactData GetNewImpactData()
		{
			return null;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x2DBF050", Offset = "0x2DBD650", VA = "0x182DBF050", Slot = "7")]
		public Transform GetRootTransform()
		{
			return null;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x2DBF0F0", Offset = "0x2DBD6F0", VA = "0x182DBF0F0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x2DBF150", Offset = "0x2DBD750", VA = "0x182DBF150")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x2DBF4B0", Offset = "0x2DBDAB0", VA = "0x182DBF4B0")]
		private void OnCollisionEnter(Collision other)
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000036A4 File Offset: 0x000018A4
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x2DBF830", Offset = "0x2DBDE30", VA = "0x182DBF830")]
		private bool TryDamageNearbyStructures(Vector3 pos, float radius)
		{
			return default(bool);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x2DBFDE0", Offset = "0x2DBE3E0", VA = "0x182DBFDE0")]
		private void DoImpact(IImpactReceiver impactReceiver)
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		private void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "8")]
		private MonoBehaviour GetSourceStimuli()
		{
			return null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x727AA0", Offset = "0x7260A0", VA = "0x180727AA0")]
		public ConstructionFallingTreeDamage()
		{
		}

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ImpactMeleeType _type;

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _damage;

		// Token: 0x04000351 RID: 849
		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isSiegeDamage;

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _doAchievementCheck;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private AudioImpactMaterial _impactAudioMaterial;

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeleeWeaponData _meleeWeaponData;

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x38")]
		private MeleeImpactData _cachedImpactData;
	}
}
