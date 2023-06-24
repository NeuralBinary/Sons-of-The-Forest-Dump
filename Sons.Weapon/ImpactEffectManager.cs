using System;
using System.Collections;
using FMODUnity;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	[AddComponentMenu("Sons/Weapon/Impact Effect Manager")]
	public class ImpactEffectManager : MonoBehaviour
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x319F300", Offset = "0x319D900", VA = "0x18319F300")]
		private void Awake()
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x319F390", Offset = "0x319D990", VA = "0x18319F390")]
		private void Start()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x319F480", Offset = "0x319DA80", VA = "0x18319F480")]
		private bool WithinActiveDistance(Vector3 spawnPos)
		{
			return default(bool);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x319F500", Offset = "0x319DB00", VA = "0x18319F500")]
		private static void SendImpactEffectEvent(ImpactEffectManager.ParticleType type, Vector3 spawnPos, Quaternion spawnRot, Vector3 impactEffectVelocity)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x319F960", Offset = "0x319DF60", VA = "0x18319F960")]
		public static void SpawnNetImpactEffect(SpawnImpactEffect ev)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x319FC20", Offset = "0x319E220", VA = "0x18319FC20")]
		public static void ReplicateBallisticImpact(ImpactEffectManager.ParticleType particleType, Vector3 spawnPos, Quaternion spawnRot)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x319FDE0", Offset = "0x319E3E0", VA = "0x18319FDE0")]
		private static IEnumerator SendImpactEffectEventRoutine(ImpactEffectManager.ParticleType type, Vector3 spawnPos, Quaternion spawnRot, Vector3 impactEffectVelocity)
		{
			return null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x319FE80", Offset = "0x319E480", VA = "0x18319FE80")]
		private bool SpawnImpactOfType(ImpactEffectManager.ParticleType particleType, Vector3 spawnPos, Quaternion spawnRot, Vector3 effectVelocity, bool networkRep)
		{
			return default(bool);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x31A0570", Offset = "0x319EB70", VA = "0x1831A0570")]
		private static IEnumerator ApplyVelocity(Transform tr, Vector3 effectVelocity, Vector3 startPos)
		{
			return null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x31A0640", Offset = "0x319EC40", VA = "0x1831A0640")]
		private static GameObject SpawnRandomPrefabFromList(GameObject[] fxList, bool isPooled, Vector3 spawnPos, Quaternion spawnRot, float lifeTime)
		{
			return null;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x31A0840", Offset = "0x319EE40", VA = "0x1831A0840")]
		public static void SpawnTreeImpact(Vector3 spawnPos, Quaternion spawnRot, bool networkRep = true)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x31A09E0", Offset = "0x319EFE0", VA = "0x1831A09E0")]
		public static void SpawnBlood(Vector3 spawnPos, Quaternion spawnRot, Vector3 effectVelocity, bool networkRep = true)
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x31A0B60", Offset = "0x319F160", VA = "0x1831A0B60")]
		public static void SpawnSplash(Collider other, Vector3 weaponStart, Vector3 weaponEnd)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x31A0CB0", Offset = "0x319F2B0", VA = "0x1831A0CB0")]
		private void SpawnSplashInternal(Collider other, Vector3 weaponStart, Vector3 weaponEnd, bool networkRep = true)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x31A1290", Offset = "0x319F890", VA = "0x1831A1290")]
		public static bool SpawnSurfaceImpactObject(Transform hitTransform, Vector3 spawnPos, Quaternion spawnRot, Vector3 velocity, bool networkRep = true)
		{
			return default(bool);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x31A14D0", Offset = "0x319FAD0", VA = "0x1831A14D0")]
		private static bool SpawnSurfaceImpactObject(UnderfootSurfaceDetector.SurfaceType surfaceType, Vector3 spawnPos, Quaternion spawnRot, Vector3 velocity, bool networkRep = true)
		{
			return default(bool);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x31A1690", Offset = "0x319FC90", VA = "0x1831A1690")]
		private GameObject[] GetFxList(ImpactEffectManager.ParticleType particleType, out bool isPooled, out bool useImpactAudio)
		{
			return null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x31A1710", Offset = "0x319FD10", VA = "0x1831A1710")]
		public static void PlayBlockSound(Vector3 position, AudioImpactMaterial weapon, AudioImpactMaterial blocker)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x31A1850", Offset = "0x319FE50", VA = "0x1831A1850")]
		public void PlayBlockSoundInternal(Vector3 position, AudioImpactMaterial weapon, AudioImpactMaterial blocker)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x31A1A80", Offset = "0x31A0080", VA = "0x1831A1A80")]
		public ImpactEffectManager()
		{
		}

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x0")]
		private static ImpactEffectManager _instance;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxActiveDistance;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x8")]
		private static bool _debugLog;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ImpactEffectManager.ParticleTypeDefinition[] _particleTypeDefinitions;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[EventRef]
		private string _boneOnWood;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[EventRef]
		private string _fleshOnWood;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[EventRef]
		private string _metalOnWood;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[EventRef]
		private string _boneOnMetal;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[EventRef]
		private string _fleshOnMetal;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x58")]
		[EventRef]
		[SerializeField]
		private string _metalOnMetal;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x60")]
		[EventRef]
		[SerializeField]
		private string _metalOnCreepyArmour;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x68")]
		[EventRef]
		[SerializeField]
		private string _axeHitTreeEvent;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x10")]
		private static SpawnPool _particlePool;

		// Token: 0x02000026 RID: 38
		[Token(Token = "0x2000026")]
		public enum ParticleType
		{
			// Token: 0x040000C1 RID: 193
			[Token(Token = "0x40000C1")]
			None,
			// Token: 0x040000C2 RID: 194
			[Token(Token = "0x40000C2")]
			Blood,
			// Token: 0x040000C3 RID: 195
			[Token(Token = "0x40000C3")]
			TreeImpact,
			// Token: 0x040000C4 RID: 196
			[Token(Token = "0x40000C4")]
			WaterImpact,
			// Token: 0x040000C5 RID: 197
			[Token(Token = "0x40000C5")]
			Dirt,
			// Token: 0x040000C6 RID: 198
			[Token(Token = "0x40000C6")]
			Wood,
			// Token: 0x040000C7 RID: 199
			[Token(Token = "0x40000C7")]
			Rock,
			// Token: 0x040000C8 RID: 200
			[Token(Token = "0x40000C8")]
			Spittle,
			// Token: 0x040000C9 RID: 201
			[Token(Token = "0x40000C9")]
			LavaProjectile,
			// Token: 0x040000CA RID: 202
			[Token(Token = "0x40000CA")]
			HardSurfaceProjectile,
			// Token: 0x040000CB RID: 203
			[Token(Token = "0x40000CB")]
			FleshProjectile
		}

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		[Serializable]
		private class ParticleTypeDefinition
		{
			// Token: 0x0600012E RID: 302 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ParticleTypeDefinition()
			{
			}

			// Token: 0x040000CC RID: 204
			[Token(Token = "0x40000CC")]
			[FieldOffset(Offset = "0x10")]
			public ImpactEffectManager.ParticleType _type;

			// Token: 0x040000CD RID: 205
			[Token(Token = "0x40000CD")]
			[FieldOffset(Offset = "0x14")]
			public bool _pooled;

			// Token: 0x040000CE RID: 206
			[Token(Token = "0x40000CE")]
			[FieldOffset(Offset = "0x15")]
			public bool _useImpactAudio;

			// Token: 0x040000CF RID: 207
			[Token(Token = "0x40000CF")]
			[FieldOffset(Offset = "0x18")]
			public GameObject[] _prefabs;
		}
	}
}
