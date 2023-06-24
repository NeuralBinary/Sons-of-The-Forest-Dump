using System;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000812 RID: 2066
	[Token(Token = "0x2000812")]
	[Serializable]
	public class GolfCartPlayerState : ClearOnDisposeBase
	{
		// Token: 0x06003851 RID: 14417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003851")]
		[Address(RVA = "0x3553570", Offset = "0x3551B70", VA = "0x183553570")]
		public GolfCartPlayerState()
		{
		}

		// Token: 0x040030B8 RID: 12472
		[Token(Token = "0x40030B8")]
		[FieldOffset(Offset = "0x10")]
		[ClearOnDispose(false)]
		public bool IsConnected;

		// Token: 0x040030B9 RID: 12473
		[Token(Token = "0x40030B9")]
		[FieldOffset(Offset = "0x14")]
		[ClearOnDispose(0)]
		public int ConnectedSlotIndex;

		// Token: 0x040030BA RID: 12474
		[Token(Token = "0x40030BA")]
		[FieldOffset(Offset = "0x18")]
		[ClearOnDispose(null)]
		public GolfCartControllerDefinition Definition;

		// Token: 0x040030BB RID: 12475
		[Token(Token = "0x40030BB")]
		[FieldOffset(Offset = "0x20")]
		[ClearOnDispose(null)]
		public GolfCartController ConnectedGolfCartController;

		// Token: 0x040030BC RID: 12476
		[Token(Token = "0x40030BC")]
		[FieldOffset(Offset = "0x28")]
		[ClearOnDispose(0)]
		public int InitializedFrame;

		// Token: 0x040030BD RID: 12477
		[Token(Token = "0x40030BD")]
		[FieldOffset(Offset = "0x2C")]
		[ClearOnDispose(0f)]
		public float InitializedTime;

		// Token: 0x040030BE RID: 12478
		[Token(Token = "0x40030BE")]
		[FieldOffset(Offset = "0x30")]
		[ClearOnDispose]
		public Vector2 MovementInput;

		// Token: 0x040030BF RID: 12479
		[Token(Token = "0x40030BF")]
		[FieldOffset(Offset = "0x38")]
		[ClearOnDispose]
		public bool BoostInput;

		// Token: 0x040030C0 RID: 12480
		[Token(Token = "0x40030C0")]
		[FieldOffset(Offset = "0x39")]
		[ClearOnDispose]
		public bool HandBrakeInput;
	}
}
