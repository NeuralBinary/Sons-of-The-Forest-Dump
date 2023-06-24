using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000278 RID: 632
	[Token(Token = "0x2000278")]
	[Serializable]
	public class Tweener
	{
		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x0000BC24 File Offset: 0x00009E24
		[Token(Token = "0x1700042F")]
		public TweenTypes Type
		{
			[Token(Token = "0x6001365")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return TweenTypes.None;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x0000BC3C File Offset: 0x00009E3C
		[Token(Token = "0x17000430")]
		public float Duration
		{
			[Token(Token = "0x6001366")]
			[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x0000BC54 File Offset: 0x00009E54
		[Token(Token = "0x17000431")]
		public bool Running
		{
			[Token(Token = "0x6001367")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001368")]
		[Address(RVA = "0x2F56340", Offset = "0x2F54940", VA = "0x182F56340")]
		public void Start(TweenTypes type, float duration)
		{
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001369")]
		[Address(RVA = "0x2F563B0", Offset = "0x2F549B0", VA = "0x182F563B0")]
		public void Start()
		{
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600136A")]
		[Address(RVA = "0x12C8170", Offset = "0x12C6770", VA = "0x1812C8170")]
		public void Stop()
		{
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x0000BC6C File Offset: 0x00009E6C
		[Token(Token = "0x600136B")]
		[Address(RVA = "0x2F56410", Offset = "0x2F54A10", VA = "0x182F56410")]
		public float CalcTweenAlpha()
		{
			return 0f;
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600136C")]
		[Address(RVA = "0x2F56550", Offset = "0x2F54B50", VA = "0x182F56550")]
		public Tweener()
		{
		}

		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x4000963")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TweenTypes _type;

		// Token: 0x04000964 RID: 2404
		[Token(Token = "0x4000964")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _duration;

		// Token: 0x04000965 RID: 2405
		[Token(Token = "0x4000965")]
		[FieldOffset(Offset = "0x18")]
		private bool _running;

		// Token: 0x04000966 RID: 2406
		[Token(Token = "0x4000966")]
		[FieldOffset(Offset = "0x1C")]
		private float _startTime;
	}
}
