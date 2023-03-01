using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Sons.Gameplay.GPS
{
	// Token: 0x0200070A RID: 1802
	[Token(Token = "0x200070A")]
	[AddComponentMenu("Sons/Gameplay/GPS/GPSTrackerSystem")]
	public class GPSTrackerSystem : MonoBehaviour
	{
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06002EE0 RID: 12000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DE")]
		public static List<GPSTrackerSystem> GpsTrackers
		{
			[Token(Token = "0x6002EE0")]
			[Address(RVA = "0x2E315B0", Offset = "0x2E305B0", VA = "0x182E315B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		[Token(Token = "0x6002EE1")]
		[Address(RVA = "0x2E2CE10", Offset = "0x2E2BE10", VA = "0x182E2CE10")]
		public bool HasSignal()
		{
			return default(bool);
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EE2")]
		[Address(RVA = "0x2E2E4B0", Offset = "0x2E2D4B0", VA = "0x182E2E4B0")]
		private void Start()
		{
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EE3")]
		[Address(RVA = "0x2E2E2E0", Offset = "0x2E2D2E0", VA = "0x182E2E2E0")]
		private void ShowScreen(bool show)
		{
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EE4")]
		[Address(RVA = "0x2E2D1C0", Offset = "0x2E2C1C0", VA = "0x182E2D1C0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EE5")]
		[Address(RVA = "0x2E30D10", Offset = "0x2E2FD10", VA = "0x182E30D10")]
		private void UpdateTimeText()
		{
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x0000D608 File Offset: 0x0000B808
		[Token(Token = "0x6002EE6")]
		[Address(RVA = "0x2E2CA90", Offset = "0x2E2BA90", VA = "0x182E2CA90")]
		private static int GetDaysSurvived()
		{
			return default(int);
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x0000D620 File Offset: 0x0000B820
		[Token(Token = "0x6002EE7")]
		[Address(RVA = "0x2E2D150", Offset = "0x2E2C150", VA = "0x182E2D150")]
		private bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EE8")]
		[Address(RVA = "0x2E2D760", Offset = "0x2E2C760", VA = "0x182E2D760")]
		private void OnEnable()
		{
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EE9")]
		[Address(RVA = "0x2E2D700", Offset = "0x2E2C700", VA = "0x182E2D700")]
		private void OnDisable()
		{
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EEA")]
		[Address(RVA = "0x2E2D650", Offset = "0x2E2C650", VA = "0x182E2D650")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EEB")]
		[Address(RVA = "0x2E2CE20", Offset = "0x2E2BE20", VA = "0x182E2CE20")]
		private void Instantiate()
		{
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EEC")]
		[Address(RVA = "0x7B9910", Offset = "0x7B8910", VA = "0x1807B9910")]
		public void SetTrackerLocation(Transform trackerTransform)
		{
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EED")]
		[Address(RVA = "0x2E2EDD0", Offset = "0x2E2DDD0", VA = "0x182E2EDD0")]
		private void UpdateHistoryNodes()
		{
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EEE")]
		[Address(RVA = "0x2E2E5C0", Offset = "0x2E2D5C0", VA = "0x182E2E5C0")]
		private void UpdateGPSLocationsOnMap()
		{
		}

		// Token: 0x06002EEF RID: 12015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EEF")]
		[Address(RVA = "0x2E2FEF0", Offset = "0x2E2EEF0", VA = "0x182E2FEF0")]
		private void UpdateLocatorsOnScreen(GPSLocator gpsLocator, Vector2 worldPosition2D, RectTransform gpsLocatorVisuals, RectTransform gpsLocatorMapLocation)
		{
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EF0")]
		[Address(RVA = "0x2E30580", Offset = "0x2E2F580", VA = "0x182E30580")]
		private void UpdateMapPosition(Vector3 targetWorldPos)
		{
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EF1")]
		[Address(RVA = "0x2E306B0", Offset = "0x2E2F6B0", VA = "0x182E306B0")]
		private void UpdateMapRotation(Vector3 trackerForward)
		{
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EF2")]
		[Address(RVA = "0x2E2DF50", Offset = "0x2E2CF50", VA = "0x182E2DF50")]
		public void SetZoomLevel(int zoomLevel)
		{
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x0000D638 File Offset: 0x0000B838
		[Token(Token = "0x6002EF3")]
		[Address(RVA = "0x2E2CB80", Offset = "0x2E2BB80", VA = "0x182E2CB80")]
		public int GetTotalZoomLevels()
		{
			return default(int);
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x0000D650 File Offset: 0x0000B850
		[Token(Token = "0x6002EF4")]
		[Address(RVA = "0x2E2CD20", Offset = "0x2E2BD20", VA = "0x182E2CD20")]
		private Vector3 GetTrackerPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x0000D668 File Offset: 0x0000B868
		[Token(Token = "0x6002EF5")]
		[Address(RVA = "0x2E2CBC0", Offset = "0x2E2BBC0", VA = "0x182E2CBC0")]
		private Vector3 GetTrackerForward()
		{
			return default(Vector3);
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EF6")]
		[Address(RVA = "0x2E31030", Offset = "0x2E30030", VA = "0x182E31030")]
		private void World2DToMap2D(Vector2 worldPosition, ref Vector2 mapPosition)
		{
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EF7")]
		[Address(RVA = "0x2E2C4F0", Offset = "0x2E2B4F0", VA = "0x182E2C4F0")]
		public void AddGpsLocator(GPSLocator gpsLocator)
		{
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EF8")]
		[Address(RVA = "0x2E2D920", Offset = "0x2E2C920", VA = "0x182E2D920")]
		private void OnGpsLocatorPropertiesChanged(GPSLocator gpsLocator)
		{
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EF9")]
		[Address(RVA = "0x2E2F410", Offset = "0x2E2E410", VA = "0x182E2F410")]
		private void UpdateLocatorVisuals(GPSLocator gpsLocator, RectTransform locatorVisuals)
		{
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EFA")]
		[Address(RVA = "0x2E2DA60", Offset = "0x2E2CA60", VA = "0x182E2DA60")]
		public void RemoveGpsLocator(GPSLocator gpsLocator)
		{
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EFB")]
		[Address(RVA = "0x2E30970", Offset = "0x2E2F970", VA = "0x182E30970")]
		private void UpdateSfx(Vector3 trackerPosition)
		{
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EFC")]
		[Address(RVA = "0x2E2E300", Offset = "0x2E2D300", VA = "0x182E2E300")]
		private void StartSfx()
		{
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EFD")]
		[Address(RVA = "0x2E31160", Offset = "0x2E30160", VA = "0x182E31160")]
		public GPSTrackerSystem()
		{
		}

		// Token: 0x0400297D RID: 10621
		[Token(Token = "0x400297D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ItemRenderable _itemRenderable;

		// Token: 0x0400297E RID: 10622
		[Token(Token = "0x400297E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Canvas _rootCanvas;

		// Token: 0x0400297F RID: 10623
		[Token(Token = "0x400297F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _miniMap;

		// Token: 0x04002980 RID: 10624
		[Token(Token = "0x4002980")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _map;

		// Token: 0x04002981 RID: 10625
		[Token(Token = "0x4002981")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _mapRotator;

		// Token: 0x04002982 RID: 10626
		[Token(Token = "0x4002982")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _playerArrow;

		// Token: 0x04002983 RID: 10627
		[Token(Token = "0x4002983")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _signalLost;

		// Token: 0x04002984 RID: 10628
		[Token(Token = "0x4002984")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _screenStatic;

		// Token: 0x04002985 RID: 10629
		[Token(Token = "0x4002985")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector2 _worldSize;

		// Token: 0x04002986 RID: 10630
		[Token(Token = "0x4002986")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _trackerSignalLost;

		// Token: 0x04002987 RID: 10631
		[Token(Token = "0x4002987")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<float> _mapZoomLevels;

		// Token: 0x04002988 RID: 10632
		[Token(Token = "0x4002988")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _locatorScale;

		// Token: 0x04002989 RID: 10633
		[Token(Token = "0x4002989")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private int _historyNodeCount;

		// Token: 0x0400298A RID: 10634
		[Token(Token = "0x400298A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _historyNodeSpacing;

		// Token: 0x0400298B RID: 10635
		[Token(Token = "0x400298B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _historyNodesGroup;

		// Token: 0x0400298C RID: 10636
		[Token(Token = "0x400298C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _dayText;

		// Token: 0x0400298D RID: 10637
		[Token(Token = "0x400298D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _timeText;

		// Token: 0x0400298E RID: 10638
		[Token(Token = "0x400298E")]
		[FieldOffset(Offset = "0xA0")]
		[FormerlySerializedAs("_trackerLocatorMapArea")]
		[FormerlySerializedAs("_soldierMapArea")]
		[SerializeField]
		private RectTransform _gpsLocatorMapLocation;

		// Token: 0x0400298F RID: 10639
		[Token(Token = "0x400298F")]
		[FieldOffset(Offset = "0xA8")]
		[FormerlySerializedAs("_gpsLocatorEdgeDot")]
		[SerializeField]
		private RectTransform _gpsLocatorVisual;

		// Token: 0x04002990 RID: 10640
		[Token(Token = "0x4002990")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private BoxCollider _screenBoxCollider;

		// Token: 0x04002991 RID: 10641
		[Token(Token = "0x4002991")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _overlappingPinRotationDegrees;

		// Token: 0x04002992 RID: 10642
		[Token(Token = "0x4002992")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _overlappingPinDistanceThreshold;

		// Token: 0x04002993 RID: 10643
		[Token(Token = "0x4002993")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[EventRef]
		public string _trackingSfxEvent;

		// Token: 0x04002994 RID: 10644
		[Token(Token = "0x4002994")]
		[FieldOffset(Offset = "0xC8")]
		[EventRef]
		[SerializeField]
		public string _zoomChangeSfxEvent;

		// Token: 0x04002995 RID: 10645
		[Token(Token = "0x4002995")]
		[FieldOffset(Offset = "0xD0")]
		private readonly List<List<RectTransform>> _gpsLocatorHistory;

		// Token: 0x04002996 RID: 10646
		[Token(Token = "0x4002996")]
		[FieldOffset(Offset = "0xD8")]
		private readonly List<RectTransform> _gpsLocatorMapLocations;

		// Token: 0x04002997 RID: 10647
		[Token(Token = "0x4002997")]
		[FieldOffset(Offset = "0xE0")]
		private readonly List<GPSLocator> _gpsLocators;

		// Token: 0x04002998 RID: 10648
		[Token(Token = "0x4002998")]
		[FieldOffset(Offset = "0xE8")]
		private readonly List<RectTransform> _gpsLocatorVisuals;

		// Token: 0x04002999 RID: 10649
		[Token(Token = "0x4002999")]
		[FieldOffset(Offset = "0xF0")]
		private bool _isInstantiated;

		// Token: 0x0400299A RID: 10650
		[Token(Token = "0x400299A")]
		[FieldOffset(Offset = "0xF8")]
		private Transform _target;

		// Token: 0x0400299B RID: 10651
		[Token(Token = "0x400299B")]
		[FieldOffset(Offset = "0x100")]
		private RectTransform _targetMapDot;

		// Token: 0x0400299C RID: 10652
		[Token(Token = "0x400299C")]
		[FieldOffset(Offset = "0x108")]
		private Transform _trackerLocation;

		// Token: 0x0400299D RID: 10653
		[Token(Token = "0x400299D")]
		[FieldOffset(Offset = "0x110")]
		private EventInstance _trackingSfx;

		// Token: 0x0400299E RID: 10654
		[Token(Token = "0x400299E")]
		[FieldOffset(Offset = "0x118")]
		private int _uiHistoryNodeIndex;

		// Token: 0x0400299F RID: 10655
		[Token(Token = "0x400299F")]
		[FieldOffset(Offset = "0x11C")]
		private Vector3 _trackerCurrentPosition;

		// Token: 0x040029A0 RID: 10656
		[Token(Token = "0x40029A0")]
		[FieldOffset(Offset = "0x128")]
		private Vector3 _trackerCurrentForward;

		// Token: 0x040029A1 RID: 10657
		[Token(Token = "0x40029A1")]
		[FieldOffset(Offset = "0x134")]
		private int _lastDaysSurvived;

		// Token: 0x040029A2 RID: 10658
		[Token(Token = "0x40029A2")]
		[FieldOffset(Offset = "0x138")]
		private int _lastMinutes;

		// Token: 0x040029A3 RID: 10659
		[Token(Token = "0x40029A3")]
		[FieldOffset(Offset = "0x13C")]
		private int _lastHours;

		// Token: 0x040029A5 RID: 10661
		[Token(Token = "0x40029A5")]
		[FieldOffset(Offset = "0x140")]
		private readonly List<int> _alreadyAdjustedLocatorIndices;

		// Token: 0x040029A6 RID: 10662
		[Token(Token = "0x40029A6")]
		[FieldOffset(Offset = "0x148")]
		private readonly List<int> _overlappingLocatorIndices;

		// Token: 0x040029A7 RID: 10663
		[Token(Token = "0x40029A7")]
		[FieldOffset(Offset = "0x150")]
		private readonly List<int> _setIndicies;
	}
}
