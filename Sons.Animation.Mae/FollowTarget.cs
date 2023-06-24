using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[Serializable]
	public class FollowTarget : ActionTemplate
	{
		// Token: 0x0600004B RID: 75 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2B87C30", Offset = "0x2B86230", VA = "0x182B87C30", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2D1DCF0", Offset = "0x2D1C2F0", VA = "0x182D1DCF0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2D1DD60", Offset = "0x2D1C360", VA = "0x182D1DD60", Slot = "17")]
		public override void OnValidate()
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2D1DDD0", Offset = "0x2D1C3D0", VA = "0x182D1DDD0", Slot = "11")]
		internal override bool Start()
		{
			return default(bool);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2D1DF30", Offset = "0x2D1C530", VA = "0x182D1DF30", Slot = "16")]
		protected override bool AllPassed()
		{
			return default(bool);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void CompletedCallback()
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2D1DF60", Offset = "0x2D1C560", VA = "0x182D1DF60")]
		private void InterruptedCallback()
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2BC0FA0", Offset = "0x2BBF5A0", VA = "0x182BC0FA0")]
		public FollowTarget()
		{
		}

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SpeedRangeSet _speeds;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		private bool _convertedSpeed;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		protected float _speed;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected bool _endOnlyOnInterrupt;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x71")]
		private bool _followWasInterrupted;
	}
}
