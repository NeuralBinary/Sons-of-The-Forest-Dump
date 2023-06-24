using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Atmosphere
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	public class UnityCloudsWrapper : CloudSystemMonoBehaviour, IWindReceiver
	{
		// Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2D3EC20", Offset = "0x2D3D220", VA = "0x182D3EC20")]
		private void OnEnable()
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2D3ECA0", Offset = "0x2D3D2A0", VA = "0x182D3ECA0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		public override void SwitchToRandomProfile()
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public override void SwitchToProfile(string name)
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		public override void SwitchToProfile(int index)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		public override void UpdateWind(Vector3 direction, float intensity)
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2D3ED20", Offset = "0x2D3D320", VA = "0x182D3ED20", Slot = "6")]
		public override void UpdateCloud(float density)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2D3F1F0", Offset = "0x2D3D7F0", VA = "0x182D3F1F0")]
		private void VerifyCloudsComponent()
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2D3F630", Offset = "0x2D3DC30", VA = "0x182D3F630")]
		private void VerifyIndirectLightingController()
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2D3F760", Offset = "0x2D3DD60", VA = "0x182D3F760")]
		public void SetCloudEnabled(bool value)
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2D3F8C0", Offset = "0x2D3DEC0", VA = "0x182D3F8C0")]
		public void SetCloudShadowEnabled(bool value)
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2D3FA20", Offset = "0x2D3E020", VA = "0x182D3FA20")]
		public UnityCloudsWrapper()
		{
		}

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x20")]
		[Header("Ambient Control")]
		[SerializeField]
		private bool _autoAmbient;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _constantAmbientMultiplier;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x28")]
		[Space(8f)]
		[SerializeField]
		private Volume _volumeTarget;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _windScale;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _minReflectionStrength;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _minAmbientProbeDimmerValue;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CloudModelDataProfile _baseProfile;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CloudModelDataProfile _rainingProfile;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x50")]
		private float _targetDensity;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x58")]
		private CloudModelDataProfile _lerpedResult;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x60")]
		private VolumetricClouds _volumetricClouds;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x68")]
		private IndirectLightingController _indirectLightingController;
	}
}
