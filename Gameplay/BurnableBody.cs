using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Interfaces;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay
{
	// Token: 0x02000632 RID: 1586
	[Token(Token = "0x2000632")]
	[AddComponentMenu("Sons/Gameplay/BurnableBody")]
	public class BurnableBody : MonoBehaviour, IBurnable, ILightableFire, IMonoBehaviour, IBurnableBody
	{
		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055C")]
		public bool IsBurning
		{
			[Token(Token = "0x60028A3")]
			[Address(RVA = "0x1526980", Offset = "0x1525980", VA = "0x181526980", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028A4")]
			[Address(RVA = "0x1526BF0", Offset = "0x1525BF0", VA = "0x181526BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A5")]
		[Address(RVA = "0x2DB0130", Offset = "0x2DAF130", VA = "0x182DB0130")]
		private void OnValidate()
		{
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A6")]
		[Address(RVA = "0x2DB00B0", Offset = "0x2DAF0B0", VA = "0x182DB00B0")]
		private void OnEnable()
		{
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A7")]
		[Address(RVA = "0x2DB07C0", Offset = "0x2DAF7C0", VA = "0x182DB07C0")]
		private void Update()
		{
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A8")]
		[Address(RVA = "0x2DAFEA0", Offset = "0x2DAEEA0", VA = "0x182DAFEA0", Slot = "5")]
		public void Burn()
		{
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A9")]
		[Address(RVA = "0x2DB0240", Offset = "0x2DAF240", VA = "0x182DB0240", Slot = "12")]
		private void StartBurning()
		{
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028AA")]
		[Address(RVA = "0x2DB0250", Offset = "0x2DAF250", VA = "0x182DB0250")]
		public void StartBurning()
		{
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028AB")]
		[Address(RVA = "0x2DAFF00", Offset = "0x2DAEF00", VA = "0x182DAFF00")]
		private void InitializeParticleSystem()
		{
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028AC")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "6")]
		private void ToggleUiIcons(bool onOff)
		{
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028AD")]
		[Address(RVA = "0x2DAFEA0", Offset = "0x2DAEEA0", VA = "0x182DAFEA0", Slot = "7")]
		private void LightFire()
		{
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060028AE RID: 10414 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		[Token(Token = "0x1700055D")]
		private bool ShouldLeanToLight
		{
			[Token(Token = "0x60028AE")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028AF")]
		[Address(RVA = "0x2DB0CF0", Offset = "0x2DAFCF0", VA = "0x182DB0CF0")]
		public BurnableBody()
		{
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B1")]
		[Address(RVA = "0x288E5E0", Offset = "0x288D5E0", VA = "0x18288E5E0", Slot = "9")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B2")]
		[Address(RVA = "0x5E9620", Offset = "0x5E8620", VA = "0x1805E9620", Slot = "10")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		[Token(Token = "0x60028B3")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04002449 RID: 9289
		[Token(Token = "0x4002449")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BurnShaderPropertyID;

		// Token: 0x0400244A RID: 9290
		[Token(Token = "0x400244A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VailActor _vailActor;

		// Token: 0x0400244B RID: 9291
		[Token(Token = "0x400244B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _destroyObjectAfterBurnt;

		// Token: 0x0400244C RID: 9292
		[Token(Token = "0x400244C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _particleSystemAsset;

		// Token: 0x0400244D RID: 9293
		[Token(Token = "0x400244D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Renderer[] _renderers;

		// Token: 0x0400244E RID: 9294
		[Token(Token = "0x400244E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SpawnItemTarget[] _spawnTargets;

		// Token: 0x0400244F RID: 9295
		[Token(Token = "0x400244F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _burnDuration;

		// Token: 0x04002450 RID: 9296
		[Token(Token = "0x4002450")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _burn;

		// Token: 0x04002451 RID: 9297
		[Token(Token = "0x4002451")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _maxParticleEmission;

		// Token: 0x04002452 RID: 9298
		[Token(Token = "0x4002452")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationCurve _burnToParticleEmission;

		// Token: 0x04002453 RID: 9299
		[Token(Token = "0x4002453")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _endEmitterShapeScale;

		// Token: 0x04002454 RID: 9300
		[Token(Token = "0x4002454")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationCurve _burnToBones;

		// Token: 0x04002455 RID: 9301
		[Token(Token = "0x4002455")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BurnableBody.ActivateObjects[] _activateOnBurn;

		// Token: 0x04002456 RID: 9302
		[Token(Token = "0x4002456")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject[] _deactivateOnBurn;

		// Token: 0x04002457 RID: 9303
		[Token(Token = "0x4002457")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UnityEvent _burnBegan;

		// Token: 0x04002459 RID: 9305
		[Token(Token = "0x4002459")]
		[FieldOffset(Offset = "0x8C")]
		private float _burnSpeed;

		// Token: 0x0400245A RID: 9306
		[Token(Token = "0x400245A")]
		[FieldOffset(Offset = "0x90")]
		private MaterialPropertyBlock _materialPropertyBlock;

		// Token: 0x0400245B RID: 9307
		[Token(Token = "0x400245B")]
		[FieldOffset(Offset = "0x98")]
		private ParticleSystem _particleSystem;

		// Token: 0x02000633 RID: 1587
		[Token(Token = "0x2000633")]
		[Serializable]
		private class ActivateObjects
		{
			// Token: 0x060028B4 RID: 10420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60028B4")]
			[Address(RVA = "0x2DABF40", Offset = "0x2DAAF40", VA = "0x182DABF40")]
			public ActivateObjects()
			{
			}

			// Token: 0x0400245C RID: 9308
			[Token(Token = "0x400245C")]
			[FieldOffset(Offset = "0x10")]
			public GameObject GameObject;

			// Token: 0x0400245D RID: 9309
			[Token(Token = "0x400245D")]
			[FieldOffset(Offset = "0x18")]
			public DismembermentController.DismemberPartId DismemberPartId;
		}
	}
}
