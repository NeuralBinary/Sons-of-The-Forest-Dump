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
	// Token: 0x0200074A RID: 1866
	[Token(Token = "0x200074A")]
	public class BloodAndColdScreenOverlay : MonoBehaviour, IEnvironmentWetnessAndRainReceiver, IInteriorSpaceProbeReceiver
	{
		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x0600308F RID: 12431 RVA: 0x0000DD70 File Offset: 0x0000BF70
		[Token(Token = "0x17000617")]
		public float FrostAmount
		{
			[Token(Token = "0x600308F")]
			[Address(RVA = "0x8A27B0", Offset = "0x8A17B0", VA = "0x1808A27B0")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003090")]
		[Address(RVA = "0x2E3B3D0", Offset = "0x2E3A3D0", VA = "0x182E3B3D0")]
		private void GetProfile()
		{
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003091")]
		[Address(RVA = "0x2E3B630", Offset = "0x2E3A630", VA = "0x182E3B630")]
		public void ShowWaterRunDownScreenEffect()
		{
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003092")]
		[Address(RVA = "0x2E3B330", Offset = "0x2E3A330", VA = "0x182E3B330")]
		private IEnumerator DoWaterRunDownScreenEffect()
		{
			return null;
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003093")]
		[Address(RVA = "0x2E3B3A0", Offset = "0x2E3A3A0", VA = "0x182E3B3A0")]
		private void FinalizeWaterRunDownScreenEffect()
		{
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003094")]
		[Address(RVA = "0x2E3B590", Offset = "0x2E3A590", VA = "0x182E3B590")]
		private void SetWetlessProgress(float wetlensProgressValue)
		{
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003095")]
		[Address(RVA = "0x2E3B720", Offset = "0x2E3A720", VA = "0x182E3B720")]
		public void StopWaterRunDownScreenEffect()
		{
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003096")]
		[Address(RVA = "0x2E3B2C0", Offset = "0x2E3A2C0", VA = "0x182E3B2C0")]
		public void AddBlood(float blood)
		{
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003097")]
		[Address(RVA = "0x2E3B320", Offset = "0x2E3A320", VA = "0x182E3B320")]
		public void ClearBlood()
		{
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003098")]
		[Address(RVA = "0x567970", Offset = "0x566970", VA = "0x180567970")]
		public void SetRecoveryRate(float recoveryRate)
		{
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003099")]
		[Address(RVA = "0x2E3B2F0", Offset = "0x2E3A2F0", VA = "0x182E3B2F0")]
		public void AddFrost(float frost)
		{
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600309A")]
		[Address(RVA = "0x22C9CF0", Offset = "0x22C8CF0", VA = "0x1822C9CF0")]
		public void SetFrost(float frost)
		{
		}

		// Token: 0x0600309B RID: 12443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600309B")]
		[Address(RVA = "0x10439C0", Offset = "0x10429C0", VA = "0x1810439C0")]
		public void ResetFrost()
		{
		}

		// Token: 0x0600309C RID: 12444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600309C")]
		[Address(RVA = "0x2E3B800", Offset = "0x2E3A800", VA = "0x182E3B800")]
		private void Update()
		{
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600309D")]
		[Address(RVA = "0x2E3B4D0", Offset = "0x2E3A4D0", VA = "0x182E3B4D0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600309E")]
		[Address(RVA = "0x2E3B770", Offset = "0x2E3A770", VA = "0x182E3B770", Slot = "4")]
		public void UpdateWetnessAndRain(float wetnessCurrent, float rainFactor)
		{
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600309F")]
		[Address(RVA = "0x2E3B6F0", Offset = "0x2E3A6F0", VA = "0x182E3B6F0", Slot = "5")]
		private void OnInteriorSpaceChange(bool isInside)
		{
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030A0")]
		[Address(RVA = "0x2E3BC80", Offset = "0x2E3AC80", VA = "0x182E3BC80")]
		public BloodAndColdScreenOverlay()
		{
		}

		// Token: 0x04002A88 RID: 10888
		[Token(Token = "0x4002A88")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _bloodAmount;

		// Token: 0x04002A89 RID: 10889
		[Token(Token = "0x4002A89")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Min(0f)]
		private float _recoveryRate;

		// Token: 0x04002A8A RID: 10890
		[Token(Token = "0x4002A8A")]
		[FieldOffset(Offset = "0x28")]
		[Min(0f)]
		[SerializeField]
		private float _minRecoveryRate;

		// Token: 0x04002A8B RID: 10891
		[Token(Token = "0x4002A8B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Min(0f)]
		private float _maxBloodIntensity;

		// Token: 0x04002A8C RID: 10892
		[Token(Token = "0x4002A8C")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _frostAmount;

		// Token: 0x04002A8D RID: 10893
		[Token(Token = "0x4002A8D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _frostPhaseSpeed;

		// Token: 0x04002A8E RID: 10894
		[Token(Token = "0x4002A8E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _frostPhaseScale;

		// Token: 0x04002A8F RID: 10895
		[Token(Token = "0x4002A8F")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _nonTemperatureBaseFrostAmount;

		// Token: 0x04002A90 RID: 10896
		[Token(Token = "0x4002A90")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _maxFrostAmount;

		// Token: 0x04002A91 RID: 10897
		[Token(Token = "0x4002A91")]
		[FieldOffset(Offset = "0x44")]
		[FormerlySerializedAs("_waterRunDownSpeed")]
		[SerializeField]
		private float _waterRunDownTime;

		// Token: 0x04002A92 RID: 10898
		[Token(Token = "0x4002A92")]
		[FieldOffset(Offset = "0x48")]
		private float _waterRunDownProgress;

		// Token: 0x04002A93 RID: 10899
		[Token(Token = "0x4002A93")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		private float _wetnessOverrideFactor;

		// Token: 0x04002A94 RID: 10900
		[Token(Token = "0x4002A94")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		private float _displayedFrostLevel;

		// Token: 0x04002A95 RID: 10901
		[Token(Token = "0x4002A95")]
		[FieldOffset(Offset = "0x58")]
		private VolumeProfile _volumeProfile;

		// Token: 0x04002A96 RID: 10902
		[Token(Token = "0x4002A96")]
		[FieldOffset(Offset = "0x60")]
		private BloodColdPostProcess _bloodColdController;

		// Token: 0x04002A97 RID: 10903
		[Token(Token = "0x4002A97")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine _waterRunDownScreenEffectWorker;

		// Token: 0x04002A98 RID: 10904
		[Token(Token = "0x4002A98")]
		[FieldOffset(Offset = "0x70")]
		private RealtimeAutoTimer _waterRunDownProgressTimer;

		// Token: 0x04002A99 RID: 10905
		[Token(Token = "0x4002A99")]
		[FieldOffset(Offset = "0x78")]
		private bool _rainReceiverInitialized;
	}
}
