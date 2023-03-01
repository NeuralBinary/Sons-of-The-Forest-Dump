using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Interfaces;
using Sons.TerrainDetail;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000634 RID: 1588
	[Token(Token = "0x2000634")]
	[AddComponentMenu("Sons/Gameplay/BurnableFoliage")]
	public class BurnableFoliage : MonoBehaviour, IBurnable
	{
		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x0000BD00 File Offset: 0x00009F00
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055E")]
		public bool IsBurning
		{
			[Token(Token = "0x60028B5")]
			[Address(RVA = "0x1E52250", Offset = "0x1E51250", VA = "0x181E52250", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028B6")]
			[Address(RVA = "0x1E52300", Offset = "0x1E51300", VA = "0x181E52300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028B7")]
		[Address(RVA = "0x541240", Offset = "0x540240", VA = "0x180541240")]
		public void SetDestroyAfterBurntTarget(GameObject target)
		{
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028B8")]
		[Address(RVA = "0x541250", Offset = "0x540250", VA = "0x180541250")]
		public void SetRenderers(Renderer[] source)
		{
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028B9")]
		[Address(RVA = "0x2DB1460", Offset = "0x2DB0460", VA = "0x182DB1460")]
		private void OnValidate()
		{
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BA")]
		[Address(RVA = "0x2DB0D10", Offset = "0x2DAFD10", VA = "0x182DB0D10", Slot = "5")]
		public void Burn()
		{
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BB")]
		[Address(RVA = "0x2DB17A0", Offset = "0x2DB07A0", VA = "0x182DB17A0")]
		private void UpdateMaterialPropertyBlock(float burn)
		{
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BC")]
		[Address(RVA = "0x2DB1880", Offset = "0x2DB0880", VA = "0x182DB1880")]
		private void Update()
		{
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BD")]
		[Address(RVA = "0x2DB1280", Offset = "0x2DB0280", VA = "0x182DB1280")]
		private void OnEnable()
		{
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BE")]
		[Address(RVA = "0x2DB1140", Offset = "0x2DB0140", VA = "0x182DB1140")]
		public void OnDisable()
		{
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BF")]
		[Address(RVA = "0x2DB15A0", Offset = "0x2DB05A0", VA = "0x182DB15A0")]
		private void OnWorldObjectLocatorStateChanged(WorldObjectState state)
		{
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C0")]
		[Address(RVA = "0x2DB1650", Offset = "0x2DB0650", VA = "0x182DB1650")]
		private void TryInitializeParticleSystem()
		{
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C1")]
		[Address(RVA = "0x2DB1CC0", Offset = "0x2DB0CC0", VA = "0x182DB1CC0")]
		public BurnableFoliage()
		{
		}

		// Token: 0x0400245E RID: 9310
		[Token(Token = "0x400245E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _burnShaderPropertyID;

		// Token: 0x0400245F RID: 9311
		[Token(Token = "0x400245F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _destroyObjectAfterBurnt;

		// Token: 0x04002460 RID: 9312
		[Token(Token = "0x4002460")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _particleSystemAsset;

		// Token: 0x04002461 RID: 9313
		[Token(Token = "0x4002461")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Renderer[] _renderers;

		// Token: 0x04002462 RID: 9314
		[Token(Token = "0x4002462")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _burnDuration;

		// Token: 0x04002463 RID: 9315
		[Token(Token = "0x4002463")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _burn;

		// Token: 0x04002464 RID: 9316
		[Token(Token = "0x4002464")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _maxParticleEmission;

		// Token: 0x04002465 RID: 9317
		[Token(Token = "0x4002465")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve _burnToParticleEmission;

		// Token: 0x04002466 RID: 9318
		[Token(Token = "0x4002466")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _minEmitterShapeScale;

		// Token: 0x04002467 RID: 9319
		[Token(Token = "0x4002467")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationCurve _burnToBushFire;

		// Token: 0x04002468 RID: 9320
		[Token(Token = "0x4002468")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private WorldObjectLocatorHolder _worldObjectLocatorHolder;

		// Token: 0x0400246A RID: 9322
		[Token(Token = "0x400246A")]
		[FieldOffset(Offset = "0x6C")]
		private float _burnSpeed;

		// Token: 0x0400246B RID: 9323
		[Token(Token = "0x400246B")]
		[FieldOffset(Offset = "0x70")]
		private MaterialPropertyBlock _materialPropertyBlock;

		// Token: 0x0400246C RID: 9324
		[Token(Token = "0x400246C")]
		[FieldOffset(Offset = "0x78")]
		private float _startEmitterShapeScale;

		// Token: 0x0400246D RID: 9325
		[Token(Token = "0x400246D")]
		[FieldOffset(Offset = "0x7C")]
		private float _targetParticleShapeHeight;

		// Token: 0x0400246E RID: 9326
		[Token(Token = "0x400246E")]
		[FieldOffset(Offset = "0x80")]
		private ParticleSystem _particleSystem;
	}
}
