using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Physics
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public class KeepRigidbodyOnOrUnderWaterSurface : MonoBehaviour
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x3104480", Offset = "0x3102A80", VA = "0x183104480")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x3104660", Offset = "0x3102C60", VA = "0x183104660")]
		private bool PassesMinDepth(float waterDepth)
		{
			return default(bool);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x3104680", Offset = "0x3102C80", VA = "0x183104680")]
		private void KeepAboveOrUnder()
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x3104800", Offset = "0x3102E00", VA = "0x183104800")]
		public KeepRigidbodyOnOrUnderWaterSurface()
		{
		}

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WaterLevelSensor _waterLevelSensor;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _minDepth;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _offset;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[FormerlySerializedAs("_keepBelow")]
		private bool _keepUnder;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private KeepRigidbodyOnOrUnderWaterSurface.SmoothSettings _pastSmoothSettings;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private KeepRigidbodyOnOrUnderWaterSurface.SmoothSettings _nearSmoothSettings;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("_smoothToSurfaceThreshold")]
		[SerializeField]
		public float _nearSmoothToSurfaceThreshold;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x54")]
		private bool _isInWater;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x58")]
		private float _waterLevel;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x5C")]
		private float _waterDepth;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 _waterForce;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x6C")]
		private float _currentSharedSmoothVelocity;

		// Token: 0x02000019 RID: 25
		[Token(Token = "0x2000019")]
		[Serializable]
		public class SmoothSettings
		{
			// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x3104950", Offset = "0x3102F50", VA = "0x183104950")]
			public SmoothSettings()
			{
			}

			// Token: 0x040000AA RID: 170
			[Token(Token = "0x40000AA")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public float _smoothTime;

			// Token: 0x040000AB RID: 171
			[Token(Token = "0x40000AB")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			public float _maxSmoothSpeed;
		}
	}
}
