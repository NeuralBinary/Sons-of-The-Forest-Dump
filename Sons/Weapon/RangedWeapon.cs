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
	// Token: 0x020008F2 RID: 2290
	[Token(Token = "0x20008F2")]
	public class RangedWeapon : Weapon, IVailWeapon
	{
		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06004169 RID: 16745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000848")]
		public ProjectileTrajectoryOffsetData TrajectoryOffsetData
		{
			[Token(Token = "0x6004169")]
			[Address(RVA = "0x737420", Offset = "0x735A20", VA = "0x180737420")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600416A")]
		[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
		public RangedWeapon.Ammo GetAmmo()
		{
			return null;
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600416B")]
		[Address(RVA = "0x675FB0", Offset = "0x6745B0", VA = "0x180675FB0")]
		public void SetAmmo(RangedWeapon.Ammo ammo)
		{
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x0600416C RID: 16748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000849")]
		public Bullet LastFiredProjectile
		{
			[Token(Token = "0x600416C")]
			[Address(RVA = "0x784A30", Offset = "0x783030", VA = "0x180784A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x00013F98 File Offset: 0x00012198
		// (set) Token: 0x0600416E RID: 16750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700084A")]
		public bool IsAiming
		{
			[Token(Token = "0x600416D")]
			[Address(RVA = "0x30AECE0", Offset = "0x30AD2E0", VA = "0x1830AECE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600416E")]
			[Address(RVA = "0x3610F50", Offset = "0x360F550", VA = "0x183610F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x0600416F RID: 16751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084B")]
		public ItemData ItemData
		{
			[Token(Token = "0x600416F")]
			[Address(RVA = "0x3610F60", Offset = "0x360F560", VA = "0x183610F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004170")]
		[Address(RVA = "0x3611090", Offset = "0x360F690", VA = "0x183611090")]
		public void SetIsLocalPlayer(bool isLocalPlayer)
		{
		}

		// Token: 0x06004171 RID: 16753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004171")]
		[Address(RVA = "0x36110A0", Offset = "0x360F6A0", VA = "0x1836110A0")]
		public void Awake()
		{
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004172")]
		[Address(RVA = "0x36112F0", Offset = "0x360F8F0", VA = "0x1836112F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004173")]
		[Address(RVA = "0x3611690", Offset = "0x360FC90", VA = "0x183611690")]
		private void OnRenderableLoaded(Transform rootTransform)
		{
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004174")]
		[Address(RVA = "0x36116A0", Offset = "0x360FCA0", VA = "0x1836116A0")]
		public void LateUpdate()
		{
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004175")]
		[Address(RVA = "0x3301590", Offset = "0x32FFB90", VA = "0x183301590")]
		public void LockImpactLocationVisibility(bool lockImpactLocationVisibility)
		{
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004176")]
		[Address(RVA = "0x36116C0", Offset = "0x360FCC0", VA = "0x1836116C0")]
		public void ShowImpactLocation(bool show)
		{
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004177")]
		[Address(RVA = "0x36118B0", Offset = "0x360FEB0", VA = "0x1836118B0")]
		private void UpdateImpactLocation()
		{
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004178")]
		[Address(RVA = "0x36124C0", Offset = "0x3610AC0", VA = "0x1836124C0")]
		public WeaponMods GetWeaponMods()
		{
			return null;
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004179")]
		[Address(RVA = "0x3612600", Offset = "0x3610C00", VA = "0x183612600")]
		public void FindProjectileTransformInRenderable()
		{
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x0600417A RID: 16762 RVA: 0x00013FB0 File Offset: 0x000121B0
		[Token(Token = "0x1700084C")]
		public bool CanUseMultipleAmmoTypes
		{
			[Token(Token = "0x600417A")]
			[Address(RVA = "0x3613100", Offset = "0x3611700", VA = "0x183613100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x00013FC8 File Offset: 0x000121C8
		[Token(Token = "0x600417B")]
		[Address(RVA = "0x3613150", Offset = "0x3611750", VA = "0x183613150")]
		public bool CanCycleAmmo()
		{
			return default(bool);
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600417C")]
		[Address(RVA = "0x36132D0", Offset = "0x36118D0", VA = "0x1836132D0")]
		public void CycleAmmoType()
		{
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x00013FE0 File Offset: 0x000121E0
		[Token(Token = "0x600417D")]
		[Address(RVA = "0x36136D0", Offset = "0x3611CD0", VA = "0x1836136D0")]
		public LayerMask GetHitMask()
		{
			return default(LayerMask);
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x00013FF8 File Offset: 0x000121F8
		[Token(Token = "0x600417E")]
		[Address(RVA = "0x3613700", Offset = "0x3611D00", VA = "0x183613700")]
		public float GetProjectileDamageMultiplier()
		{
			return 0f;
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417F")]
		[Address(RVA = "0x36137F0", Offset = "0x3611DF0", VA = "0x1836137F0")]
		public Transform GetProjectileTransform()
		{
			return null;
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004180")]
		[Address(RVA = "0x36138C0", Offset = "0x3611EC0", VA = "0x1836138C0")]
		public Transform GetProjectileVisualTransform()
		{
			return null;
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x00014010 File Offset: 0x00012210
		[Token(Token = "0x6004181")]
		[Address(RVA = "0x3613990", Offset = "0x3611F90", VA = "0x183613990")]
		public BulletHandler.TrajectoryData SimulateTrajectory()
		{
			return default(BulletHandler.TrajectoryData);
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004182")]
		[Address(RVA = "0x3614320", Offset = "0x3612920", VA = "0x183614320")]
		public void Shoot()
		{
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004183")]
		[Address(RVA = "0x3614A80", Offset = "0x3613080", VA = "0x183614A80", Slot = "5")]
		private void Shoot(Vector3 targetPos, Vector3 targetVel, Vector3 forwardDir)
		{
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004184")]
		[Address(RVA = "0x3615000", Offset = "0x3613600", VA = "0x183615000")]
		private void ShootInternal(Quaternion lookRotation)
		{
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004185")]
		[Address(RVA = "0x3615460", Offset = "0x3613A60", VA = "0x183615460")]
		public void Start()
		{
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004186")]
		[Address(RVA = "0x36154D0", Offset = "0x3613AD0", VA = "0x1836154D0", Slot = "6")]
		public virtual void Throw(Vector3 direction, Transform visualTransform, Vector3 physicalPosition)
		{
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004187")]
		[Address(RVA = "0x3615C00", Offset = "0x3614200", VA = "0x183615C00", Slot = "4")]
		public override void Shoot(Vector3 direction, float zeroAngle = 0f)
		{
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x00014028 File Offset: 0x00012228
		[Token(Token = "0x6004188")]
		[Address(RVA = "0x3616670", Offset = "0x3614C70", VA = "0x183616670")]
		private BulletHandler.TrajectoryData SimulateTrajectory(Vector3 position, Vector3 direction)
		{
			return default(BulletHandler.TrajectoryData);
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004189")]
		[Address(RVA = "0x36169A0", Offset = "0x3614FA0", VA = "0x1836169A0")]
		public RangedWeapon()
		{
		}

		// Token: 0x04003623 RID: 13859
		[Token(Token = "0x4003623")]
		private const string ProjectileTransformName = "ProjectileTransform";

		// Token: 0x04003624 RID: 13860
		[Token(Token = "0x4003624")]
		private const string ProjectileVisualTransformName = "ProjectileVisualTransform";

		// Token: 0x04003625 RID: 13861
		[Token(Token = "0x4003625")]
		private const string AimTransformName = "AimTransform";

		// Token: 0x04003626 RID: 13862
		[Token(Token = "0x4003626")]
		[FieldOffset(Offset = "0x60")]
		[ItemIdPicker(Types.RangedWeapon, false)]
		[SerializeField]
		private int _weaponItemId;

		// Token: 0x04003627 RID: 13863
		[Token(Token = "0x4003627")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RangedWeapon.Ammo _ammo;

		// Token: 0x04003628 RID: 13864
		[Token(Token = "0x4003628")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool _controlledByAI;

		// Token: 0x04003629 RID: 13865
		[Token(Token = "0x4003629")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private VailActor _vailActor;

		// Token: 0x0400362A RID: 13866
		[Token(Token = "0x400362A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _vailVerticalAdjustAngle;

		// Token: 0x0400362B RID: 13867
		[Token(Token = "0x400362B")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _vailAngleVariation;

		// Token: 0x0400362C RID: 13868
		[Token(Token = "0x400362C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool _useModifiedScreenPostion;

		// Token: 0x0400362D RID: 13869
		[Token(Token = "0x400362D")]
		[FieldOffset(Offset = "0x89")]
		[SerializeField]
		private bool _showImpactLocation;

		// Token: 0x0400362E RID: 13870
		[Token(Token = "0x400362E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _impactTargetPrefab;

		// Token: 0x0400362F RID: 13871
		[Token(Token = "0x400362F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _trajectoryPathPrefab;

		// Token: 0x04003630 RID: 13872
		[Token(Token = "0x4003630")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ProjectileTrajectoryOffsetData _trajectoryOffsetData;

		// Token: 0x04003631 RID: 13873
		[Token(Token = "0x4003631")]
		[FieldOffset(Offset = "0xA8")]
		private Transform _projectileTransform;

		// Token: 0x04003632 RID: 13874
		[Token(Token = "0x4003632")]
		[FieldOffset(Offset = "0xB0")]
		private Transform _projectileVisualTransform;

		// Token: 0x04003633 RID: 13875
		[Token(Token = "0x4003633")]
		[FieldOffset(Offset = "0xB8")]
		private Transform _projectilePhysicalSpawnPoint;

		// Token: 0x04003634 RID: 13876
		[Token(Token = "0x4003634")]
		[FieldOffset(Offset = "0xC0")]
		private Transform _aimTransform;

		// Token: 0x04003635 RID: 13877
		[Token(Token = "0x4003635")]
		[FieldOffset(Offset = "0xC8")]
		private WeaponMods _weaponMods;

		// Token: 0x04003636 RID: 13878
		[Token(Token = "0x4003636")]
		[FieldOffset(Offset = "0xD0")]
		private Bullet _lastFiredProjectile;

		// Token: 0x04003637 RID: 13879
		[Token(Token = "0x4003637")]
		[FieldOffset(Offset = "0xD8")]
		private bool _renderableIsLoaded;

		// Token: 0x04003638 RID: 13880
		[Token(Token = "0x4003638")]
		[FieldOffset(Offset = "0xD9")]
		private bool _isLocalPlayer;

		// Token: 0x04003639 RID: 13881
		[Token(Token = "0x4003639")]
		[FieldOffset(Offset = "0xDA")]
		private bool _firstShotDone;

		// Token: 0x0400363A RID: 13882
		[Token(Token = "0x400363A")]
		[FieldOffset(Offset = "0xDC")]
		private Quaternion _projectileRotationOffset;

		// Token: 0x0400363B RID: 13883
		[Token(Token = "0x400363B")]
		[FieldOffset(Offset = "0xF0")]
		private GameObject _simulatedBulletObject;

		// Token: 0x0400363C RID: 13884
		[Token(Token = "0x400363C")]
		[FieldOffset(Offset = "0xF8")]
		private BulletInfo _simulatedBulletInfo;

		// Token: 0x0400363D RID: 13885
		[Token(Token = "0x400363D")]
		[FieldOffset(Offset = "0x100")]
		private Bullet _simulatedBullet;

		// Token: 0x0400363E RID: 13886
		[Token(Token = "0x400363E")]
		[FieldOffset(Offset = "0x108")]
		private LineRenderer _trajectoryPathInstance;

		// Token: 0x0400363F RID: 13887
		[Token(Token = "0x400363F")]
		[FieldOffset(Offset = "0x110")]
		private GameObject _impactTargetInstance;

		// Token: 0x04003640 RID: 13888
		[Token(Token = "0x4003640")]
		[FieldOffset(Offset = "0x118")]
		private bool _lockImpactLocationVisibility;

		// Token: 0x04003642 RID: 13890
		[Token(Token = "0x4003642")]
		[FieldOffset(Offset = "0x0")]
		public static bool ShowDebugTrails;

		// Token: 0x04003643 RID: 13891
		[Token(Token = "0x4003643")]
		[FieldOffset(Offset = "0x120")]
		protected ItemData _itemData;

		// Token: 0x020008F3 RID: 2291
		[Token(Token = "0x20008F3")]
		[Serializable]
		public class Ammo
		{
			// Token: 0x0600418C RID: 16780 RVA: 0x00014070 File Offset: 0x00012270
			[Token(Token = "0x600418C")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			public int GetItemType()
			{
				return 0;
			}

			// Token: 0x0600418D RID: 16781 RVA: 0x00014088 File Offset: 0x00012288
			[Token(Token = "0x600418D")]
			[Address(RVA = "0x5FD560", Offset = "0x5FBB60", VA = "0x1805FD560")]
			public bool UsesInternalAmmoStorage()
			{
				return default(bool);
			}

			// Token: 0x0600418E RID: 16782 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600418E")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			public AmmoProperties GetProperties()
			{
				return null;
			}

			// Token: 0x0600418F RID: 16783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600418F")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			public void SetAmmoProperties(AmmoProperties ammoProperties)
			{
			}

			// Token: 0x06004190 RID: 16784 RVA: 0x000140A0 File Offset: 0x000122A0
			[Token(Token = "0x6004190")]
			[Address(RVA = "0x362B370", Offset = "0x3629970", VA = "0x18362B370")]
			public bool IsFull()
			{
				return default(bool);
			}

			// Token: 0x06004191 RID: 16785 RVA: 0x000140B8 File Offset: 0x000122B8
			[Token(Token = "0x6004191")]
			[Address(RVA = "0x3131080", Offset = "0x312F680", VA = "0x183131080")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x06004192 RID: 16786 RVA: 0x000140D0 File Offset: 0x000122D0
			[Token(Token = "0x6004192")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			public int GetCapacity()
			{
				return 0;
			}

			// Token: 0x06004193 RID: 16787 RVA: 0x000140E8 File Offset: 0x000122E8
			[Token(Token = "0x6004193")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
			public int GetRemainingAmmo()
			{
				return 0;
			}

			// Token: 0x06004194 RID: 16788 RVA: 0x00014100 File Offset: 0x00012300
			[Token(Token = "0x6004194")]
			[Address(RVA = "0x362B380", Offset = "0x3629980", VA = "0x18362B380")]
			public int GetRemainingSpace()
			{
				return 0;
			}

			// Token: 0x06004195 RID: 16789 RVA: 0x00014118 File Offset: 0x00012318
			[Token(Token = "0x6004195")]
			[Address(RVA = "0x362B390", Offset = "0x3629990", VA = "0x18362B390")]
			public bool IsAvailableInInventory()
			{
				return default(bool);
			}

			// Token: 0x06004196 RID: 16790 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004196")]
			[Address(RVA = "0x362B3F0", Offset = "0x36299F0", VA = "0x18362B3F0")]
			public void Remove(int count)
			{
			}

			// Token: 0x06004197 RID: 16791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004197")]
			[Address(RVA = "0x362B4F0", Offset = "0x3629AF0", VA = "0x18362B4F0")]
			public void AddAmmo(int count)
			{
			}

			// Token: 0x06004198 RID: 16792 RVA: 0x00014130 File Offset: 0x00012330
			[Token(Token = "0x6004198")]
			[Address(RVA = "0x362B630", Offset = "0x3629C30", VA = "0x18362B630")]
			public bool SetItemType(int ammoType)
			{
				return default(bool);
			}

			// Token: 0x06004199 RID: 16793 RVA: 0x00014148 File Offset: 0x00012348
			[Token(Token = "0x6004199")]
			[Address(RVA = "0x362B830", Offset = "0x3629E30", VA = "0x18362B830")]
			public bool Refresh()
			{
				return default(bool);
			}

			// Token: 0x0600419A RID: 16794 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600419A")]
			[Address(RVA = "0x2BC0FA0", Offset = "0x2BBF5A0", VA = "0x182BC0FA0")]
			public Ammo()
			{
			}

			// Token: 0x04003644 RID: 13892
			[Token(Token = "0x4003644")]
			[FieldOffset(Offset = "0x10")]
			[ItemIdPicker(Types.Ammo, false)]
			[FormerlySerializedAs("_ammoType")]
			[SerializeField]
			private int _type;

			// Token: 0x04003645 RID: 13893
			[Token(Token = "0x4003645")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("If this is true, the weapon will consume rounds stored in the weapon. If false, the weapon will consume ammo straight from the inventory")]
			[SerializeField]
			private bool _usesInternalAmmoStorage;

			// Token: 0x04003646 RID: 13894
			[Token(Token = "0x4003646")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private int _maxCount;

			// Token: 0x04003647 RID: 13895
			[Token(Token = "0x4003647")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private int _currentCount;

			// Token: 0x04003648 RID: 13896
			[Token(Token = "0x4003648")]
			[FieldOffset(Offset = "0x20")]
			private bool _isMissingAmmoProperties;

			// Token: 0x04003649 RID: 13897
			[Token(Token = "0x4003649")]
			[FieldOffset(Offset = "0x28")]
			[FormerlySerializedAs("_ammoProperties")]
			[SerializeField]
			public AmmoProperties _properties;
		}
	}
}
