using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[Serializable]
	public class MoveRandom : ActionTemplate
	{
		// Token: 0x06000076 RID: 118 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2B87C30", Offset = "0x2B86230", VA = "0x182B87C30", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2D1EE10", Offset = "0x2D1D410", VA = "0x182D1EE10", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2D1D430", Offset = "0x2D1BA30", VA = "0x182D1D430", Slot = "17")]
		public override void OnValidate()
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2D1EE80", Offset = "0x2D1D480", VA = "0x182D1EE80", Slot = "11")]
		internal override bool Start()
		{
			return default(bool);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2D1F080", Offset = "0x2D1D680", VA = "0x182D1F080", Slot = "15")]
		public override bool ShouldEnd()
		{
			return default(bool);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2D1F120", Offset = "0x2D1D720", VA = "0x182D1F120", Slot = "16")]
		protected override bool AllPassed()
		{
			return default(bool);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2D1F140", Offset = "0x2D1D740", VA = "0x182D1F140")]
		private void CompletedCallback()
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2D1C040", Offset = "0x2D1A640", VA = "0x182D1C040")]
		private void InterruptedCallback()
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2D1F150", Offset = "0x2D1D750", VA = "0x182D1F150")]
		public MoveRandom()
		{
		}

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[SerializeField]
		private float _speed;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[HideInInspector]
		private bool _convertedSpeed;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SpeedRangeSet _speeds;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MoveRandomDirection _direction;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private MoveRandomBounds _boundsType;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector2 _minMaxDirection;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector2 _minMaxDistance;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _stopDistance;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private ActionTemplate.MoveStateEnd _onMoveState;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x90")]
		private bool _passed;
	}
}
