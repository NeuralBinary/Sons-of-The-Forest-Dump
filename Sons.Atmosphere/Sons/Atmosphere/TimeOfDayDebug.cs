using System;
using Il2CppDummyDll;
using Sons.Environment;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Atmosphere
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	public class TimeOfDayDebug : TimeOfDayBehaviour
	{
		// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2D4FA30", Offset = "0x2D4E030", VA = "0x182D4FA30", Slot = "10")]
		protected override void OnDestroyHook()
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2D4FBC0", Offset = "0x2D4E1C0", VA = "0x182D4FBC0", Slot = "8")]
		public override void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2D4FC40", Offset = "0x2D4E240", VA = "0x182D4FC40")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2D502E0", Offset = "0x2D4E8E0", VA = "0x182D502E0")]
		private void UpdateLightReadout(DirectionalLightRotation lightRotation, TMP_Text readout, ref Light lightSource, ref HDAdditionalLightData lightData)
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2D50770", Offset = "0x2D4ED70", VA = "0x182D50770")]
		private static float CalculateHorizonAngle(float lightAngle)
		{
			return 0f;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2D50780", Offset = "0x2D4ED80", VA = "0x182D50780")]
		private float GetLight(DirectionalLightRotation directionalLightRotation)
		{
			return 0f;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2D509A0", Offset = "0x2D4EFA0", VA = "0x182D509A0")]
		public static void SetEnable(bool value)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2D2D8D0", Offset = "0x2D2BED0", VA = "0x182D2D8D0")]
		public TimeOfDayDebug()
		{
		}

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TMP_Text _timeOfDayReadout;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TMP_Text _sunAngleReadout;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TMP_Text _moonAngleReadout;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TMP_Text _volumeStackReadout;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private DirectionalLightRotation _sunRotation;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private DirectionalLightRotation _moonRotation;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x68")]
		private HDAdditionalLightData _sunLightData;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x70")]
		private HDAdditionalLightData _moonLightData;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x78")]
		private Light _moonLight;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x80")]
		private Light _sunLight;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x0")]
		private static TimeOfDayDebug _instance;
	}
}
