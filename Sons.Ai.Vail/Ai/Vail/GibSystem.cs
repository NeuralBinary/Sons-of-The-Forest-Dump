using System;
using Il2CppDummyDll;
using Sons.StatSystem;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[AddComponentMenu("Sons/Ai/GibSystem")]
	public class GibSystem : MonoBehaviour
	{
		// Token: 0x06000477 RID: 1143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x2B16D80", Offset = "0x2B15380", VA = "0x182B16D80")]
		private void OnValidate()
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x2B16D90", Offset = "0x2B15390", VA = "0x182B16D90")]
		private void ValidateComponents()
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x2B173D0", Offset = "0x2B159D0", VA = "0x182B173D0")]
		private void Awake()
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x2B17610", Offset = "0x2B15C10", VA = "0x182B17610")]
		private void OnEnable()
		{
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x2B17870", Offset = "0x2B15E70", VA = "0x182B17870")]
		private void OnDisable()
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x2B17990", Offset = "0x2B15F90", VA = "0x182B17990")]
		private void OnImpact(IImpactSender sender, IImpactData data)
		{
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x2B17B50", Offset = "0x2B16150", VA = "0x182B17B50")]
		private void Trigger(IImpactSender sender, IImpactData data)
		{
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x2B17DE0", Offset = "0x2B163E0", VA = "0x182B17DE0")]
		public GibSystem()
		{
		}

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _autoCollectComponents;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DamageController _damageController;

		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MonoBehaviour _statsManagerComponent;

		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DismembermentController _dismembermentController;

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x40")]
		private HealthStat _healthStat;

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("The % of the Max Health below 0.0 that would have been caused by the damage to trigger")]
		[SerializeField]
		private float _gibMinPercent;

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _gibPrefabSource;

		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _triggeredInstance;

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x60")]
		private IStatsManager _statsManager;
	}
}
