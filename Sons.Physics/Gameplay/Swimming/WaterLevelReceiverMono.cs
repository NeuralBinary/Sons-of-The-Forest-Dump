using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Swimming
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public abstract class WaterLevelReceiverMono : MonoBehaviour, IWaterLevelReceiver
	{
		// Token: 0x06000019 RID: 25
		[Token(Token = "0x6000019")]
		public abstract void OnBelowWaterLevel();

		// Token: 0x0600001A RID: 26
		[Token(Token = "0x600001A")]
		public abstract void OnAboveWaterLevel();

		// Token: 0x0600001B RID: 27
		[Token(Token = "0x600001B")]
		public abstract void UpdateWaterLevelDistance(float distance);

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected WaterLevelReceiverMono()
		{
		}
	}
}
