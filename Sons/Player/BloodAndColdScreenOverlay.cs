using System;
using System.Collections;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using Sons.Environment;
using Sons.Gameplay;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace Sons.Player
{
	// Token: 0x02000654 RID: 1620
	[Token(Token = "0x2000654")]
	public class BloodAndColdScreenOverlay : MonoBehaviour, IEnvironmentWetnessAndRainReceiver, IInteriorSpaceProbeReceiver
	{
		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060029EA RID: 10730 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
		[Token(Token = "0x17000582")]
		public float FrostAmount
		{
			[Token(Token = "0x60029EA")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EB")]
		[Address(RVA = "0x33F4440", Offset = "0x33F2A40", VA = "0x1833F4440")]
		private void GetProfile()
		{
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EC")]
		[Address(RVA = "0x33F4590", Offset = "0x33F2B90", VA = "0x1833F4590")]
		public void ShowWaterRunDownScreenEffect()
		{
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029ED")]
		[Address(RVA = "0x33F46B0", Offset = "0x33F2CB0", VA = "0x1833F46B0")]
		private IEnumerator DoWaterRunDownScreenEffect()
		{
			return null;
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EE")]
		[Address(RVA = "0x33F4740", Offset = "0x33F2D40", VA = "0x1833F4740")]
		private void FinalizeWaterRunDownScreenEffect()
		{
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EF")]
		[Address(RVA = "0x33F47B0", Offset = "0x33F2DB0", VA = "0x1833F47B0")]
		private void SetWetlessProgress(float wetlensProgressValue)
		{
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F0")]
		[Address(RVA = "0x33F48B0", Offset = "0x33F2EB0", VA = "0x1833F48B0")]
		public void StopWaterRunDownScreenEffect()
		{
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F1")]
		[Address(RVA = "0x33F48E0", Offset = "0x33F2EE0", VA = "0x1833F48E0")]
		public void AddBlood(float blood)
		{
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F2")]
		[Address(RVA = "0x33F4910", Offset = "0x33F2F10", VA = "0x1833F4910")]
		public void ClearBlood()
		{
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F3")]
		[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
		public void SetRecoveryRate(float recoveryRate)
		{
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F4")]
		[Address(RVA = "0x33F4920", Offset = "0x33F2F20", VA = "0x1833F4920")]
		public void AddFrost(float frost)
		{
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F5")]
		[Address(RVA = "0x2715B10", Offset = "0x2714110", VA = "0x182715B10")]
		public void SetFrost(float frost)
		{
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F6")]
		[Address(RVA = "0x1240ED0", Offset = "0x123F4D0", VA = "0x181240ED0")]
		public void ResetFrost()
		{
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F7")]
		[Address(RVA = "0x33F4950", Offset = "0x33F2F50", VA = "0x1833F4950")]
		private void Update()
		{
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F8")]
		[Address(RVA = "0x33F5000", Offset = "0x33F3600", VA = "0x1833F5000")]
		private void OnDisable()
		{
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F9")]
		[Address(RVA = "0x33F50A0", Offset = "0x33F36A0", VA = "0x1833F50A0", Slot = "4")]
		public void UpdateWetnessAndRain(float wetnessCurrent, float rainFactor)
		{
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FA")]
		[Address(RVA = "0x33F5150", Offset = "0x33F3750", VA = "0x1833F5150", Slot = "5")]
		private void OnInteriorSpaceChange(bool isInside)
		{
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FB")]
		[Address(RVA = "0x33F5180", Offset = "0x33F3780", VA = "0x1833F5180")]
		public BloodAndColdScreenOverlay()
		{
		}

		// Token: 0x0400254E RID: 9550
		[Token(Token = "0x400254E")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _bloodAmount;

		// Token: 0x0400254F RID: 9551
		[Token(Token = "0x400254F")]
		[FieldOffset(Offset = "0x24")]
		[Min(0f)]
		[SerializeField]
		private float _recoveryRate;

		// Token: 0x04002550 RID: 9552
		[Token(Token = "0x4002550")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Min(0f)]
		private float _minRecoveryRate;

		// Token: 0x04002551 RID: 9553
		[Token(Token = "0x4002551")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Min(0f)]
		private float _maxBloodIntensity;

		// Token: 0x04002552 RID: 9554
		[Token(Token = "0x4002552")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _frostAmount;

		// Token: 0x04002553 RID: 9555
		[Token(Token = "0x4002553")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _frostPhaseSpeed;

		// Token: 0x04002554 RID: 9556
		[Token(Token = "0x4002554")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _frostPhaseScale;

		// Token: 0x04002555 RID: 9557
		[Token(Token = "0x4002555")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _nonTemperatureBaseFrostAmount;

		// Token: 0x04002556 RID: 9558
		[Token(Token = "0x4002556")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _maxFrostAmount;

		// Token: 0x04002557 RID: 9559
		[Token(Token = "0x4002557")]
		[FieldOffset(Offset = "0x44")]
		[FormerlySerializedAs("_waterRunDownSpeed")]
		[SerializeField]
		private float _waterRunDownTime;

		// Token: 0x04002558 RID: 9560
		[Token(Token = "0x4002558")]
		[FieldOffset(Offset = "0x48")]
		private float _waterRunDownProgress;

		// Token: 0x04002559 RID: 9561
		[Token(Token = "0x4002559")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		private float _wetnessOverrideFactor;

		// Token: 0x0400255A RID: 9562
		[Token(Token = "0x400255A")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		private float _displayedFrostLevel;

		// Token: 0x0400255B RID: 9563
		[Token(Token = "0x400255B")]
		[FieldOffset(Offset = "0x58")]
		private VolumeProfile _volumeProfile;

		// Token: 0x0400255C RID: 9564
		[Token(Token = "0x400255C")]
		[FieldOffset(Offset = "0x60")]
		private BloodColdPostProcess _bloodColdController;

		// Token: 0x0400255D RID: 9565
		[Token(Token = "0x400255D")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine _waterRunDownScreenEffectWorker;

		// Token: 0x0400255E RID: 9566
		[Token(Token = "0x400255E")]
		[FieldOffset(Offset = "0x70")]
		private RealtimeAutoTimer _waterRunDownProgressTimer;

		// Token: 0x0400255F RID: 9567
		[Token(Token = "0x400255F")]
		[FieldOffset(Offset = "0x78")]
		private bool _rainReceiverInitialized;
	}
}
