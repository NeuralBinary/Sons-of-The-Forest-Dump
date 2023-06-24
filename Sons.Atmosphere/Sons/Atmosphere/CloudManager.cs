using System;
using System.Collections.Generic;
using Endnight.Utilities.PropertyAttributes;
using Il2CppDummyDll;
using Sons.Environment;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Atmosphere
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public class CloudManager : TimeOfDayBehaviour
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2D3C210", Offset = "0x2D3A810", VA = "0x182D3C210", Slot = "8")]
		public override void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2D3C2D0", Offset = "0x2D3A8D0", VA = "0x182D3C2D0")]
		private void AssignLight(Light sourceLight)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2D3C3C0", Offset = "0x2D3A9C0", VA = "0x182D3C3C0", Slot = "9")]
		protected override void AwakeHook()
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2D3C6B0", Offset = "0x2D3ACB0", VA = "0x182D3C6B0")]
		private void Update()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2D3C7A0", Offset = "0x2D3ADA0", VA = "0x182D3C7A0")]
		private void UpdateCloudFactors()
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2D3C830", Offset = "0x2D3AE30", VA = "0x182D3C830")]
		private float GetCurrentCloudStormFactorTarget()
		{
			return 0f;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void UpdateWorkers()
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void ResetClouds()
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2D3C850", Offset = "0x2D3AE50", VA = "0x182D3C850")]
		private void RandomClouds()
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2D3C8C0", Offset = "0x2D3AEC0", VA = "0x182D3C8C0", Slot = "10")]
		protected override void OnDestroyHook()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2D3CA80", Offset = "0x2D3B080", VA = "0x182D3CA80")]
		public void GrowClouds()
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2D3CAE0", Offset = "0x2D3B0E0", VA = "0x182D3CAE0")]
		public bool FinishedClouds()
		{
			return default(bool);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2D3CA80", Offset = "0x2D3B080", VA = "0x182D3CA80")]
		public void ReduceClouds()
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x1700000D")]
		public float CloudOvercastCurrent
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1F05980", Offset = "0x1F03F80", VA = "0x181F05980")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00002AA8 File Offset: 0x00000CA8
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		public float CloudOvercastTarget
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0xA53160", Offset = "0xA51760", VA = "0x180A53160")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x2B40070", Offset = "0x2B3E670", VA = "0x182B40070")]
			set
			{
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2B89DD0", Offset = "0x2B883D0", VA = "0x182B89DD0")]
		public void SetTargetStormFactor(float factor)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2D3CC20", Offset = "0x2D3B220", VA = "0x182D3CC20")]
		public void SetCurrentStormFactor(float factor)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000124")]
		[Address(RVA = "0xAFF290", Offset = "0xAFD890", VA = "0x180AFF290")]
		public void SetState(CloudState cloudState)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2D3CC30", Offset = "0x2D3B230", VA = "0x182D3CC30")]
		public void SwitchToRandomProfile()
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2D3CD10", Offset = "0x2D3B310", VA = "0x182D3CD10")]
		public void SwitchToProfile(string profileName)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2D3CE00", Offset = "0x2D3B400", VA = "0x182D3CE00")]
		public void SwitchToProfile(int profileIndex)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2D3CEF0", Offset = "0x2D3B4F0", VA = "0x182D3CEF0")]
		public static bool TryGetInstance(out CloudManager result)
		{
			return default(bool);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2D3D070", Offset = "0x2D3B670", VA = "0x182D3D070")]
		private void UpdateReceivers()
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2D3D230", Offset = "0x2D3B830", VA = "0x182D3D230")]
		public static void Unregister(ICloudReceiver receiver)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2D3D390", Offset = "0x2D3B990", VA = "0x182D3D390")]
		public static void Register(ICloudReceiver receiver)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2D3D4A0", Offset = "0x2D3BAA0", VA = "0x182D3D4A0")]
		public static bool IsRegistered(ICloudReceiver receiver)
		{
			return default(bool);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2D3D540", Offset = "0x2D3BB40", VA = "0x182D3D540")]
		public void LockStormFactor(float lockedFactor = -1f)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2D3D560", Offset = "0x2D3BB60", VA = "0x182D3D560")]
		public CloudManager()
		{
		}

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x0")]
		private static CloudManager _instance;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<ICloudReceiver> Receivers;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Min(0f)]
		private int _nextCloudProfile;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CloudSystemMonoBehaviour _cloudSystem;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _currentCloudProfileFactor;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x4C")]
		private float _currentCloudProfileFactorVelocity;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x50")]
		private int _currentCloudProfile;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _cloudStormFactor;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _currentCloudStormFactor;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _cloudStormFactorVelocity;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x60")]
		public float CloudSmoothTime;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x64")]
		private float CloudOvercastCurrentValue;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x68")]
		private float CloudOvercastTargetValue;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x6C")]
		private float CloudOvercastVelocity;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x70")]
		private bool _randomCloudsWorkerActive;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _randomCloudsWorkerInterval;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _randomCloudsWorkerCountdown;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x7C")]
		[ReadOnly]
		[SerializeField]
		[FormerlySerializedAs("_state")]
		private CloudState _cloudState;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Light _sunLight;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Light _moonLight;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x90")]
		private TimeOfDay _timeOfDay;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0xB0")]
		private float _lightingTarget;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0xB4")]
		private float _directLightTarget;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xB8")]
		private bool _isDay;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0xB9")]
		private bool _isNight;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0xBA")]
		private bool _hasSetLighting;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0xBC")]
		private float _currentLighting;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0xC0")]
		private float _currentDirectLight;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0xC4")]
		private float _baseDirectLightDay;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0xC8")]
		private float _baseLightingDay;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0xCC")]
		private float _baseLightingNight;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0xD0")]
		private float _baseDirectLightNight;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0xD4")]
		private float _lockedCloudStormFactor;
	}
}
