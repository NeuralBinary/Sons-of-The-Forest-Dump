using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[Serializable]
	public class Flank : ActionTemplate
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2B87C30", Offset = "0x2B86230", VA = "0x182B87C30", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2D1D3C0", Offset = "0x2D1B9C0", VA = "0x182D1D3C0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2D1D430", Offset = "0x2D1BA30", VA = "0x182D1D430", Slot = "17")]
		public override void OnValidate()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2D1D4A0", Offset = "0x2D1BAA0", VA = "0x182D1D4A0", Slot = "11")]
		internal override bool Start()
		{
			return default(bool);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2D1D720", Offset = "0x2D1BD20", VA = "0x182D1D720", Slot = "16")]
		protected override bool AllPassed()
		{
			return default(bool);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2D1D740", Offset = "0x2D1BD40", VA = "0x182D1D740")]
		private void CompletedCallback()
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2D1C040", Offset = "0x2D1A640", VA = "0x182D1C040")]
		private void InterruptedCallback()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2D1D750", Offset = "0x2D1BD50", VA = "0x182D1D750")]
		public Flank()
		{
		}

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private float _speed;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[SerializeField]
		private bool _convertedSpeed;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SpeedRangeSet _speeds;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MoveTargetType _targetType;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Vector2 _minMaxDegrees;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector2 _minMaxDistanceOffset;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _stopDistance;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool _stopIgnoreY;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x89")]
		private bool _flankPassed;
	}
}
