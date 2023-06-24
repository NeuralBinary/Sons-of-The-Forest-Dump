using System;
using Il2CppDummyDll;
using Sons.Environment;
using UnityEngine;

namespace TheForest.World
{
	// Token: 0x02000391 RID: 913
	[Token(Token = "0x2000391")]
	public class TerrainEnvironmentWetness : MonoBehaviour, IEnvironmentWetnessAndRainReceiver
	{
		// Token: 0x06001847 RID: 6215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x327BDB0", Offset = "0x327A3B0", VA = "0x18327BDB0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x327BE90", Offset = "0x327A490", VA = "0x18327BE90")]
		private void OnDisable()
		{
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x327BF70", Offset = "0x327A570", VA = "0x18327BF70", Slot = "4")]
		public void UpdateWetnessAndRain(float wetnessCurrent, float rainFactor)
		{
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184A")]
		[Address(RVA = "0x327C210", Offset = "0x327A810", VA = "0x18327C210")]
		public TerrainEnvironmentWetness()
		{
		}

		// Token: 0x0400175C RID: 5980
		[Token(Token = "0x400175C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WeatherSystem _weatherSystem;

		// Token: 0x0400175D RID: 5981
		[Token(Token = "0x400175D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _puddleOff;

		// Token: 0x0400175E RID: 5982
		[Token(Token = "0x400175E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _puddleOn;

		// Token: 0x0400175F RID: 5983
		[Token(Token = "0x400175F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _wetnessToPuddle;

		// Token: 0x04001760 RID: 5984
		[Token(Token = "0x4001760")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _wetnessOff;

		// Token: 0x04001761 RID: 5985
		[Token(Token = "0x4001761")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _wetnessOn;

		// Token: 0x04001762 RID: 5986
		[Token(Token = "0x4001762")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _staticWaterAmount;

		// Token: 0x04001763 RID: 5987
		[Token(Token = "0x4001763")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _rainOff;

		// Token: 0x04001764 RID: 5988
		[Token(Token = "0x4001764")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _rainOn;

		// Token: 0x04001765 RID: 5989
		[Token(Token = "0x4001765")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _rainIncreaseSmoothTime;

		// Token: 0x04001766 RID: 5990
		[Token(Token = "0x4001766")]
		[FieldOffset(Offset = "0x50")]
		[Header("Debug")]
		private float _currentPuddle;

		// Token: 0x04001767 RID: 5991
		[Token(Token = "0x4001767")]
		[FieldOffset(Offset = "0x54")]
		private float _currentWetness;

		// Token: 0x04001768 RID: 5992
		[Token(Token = "0x4001768")]
		[FieldOffset(Offset = "0x58")]
		private float _currentStaticWater;

		// Token: 0x04001769 RID: 5993
		[Token(Token = "0x4001769")]
		[FieldOffset(Offset = "0x5C")]
		private float _previousWetness;

		// Token: 0x0400176A RID: 5994
		[Token(Token = "0x400176A")]
		[FieldOffset(Offset = "0x60")]
		private float _wetnessToPuddleFac;

		// Token: 0x0400176B RID: 5995
		[Token(Token = "0x400176B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int GlobalPuddleParams;

		// Token: 0x0400176C RID: 5996
		[Token(Token = "0x400176C")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int GlobalWetnessParams;

		// Token: 0x0400176D RID: 5997
		[Token(Token = "0x400176D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int GlobalRainIntensity;

		// Token: 0x0400176E RID: 5998
		[Token(Token = "0x400176E")]
		[FieldOffset(Offset = "0x64")]
		private float _currentRainIntensity;

		// Token: 0x0400176F RID: 5999
		[Token(Token = "0x400176F")]
		[FieldOffset(Offset = "0x68")]
		private float _rainIntensityVelocity;
	}
}
