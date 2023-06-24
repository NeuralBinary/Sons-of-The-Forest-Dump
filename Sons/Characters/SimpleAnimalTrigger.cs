using System;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000709 RID: 1801
	[Token(Token = "0x2000709")]
	[AddComponentMenu("Sons/Characters/Simple Animal Trigger")]
	public class SimpleAnimalTrigger : MonoBehaviour
	{
		// Token: 0x06002FC1 RID: 12225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC1")]
		[Address(RVA = "0x3466D80", Offset = "0x3465380", VA = "0x183466D80")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC2")]
		[Address(RVA = "0x3467050", Offset = "0x3465650", VA = "0x183467050")]
		private void Trigger()
		{
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC3")]
		[Address(RVA = "0x34671C0", Offset = "0x34657C0", VA = "0x1834671C0")]
		private void PlaySound()
		{
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC4")]
		[Address(RVA = "0x3467490", Offset = "0x3465A90", VA = "0x183467490")]
		public SimpleAnimalTrigger()
		{
		}

		// Token: 0x04002958 RID: 10584
		[Token(Token = "0x4002958")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _cooldown;

		// Token: 0x04002959 RID: 10585
		[Token(Token = "0x4002959")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _eventDelay;

		// Token: 0x0400295A RID: 10586
		[Token(Token = "0x400295A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[EventRef]
		private string _triggerEvent;

		// Token: 0x0400295B RID: 10587
		[Token(Token = "0x400295B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleAnimalZone _triggeredZone;

		// Token: 0x0400295C RID: 10588
		[Token(Token = "0x400295C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _triggerChance;

		// Token: 0x0400295D RID: 10589
		[Token(Token = "0x400295D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _useActiveHours;

		// Token: 0x0400295E RID: 10590
		[Token(Token = "0x400295E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2Int _hourOfDayRange;

		// Token: 0x0400295F RID: 10591
		[Token(Token = "0x400295F")]
		[FieldOffset(Offset = "0x48")]
		private bool _triggered;

		// Token: 0x04002960 RID: 10592
		[Token(Token = "0x4002960")]
		[FieldOffset(Offset = "0x4C")]
		private float _triggeredTime;
	}
}
