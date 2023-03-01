using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006C9 RID: 1737
	[Token(Token = "0x20006C9")]
	public class ThrownLogDamage : MeleeWeapon
	{
		// Token: 0x06002C79 RID: 11385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C79")]
		[Address(RVA = "0x68B0F0", Offset = "0x68A0F0", VA = "0x18068B0F0", Slot = "13")]
		public override MonoBehaviour GetSourceStimuli()
		{
			return null;
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C7A")]
		[Address(RVA = "0x6AC8D0", Offset = "0x6AB8D0", VA = "0x1806AC8D0")]
		public void SetSourceStimuli(MonoBehaviourStimuli sourceStimuli)
		{
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C7B")]
		[Address(RVA = "0x2DFB210", Offset = "0x2DFA210", VA = "0x182DFB210", Slot = "10")]
		protected override void OnValidate()
		{
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C7C")]
		[Address(RVA = "0x2DFAE10", Offset = "0x2DF9E10", VA = "0x182DFAE10", Slot = "11")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C7D")]
		[Address(RVA = "0x2DFAE50", Offset = "0x2DF9E50", VA = "0x182DFAE50", Slot = "12")]
		protected override void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C7E")]
		[Address(RVA = "0x2DFB2B0", Offset = "0x2DFA2B0", VA = "0x182DFB2B0")]
		private void Update()
		{
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C7F")]
		[Address(RVA = "0x2DFB3F0", Offset = "0x2DFA3F0", VA = "0x182DFB3F0")]
		public ThrownLogDamage()
		{
		}

		// Token: 0x040027D1 RID: 10193
		[Token(Token = "0x40027D1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x040027D2 RID: 10194
		[Token(Token = "0x40027D2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _minDamageSpeed;

		// Token: 0x040027D3 RID: 10195
		[Token(Token = "0x40027D3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[EventRef]
		private string _fleshHitEvent;

		// Token: 0x040027D4 RID: 10196
		[Token(Token = "0x40027D4")]
		[FieldOffset(Offset = "0x90")]
		private float _lastAudioTime;

		// Token: 0x040027D5 RID: 10197
		[Token(Token = "0x40027D5")]
		[FieldOffset(Offset = "0x94")]
		private float _enableTime;

		// Token: 0x040027D6 RID: 10198
		[Token(Token = "0x40027D6")]
		[FieldOffset(Offset = "0x98")]
		private float _noDamageTime;

		// Token: 0x040027D7 RID: 10199
		[Token(Token = "0x40027D7")]
		[FieldOffset(Offset = "0xA0")]
		private MonoBehaviourStimuli _sourceStimuli;
	}
}
