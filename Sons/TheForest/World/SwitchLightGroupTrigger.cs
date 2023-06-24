using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.World
{
	// Token: 0x0200038E RID: 910
	[Token(Token = "0x200038E")]
	public class SwitchLightGroupTrigger : MonoBehaviour
	{
		// Token: 0x0600183F RID: 6207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		private void Awake()
		{
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x327B520", Offset = "0x3279B20", VA = "0x18327B520")]
		private void Update()
		{
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001841")]
		[Address(RVA = "0x327B6D0", Offset = "0x3279CD0", VA = "0x18327B6D0")]
		private void GrabEnter()
		{
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001842")]
		[Address(RVA = "0x327B740", Offset = "0x3279D40", VA = "0x18327B740")]
		private void GrabExit()
		{
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001843")]
		[Address(RVA = "0x327B7B0", Offset = "0x3279DB0", VA = "0x18327B7B0")]
		private void ToggleIcons(bool showSheen, bool showPickup)
		{
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001844")]
		[Address(RVA = "0x327B9C0", Offset = "0x3279FC0", VA = "0x18327B9C0")]
		private void BatchLights()
		{
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001845")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SwitchLightGroupTrigger()
		{
		}

		// Token: 0x04001747 RID: 5959
		[Token(Token = "0x4001747")]
		[FieldOffset(Offset = "0x20")]
		public SwitchLightGroupTrigger.LightObject[] _lights;

		// Token: 0x04001748 RID: 5960
		[Token(Token = "0x4001748")]
		[FieldOffset(Offset = "0x28")]
		public Material _turnedOnMat;

		// Token: 0x04001749 RID: 5961
		[Token(Token = "0x4001749")]
		[FieldOffset(Offset = "0x30")]
		public Material _turnedOffMat;

		// Token: 0x0400174A RID: 5962
		[Token(Token = "0x400174A")]
		[FieldOffset(Offset = "0x38")]
		public float _batchInterval;

		// Token: 0x0400174B RID: 5963
		[Token(Token = "0x400174B")]
		[FieldOffset(Offset = "0x3C")]
		public int _lightsPerBatch;

		// Token: 0x0400174C RID: 5964
		[Token(Token = "0x400174C")]
		[FieldOffset(Offset = "0x40")]
		public GameObject _sheenIcon;

		// Token: 0x0400174D RID: 5965
		[Token(Token = "0x400174D")]
		[FieldOffset(Offset = "0x48")]
		public GameObject _pickupIcon;

		// Token: 0x0400174E RID: 5966
		[Token(Token = "0x400174E")]
		[FieldOffset(Offset = "0x50")]
		[Header("Testing")]
		public bool _turnOnTest;

		// Token: 0x0400174F RID: 5967
		[Token(Token = "0x400174F")]
		[FieldOffset(Offset = "0x51")]
		public bool _turnOffTest;

		// Token: 0x04001750 RID: 5968
		[Token(Token = "0x4001750")]
		[FieldOffset(Offset = "0x54")]
		private float _nextBatchTime;

		// Token: 0x04001751 RID: 5969
		[Token(Token = "0x4001751")]
		[FieldOffset(Offset = "0x58")]
		private bool _grabbed;

		// Token: 0x04001752 RID: 5970
		[Token(Token = "0x4001752")]
		[FieldOffset(Offset = "0x5C")]
		private int _currentLight;

		// Token: 0x04001753 RID: 5971
		[Token(Token = "0x4001753")]
		[FieldOffset(Offset = "0x60")]
		private SwitchLightGroupTrigger.States _state;

		// Token: 0x0200038F RID: 911
		[Token(Token = "0x200038F")]
		[Serializable]
		public class LightObject
		{
			// Token: 0x06001846 RID: 6214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001846")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public LightObject()
			{
			}

			// Token: 0x04001754 RID: 5972
			[Token(Token = "0x4001754")]
			[FieldOffset(Offset = "0x10")]
			public GameObject _rootGo;

			// Token: 0x04001755 RID: 5973
			[Token(Token = "0x4001755")]
			[FieldOffset(Offset = "0x18")]
			public Light _light;

			// Token: 0x04001756 RID: 5974
			[Token(Token = "0x4001756")]
			[FieldOffset(Offset = "0x20")]
			public Renderer _renderer;
		}

		// Token: 0x02000390 RID: 912
		[Token(Token = "0x2000390")]
		public enum States
		{
			// Token: 0x04001758 RID: 5976
			[Token(Token = "0x4001758")]
			Off,
			// Token: 0x04001759 RID: 5977
			[Token(Token = "0x4001759")]
			On,
			// Token: 0x0400175A RID: 5978
			[Token(Token = "0x400175A")]
			TurningOff,
			// Token: 0x0400175B RID: 5979
			[Token(Token = "0x400175B")]
			TurningOn
		}
	}
}
