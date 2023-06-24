using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay.GPS
{
	// Token: 0x02000852 RID: 2130
	[Token(Token = "0x2000852")]
	[AddComponentMenu("Sons/Gameplay/GPS/GPSLocator")]
	public class GPSLocator : MonoBehaviour, IItemInstanceModuleConsumer
	{
		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06003CAB RID: 15531 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003CAC RID: 15532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D2")]
		public Transform PinIcon
		{
			[Token(Token = "0x6003CAB")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CAC")]
			[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06003CAD RID: 15533 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003CAE RID: 15534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D3")]
		public Transform PinText
		{
			[Token(Token = "0x6003CAD")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CAE")]
			[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06003CAF RID: 15535 RVA: 0x00012720 File Offset: 0x00010920
		[Token(Token = "0x170007D4")]
		public GPSLocator.Style UIStyle
		{
			[Token(Token = "0x6003CAF")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return GPSLocator.Style.Pin;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06003CB0 RID: 15536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D5")]
		public GPSLocatorIcons.IconData IconData
		{
			[Token(Token = "0x6003CB0")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06003CB1 RID: 15537 RVA: 0x00012738 File Offset: 0x00010938
		[Token(Token = "0x170007D6")]
		public float IconScale
		{
			[Token(Token = "0x6003CB1")]
			[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06003CB2 RID: 15538 RVA: 0x00012750 File Offset: 0x00010950
		[Token(Token = "0x170007D7")]
		public bool PulseIcon
		{
			[Token(Token = "0x6003CB2")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06003CB3 RID: 15539 RVA: 0x00012768 File Offset: 0x00010968
		[Token(Token = "0x170007D8")]
		public bool ConstrainToScreen
		{
			[Token(Token = "0x6003CB3")]
			[Address(RVA = "0x9962C0", Offset = "0x9948C0", VA = "0x1809962C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06003CB4 RID: 15540 RVA: 0x00012780 File Offset: 0x00010980
		[Token(Token = "0x170007D9")]
		public bool ShouldBeepWhenInRange
		{
			[Token(Token = "0x6003CB4")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06003CB5 RID: 15541 RVA: 0x00012798 File Offset: 0x00010998
		[Token(Token = "0x170007DA")]
		public float BeepMaxRangeSqr
		{
			[Token(Token = "0x6003CB5")]
			[Address(RVA = "0x35AB5E0", Offset = "0x35A9BE0", VA = "0x1835AB5E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06003CB6 RID: 15542 RVA: 0x000127B0 File Offset: 0x000109B0
		[Token(Token = "0x170007DB")]
		public bool IsActive
		{
			[Token(Token = "0x6003CB6")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06003CB7 RID: 15543 RVA: 0x000127C8 File Offset: 0x000109C8
		[Token(Token = "0x170007DC")]
		public bool HasPositionHistory
		{
			[Token(Token = "0x6003CB7")]
			[Address(RVA = "0x66E8C0", Offset = "0x66CEC0", VA = "0x18066E8C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06003CB8 RID: 15544 RVA: 0x000127E0 File Offset: 0x000109E0
		[Token(Token = "0x170007DD")]
		public int CurrentIconId
		{
			[Token(Token = "0x6003CB8")]
			[Address(RVA = "0x5FDAB0", Offset = "0x5FC0B0", VA = "0x1805FDAB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06003CB9 RID: 15545 RVA: 0x000127F8 File Offset: 0x000109F8
		[Token(Token = "0x170007DE")]
		public int NextIconId
		{
			[Token(Token = "0x6003CB9")]
			[Address(RVA = "0x35AB5F0", Offset = "0x35A9BF0", VA = "0x1835AB5F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06003CBA RID: 15546 RVA: 0x00012810 File Offset: 0x00010A10
		[Token(Token = "0x170007DF")]
		public int PreviousIconId
		{
			[Token(Token = "0x6003CBA")]
			[Address(RVA = "0x35AB6C0", Offset = "0x35A9CC0", VA = "0x1835AB6C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBB")]
		[Address(RVA = "0x35AB790", Offset = "0x35A9D90", VA = "0x1835AB790")]
		private void Start()
		{
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBC")]
		[Address(RVA = "0x35AB870", Offset = "0x35A9E70", VA = "0x1835AB870")]
		private void OnEnable()
		{
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBD")]
		[Address(RVA = "0x35AB8E0", Offset = "0x35A9EE0", VA = "0x1835AB8E0")]
		private void OnPointOfInterestDiscovered(object eventParameter)
		{
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBE")]
		[Address(RVA = "0x35AB9E0", Offset = "0x35A9FE0", VA = "0x1835AB9E0")]
		public void Initialize()
		{
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBF")]
		[Address(RVA = "0x35ABA30", Offset = "0x35AA030", VA = "0x1835ABA30")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC0")]
		[Address(RVA = "0x35ABB20", Offset = "0x35AA120", VA = "0x1835ABB20")]
		private void OnDisable()
		{
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC1")]
		[Address(RVA = "0x35ABB80", Offset = "0x35AA180", VA = "0x1835ABB80", Slot = "4")]
		public void ModuleRefreshed(ItemInstanceModule module)
		{
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC2")]
		[Address(RVA = "0x8DD0B0", Offset = "0x8DB6B0", VA = "0x1808DD0B0")]
		public void AttachToWorldSimActor(WorldSimActor worldSimActor)
		{
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC3")]
		[Address(RVA = "0x2B88730", Offset = "0x2B86D30", VA = "0x182B88730")]
		public void DetachFromWorldSimActor()
		{
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x00012828 File Offset: 0x00010A28
		[Token(Token = "0x6003CC4")]
		[Address(RVA = "0x35ABD20", Offset = "0x35AA320", VA = "0x1835ABD20")]
		public Vector3 Position()
		{
			return default(Vector3);
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC5")]
		[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
		public List<Vector2> GetHistory()
		{
			return null;
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC6")]
		[Address(RVA = "0x35ABE30", Offset = "0x35AA430", VA = "0x1835ABE30")]
		public static IEnumerable<GPSLocator> GetActiveLocators()
		{
			return null;
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC7")]
		[Address(RVA = "0x35ABE80", Offset = "0x35AA480", VA = "0x1835ABE80")]
		private void ActiveChangedInspector()
		{
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC8")]
		[Address(RVA = "0x35ABE90", Offset = "0x35AA490", VA = "0x1835ABE90")]
		public void EnablePositionHistory(bool enable)
		{
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x00012840 File Offset: 0x00010A40
		[Token(Token = "0x6003CC9")]
		[Address(RVA = "0x35ABEA0", Offset = "0x35AA4A0", VA = "0x1835ABEA0")]
		public bool TrySetIconId(int iconId)
		{
			return default(bool);
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CCA")]
		[Address(RVA = "0x35AC1C0", Offset = "0x35AA7C0", VA = "0x1835AC1C0")]
		public void ForceRefresh()
		{
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CCB")]
		[Address(RVA = "0x35AC1E0", Offset = "0x35AA7E0", VA = "0x1835AC1E0")]
		public void SetActive(bool active)
		{
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CCC")]
		[Address(RVA = "0x35AC210", Offset = "0x35AA810", VA = "0x1835AC210")]
		private void Enable(bool enable)
		{
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CCD")]
		[Address(RVA = "0x35AC750", Offset = "0x35AAD50", VA = "0x1835AC750")]
		private void RecordHistoryNode()
		{
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CCE")]
		[Address(RVA = "0x35AC910", Offset = "0x35AAF10", VA = "0x1835AC910")]
		public GPSLocator()
		{
		}

		// Token: 0x0400333E RID: 13118
		[Token(Token = "0x400333E")]
		private const int MaxHistoryCount = 1024;

		// Token: 0x0400333F RID: 13119
		[Token(Token = "0x400333F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<GPSLocator> _activeLocators;

		// Token: 0x04003340 RID: 13120
		[Token(Token = "0x4003340")]
		[FieldOffset(Offset = "0x8")]
		private static GPSTrackerSystem _gpsTrackerSystem;

		// Token: 0x04003341 RID: 13121
		[Token(Token = "0x4003341")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GPSLocator.Style _uiStyle;

		// Token: 0x04003342 RID: 13122
		[Token(Token = "0x4003342")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(0.1f, 5f)]
		private float _iconScale;

		// Token: 0x04003343 RID: 13123
		[Token(Token = "0x4003343")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _pulseIcon;

		// Token: 0x04003344 RID: 13124
		[Token(Token = "0x4003344")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _constrainToScreen;

		// Token: 0x04003345 RID: 13125
		[Token(Token = "0x4003345")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _recordMovementHistory;

		// Token: 0x04003346 RID: 13126
		[Token(Token = "0x4003346")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _recordEveryNSeconds;

		// Token: 0x04003347 RID: 13127
		[Token(Token = "0x4003347")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _shouldBeepWhenInRange;

		// Token: 0x04003348 RID: 13128
		[Token(Token = "0x4003348")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _beepMaxRange;

		// Token: 0x04003349 RID: 13129
		[Token(Token = "0x4003349")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _isActive;

		// Token: 0x0400334A RID: 13130
		[Token(Token = "0x400334A")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _excludeFromModuleRefresh;

		// Token: 0x0400334B RID: 13131
		[Token(Token = "0x400334B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int _currentLocatorIconId;

		// Token: 0x0400334C RID: 13132
		[Token(Token = "0x400334C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GPSLocatorIcons _locatorIcons;

		// Token: 0x0400334D RID: 13133
		[Token(Token = "0x400334D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _deactivateTrackerOnDisable;

		// Token: 0x0400334E RID: 13134
		[Token(Token = "0x400334E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _pointOfInterestName;

		// Token: 0x0400334F RID: 13135
		[Token(Token = "0x400334F")]
		[FieldOffset(Offset = "0x58")]
		private readonly List<Vector2> _positionHistory;

		// Token: 0x04003350 RID: 13136
		[Token(Token = "0x4003350")]
		[FieldOffset(Offset = "0x60")]
		private GPSLocatorItemInstanceModule _gpsLocatorItemInstanceModule;

		// Token: 0x04003351 RID: 13137
		[Token(Token = "0x4003351")]
		[FieldOffset(Offset = "0x68")]
		public Action<GPSLocator> OnGpsLocatorPropertiesChanged;

		// Token: 0x04003354 RID: 13140
		[Token(Token = "0x4003354")]
		[FieldOffset(Offset = "0x80")]
		public string Text;

		// Token: 0x04003355 RID: 13141
		[Token(Token = "0x4003355")]
		[FieldOffset(Offset = "0x88")]
		private WorldSimActor _worldSimActor;

		// Token: 0x04003356 RID: 13142
		[Token(Token = "0x4003356")]
		[FieldOffset(Offset = "0x90")]
		private GPSLocatorIcons.IconData _currentIconData;

		// Token: 0x04003357 RID: 13143
		[Token(Token = "0x4003357")]
		[FieldOffset(Offset = "0x98")]
		private bool _initialized;

		// Token: 0x02000853 RID: 2131
		[Token(Token = "0x2000853")]
		public enum Style
		{
			// Token: 0x04003359 RID: 13145
			[Token(Token = "0x4003359")]
			Pin,
			// Token: 0x0400335A RID: 13146
			[Token(Token = "0x400335A")]
			IconOnly = 2,
			// Token: 0x0400335B RID: 13147
			[Token(Token = "0x400335B")]
			PlayerPin
		}
	}
}
