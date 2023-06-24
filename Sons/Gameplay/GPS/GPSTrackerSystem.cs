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
	// Token: 0x02000858 RID: 2136
	[Token(Token = "0x2000858")]
	[AddComponentMenu("Sons/Gameplay/GPS/GPSTrackerSystem")]
	public class GPSTrackerSystem : MonoBehaviour
	{
		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06003CDA RID: 15578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E1")]
		public static List<GPSTrackerSystem> GpsTrackers
		{
			[Token(Token = "0x6003CDA")]
			[Address(RVA = "0x35AD230", Offset = "0x35AB830", VA = "0x1835AD230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x000128A0 File Offset: 0x00010AA0
		[Token(Token = "0x6003CDB")]
		[Address(RVA = "0x35AD280", Offset = "0x35AB880", VA = "0x1835AD280")]
		public bool HasSignal()
		{
			return default(bool);
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CDC")]
		[Address(RVA = "0x35AD290", Offset = "0x35AB890", VA = "0x1835AD290")]
		private void Start()
		{
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CDD")]
		[Address(RVA = "0x35AD3C0", Offset = "0x35AB9C0", VA = "0x1835AD3C0")]
		private void ShowScreen(bool show)
		{
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CDE")]
		[Address(RVA = "0x35AD430", Offset = "0x35ABA30", VA = "0x1835AD430")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CDF")]
		[Address(RVA = "0x35ADB70", Offset = "0x35AC170", VA = "0x1835ADB70")]
		private void UpdateNorthArrow()
		{
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE0")]
		[Address(RVA = "0x35AE050", Offset = "0x35AC650", VA = "0x1835AE050")]
		private void UpdateTimeText()
		{
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x000128B8 File Offset: 0x00010AB8
		[Token(Token = "0x6003CE1")]
		[Address(RVA = "0x35AE530", Offset = "0x35ACB30", VA = "0x1835AE530")]
		private static int GetDaysSurvived()
		{
			return 0;
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x000128D0 File Offset: 0x00010AD0
		[Token(Token = "0x6003CE2")]
		[Address(RVA = "0x35AE620", Offset = "0x35ACC20", VA = "0x1835AE620")]
		private bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE3")]
		[Address(RVA = "0x35AE6F0", Offset = "0x35ACCF0", VA = "0x1835AE6F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE4")]
		[Address(RVA = "0x35AE8B0", Offset = "0x35ACEB0", VA = "0x1835AE8B0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE5")]
		[Address(RVA = "0x35AE910", Offset = "0x35ACF10", VA = "0x1835AE910")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE6")]
		[Address(RVA = "0x35AE9C0", Offset = "0x35ACFC0", VA = "0x1835AE9C0")]
		private void Instantiate()
		{
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE7")]
		[Address(RVA = "0x8DF570", Offset = "0x8DDB70", VA = "0x1808DF570")]
		public void SetTrackerLocation(Transform trackerTransform)
		{
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE8")]
		[Address(RVA = "0x35AED50", Offset = "0x35AD350", VA = "0x1835AED50")]
		private void UpdateHistoryNodes()
		{
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE9")]
		[Address(RVA = "0x35AF4D0", Offset = "0x35ADAD0", VA = "0x1835AF4D0")]
		private void UpdateGPSLocationsOnMap()
		{
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEA")]
		[Address(RVA = "0x35AFEF0", Offset = "0x35AE4F0", VA = "0x1835AFEF0")]
		private void UpdateLocatorsOnScreen(GPSLocator gpsLocator, Vector2 worldPosition2D, RectTransform gpsLocatorVisuals, RectTransform gpsLocatorMapLocation)
		{
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEB")]
		[Address(RVA = "0x35B09C0", Offset = "0x35AEFC0", VA = "0x1835B09C0")]
		private void UpdateMapPosition(Vector3 targetWorldPos)
		{
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEC")]
		[Address(RVA = "0x35B0B40", Offset = "0x35AF140", VA = "0x1835B0B40")]
		private void UpdateMapRotation(Vector3 trackerForward)
		{
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CED")]
		[Address(RVA = "0x35B0CC0", Offset = "0x35AF2C0", VA = "0x1835B0CC0")]
		public void SetZoomLevel(int zoomLevel)
		{
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x000128E8 File Offset: 0x00010AE8
		[Token(Token = "0x6003CEE")]
		[Address(RVA = "0x35B11D0", Offset = "0x35AF7D0", VA = "0x1835B11D0")]
		public int GetTotalZoomLevels()
		{
			return 0;
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x00012900 File Offset: 0x00010B00
		[Token(Token = "0x6003CEF")]
		[Address(RVA = "0x35B1210", Offset = "0x35AF810", VA = "0x1835B1210")]
		private Vector3 GetTrackerPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06003CF0 RID: 15600 RVA: 0x00012918 File Offset: 0x00010B18
		[Token(Token = "0x6003CF0")]
		[Address(RVA = "0x35B13F0", Offset = "0x35AF9F0", VA = "0x1835B13F0")]
		private Vector3 GetTrackerForward()
		{
			return default(Vector3);
		}

		// Token: 0x06003CF1 RID: 15601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF1")]
		[Address(RVA = "0x35B15A0", Offset = "0x35AFBA0", VA = "0x1835B15A0")]
		private void World2DToMap2D(Vector2 worldPosition, ref Vector2 mapPosition)
		{
		}

		// Token: 0x06003CF2 RID: 15602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF2")]
		[Address(RVA = "0x35B1670", Offset = "0x35AFC70", VA = "0x1835B1670")]
		public void AddGpsLocator(GPSLocator gpsLocator)
		{
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF3")]
		[Address(RVA = "0x35B1EA0", Offset = "0x35B04A0", VA = "0x1835B1EA0")]
		private void OnGpsLocatorPropertiesChanged(GPSLocator gpsLocator)
		{
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF4")]
		[Address(RVA = "0x35B2020", Offset = "0x35B0620", VA = "0x1835B2020")]
		private void UpdateLocatorVisuals(GPSLocator gpsLocator, RectTransform locatorVisuals)
		{
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF5")]
		[Address(RVA = "0x35B3040", Offset = "0x35B1640", VA = "0x1835B3040")]
		public void RemoveGpsLocator(GPSLocator gpsLocator)
		{
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF6")]
		[Address(RVA = "0x35B37F0", Offset = "0x35B1DF0", VA = "0x1835B37F0")]
		private void UpdateSfx(Vector3 trackerPosition)
		{
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF7")]
		[Address(RVA = "0x35B3CA0", Offset = "0x35B22A0", VA = "0x1835B3CA0")]
		private void StartSfx()
		{
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF8")]
		[Address(RVA = "0x35B3E50", Offset = "0x35B2450", VA = "0x1835B3E50")]
		public GPSTrackerSystem()
		{
		}

		// Token: 0x04003365 RID: 13157
		[Token(Token = "0x4003365")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ItemRenderable _itemRenderable;

		// Token: 0x04003366 RID: 13158
		[Token(Token = "0x4003366")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Canvas _rootCanvas;

		// Token: 0x04003367 RID: 13159
		[Token(Token = "0x4003367")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _miniMap;

		// Token: 0x04003368 RID: 13160
		[Token(Token = "0x4003368")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _map;

		// Token: 0x04003369 RID: 13161
		[Token(Token = "0x4003369")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _mapRotator;

		// Token: 0x0400336A RID: 13162
		[Token(Token = "0x400336A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _playerArrow;

		// Token: 0x0400336B RID: 13163
		[Token(Token = "0x400336B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _signalLost;

		// Token: 0x0400336C RID: 13164
		[Token(Token = "0x400336C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _screenStatic;

		// Token: 0x0400336D RID: 13165
		[Token(Token = "0x400336D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector2 _worldSize;

		// Token: 0x0400336E RID: 13166
		[Token(Token = "0x400336E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _trackerSignalLost;

		// Token: 0x0400336F RID: 13167
		[Token(Token = "0x400336F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<float> _mapZoomLevels;

		// Token: 0x04003370 RID: 13168
		[Token(Token = "0x4003370")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _northArrowPivot;

		// Token: 0x04003371 RID: 13169
		[Token(Token = "0x4003371")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _locatorScale;

		// Token: 0x04003372 RID: 13170
		[Token(Token = "0x4003372")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private int _historyNodeCount;

		// Token: 0x04003373 RID: 13171
		[Token(Token = "0x4003373")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _historyNodeSpacing;

		// Token: 0x04003374 RID: 13172
		[Token(Token = "0x4003374")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _historyNodesGroup;

		// Token: 0x04003375 RID: 13173
		[Token(Token = "0x4003375")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _dayText;

		// Token: 0x04003376 RID: 13174
		[Token(Token = "0x4003376")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _timeText;

		// Token: 0x04003377 RID: 13175
		[Token(Token = "0x4003377")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[FormerlySerializedAs("_trackerLocatorMapArea")]
		[FormerlySerializedAs("_soldierMapArea")]
		private RectTransform _gpsLocatorMapLocation;

		// Token: 0x04003378 RID: 13176
		[Token(Token = "0x4003378")]
		[FieldOffset(Offset = "0xB0")]
		[FormerlySerializedAs("_gpsLocatorEdgeDot")]
		[SerializeField]
		private RectTransform _gpsLocatorVisual;

		// Token: 0x04003379 RID: 13177
		[Token(Token = "0x4003379")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private BoxCollider _screenBoxCollider;

		// Token: 0x0400337A RID: 13178
		[Token(Token = "0x400337A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _overlappingPinRotationDegrees;

		// Token: 0x0400337B RID: 13179
		[Token(Token = "0x400337B")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float _overlappingPinDistanceThreshold;

		// Token: 0x0400337C RID: 13180
		[Token(Token = "0x400337C")]
		[FieldOffset(Offset = "0xC8")]
		[EventRef]
		[SerializeField]
		public string _trackingSfxEvent;

		// Token: 0x0400337D RID: 13181
		[Token(Token = "0x400337D")]
		[FieldOffset(Offset = "0xD0")]
		[EventRef]
		[SerializeField]
		public string _zoomChangeSfxEvent;

		// Token: 0x0400337E RID: 13182
		[Token(Token = "0x400337E")]
		[FieldOffset(Offset = "0xD8")]
		private readonly List<List<RectTransform>> _gpsLocatorHistory;

		// Token: 0x0400337F RID: 13183
		[Token(Token = "0x400337F")]
		[FieldOffset(Offset = "0xE0")]
		private readonly List<RectTransform> _gpsLocatorMapLocations;

		// Token: 0x04003380 RID: 13184
		[Token(Token = "0x4003380")]
		[FieldOffset(Offset = "0xE8")]
		private readonly List<GPSLocator> _gpsLocators;

		// Token: 0x04003381 RID: 13185
		[Token(Token = "0x4003381")]
		[FieldOffset(Offset = "0xF0")]
		private readonly List<RectTransform> _gpsLocatorVisuals;

		// Token: 0x04003382 RID: 13186
		[Token(Token = "0x4003382")]
		[FieldOffset(Offset = "0xF8")]
		private bool _isInstantiated;

		// Token: 0x04003383 RID: 13187
		[Token(Token = "0x4003383")]
		[FieldOffset(Offset = "0x100")]
		private Transform _target;

		// Token: 0x04003384 RID: 13188
		[Token(Token = "0x4003384")]
		[FieldOffset(Offset = "0x108")]
		private RectTransform _targetMapDot;

		// Token: 0x04003385 RID: 13189
		[Token(Token = "0x4003385")]
		[FieldOffset(Offset = "0x110")]
		private Transform _trackerLocation;

		// Token: 0x04003386 RID: 13190
		[Token(Token = "0x4003386")]
		[FieldOffset(Offset = "0x118")]
		private EventInstance _trackingSfx;

		// Token: 0x04003387 RID: 13191
		[Token(Token = "0x4003387")]
		[FieldOffset(Offset = "0x120")]
		private int _uiHistoryNodeIndex;

		// Token: 0x04003388 RID: 13192
		[Token(Token = "0x4003388")]
		[FieldOffset(Offset = "0x124")]
		private Vector3 _trackerCurrentPosition;

		// Token: 0x04003389 RID: 13193
		[Token(Token = "0x4003389")]
		[FieldOffset(Offset = "0x130")]
		private Vector3 _trackerCurrentForward;

		// Token: 0x0400338A RID: 13194
		[Token(Token = "0x400338A")]
		[FieldOffset(Offset = "0x13C")]
		private int _lastDaysSurvived;

		// Token: 0x0400338B RID: 13195
		[Token(Token = "0x400338B")]
		[FieldOffset(Offset = "0x140")]
		private int _lastMinutes;

		// Token: 0x0400338C RID: 13196
		[Token(Token = "0x400338C")]
		[FieldOffset(Offset = "0x144")]
		private int _lastHours;

		// Token: 0x0400338D RID: 13197
		[Token(Token = "0x400338D")]
		[FieldOffset(Offset = "0x148")]
		private int _currentZoomLevel;

		// Token: 0x0400338F RID: 13199
		[Token(Token = "0x400338F")]
		[FieldOffset(Offset = "0x150")]
		private readonly List<int> _alreadyAdjustedLocatorIndices;

		// Token: 0x04003390 RID: 13200
		[Token(Token = "0x4003390")]
		[FieldOffset(Offset = "0x158")]
		private readonly List<int> _overlappingLocatorIndices;

		// Token: 0x04003391 RID: 13201
		[Token(Token = "0x4003391")]
		[FieldOffset(Offset = "0x160")]
		private readonly List<int> _setIndicies;
	}
}
