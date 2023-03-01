using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay.GPS
{
	// Token: 0x02000704 RID: 1796
	[Token(Token = "0x2000704")]
	[AddComponentMenu("Sons/Gameplay/GPS/GPSLocator")]
	public class GPSLocator : MonoBehaviour, IItemInstanceModuleConsumer
	{
		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06002EB3 RID: 11955 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EB4 RID: 11956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005CF")]
		public Transform PinIcon
		{
			[Token(Token = "0x6002EB3")]
			[Address(RVA = "0x5E4C40", Offset = "0x5E3C40", VA = "0x1805E4C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EB4")]
			[Address(RVA = "0x5E4C50", Offset = "0x5E3C50", VA = "0x1805E4C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06002EB5 RID: 11957 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EB6 RID: 11958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D0")]
		public Transform PinText
		{
			[Token(Token = "0x6002EB5")]
			[Address(RVA = "0x656130", Offset = "0x655130", VA = "0x180656130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EB6")]
			[Address(RVA = "0x656140", Offset = "0x655140", VA = "0x180656140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x0000D470 File Offset: 0x0000B670
		[Token(Token = "0x170005D1")]
		public GPSLocator.Style UIStyle
		{
			[Token(Token = "0x6002EB7")]
			[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
			get
			{
				return GPSLocator.Style.Pin;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06002EB8 RID: 11960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D2")]
		public GPSLocatorIcons.IconData IconData
		{
			[Token(Token = "0x6002EB8")]
			[Address(RVA = "0x7B2340", Offset = "0x7B1340", VA = "0x1807B2340")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06002EB9 RID: 11961 RVA: 0x0000D488 File Offset: 0x0000B688
		[Token(Token = "0x170005D3")]
		public float IconScale
		{
			[Token(Token = "0x6002EB9")]
			[Address(RVA = "0x567910", Offset = "0x566910", VA = "0x180567910")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06002EBA RID: 11962 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		[Token(Token = "0x170005D4")]
		public bool PulseIcon
		{
			[Token(Token = "0x6002EBA")]
			[Address(RVA = "0x5BA880", Offset = "0x5B9880", VA = "0x1805BA880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06002EBB RID: 11963 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		[Token(Token = "0x170005D5")]
		public bool ConstrainToScreen
		{
			[Token(Token = "0x6002EBB")]
			[Address(RVA = "0x931D10", Offset = "0x930D10", VA = "0x180931D10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		[Token(Token = "0x170005D6")]
		public bool ShouldBeepWhenInRange
		{
			[Token(Token = "0x6002EBC")]
			[Address(RVA = "0x5A15F0", Offset = "0x5A05F0", VA = "0x1805A15F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06002EBD RID: 11965 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		[Token(Token = "0x170005D7")]
		public float BeepMaxRangeSqr
		{
			[Token(Token = "0x6002EBD")]
			[Address(RVA = "0x2E2C340", Offset = "0x2E2B340", VA = "0x182E2C340")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x0000D500 File Offset: 0x0000B700
		[Token(Token = "0x170005D8")]
		public bool IsActive
		{
			[Token(Token = "0x6002EBE")]
			[Address(RVA = "0x576470", Offset = "0x575470", VA = "0x180576470")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06002EBF RID: 11967 RVA: 0x0000D518 File Offset: 0x0000B718
		[Token(Token = "0x170005D9")]
		public bool HasPositionHistory
		{
			[Token(Token = "0x6002EBF")]
			[Address(RVA = "0x5F6720", Offset = "0x5F5720", VA = "0x1805F6720")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x0000D530 File Offset: 0x0000B730
		[Token(Token = "0x170005DA")]
		public int CurrentIconId
		{
			[Token(Token = "0x6002EC0")]
			[Address(RVA = "0x5763E0", Offset = "0x5753E0", VA = "0x1805763E0")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06002EC1 RID: 11969 RVA: 0x0000D548 File Offset: 0x0000B748
		[Token(Token = "0x170005DB")]
		public int NextIconId
		{
			[Token(Token = "0x6002EC1")]
			[Address(RVA = "0x2E2C350", Offset = "0x2E2B350", VA = "0x182E2C350")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x0000D560 File Offset: 0x0000B760
		[Token(Token = "0x170005DC")]
		public int PreviousIconId
		{
			[Token(Token = "0x6002EC2")]
			[Address(RVA = "0x2E2C420", Offset = "0x2E2B420", VA = "0x182E2C420")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EC3")]
		[Address(RVA = "0x2E2BCA0", Offset = "0x2E2ACA0", VA = "0x182E2BCA0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EC4")]
		[Address(RVA = "0x2E2BA90", Offset = "0x2E2AA90", VA = "0x182E2BA90")]
		public void Initialize()
		{
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EC5")]
		[Address(RVA = "0x2E2BC30", Offset = "0x2E2AC30", VA = "0x182E2BC30")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EC6")]
		[Address(RVA = "0x2E2BC40", Offset = "0x2E2AC40", VA = "0x182E2BC40")]
		private void OnDisable()
		{
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EC7")]
		[Address(RVA = "0x2E2BAE0", Offset = "0x2E2AAE0", VA = "0x182E2BAE0", Slot = "4")]
		public void ModuleRefreshed(ItemInstanceModule module)
		{
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EC8")]
		[Address(RVA = "0x7B2370", Offset = "0x7B1370", VA = "0x1807B2370")]
		public void AttachToWorldSimActor(WorldSimActor worldSimActor)
		{
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EC9")]
		[Address(RVA = "0x267EB40", Offset = "0x267DB40", VA = "0x18267EB40")]
		public void DetachFromWorldSimActor()
		{
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x0000D578 File Offset: 0x0000B778
		[Token(Token = "0x6002ECA")]
		[Address(RVA = "0x2E2BD10", Offset = "0x2E2AD10", VA = "0x182E2BD10")]
		public Vector3 Position()
		{
			return default(Vector3);
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECB")]
		[Address(RVA = "0x5E9610", Offset = "0x5E8610", VA = "0x1805E9610")]
		public List<Vector2> GetHistory()
		{
			return null;
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECC")]
		[Address(RVA = "0x2E2BA40", Offset = "0x2E2AA40", VA = "0x182E2BA40")]
		public static IEnumerable<GPSLocator> GetActiveLocators()
		{
			return null;
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ECD")]
		[Address(RVA = "0x2E2B5D0", Offset = "0x2E2A5D0", VA = "0x182E2B5D0")]
		private void ActiveChangedInspector()
		{
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ECE")]
		[Address(RVA = "0x2E2B5E0", Offset = "0x2E2A5E0", VA = "0x182E2B5E0")]
		public void EnablePositionHistory(bool enable)
		{
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x0000D590 File Offset: 0x0000B790
		[Token(Token = "0x6002ECF")]
		[Address(RVA = "0x2E2BF90", Offset = "0x2E2AF90", VA = "0x182E2BF90")]
		public bool TrySetIconId(int iconId)
		{
			return default(bool);
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED0")]
		[Address(RVA = "0x2E2BA20", Offset = "0x2E2AA20", VA = "0x182E2BA20")]
		public void ForceRefresh()
		{
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED1")]
		[Address(RVA = "0x2E2BF60", Offset = "0x2E2AF60", VA = "0x182E2BF60")]
		public void SetActive(bool active)
		{
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED2")]
		[Address(RVA = "0x2E2B5F0", Offset = "0x2E2A5F0", VA = "0x182E2B5F0")]
		private void Enable(bool enable)
		{
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED3")]
		[Address(RVA = "0x2E2BD80", Offset = "0x2E2AD80", VA = "0x182E2BD80")]
		private void RecordHistoryNode()
		{
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED4")]
		[Address(RVA = "0x2E2C280", Offset = "0x2E2B280", VA = "0x182E2C280")]
		public GPSLocator()
		{
		}

		// Token: 0x04002957 RID: 10583
		[Token(Token = "0x4002957")]
		private const int MaxHistoryCount = 1024;

		// Token: 0x04002958 RID: 10584
		[Token(Token = "0x4002958")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<GPSLocator> _activeLocators;

		// Token: 0x04002959 RID: 10585
		[Token(Token = "0x4002959")]
		[FieldOffset(Offset = "0x8")]
		private static GPSTrackerSystem _gpsTrackerSystem;

		// Token: 0x0400295A RID: 10586
		[Token(Token = "0x400295A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GPSLocator.Style _uiStyle;

		// Token: 0x0400295B RID: 10587
		[Token(Token = "0x400295B")]
		[FieldOffset(Offset = "0x24")]
		[Range(0.1f, 5f)]
		[SerializeField]
		private float _iconScale;

		// Token: 0x0400295C RID: 10588
		[Token(Token = "0x400295C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _pulseIcon;

		// Token: 0x0400295D RID: 10589
		[Token(Token = "0x400295D")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _constrainToScreen;

		// Token: 0x0400295E RID: 10590
		[Token(Token = "0x400295E")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _recordMovementHistory;

		// Token: 0x0400295F RID: 10591
		[Token(Token = "0x400295F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _recordEveryNSeconds;

		// Token: 0x04002960 RID: 10592
		[Token(Token = "0x4002960")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _shouldBeepWhenInRange;

		// Token: 0x04002961 RID: 10593
		[Token(Token = "0x4002961")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _beepMaxRange;

		// Token: 0x04002962 RID: 10594
		[Token(Token = "0x4002962")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _isActive;

		// Token: 0x04002963 RID: 10595
		[Token(Token = "0x4002963")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _excludeFromModuleRefresh;

		// Token: 0x04002964 RID: 10596
		[Token(Token = "0x4002964")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int _currentLocatorIconId;

		// Token: 0x04002965 RID: 10597
		[Token(Token = "0x4002965")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GPSLocatorIcons _locatorIcons;

		// Token: 0x04002966 RID: 10598
		[Token(Token = "0x4002966")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _deactivateTrackerOnDisable;

		// Token: 0x04002967 RID: 10599
		[Token(Token = "0x4002967")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<Vector2> _positionHistory;

		// Token: 0x04002968 RID: 10600
		[Token(Token = "0x4002968")]
		[FieldOffset(Offset = "0x58")]
		private GPSLocatorItemInstanceModule _gpsLocatorItemInstanceModule;

		// Token: 0x04002969 RID: 10601
		[Token(Token = "0x4002969")]
		[FieldOffset(Offset = "0x60")]
		public Action<GPSLocator> OnGpsLocatorPropertiesChanged;

		// Token: 0x0400296C RID: 10604
		[Token(Token = "0x400296C")]
		[FieldOffset(Offset = "0x78")]
		public string Text;

		// Token: 0x0400296D RID: 10605
		[Token(Token = "0x400296D")]
		[FieldOffset(Offset = "0x80")]
		private WorldSimActor _worldSimActor;

		// Token: 0x0400296E RID: 10606
		[Token(Token = "0x400296E")]
		[FieldOffset(Offset = "0x88")]
		private GPSLocatorIcons.IconData _currentIconData;

		// Token: 0x0400296F RID: 10607
		[Token(Token = "0x400296F")]
		[FieldOffset(Offset = "0x90")]
		private bool _initialized;

		// Token: 0x02000705 RID: 1797
		[Token(Token = "0x2000705")]
		public enum Style
		{
			// Token: 0x04002971 RID: 10609
			[Token(Token = "0x4002971")]
			Pin,
			// Token: 0x04002972 RID: 10610
			[Token(Token = "0x4002972")]
			IconOnly = 2,
			// Token: 0x04002973 RID: 10611
			[Token(Token = "0x4002973")]
			PlayerPin
		}
	}
}
