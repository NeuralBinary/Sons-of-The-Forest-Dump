using System;
using System.Runtime.CompilerServices;
using Ballistics;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Weapon
{
	// Token: 0x02000880 RID: 2176
	[Token(Token = "0x2000880")]
	public class RangedWeapon : Weapon, IVailWeapon
	{
		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06003A41 RID: 14913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000724")]
		public ProjectileTrajectoryOffsetData TrajectoryOffsetData
		{
			[Token(Token = "0x6003A41")]
			[Address(RVA = "0x68B0F0", Offset = "0x68A0F0", VA = "0x18068B0F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A42")]
		[Address(RVA = "0x5E4C40", Offset = "0x5E3C40", VA = "0x1805E4C40")]
		public RangedWeapon.Ammo GetAmmo()
		{
			return null;
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A43")]
		[Address(RVA = "0x5E4C50", Offset = "0x5E3C50", VA = "0x1805E4C50")]
		public void SetAmmo(RangedWeapon.Ammo ammo)
		{
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06003A44 RID: 14916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000725")]
		public Bullet LastFiredProjectile
		{
			[Token(Token = "0x6003A44")]
			[Address(RVA = "0x6B7130", Offset = "0x6B6130", VA = "0x1806B7130")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06003A45 RID: 14917 RVA: 0x00011100 File Offset: 0x0000F300
		// (set) Token: 0x06003A46 RID: 14918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000726")]
		public bool IsAiming
		{
			[Token(Token = "0x6003A45")]
			[Address(RVA = "0x2F04FF0", Offset = "0x2F03FF0", VA = "0x182F04FF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A46")]
			[Address(RVA = "0x2F05000", Offset = "0x2F04000", VA = "0x182F05000")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A47")]
		[Address(RVA = "0x2F02550", Offset = "0x2F01550", VA = "0x182F02550")]
		public void SetIsLocalPlayer(bool isLocalPlayer)
		{
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A48")]
		[Address(RVA = "0x2F01620", Offset = "0x2F00620", VA = "0x182F01620")]
		public void Awake()
		{
		}

		// Token: 0x06003A49 RID: 14921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A49")]
		[Address(RVA = "0x2F02390", Offset = "0x2F01390", VA = "0x182F02390")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003A4A RID: 14922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4A")]
		[Address(RVA = "0x2F02540", Offset = "0x2F01540", VA = "0x182F02540")]
		private void OnRenderableLoaded(Transform rootTransform)
		{
		}

		// Token: 0x06003A4B RID: 14923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4B")]
		[Address(RVA = "0x2F02360", Offset = "0x2F01360", VA = "0x182F02360")]
		public void LateUpdate()
		{
		}

		// Token: 0x06003A4C RID: 14924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4C")]
		[Address(RVA = "0x2F02380", Offset = "0x2F01380", VA = "0x182F02380")]
		public void LockImpactLocationVisibility(bool lockImpactLocationVisibility)
		{
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4D")]
		[Address(RVA = "0x2F034C0", Offset = "0x2F024C0", VA = "0x182F034C0")]
		public void ShowImpactLocation(bool show)
		{
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4E")]
		[Address(RVA = "0x2F048A0", Offset = "0x2F038A0", VA = "0x182F048A0")]
		private void UpdateImpactLocation()
		{
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A4F")]
		[Address(RVA = "0x2F022B0", Offset = "0x2F012B0", VA = "0x182F022B0")]
		public WeaponMods GetWeaponMods()
		{
			return null;
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A50")]
		[Address(RVA = "0x2F01CB0", Offset = "0x2F00CB0", VA = "0x182F01CB0")]
		public void FindProjectileTransformInRenderable()
		{
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06003A51 RID: 14929 RVA: 0x00011118 File Offset: 0x0000F318
		[Token(Token = "0x17000727")]
		public bool CanUseMultipleAmmoTypes
		{
			[Token(Token = "0x6003A51")]
			[Address(RVA = "0x2F04FA0", Offset = "0x2F03FA0", VA = "0x182F04FA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x00011130 File Offset: 0x0000F330
		[Token(Token = "0x6003A52")]
		[Address(RVA = "0x2F01780", Offset = "0x2F00780", VA = "0x182F01780")]
		public bool CanCycleAmmo()
		{
			return default(bool);
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A53")]
		[Address(RVA = "0x2F01900", Offset = "0x2F00900", VA = "0x182F01900")]
		public void CycleAmmoType()
		{
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x00011148 File Offset: 0x0000F348
		[Token(Token = "0x6003A54")]
		[Address(RVA = "0x2F020F0", Offset = "0x2F010F0", VA = "0x182F020F0")]
		public LayerMask GetHitMask()
		{
			return default(LayerMask);
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x00011160 File Offset: 0x0000F360
		[Token(Token = "0x6003A55")]
		[Address(RVA = "0x2F02120", Offset = "0x2F01120", VA = "0x182F02120")]
		public float GetProjectileDamageMultiplier()
		{
			return default(float);
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A56")]
		[Address(RVA = "0x2F021B0", Offset = "0x2F011B0", VA = "0x182F021B0")]
		public Transform GetProjectileTransform()
		{
			return null;
		}

		// Token: 0x06003A57 RID: 14935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A57")]
		[Address(RVA = "0x2F02230", Offset = "0x2F01230", VA = "0x182F02230")]
		public Transform GetProjectileVisualTransform()
		{
			return null;
		}

		// Token: 0x06003A58 RID: 14936 RVA: 0x00011178 File Offset: 0x0000F378
		[Token(Token = "0x6003A58")]
		[Address(RVA = "0x2F03860", Offset = "0x2F02860", VA = "0x182F03860")]
		public BulletHandler.TrajectoryData SimulateTrajectory()
		{
			return default(BulletHandler.TrajectoryData);
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A59")]
		[Address(RVA = "0x2F02910", Offset = "0x2F01910", VA = "0x182F02910")]
		public void Shoot()
		{
		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5A")]
		[Address(RVA = "0x2F03EE0", Offset = "0x2F02EE0", VA = "0x182F03EE0", Slot = "5")]
		private void Shoot(Vector3 targetPos, Vector3 forwardDir)
		{
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5B")]
		[Address(RVA = "0x2F02560", Offset = "0x2F01560", VA = "0x182F02560")]
		private void ShootInternal(Quaternion lookRotation)
		{
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5C")]
		[Address(RVA = "0x2F04420", Offset = "0x2F03420", VA = "0x182F04420")]
		public void Start()
		{
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5D")]
		[Address(RVA = "0x2F04450", Offset = "0x2F03450", VA = "0x182F04450", Slot = "6")]
		public virtual void Throw(Vector3 direction, Transform visualTransform, Vector3 physicalPosition)
		{
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5E")]
		[Address(RVA = "0x2F02D70", Offset = "0x2F01D70", VA = "0x182F02D70", Slot = "4")]
		public override void Shoot(Vector3 direction, float zeroAngle = 0f)
		{
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x00011190 File Offset: 0x0000F390
		[Token(Token = "0x6003A5F")]
		[Address(RVA = "0x2F035C0", Offset = "0x2F025C0", VA = "0x182F035C0")]
		private BulletHandler.TrajectoryData SimulateTrajectory(Vector3 position, Vector3 direction)
		{
			return default(BulletHandler.TrajectoryData);
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A60")]
		[Address(RVA = "0x2F04F80", Offset = "0x2F03F80", VA = "0x182F04F80")]
		public RangedWeapon()
		{
		}

		// Token: 0x04003159 RID: 12633
		[Token(Token = "0x4003159")]
		private const string ProjectileTransformName = "ProjectileTransform";

		// Token: 0x0400315A RID: 12634
		[Token(Token = "0x400315A")]
		private const string ProjectileVisualTransformName = "ProjectileVisualTransform";

		// Token: 0x0400315B RID: 12635
		[Token(Token = "0x400315B")]
		private const string AimTransformName = "AimTransform";

		// Token: 0x0400315C RID: 12636
		[Token(Token = "0x400315C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[ItemIdPicker(512, false)]
		private int _weaponItemId;

		// Token: 0x0400315D RID: 12637
		[Token(Token = "0x400315D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RangedWeapon.Ammo _ammo;

		// Token: 0x0400315E RID: 12638
		[Token(Token = "0x400315E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool _controlledByAI;

		// Token: 0x0400315F RID: 12639
		[Token(Token = "0x400315F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private VailActor _vailActor;

		// Token: 0x04003160 RID: 12640
		[Token(Token = "0x4003160")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _vailVerticalAdjustAngle;

		// Token: 0x04003161 RID: 12641
		[Token(Token = "0x4003161")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _vailAngleVariation;

		// Token: 0x04003162 RID: 12642
		[Token(Token = "0x4003162")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool _useModifiedScreenPostion;

		// Token: 0x04003163 RID: 12643
		[Token(Token = "0x4003163")]
		[FieldOffset(Offset = "0x89")]
		[SerializeField]
		private bool _showImpactLocation;

		// Token: 0x04003164 RID: 12644
		[Token(Token = "0x4003164")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _impactTargetPrefab;

		// Token: 0x04003165 RID: 12645
		[Token(Token = "0x4003165")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _trajectoryPathPrefab;

		// Token: 0x04003166 RID: 12646
		[Token(Token = "0x4003166")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ProjectileTrajectoryOffsetData _trajectoryOffsetData;

		// Token: 0x04003167 RID: 12647
		[Token(Token = "0x4003167")]
		[FieldOffset(Offset = "0xA8")]
		private Transform _projectileTransform;

		// Token: 0x04003168 RID: 12648
		[Token(Token = "0x4003168")]
		[FieldOffset(Offset = "0xB0")]
		private Transform _projectileVisualTransform;

		// Token: 0x04003169 RID: 12649
		[Token(Token = "0x4003169")]
		[FieldOffset(Offset = "0xB8")]
		private Transform _projectilePhysicalSpawnPoint;

		// Token: 0x0400316A RID: 12650
		[Token(Token = "0x400316A")]
		[FieldOffset(Offset = "0xC0")]
		private Transform _aimTransform;

		// Token: 0x0400316B RID: 12651
		[Token(Token = "0x400316B")]
		[FieldOffset(Offset = "0xC8")]
		private WeaponMods _weaponMods;

		// Token: 0x0400316C RID: 12652
		[Token(Token = "0x400316C")]
		[FieldOffset(Offset = "0xD0")]
		private Bullet _lastFiredProjectile;

		// Token: 0x0400316D RID: 12653
		[Token(Token = "0x400316D")]
		[FieldOffset(Offset = "0xD8")]
		private bool _renderableIsLoaded;

		// Token: 0x0400316E RID: 12654
		[Token(Token = "0x400316E")]
		[FieldOffset(Offset = "0xD9")]
		private bool _isLocalPlayer;

		// Token: 0x0400316F RID: 12655
		[Token(Token = "0x400316F")]
		[FieldOffset(Offset = "0xDA")]
		private bool _firstShotDone;

		// Token: 0x04003170 RID: 12656
		[Token(Token = "0x4003170")]
		[FieldOffset(Offset = "0xDC")]
		private Quaternion _projectileRotationOffset;

		// Token: 0x04003171 RID: 12657
		[Token(Token = "0x4003171")]
		[FieldOffset(Offset = "0xF0")]
		private GameObject _simulatedBulletObject;

		// Token: 0x04003172 RID: 12658
		[Token(Token = "0x4003172")]
		[FieldOffset(Offset = "0xF8")]
		private BulletInfo _simulatedBulletInfo;

		// Token: 0x04003173 RID: 12659
		[Token(Token = "0x4003173")]
		[FieldOffset(Offset = "0x100")]
		private Bullet _simulatedBullet;

		// Token: 0x04003174 RID: 12660
		[Token(Token = "0x4003174")]
		[FieldOffset(Offset = "0x108")]
		private LineRenderer _trajectoryPathInstance;

		// Token: 0x04003175 RID: 12661
		[Token(Token = "0x4003175")]
		[FieldOffset(Offset = "0x110")]
		private GameObject _impactTargetInstance;

		// Token: 0x04003176 RID: 12662
		[Token(Token = "0x4003176")]
		[FieldOffset(Offset = "0x118")]
		private bool _lockImpactLocationVisibility;

		// Token: 0x04003178 RID: 12664
		[Token(Token = "0x4003178")]
		[FieldOffset(Offset = "0x0")]
		public static bool ShowDebugTrails;

		// Token: 0x04003179 RID: 12665
		[Token(Token = "0x4003179")]
		[FieldOffset(Offset = "0x120")]
		protected ItemData _itemData;

		// Token: 0x02000881 RID: 2177
		[Token(Token = "0x2000881")]
		[Serializable]
		public class Ammo
		{
			// Token: 0x06003A63 RID: 14947 RVA: 0x000111D8 File Offset: 0x0000F3D8
			[Token(Token = "0x6003A63")]
			[Address(RVA = "0x55E9A0", Offset = "0x55D9A0", VA = "0x18055E9A0")]
			public int GetItemType()
			{
				return default(int);
			}

			// Token: 0x06003A64 RID: 14948 RVA: 0x000111F0 File Offset: 0x0000F3F0
			[Token(Token = "0x6003A64")]
			[Address(RVA = "0x576320", Offset = "0x575320", VA = "0x180576320")]
			public bool UsesInternalAmmoStorage()
			{
				return default(bool);
			}

			// Token: 0x06003A65 RID: 14949 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A65")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			public AmmoProperties GetProperties()
			{
				return null;
			}

			// Token: 0x06003A66 RID: 14950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A66")]
			[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270")]
			public void SetAmmoProperties(AmmoProperties ammoProperties)
			{
			}

			// Token: 0x06003A67 RID: 14951 RVA: 0x00011208 File Offset: 0x0000F408
			[Token(Token = "0x6003A67")]
			[Address(RVA = "0x2EF2AE0", Offset = "0x2EF1AE0", VA = "0x182EF2AE0")]
			public bool IsFull()
			{
				return default(bool);
			}

			// Token: 0x06003A68 RID: 14952 RVA: 0x00011220 File Offset: 0x0000F420
			[Token(Token = "0x6003A68")]
			[Address(RVA = "0x2B07990", Offset = "0x2B06990", VA = "0x182B07990")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x06003A69 RID: 14953 RVA: 0x00011238 File Offset: 0x0000F438
			[Token(Token = "0x6003A69")]
			[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
			public int GetCapacity()
			{
				return default(int);
			}

			// Token: 0x06003A6A RID: 14954 RVA: 0x00011250 File Offset: 0x0000F450
			[Token(Token = "0x6003A6A")]
			[Address(RVA = "0x8CDC40", Offset = "0x8CCC40", VA = "0x1808CDC40")]
			public int GetRemainingAmmo()
			{
				return default(int);
			}

			// Token: 0x06003A6B RID: 14955 RVA: 0x00011268 File Offset: 0x0000F468
			[Token(Token = "0x6003A6B")]
			[Address(RVA = "0x2EF2A70", Offset = "0x2EF1A70", VA = "0x182EF2A70")]
			public int GetRemainingSpace()
			{
				return default(int);
			}

			// Token: 0x06003A6C RID: 14956 RVA: 0x00011280 File Offset: 0x0000F480
			[Token(Token = "0x6003A6C")]
			[Address(RVA = "0x2EF2A80", Offset = "0x2EF1A80", VA = "0x182EF2A80")]
			public bool IsAvailableInInventory()
			{
				return default(bool);
			}

			// Token: 0x06003A6D RID: 14957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A6D")]
			[Address(RVA = "0x2EF2B30", Offset = "0x2EF1B30", VA = "0x182EF2B30")]
			public void Remove(int count)
			{
			}

			// Token: 0x06003A6E RID: 14958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A6E")]
			[Address(RVA = "0x2EF2940", Offset = "0x2EF1940", VA = "0x182EF2940")]
			public void AddAmmo(int count)
			{
			}

			// Token: 0x06003A6F RID: 14959 RVA: 0x00011298 File Offset: 0x0000F498
			[Token(Token = "0x6003A6F")]
			[Address(RVA = "0x2EF2C30", Offset = "0x2EF1C30", VA = "0x182EF2C30")]
			public bool SetItemType(int ammoType)
			{
				return default(bool);
			}

			// Token: 0x06003A70 RID: 14960 RVA: 0x000112B0 File Offset: 0x0000F4B0
			[Token(Token = "0x6003A70")]
			[Address(RVA = "0x2EF2AF0", Offset = "0x2EF1AF0", VA = "0x182EF2AF0")]
			public bool Refresh()
			{
				return default(bool);
			}

			// Token: 0x06003A71 RID: 14961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A71")]
			[Address(RVA = "0x26A5900", Offset = "0x26A4900", VA = "0x1826A5900")]
			public Ammo()
			{
			}

			// Token: 0x0400317A RID: 12666
			[Token(Token = "0x400317A")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[FormerlySerializedAs("_ammoType")]
			[ItemIdPicker(32, false)]
			private int _type;

			// Token: 0x0400317B RID: 12667
			[Token(Token = "0x400317B")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("If this is true, the weapon will consume rounds stored in the weapon. If false, the weapon will consume ammo straight from the inventory")]
			[SerializeField]
			private bool _usesInternalAmmoStorage;

			// Token: 0x0400317C RID: 12668
			[Token(Token = "0x400317C")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private int _maxCount;

			// Token: 0x0400317D RID: 12669
			[Token(Token = "0x400317D")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private int _currentCount;

			// Token: 0x0400317E RID: 12670
			[Token(Token = "0x400317E")]
			[FieldOffset(Offset = "0x20")]
			private bool _isMissingAmmoProperties;

			// Token: 0x0400317F RID: 12671
			[Token(Token = "0x400317F")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			[FormerlySerializedAs("_ammoProperties")]
			public AmmoProperties _properties;
		}
	}
}
