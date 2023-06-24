using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[AddComponentMenu("Sons/Atmosphere/SnowHeightManager")]
	public class SnowHeightManager : MonoBehaviour, ISeasonsReceiver, IRainAndSnowingReceiver, IRainReceiver, ISnowingReceiver
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x17000034")]
		private static Color GetDefaultGuiColor
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x2D4AE30", Offset = "0x2D49430", VA = "0x182D4AE30")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x17000035")]
		private static Color GetWinterGuiColor
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x2D4AE50", Offset = "0x2D49450", VA = "0x182D4AE50")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		public static SnowHeightManager Instance
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x2D4AE70", Offset = "0x2D49470", VA = "0x182D4AE70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x2D4AEB0", Offset = "0x2D494B0", VA = "0x182D4AEB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x17000037")]
		private float CurrentSnowFadeRange
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x2D4AF40", Offset = "0x2D49540", VA = "0x182D4AF40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x17000038")]
		public float CurrentSnowHeight
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x2D4AF60", Offset = "0x2D49560", VA = "0x182D4AF60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x17000039")]
		public float CurrentSnowAmount
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x2D4AF80", Offset = "0x2D49580", VA = "0x182D4AF80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2D4AFA0", Offset = "0x2D495A0", VA = "0x182D4AFA0")]
		public bool IsAboveSnowHeight(float terrainHeight)
		{
			return default(bool);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2D4AFD0", Offset = "0x2D495D0", VA = "0x182D4AFD0")]
		private void Awake()
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2D4B270", Offset = "0x2D49870", VA = "0x182D4B270")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2D4B5B0", Offset = "0x2D49BB0", VA = "0x182D4B5B0")]
		private bool HasRainOrSnowFogCover()
		{
			return default(bool);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2D4B5D0", Offset = "0x2D49BD0", VA = "0x182D4B5D0")]
		private float GetTransitionMaxSpeed(bool isFar)
		{
			return 0f;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2D4B600", Offset = "0x2D49C00", VA = "0x182D4B600")]
		private float GetTransitionTime(bool isFar, float snowDepthFactor)
		{
			return 0f;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2D4B680", Offset = "0x2D49C80", VA = "0x182D4B680")]
		private bool AtTarget()
		{
			return default(bool);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2D4B6A0", Offset = "0x2D49CA0", VA = "0x182D4B6A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2D4B6F0", Offset = "0x2D49CF0", VA = "0x182D4B6F0", Slot = "4")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2D4B7F0", Offset = "0x2D49DF0", VA = "0x182D4B7F0")]
		public void SetIsWinter(bool isWinter)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2D4B840", Offset = "0x2D49E40", VA = "0x182D4B840")]
		private void ApplyProfile(SnowProfile snowProfile)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2D4BA20", Offset = "0x2D4A020", VA = "0x182D4BA20")]
		private void UpdateWinterFactor(float currentWinterFactor)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2D4BA70", Offset = "0x2D4A070", VA = "0x182D4BA70")]
		public bool TryGetSnowDepthAtTerrainPosition(Vector3 position, out float snowDepth, bool ignoreBelowTerrain = false, bool ignoreAboveTerrain = false)
		{
			return default(bool);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2D4BB60", Offset = "0x2D4A160", VA = "0x182D4BB60")]
		public float GetSnowDepthAtHeight(float worldYPos)
		{
			return 0f;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x25AEEB0", Offset = "0x25AD4B0", VA = "0x1825AEEB0", Slot = "6")]
		public void UpdateRain(bool isRaining)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x25AEED0", Offset = "0x25AD4D0", VA = "0x1825AEED0", Slot = "7")]
		public void UpdateSnowing(bool isSnowing)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2D4BBC0", Offset = "0x2D4A1C0", VA = "0x182D4BBC0")]
		public SnowHeightManager()
		{
		}

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MSColorMapFeature _colorMapFeature;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _farTransitionHeight;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _toDefaultFarTransitionTime;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _toDefaultFarMaxSpeed;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _toDefaultTransitionTime;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _toDefaultMaxSpeed;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve _defaultTransitionCurve;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SnowProfile _defaultSnowProfile;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _toWinterFarTransitionTime;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _toWinterFarMaxSpeed;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _toWinterTransitionTime;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _toWinterMaxSpeed;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AnimationCurve _winterTransitionCurve;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SnowProfile _winterSnowProfile;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x70")]
		private bool _forceEditProfile;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x78")]
		private SnowProfile _editSnowProfile;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x80")]
		private float _snowDepth;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x84")]
		private bool _isWinter;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x88")]
		private float _currentWinterFactor;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x90")]
		private SnowProfile _currentProfile;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x98")]
		private float _currentWinterFactorTarget;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x9C")]
		private float _currentWinterFactorVelocity;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0xA0")]
		private bool _forceUpdate;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0xA1")]
		private bool _isRaining;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0xA2")]
		private bool _isSnowing;
	}
}
