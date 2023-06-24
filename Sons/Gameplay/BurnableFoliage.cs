using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Interfaces;
using Sons.TerrainDetail;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000750 RID: 1872
	[Token(Token = "0x2000750")]
	[AddComponentMenu("Sons/Gameplay/BurnableFoliage")]
	public class BurnableFoliage : MonoBehaviour, IBurnable
	{
		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600328A RID: 12938 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		// (set) Token: 0x0600328B RID: 12939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000689")]
		public bool IsBurning
		{
			[Token(Token = "0x600328A")]
			[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600328B")]
			[Address(RVA = "0x15771E0", Offset = "0x15757E0", VA = "0x1815771E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600328C")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetDestroyAfterBurntTarget(GameObject target)
		{
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600328D")]
		[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
		public void SetRenderers(Renderer[] source)
		{
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600328E")]
		[Address(RVA = "0x34A3A60", Offset = "0x34A2060", VA = "0x1834A3A60")]
		private void OnValidate()
		{
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600328F")]
		[Address(RVA = "0x34A3DC0", Offset = "0x34A23C0", VA = "0x1834A3DC0", Slot = "5")]
		public void Burn()
		{
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003290")]
		[Address(RVA = "0x34A43F0", Offset = "0x34A29F0", VA = "0x1834A43F0")]
		private void UpdateMaterialPropertyBlock(float burn)
		{
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003291")]
		[Address(RVA = "0x34A45C0", Offset = "0x34A2BC0", VA = "0x1834A45C0")]
		private void Update()
		{
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003292")]
		[Address(RVA = "0x34A4E60", Offset = "0x34A3460", VA = "0x1834A4E60")]
		private void OnEnable()
		{
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003293")]
		[Address(RVA = "0x34A51E0", Offset = "0x34A37E0", VA = "0x1834A51E0")]
		public void OnDisable()
		{
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003294")]
		[Address(RVA = "0x34A53C0", Offset = "0x34A39C0", VA = "0x1834A53C0")]
		private void OnWorldObjectLocatorStateChanged(WorldObjectState state, bool fromSave)
		{
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003295")]
		[Address(RVA = "0x34A5470", Offset = "0x34A3A70", VA = "0x1834A5470")]
		private void TryInitializeParticleSystem()
		{
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003296")]
		[Address(RVA = "0x34A56E0", Offset = "0x34A3CE0", VA = "0x1834A56E0")]
		public BurnableFoliage()
		{
		}

		// Token: 0x04002B9D RID: 11165
		[Token(Token = "0x4002B9D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _burnShaderPropertyID;

		// Token: 0x04002B9E RID: 11166
		[Token(Token = "0x4002B9E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _destroyObjectAfterBurnt;

		// Token: 0x04002B9F RID: 11167
		[Token(Token = "0x4002B9F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _particleSystemAsset;

		// Token: 0x04002BA0 RID: 11168
		[Token(Token = "0x4002BA0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Renderer[] _renderers;

		// Token: 0x04002BA1 RID: 11169
		[Token(Token = "0x4002BA1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _burnDuration;

		// Token: 0x04002BA2 RID: 11170
		[Token(Token = "0x4002BA2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _burn;

		// Token: 0x04002BA3 RID: 11171
		[Token(Token = "0x4002BA3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _maxParticleEmission;

		// Token: 0x04002BA4 RID: 11172
		[Token(Token = "0x4002BA4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve _burnToParticleEmission;

		// Token: 0x04002BA5 RID: 11173
		[Token(Token = "0x4002BA5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _minEmitterShapeScale;

		// Token: 0x04002BA6 RID: 11174
		[Token(Token = "0x4002BA6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationCurve _burnToBushFire;

		// Token: 0x04002BA7 RID: 11175
		[Token(Token = "0x4002BA7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private WorldObjectLocatorHolder _worldObjectLocatorHolder;

		// Token: 0x04002BA9 RID: 11177
		[Token(Token = "0x4002BA9")]
		[FieldOffset(Offset = "0x6C")]
		private float _burnSpeed;

		// Token: 0x04002BAA RID: 11178
		[Token(Token = "0x4002BAA")]
		[FieldOffset(Offset = "0x70")]
		private MaterialPropertyBlock _materialPropertyBlock;

		// Token: 0x04002BAB RID: 11179
		[Token(Token = "0x4002BAB")]
		[FieldOffset(Offset = "0x78")]
		private float _startEmitterShapeScale;

		// Token: 0x04002BAC RID: 11180
		[Token(Token = "0x4002BAC")]
		[FieldOffset(Offset = "0x7C")]
		private float _targetParticleShapeHeight;

		// Token: 0x04002BAD RID: 11181
		[Token(Token = "0x4002BAD")]
		[FieldOffset(Offset = "0x80")]
		private ParticleSystem _particleSystem;
	}
}
