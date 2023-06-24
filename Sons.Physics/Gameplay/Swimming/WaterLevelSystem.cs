using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay.Swimming
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class WaterLevelSystem : WaterLevelReceiverMono
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x30F9610", Offset = "0x30F7C10", VA = "0x1830F9610", Slot = "7")]
		public override void OnBelowWaterLevel()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x30F9730", Offset = "0x30F7D30", VA = "0x1830F9730", Slot = "8")]
		public override void OnAboveWaterLevel()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x30F9850", Offset = "0x30F7E50", VA = "0x1830F9850", Slot = "9")]
		public override void UpdateWaterLevelDistance(float distance)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public WaterLevelSystem()
		{
		}

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		private const string DepthParamString = "depth";

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent _onHeadBelowWaterUnityEvent;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent _onHeadAboveWaterUnityEvent;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent<float> _updateWaterLevelDistanceUnityEvent;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SonsFMODEventEmitter _underwaterEmitter;
	}
}
