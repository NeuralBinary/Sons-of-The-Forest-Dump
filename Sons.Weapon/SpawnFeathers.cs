using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[AddComponentMenu("Sons/Spawn Feathers")]
	public class SpawnFeathers : MonoBehaviour, IImpactReceiver, IMonoBehaviour
	{
		// Token: 0x0600014F RID: 335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x31A3700", Offset = "0x31A1D00", VA = "0x1831A3700")]
		private void Start()
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x31A3890", Offset = "0x31A1E90", VA = "0x1831A3890")]
		private void SetStart()
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x31A38A0", Offset = "0x31A1EA0", VA = "0x1831A38A0")]
		private void TrySpawnFeatherBurst()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x31A3930", Offset = "0x31A1F30", VA = "0x1831A3930")]
		public void SpawnFeatherBurst()
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x31A38A0", Offset = "0x31A1EA0", VA = "0x1831A38A0", Slot = "4")]
		public void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x31A3E80", Offset = "0x31A2480", VA = "0x1831A3E80")]
		public SpawnFeathers()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "5")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "6")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x6000157")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DamageNode[] _damageNodes;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] feather;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x30")]
		public int minFeathers;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x34")]
		public int maxFeathers;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x38")]
		public int maxSpawnEvents;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x3C")]
		public float cooldown;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float spawnChance;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool _spawnWithPopForce;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x48")]
		public float popForceMult;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x4C")]
		private int _spawnedBurstCount;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x50")]
		private bool _startUp;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x54")]
		private float _lastBurstTime;
	}
}
