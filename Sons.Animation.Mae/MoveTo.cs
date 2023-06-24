using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.Mae
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	[Serializable]
	public class MoveTo : ActionTemplate
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2B87C30", Offset = "0x2B86230", VA = "0x182B87C30", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2D1F190", Offset = "0x2D1D790", VA = "0x182D1F190", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2D1F200", Offset = "0x2D1D800", VA = "0x182D1F200", Slot = "17")]
		public override void OnValidate()
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000266C File Offset: 0x0000086C
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2D1F360", Offset = "0x2D1D960", VA = "0x182D1F360", Slot = "11")]
		internal override bool Start()
		{
			return default(bool);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002684 File Offset: 0x00000884
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2D1F620", Offset = "0x2D1DC20", VA = "0x182D1F620", Slot = "16")]
		protected override bool AllPassed()
		{
			return default(bool);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2D1F640", Offset = "0x2D1DC40", VA = "0x182D1F640", Slot = "15")]
		public override bool ShouldEnd()
		{
			return default(bool);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2D1F6E0", Offset = "0x2D1DCE0", VA = "0x182D1F6E0", Slot = "7")]
		public override bool ShouldInterrupt()
		{
			return default(bool);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2D1F6F0", Offset = "0x2D1DCF0", VA = "0x182D1F6F0")]
		private void CompletedCallback()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2D1C040", Offset = "0x2D1A640", VA = "0x182D1C040")]
		private void InterruptedCallback()
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2BC0FA0", Offset = "0x2BBF5A0", VA = "0x182BC0FA0")]
		public MoveTo()
		{
		}

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private float _speed;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[HideInInspector]
		private bool _tempConvertedSpeed;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SpeedRangeSet _speeds;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool _ignorePathBounds;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x71")]
		[SerializeField]
		private bool _timeoutInterruptsSequence;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x74")]
		[Tooltip("If non-zero, will cancel action if path end is further than max distance from target")]
		[SerializeField]
		private float _maxPathEndDistance;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _mustFollowEntirePath;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x7C")]
		[FormerlySerializedAs("_distance")]
		[SerializeField]
		[Tooltip("Move will complete successfully once within min distance of target")]
		private float _minDistance;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _stopIgnoreY;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x81")]
		[SerializeField]
		private bool _useMaxDistance;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _maxDistance;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ActionTemplate.MoveStateEnd _onMoveState;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x8C")]
		private bool _moveToPassed;
	}
}
