using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[Serializable]
	public class StatusEffect
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		public StatusEffectType Type
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return StatusEffectType.Unknown;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x17000002")]
		public float LifeTime
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x17000003")]
		public float RemainingLifetime
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2FFD5D0", Offset = "0x2FFBBD0", VA = "0x182FFD5D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x17000004")]
		private float TimeAlive
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2FFD640", Offset = "0x2FFBC40", VA = "0x182FFD640")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public StatusEffect()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2FFD6A0", Offset = "0x2FFBCA0", VA = "0x182FFD6A0")]
		public StatusEffect(StatusEffectType type, float lifeTime)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2FFD6B0", Offset = "0x2FFBCB0", VA = "0x182FFD6B0")]
		public void AddLifetime(float lifeTime)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2FFD6C0", Offset = "0x2FFBCC0", VA = "0x182FFD6C0")]
		public void Refresh(float lifetime)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2FFD750", Offset = "0x2FFBD50", VA = "0x182FFD750")]
		public void Start()
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020C8 File Offset: 0x000002C8
		[Token(Token = "0x17000005")]
		public bool Alive
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x2FFD7F0", Offset = "0x2FFBDF0", VA = "0x182FFD7F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private StatusEffectType _type;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Min(0f)]
		private float _lifeTime;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x18")]
		private float _started;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x1C")]
		private int _timeStamp;
	}
}
