using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	public class LavaVolumeTrigger : MonoBehaviour, IImpactSender
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x17000031")]
		public bool WaterInteractionsBlocked
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x31A1E90", Offset = "0x31A0490", VA = "0x1831A1E90")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x31A2090", Offset = "0x31A0690", VA = "0x1831A2090")]
		internal void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x31A20A0", Offset = "0x31A06A0", VA = "0x1831A20A0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x31A20B0", Offset = "0x31A06B0", VA = "0x1831A20B0")]
		private void RemoveDamageNode(Collider other)
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x31A2430", Offset = "0x31A0A30", VA = "0x1831A2430")]
		private void RemoveRootTransformIfNeeded(Transform rootTransform)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x31A2790", Offset = "0x31A0D90", VA = "0x1831A2790")]
		private void RegisterDamageNode(Collider other)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x31A2BD0", Offset = "0x31A11D0", VA = "0x1831A2BD0")]
		private void ApplyBurnToDamageNode(DamageNode damageNode)
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x31A2DE0", Offset = "0x31A13E0", VA = "0x1831A2DE0")]
		private bool IsValid(Collider other, out DamageNode damageNode)
		{
			return default(bool);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x31A2EE0", Offset = "0x31A14E0", VA = "0x1831A2EE0")]
		private void ApplyDamage(DamageNode damageNode)
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		private void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "7")]
		private Transform GetRootTransform()
		{
			return null;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "8")]
		private MonoBehaviour GetSourceStimuli()
		{
			return null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x31A3130", Offset = "0x31A1730", VA = "0x1831A3130")]
		public LavaVolumeTrigger()
		{
		}

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _damage;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _damageIntervalMin;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _damageIntervalMax;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _initialIntervalMin;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _initialIntervalMax;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask _layerMask;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _waterInteractionsBlocked;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x3C")]
		private int _knownDamageNodes;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<DamageNode, int> _overlappingDamageNodes;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x48")]
		private readonly Dictionary<Transform, float> _nextDamageTime;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x50")]
		private VirtualImpact _virtualImpact;
	}
}
