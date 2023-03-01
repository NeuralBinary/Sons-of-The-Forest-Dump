using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.World
{
	// Token: 0x0200039C RID: 924
	[Token(Token = "0x200039C")]
	public class SwitchLightGroupTrigger : MonoBehaviour
	{
		// Token: 0x06001804 RID: 6148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001804")]
		[Address(RVA = "0x21F6BA0", Offset = "0x21F5BA0", VA = "0x1821F6BA0")]
		private void Awake()
		{
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001805")]
		[Address(RVA = "0x2CD23A0", Offset = "0x2CD13A0", VA = "0x182CD23A0")]
		private void Update()
		{
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001806")]
		[Address(RVA = "0x2CD2250", Offset = "0x2CD1250", VA = "0x182CD2250")]
		private void GrabEnter()
		{
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001807")]
		[Address(RVA = "0x2CD2290", Offset = "0x2CD1290", VA = "0x182CD2290")]
		private void GrabExit()
		{
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001808")]
		[Address(RVA = "0x2CD22D0", Offset = "0x2CD12D0", VA = "0x182CD22D0")]
		private void ToggleIcons(bool showSheen, bool showPickup)
		{
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001809")]
		[Address(RVA = "0x2CD1F40", Offset = "0x2CD0F40", VA = "0x182CD1F40")]
		private void BatchLights()
		{
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180A")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SwitchLightGroupTrigger()
		{
		}

		// Token: 0x04001728 RID: 5928
		[Token(Token = "0x4001728")]
		[FieldOffset(Offset = "0x20")]
		public SwitchLightGroupTrigger.LightObject[] _lights;

		// Token: 0x04001729 RID: 5929
		[Token(Token = "0x4001729")]
		[FieldOffset(Offset = "0x28")]
		public Material _turnedOnMat;

		// Token: 0x0400172A RID: 5930
		[Token(Token = "0x400172A")]
		[FieldOffset(Offset = "0x30")]
		public Material _turnedOffMat;

		// Token: 0x0400172B RID: 5931
		[Token(Token = "0x400172B")]
		[FieldOffset(Offset = "0x38")]
		public float _batchInterval;

		// Token: 0x0400172C RID: 5932
		[Token(Token = "0x400172C")]
		[FieldOffset(Offset = "0x3C")]
		public int _lightsPerBatch;

		// Token: 0x0400172D RID: 5933
		[Token(Token = "0x400172D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject _sheenIcon;

		// Token: 0x0400172E RID: 5934
		[Token(Token = "0x400172E")]
		[FieldOffset(Offset = "0x48")]
		public GameObject _pickupIcon;

		// Token: 0x0400172F RID: 5935
		[Token(Token = "0x400172F")]
		[FieldOffset(Offset = "0x50")]
		[Header("Testing")]
		public bool _turnOnTest;

		// Token: 0x04001730 RID: 5936
		[Token(Token = "0x4001730")]
		[FieldOffset(Offset = "0x51")]
		public bool _turnOffTest;

		// Token: 0x04001731 RID: 5937
		[Token(Token = "0x4001731")]
		[FieldOffset(Offset = "0x54")]
		private float _nextBatchTime;

		// Token: 0x04001732 RID: 5938
		[Token(Token = "0x4001732")]
		[FieldOffset(Offset = "0x58")]
		private bool _grabbed;

		// Token: 0x04001733 RID: 5939
		[Token(Token = "0x4001733")]
		[FieldOffset(Offset = "0x5C")]
		private int _currentLight;

		// Token: 0x04001734 RID: 5940
		[Token(Token = "0x4001734")]
		[FieldOffset(Offset = "0x60")]
		private SwitchLightGroupTrigger.States _state;

		// Token: 0x0200039D RID: 925
		[Token(Token = "0x200039D")]
		[Serializable]
		public class LightObject
		{
			// Token: 0x0600180B RID: 6155 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600180B")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public LightObject()
			{
			}

			// Token: 0x04001735 RID: 5941
			[Token(Token = "0x4001735")]
			[FieldOffset(Offset = "0x10")]
			public GameObject _rootGo;

			// Token: 0x04001736 RID: 5942
			[Token(Token = "0x4001736")]
			[FieldOffset(Offset = "0x18")]
			public Light _light;

			// Token: 0x04001737 RID: 5943
			[Token(Token = "0x4001737")]
			[FieldOffset(Offset = "0x20")]
			public Renderer _renderer;
		}

		// Token: 0x0200039E RID: 926
		[Token(Token = "0x200039E")]
		public enum States
		{
			// Token: 0x04001739 RID: 5945
			[Token(Token = "0x4001739")]
			Off,
			// Token: 0x0400173A RID: 5946
			[Token(Token = "0x400173A")]
			On,
			// Token: 0x0400173B RID: 5947
			[Token(Token = "0x400173B")]
			TurningOff,
			// Token: 0x0400173C RID: 5948
			[Token(Token = "0x400173C")]
			TurningOn
		}
	}
}
