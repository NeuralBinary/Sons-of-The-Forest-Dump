using System;
using Bolt;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Atmosphere;
using Sons.Environment;
using TheForest.World;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x020007C6 RID: 1990
	[Token(Token = "0x20007C6")]
	[AddComponentMenu("Sons/Gameplay/RainCatcher")]
	public class RainCatcher : EntityBehaviour<IRainCatcherStructureState>, IEnvironmentWetnessAndRainReceiver, ISeasonsReceiver
	{
		// Token: 0x060035A6 RID: 13734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A6")]
		[Address(RVA = "0x34E6150", Offset = "0x34E4750", VA = "0x1834E6150", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A7")]
		[Address(RVA = "0x34E6610", Offset = "0x34E4C10", VA = "0x1834E6610")]
		private void ClientUpdateCurrentVolume()
		{
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A8")]
		[Address(RVA = "0x34E66B0", Offset = "0x34E4CB0", VA = "0x1834E66B0")]
		private void ClientUpdateIsFrozen()
		{
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A9")]
		[Address(RVA = "0x34E6750", Offset = "0x34E4D50", VA = "0x1834E6750")]
		private void OnEnable()
		{
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AA")]
		[Address(RVA = "0x34E68F0", Offset = "0x34E4EF0", VA = "0x1834E68F0")]
		private void OnDisable()
		{
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AB")]
		[Address(RVA = "0x34E6C80", Offset = "0x34E5280", VA = "0x1834E6C80")]
		private void Update()
		{
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AC")]
		[Address(RVA = "0x34E6E10", Offset = "0x34E5410", VA = "0x1834E6E10")]
		private void OnPerformedAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnInteractionComplete()
		{
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x000100E0 File Offset: 0x0000E2E0
		[Token(Token = "0x60035AE")]
		[Address(RVA = "0x34E7050", Offset = "0x34E5650", VA = "0x1834E7050")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AF")]
		[Address(RVA = "0x34E7060", Offset = "0x34E5660", VA = "0x1834E7060")]
		public void SetIsBusy(bool isBusy)
		{
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B0")]
		[Address(RVA = "0x34E7070", Offset = "0x34E5670", VA = "0x1834E7070")]
		public void GrabEnter()
		{
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B1")]
		[Address(RVA = "0x34E7080", Offset = "0x34E5680", VA = "0x1834E7080")]
		public void GrabExit()
		{
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B2")]
		[Address(RVA = "0x34E7070", Offset = "0x34E5670", VA = "0x1834E7070")]
		public void GrabStay()
		{
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B3")]
		[Address(RVA = "0x34E7090", Offset = "0x34E5690", VA = "0x1834E7090")]
		private void SetupLinkUi()
		{
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B4")]
		[Address(RVA = "0x34E7340", Offset = "0x34E5940", VA = "0x1834E7340")]
		private void SetInteractionState(bool enable)
		{
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B5")]
		[Address(RVA = "0x34E78D0", Offset = "0x34E5ED0", VA = "0x1834E78D0")]
		public void RemoveWaterVolume(float requestedAmount, out float amountReceived)
		{
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B6")]
		[Address(RVA = "0x34E7B10", Offset = "0x34E6110", VA = "0x1834E7B10")]
		private void UpdateCollectedRainVisuals()
		{
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B7")]
		[Address(RVA = "0x34E7D60", Offset = "0x34E6360", VA = "0x1834E7D60")]
		private void SetFrozen(bool isFrozen)
		{
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B8")]
		[Address(RVA = "0x34E8010", Offset = "0x34E6610", VA = "0x1834E8010", Slot = "25")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B9")]
		[Address(RVA = "0x34E8040", Offset = "0x34E6640", VA = "0x1834E8040", Slot = "24")]
		public void UpdateWetnessAndRain(float wetnessCurrent, float rainFactor)
		{
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035BA")]
		[Address(RVA = "0x34E8220", Offset = "0x34E6820", VA = "0x1834E8220")]
		public RainCatcher.RainCatcherData GetSerializedData()
		{
			return null;
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BB")]
		[Address(RVA = "0x34E8270", Offset = "0x34E6870", VA = "0x1834E8270")]
		public void DeserializeData(RainCatcher.RainCatcherData data)
		{
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BC")]
		[Address(RVA = "0x34E8410", Offset = "0x34E6A10", VA = "0x1834E8410")]
		public RainCatcher()
		{
		}

		// Token: 0x04002E55 RID: 11861
		[Token(Token = "0x4002E55")]
		private const string ScreenUseUiElementId = "screen.use";

		// Token: 0x04002E56 RID: 11862
		[Token(Token = "0x4002E56")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _drinkInteractionElement;

		// Token: 0x04002E57 RID: 11863
		[Token(Token = "0x4002E57")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("_refillInteractionElement")]
		private GameObject _refillFlaskInteractionElement;

		// Token: 0x04002E58 RID: 11864
		[Token(Token = "0x4002E58")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _refillPotInteractionElement;

		// Token: 0x04002E59 RID: 11865
		[Token(Token = "0x4002E59")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private InteractableWaterNode _waterNode;

		// Token: 0x04002E5A RID: 11866
		[Token(Token = "0x4002E5A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _liquidSurfaceModel;

		// Token: 0x04002E5B RID: 11867
		[Token(Token = "0x4002E5B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _frozenSurfaceModel;

		// Token: 0x04002E5C RID: 11868
		[Token(Token = "0x4002E5C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _emptyVolumeHeight;

		// Token: 0x04002E5D RID: 11869
		[Token(Token = "0x4002E5D")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _fullVolumeHeight;

		// Token: 0x04002E5E RID: 11870
		[Token(Token = "0x4002E5E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _maxVolume;

		// Token: 0x04002E5F RID: 11871
		[Token(Token = "0x4002E5F")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int _totalDrinksWhenFull;

		// Token: 0x04002E60 RID: 11872
		[Token(Token = "0x4002E60")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _fillRate;

		// Token: 0x04002E61 RID: 11873
		[Token(Token = "0x4002E61")]
		[FieldOffset(Offset = "0x6C")]
		private float _currentVolume;

		// Token: 0x04002E62 RID: 11874
		[Token(Token = "0x4002E62")]
		[FieldOffset(Offset = "0x70")]
		private bool _isFrozen;

		// Token: 0x04002E63 RID: 11875
		[Token(Token = "0x4002E63")]
		[FieldOffset(Offset = "0x71")]
		private bool _isBusy;

		// Token: 0x04002E64 RID: 11876
		[Token(Token = "0x4002E64")]
		private const float TimeBetweenMpSyncDelay = 5f;

		// Token: 0x04002E65 RID: 11877
		[Token(Token = "0x4002E65")]
		[FieldOffset(Offset = "0x74")]
		private float _nextMpTimeSync;

		// Token: 0x04002E66 RID: 11878
		[Token(Token = "0x4002E66")]
		[FieldOffset(Offset = "0x78")]
		private WeatherSystem _weatherSystem;

		// Token: 0x04002E67 RID: 11879
		[Token(Token = "0x4002E67")]
		[FieldOffset(Offset = "0x80")]
		private bool _checkForWeatherSystem;

		// Token: 0x04002E68 RID: 11880
		[Token(Token = "0x4002E68")]
		[FieldOffset(Offset = "0x84")]
		private SeasonsManager.Season _currentSeason;

		// Token: 0x020007C7 RID: 1991
		[Token(Token = "0x20007C7")]
		[Serializable]
		public class RainCatcherData
		{
			// Token: 0x060035BD RID: 13757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60035BD")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public RainCatcherData()
			{
			}

			// Token: 0x04002E69 RID: 11881
			[Token(Token = "0x4002E69")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public float CurrentVolume;

			// Token: 0x04002E6A RID: 11882
			[Token(Token = "0x4002E6A")]
			[FieldOffset(Offset = "0x14")]
			[JsonProperty]
			public bool IsFrozen;
		}
	}
}
