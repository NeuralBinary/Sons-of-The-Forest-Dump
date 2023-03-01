using System;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020007FB RID: 2043
	[Token(Token = "0x20007FB")]
	[AddComponentMenu("Sons/Characters/Simple Animal Trigger")]
	public class SimpleAnimalTrigger : MonoBehaviour
	{
		// Token: 0x0600361A RID: 13850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361A")]
		[Address(RVA = "0x2E98D30", Offset = "0x2E97D30", VA = "0x182E98D30")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361B")]
		[Address(RVA = "0x2E98F20", Offset = "0x2E97F20", VA = "0x182E98F20")]
		private void PlaySound()
		{
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361C")]
		[Address(RVA = "0x2E99090", Offset = "0x2E98090", VA = "0x182E99090")]
		public SimpleAnimalTrigger()
		{
		}

		// Token: 0x04002E66 RID: 11878
		[Token(Token = "0x4002E66")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _cooldown;

		// Token: 0x04002E67 RID: 11879
		[Token(Token = "0x4002E67")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _eventDelay;

		// Token: 0x04002E68 RID: 11880
		[Token(Token = "0x4002E68")]
		[FieldOffset(Offset = "0x28")]
		[EventRef]
		[SerializeField]
		private string _triggerEvent;

		// Token: 0x04002E69 RID: 11881
		[Token(Token = "0x4002E69")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleAnimalZone _triggeredZone;

		// Token: 0x04002E6A RID: 11882
		[Token(Token = "0x4002E6A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _triggerChance;

		// Token: 0x04002E6B RID: 11883
		[Token(Token = "0x4002E6B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _useActiveHours;

		// Token: 0x04002E6C RID: 11884
		[Token(Token = "0x4002E6C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2Int _hourOfDayRange;

		// Token: 0x04002E6D RID: 11885
		[Token(Token = "0x4002E6D")]
		[FieldOffset(Offset = "0x48")]
		private bool _triggered;

		// Token: 0x04002E6E RID: 11886
		[Token(Token = "0x4002E6E")]
		[FieldOffset(Offset = "0x4C")]
		private float _triggeredTime;
	}
}
