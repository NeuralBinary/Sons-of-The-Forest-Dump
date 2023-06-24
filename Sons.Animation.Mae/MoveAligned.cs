using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[Serializable]
	public class MoveAligned : ActionTemplate
	{
		// Token: 0x0600006C RID: 108 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2B87C30", Offset = "0x2B86230", VA = "0x182B87C30", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x1700000C")]
		private bool IsMoveAway
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x2D1D8E0", Offset = "0x2D1BEE0", VA = "0x182D1D8E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2D1E9C0", Offset = "0x2D1CFC0", VA = "0x182D1E9C0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2D1EA30", Offset = "0x2D1D030", VA = "0x182D1EA30", Slot = "17")]
		public override void OnValidate()
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2D1EAA0", Offset = "0x2D1D0A0", VA = "0x182D1EAA0", Slot = "11")]
		internal override bool Start()
		{
			return default(bool);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2D1ED90", Offset = "0x2D1D390", VA = "0x182D1ED90", Slot = "16")]
		protected override bool AllPassed()
		{
			return default(bool);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2D1EDB0", Offset = "0x2D1D3B0", VA = "0x182D1EDB0", Slot = "7")]
		public override bool ShouldInterrupt()
		{
			return default(bool);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2D1EDD0", Offset = "0x2D1D3D0", VA = "0x182D1EDD0")]
		private void CompletedCallback()
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2D1C040", Offset = "0x2D1A640", VA = "0x182D1C040")]
		private void InterruptedCallback()
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2D1EDE0", Offset = "0x2D1D3E0", VA = "0x182D1EDE0")]
		public MoveAligned()
		{
		}

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MoveAligned.AlignType _alignType;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private MoveTargetType _targetType;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[SerializeField]
		private float _speed;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x6C")]
		[HideInInspector]
		[SerializeField]
		private bool _convertedSpeed;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SpeedRangeSet _speeds;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector2 _minMaxDistance;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _stopDistance;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private bool _stopIgnoreY;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x85")]
		[SerializeField]
		private bool _timeoutInterruptsSequence;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x86")]
		private bool _passed;

		// Token: 0x0200001C RID: 28
		[Token(Token = "0x200001C")]
		public enum AlignType
		{
			// Token: 0x040000AC RID: 172
			[Token(Token = "0x40000AC")]
			MoveAwayFrom,
			// Token: 0x040000AD RID: 173
			[Token(Token = "0x40000AD")]
			MoveToCoverFromPlayer,
			// Token: 0x040000AE RID: 174
			[Token(Token = "0x40000AE")]
			MoveToBehindPlayer,
			// Token: 0x040000AF RID: 175
			[Token(Token = "0x40000AF")]
			MoveToCoverFromEnemy
		}
	}
}
