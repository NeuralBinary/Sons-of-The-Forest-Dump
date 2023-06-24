using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Interfaces;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay
{
	// Token: 0x0200074E RID: 1870
	[Token(Token = "0x200074E")]
	[AddComponentMenu("Sons/Gameplay/BurnableBody")]
	public class BurnableBody : MonoBehaviour, IBurnable, ILightableFire, IMonoBehaviour, IBurnableBody
	{
		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x0000F378 File Offset: 0x0000D578
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000687")]
		public bool IsBurning
		{
			[Token(Token = "0x6003278")]
			[Address(RVA = "0x179C600", Offset = "0x179AC00", VA = "0x18179C600", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003279")]
			[Address(RVA = "0x179C610", Offset = "0x179AC10", VA = "0x18179C610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600327A")]
		[Address(RVA = "0x34A1EA0", Offset = "0x34A04A0", VA = "0x1834A1EA0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600327B")]
		[Address(RVA = "0x34A21B0", Offset = "0x34A07B0", VA = "0x1834A21B0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600327C")]
		[Address(RVA = "0x34A22A0", Offset = "0x34A08A0", VA = "0x1834A22A0")]
		private void Update()
		{
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600327D")]
		[Address(RVA = "0x34A2E20", Offset = "0x34A1420", VA = "0x1834A2E20", Slot = "5")]
		public void Burn()
		{
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600327E")]
		[Address(RVA = "0x34A2EB0", Offset = "0x34A14B0", VA = "0x1834A2EB0", Slot = "12")]
		private void StartBurning()
		{
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600327F")]
		[Address(RVA = "0x34A2EC0", Offset = "0x34A14C0", VA = "0x1834A2EC0")]
		public void StartBurning()
		{
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003280")]
		[Address(RVA = "0x34A3640", Offset = "0x34A1C40", VA = "0x1834A3640")]
		private void InitializeParticleSystem()
		{
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003281")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		private void ToggleUiIcons(bool onOff)
		{
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003282")]
		[Address(RVA = "0x34A2E20", Offset = "0x34A1420", VA = "0x1834A2E20", Slot = "7")]
		private void LightFire()
		{
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06003283 RID: 12931 RVA: 0x0000F390 File Offset: 0x0000D590
		[Token(Token = "0x17000688")]
		private bool ShouldLeanToLight
		{
			[Token(Token = "0x6003283")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003284")]
		[Address(RVA = "0x34A3960", Offset = "0x34A1F60", VA = "0x1834A3960")]
		public BurnableBody()
		{
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003286")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "9")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003287")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "10")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
		[Token(Token = "0x6003288")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04002B88 RID: 11144
		[Token(Token = "0x4002B88")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BurnShaderPropertyID;

		// Token: 0x04002B89 RID: 11145
		[Token(Token = "0x4002B89")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VailActor _vailActor;

		// Token: 0x04002B8A RID: 11146
		[Token(Token = "0x4002B8A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _destroyObjectAfterBurnt;

		// Token: 0x04002B8B RID: 11147
		[Token(Token = "0x4002B8B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _particleSystemAsset;

		// Token: 0x04002B8C RID: 11148
		[Token(Token = "0x4002B8C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Renderer[] _renderers;

		// Token: 0x04002B8D RID: 11149
		[Token(Token = "0x4002B8D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SpawnItemTarget[] _spawnTargets;

		// Token: 0x04002B8E RID: 11150
		[Token(Token = "0x4002B8E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _burnDuration;

		// Token: 0x04002B8F RID: 11151
		[Token(Token = "0x4002B8F")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _burn;

		// Token: 0x04002B90 RID: 11152
		[Token(Token = "0x4002B90")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _maxParticleEmission;

		// Token: 0x04002B91 RID: 11153
		[Token(Token = "0x4002B91")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationCurve _burnToParticleEmission;

		// Token: 0x04002B92 RID: 11154
		[Token(Token = "0x4002B92")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _endEmitterShapeScale;

		// Token: 0x04002B93 RID: 11155
		[Token(Token = "0x4002B93")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationCurve _burnToBones;

		// Token: 0x04002B94 RID: 11156
		[Token(Token = "0x4002B94")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BurnableBody.ActivateObjects[] _activateOnBurn;

		// Token: 0x04002B95 RID: 11157
		[Token(Token = "0x4002B95")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject[] _deactivateOnBurn;

		// Token: 0x04002B96 RID: 11158
		[Token(Token = "0x4002B96")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UnityEvent _burnBegan;

		// Token: 0x04002B98 RID: 11160
		[Token(Token = "0x4002B98")]
		[FieldOffset(Offset = "0x8C")]
		private float _burnSpeed;

		// Token: 0x04002B99 RID: 11161
		[Token(Token = "0x4002B99")]
		[FieldOffset(Offset = "0x90")]
		private MaterialPropertyBlock _materialPropertyBlock;

		// Token: 0x04002B9A RID: 11162
		[Token(Token = "0x4002B9A")]
		[FieldOffset(Offset = "0x98")]
		private ParticleSystem _particleSystem;

		// Token: 0x0200074F RID: 1871
		[Token(Token = "0x200074F")]
		[Serializable]
		private class ActivateObjects
		{
			// Token: 0x06003289 RID: 12937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003289")]
			[Address(RVA = "0x34A3A50", Offset = "0x34A2050", VA = "0x1834A3A50")]
			public ActivateObjects()
			{
			}

			// Token: 0x04002B9B RID: 11163
			[Token(Token = "0x4002B9B")]
			[FieldOffset(Offset = "0x10")]
			public GameObject GameObject;

			// Token: 0x04002B9C RID: 11164
			[Token(Token = "0x4002B9C")]
			[FieldOffset(Offset = "0x18")]
			public DismembermentController.DismemberPartId DismemberPartId;
		}
	}
}
