using System;
using Il2CppDummyDll;
using Sons.Environment;
using UnityEngine;

namespace TheForest.World
{
	// Token: 0x0200039F RID: 927
	[Token(Token = "0x200039F")]
	public class TerrainEnvironmentWetness : MonoBehaviour, IEnvironmentWetnessAndRainReceiver
	{
		// Token: 0x0600180C RID: 6156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180C")]
		[Address(RVA = "0x2CD2610", Offset = "0x2CD1610", VA = "0x182CD2610")]
		private void OnEnable()
		{
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180D")]
		[Address(RVA = "0x2CD2550", Offset = "0x2CD1550", VA = "0x182CD2550")]
		private void OnDisable()
		{
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180E")]
		[Address(RVA = "0x2CD26D0", Offset = "0x2CD16D0", VA = "0x182CD26D0", Slot = "4")]
		public void UpdateWetnessAndRain(float wetnessCurrent, float rainFactor)
		{
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180F")]
		[Address(RVA = "0x2CD2990", Offset = "0x2CD1990", VA = "0x182CD2990")]
		public TerrainEnvironmentWetness()
		{
		}

		// Token: 0x0400173D RID: 5949
		[Token(Token = "0x400173D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WeatherSystem _weatherSystem;

		// Token: 0x0400173E RID: 5950
		[Token(Token = "0x400173E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _puddleOff;

		// Token: 0x0400173F RID: 5951
		[Token(Token = "0x400173F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _puddleOn;

		// Token: 0x04001740 RID: 5952
		[Token(Token = "0x4001740")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _wetnessToPuddle;

		// Token: 0x04001741 RID: 5953
		[Token(Token = "0x4001741")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _wetnessOff;

		// Token: 0x04001742 RID: 5954
		[Token(Token = "0x4001742")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _wetnessOn;

		// Token: 0x04001743 RID: 5955
		[Token(Token = "0x4001743")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _staticWaterAmount;

		// Token: 0x04001744 RID: 5956
		[Token(Token = "0x4001744")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _rainOff;

		// Token: 0x04001745 RID: 5957
		[Token(Token = "0x4001745")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _rainOn;

		// Token: 0x04001746 RID: 5958
		[Token(Token = "0x4001746")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _rainIncreaseSmoothTime;

		// Token: 0x04001747 RID: 5959
		[Token(Token = "0x4001747")]
		[FieldOffset(Offset = "0x50")]
		[Header("Debug")]
		private float _currentPuddle;

		// Token: 0x04001748 RID: 5960
		[Token(Token = "0x4001748")]
		[FieldOffset(Offset = "0x54")]
		private float _currentWetness;

		// Token: 0x04001749 RID: 5961
		[Token(Token = "0x4001749")]
		[FieldOffset(Offset = "0x58")]
		private float _currentStaticWater;

		// Token: 0x0400174A RID: 5962
		[Token(Token = "0x400174A")]
		[FieldOffset(Offset = "0x5C")]
		private float _previousWetness;

		// Token: 0x0400174B RID: 5963
		[Token(Token = "0x400174B")]
		[FieldOffset(Offset = "0x60")]
		private float _wetnessToPuddleFac;

		// Token: 0x0400174C RID: 5964
		[Token(Token = "0x400174C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int GlobalPuddleParams;

		// Token: 0x0400174D RID: 5965
		[Token(Token = "0x400174D")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int GlobalWetnessParams;

		// Token: 0x0400174E RID: 5966
		[Token(Token = "0x400174E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int GlobalRainIntensity;

		// Token: 0x0400174F RID: 5967
		[Token(Token = "0x400174F")]
		[FieldOffset(Offset = "0x64")]
		private float _currentRainIntensity;

		// Token: 0x04001750 RID: 5968
		[Token(Token = "0x4001750")]
		[FieldOffset(Offset = "0x68")]
		private float _rainIntensityVelocity;
	}
}
