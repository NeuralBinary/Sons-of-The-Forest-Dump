using System;
using Il2CppDummyDll;
using Sons.Environment;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Atmosphere
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public class SunLinkedLight : MonoBehaviour, ISunLightReceiver, ITimeOfDayReceiver
	{
		// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2D4D1D0", Offset = "0x2D4B7D0", VA = "0x182D4D1D0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2D4D1E0", Offset = "0x2D4B7E0", VA = "0x182D4D1E0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2D4D1F0", Offset = "0x2D4B7F0", VA = "0x182D4D1F0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2D4D260", Offset = "0x2D4B860", VA = "0x182D4D260")]
		private void Initialize()
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2D4D280", Offset = "0x2D4B880", VA = "0x182D4D280")]
		private void SetupBaseIntensity()
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2D4D4F0", Offset = "0x2D4BAF0", VA = "0x182D4D4F0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2D4D550", Offset = "0x2D4BB50", VA = "0x182D4D550", Slot = "4")]
		public void UpdateSunLight(GameObject sunlightGameObject, Light sunLight, HDAdditionalLightData lightData)
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2D4D670", Offset = "0x2D4BC70", VA = "0x182D4D670")]
		private void UpdateIntensity()
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2D4D8B0", Offset = "0x2D4BEB0", VA = "0x182D4D8B0")]
		private bool IsNight()
		{
			return default(bool);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2D4D8E0", Offset = "0x2D4BEE0", VA = "0x182D4D8E0", Slot = "5")]
		public void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
		public bool ShouldRun()
		{
			return default(bool);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
		public bool ShouldRunTimeSliced()
		{
			return default(bool);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public void SetLastUpdate(int frame, float time)
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2D4D8F0", Offset = "0x2D4BEF0", VA = "0x182D4D8F0")]
		public SunLinkedLight()
		{
		}

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Light _linkedLight;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve _intensityCurve;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _autoSetBaseIntensity;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _baseIntensity;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x38")]
		private float _sunAngle;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x40")]
		private TimeOfDay _timeOfDay;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x60")]
		private GameObject _sunlightGameObject;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x68")]
		private float _currentIntensity;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x70")]
		private HDAdditionalLightData _hdAdditionalLightData;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x78")]
		private bool _initialized;
	}
}
