using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace NWH.DWP2.ShipController
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[RequireComponent(typeof(AdvancedShipController))]
	[Serializable]
	public class Engine
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x17000037")]
		public float RPM
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x270E650", Offset = "0x270CC50", VA = "0x18270E650")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000266C File Offset: 0x0000086C
		[Token(Token = "0x17000038")]
		public float RpmPercent
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x270E670", Offset = "0x270CC70", VA = "0x18270E670")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00002684 File Offset: 0x00000884
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000039")]
		public float Thrust
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x69B270", Offset = "0x699870", VA = "0x18069B270")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x270E6C0", Offset = "0x270CCC0", VA = "0x18270E6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x1700003A")]
		public bool Submerged
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x270E6D0", Offset = "0x270CCD0", VA = "0x18270E6D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x1700003B")]
		public Vector3 ThrustPosition
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x270E780", Offset = "0x270CD80", VA = "0x18270E780")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x1700003C")]
		public Vector3 ThrustDirection
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x270E890", Offset = "0x270CE90", VA = "0x18270E890")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x270EB30", Offset = "0x270D130", VA = "0x18270EB30")]
		public void Initialize(AdvancedShipController sc)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x270EBC0", Offset = "0x270D1C0", VA = "0x18270EBC0", Slot = "4")]
		public virtual void Update()
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1EA3300", Offset = "0x1EA1900", VA = "0x181EA3300")]
		public void StartEngine()
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x270F330", Offset = "0x270D930", VA = "0x18270F330")]
		public void StopEngine()
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x270F340", Offset = "0x270D940", VA = "0x18270F340", Slot = "5")]
		public virtual void SoundInit()
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x270F720", Offset = "0x270DD20", VA = "0x18270F720", Slot = "6")]
		public virtual void SoundUpdate()
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x270F990", Offset = "0x270DF90", VA = "0x18270F990")]
		private void PlayStarting()
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x270FEE0", Offset = "0x270E4E0", VA = "0x18270FEE0")]
		private void PlayRunning()
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2710130", Offset = "0x270E730", VA = "0x182710130")]
		private void PlayStopping()
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2710410", Offset = "0x270EA10", VA = "0x182710410")]
		private void StopAll()
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x27106F0", Offset = "0x270ECF0", VA = "0x1827106F0")]
		public void SetDefaults()
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x27108E0", Offset = "0x270EEE0", VA = "0x1827108E0")]
		public Engine()
		{
		}

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x10")]
		public Engine.ThrottleBinding throttleBinding;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_isOn")]
		public bool isOn;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("_minRPM")]
		[Tooltip("Min RPM of the engine.")]
		public float minRPM;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_maxRPM")]
		[Tooltip("Max RPM of the engine.")]
		public float maxRPM;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x2C")]
		[FormerlySerializedAs("_maxThrust")]
		[Tooltip("Thrust at max RPM.")]
		public float maxThrust;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Time needed to spin up the engines up to max RPM")]
		[FormerlySerializedAs("_spinUpTime")]
		public float spinUpTime;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Used to determine starting sound pitch. Engine RPM when turning over.")]
		[FormerlySerializedAs("startingRpm")]
		public float startingRPM;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("How long will the engine starting take?")]
		public float startDuration;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("How long will the engine stopping take?")]
		public float stopDuration;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Local position at which the force will be applied.")]
		public Vector3 thrustPosition;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Local direction in which the force will be applied.")]
		public Vector3 thrustDirection;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Should thrust be applied when above water?")]
		public bool applyThrustWhenAboveWater;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("Amount of thrust that will be applied if ship is reversing.")]
		public float reverseThrustCoefficient;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Ship speed at which propeller will reach it's maximum rotational speed.")]
		public float maxSpeed;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Thrust curve of the propeller. X axis is speed in m/s and y axis is efficiency.")]
		public AnimationCurve thrustCurve;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("Optional. Only use if you vessel has propeller mounted to the rudder (as in outboard engines). Propuslion force direction will be rotated with rudder if assigned.")]
		public Transform rudderTransform;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("Optional. Propeller transform. Visual rotation only, does not affect physics.")]
		public Transform propellerTransform;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("Engine RPM will be multiplied by this value to get rotation speed of the propeller. Animation only.")]
		public float propellerRpmRatio;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x84")]
		[Tooltip("Direction of propeller rotation. Animation only.")]
		public Engine.RotationDirection rotationDirection;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x88")]
		[Tooltip("Engine running audio source.")]
		public AudioSource runningSource;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x90")]
		[Tooltip("[Optional] Sound of engine starting. If left empty fade-in will be used.")]
		public AudioSource startingSource;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x98")]
		[Tooltip("[Optional] Sound of engine stopping. If left empty cut-out will be used.")]
		public AudioSource stoppingSource;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0xA0")]
		[Range(0f, 2f)]
		[Tooltip("Base (idle) volume of the engine.")]
		public float volume;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0xA4")]
		[Tooltip("Base (idle) pitch of the engine.")]
		[Range(0f, 2f)]
		public float pitch;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0xA8")]
		[Range(0f, 2f)]
		[Tooltip("Volume range of the engine.")]
		public float volumeRange;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0xAC")]
		[Tooltip("Pitch range of the engine.")]
		[Range(0f, 2f)]
		public float pitchRange;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0xB0")]
		private float _rpm;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0xB4")]
		private float _spinVelocity;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0xB8")]
		private Engine.State _engineState;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0xBC")]
		private float _startTime;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xC0")]
		private float _stopTime;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0xC4")]
		private bool _wasOn;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0xC8")]
		private AdvancedShipController _sc;

		// Token: 0x0200001B RID: 27
		[Token(Token = "0x200001B")]
		public enum ThrottleBinding
		{
			// Token: 0x04000107 RID: 263
			[Token(Token = "0x4000107")]
			Throttle,
			// Token: 0x04000108 RID: 264
			[Token(Token = "0x4000108")]
			Throttle2,
			// Token: 0x04000109 RID: 265
			[Token(Token = "0x4000109")]
			Throttle3,
			// Token: 0x0400010A RID: 266
			[Token(Token = "0x400010A")]
			Throttle4
		}

		// Token: 0x0200001C RID: 28
		[Token(Token = "0x200001C")]
		public enum RotationDirection
		{
			// Token: 0x0400010C RID: 268
			[Token(Token = "0x400010C")]
			Left,
			// Token: 0x0400010D RID: 269
			[Token(Token = "0x400010D")]
			Right
		}

		// Token: 0x0200001D RID: 29
		[Token(Token = "0x200001D")]
		public enum State
		{
			// Token: 0x0400010F RID: 271
			[Token(Token = "0x400010F")]
			On,
			// Token: 0x04000110 RID: 272
			[Token(Token = "0x4000110")]
			Off,
			// Token: 0x04000111 RID: 273
			[Token(Token = "0x4000111")]
			Starting,
			// Token: 0x04000112 RID: 274
			[Token(Token = "0x4000112")]
			Stopping
		}
	}
}
