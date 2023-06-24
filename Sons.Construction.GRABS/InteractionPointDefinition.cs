using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[Serializable]
	public class InteractionPointDefinition
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x17000075")]
		public bool Enabled
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x17000076")]
		public InteractionPointMode Mode
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
			get
			{
				return InteractionPointMode.FixedPosition;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000077")]
		public string Name
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x17000078")]
		public Vector3 RelativePosition
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x29A0830", Offset = "0x299EE30", VA = "0x1829A0830")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00002A14 File Offset: 0x00000C14
		[Token(Token = "0x17000079")]
		public Vector3 ForwardAxis
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x28D1490", Offset = "0x28CFA90", VA = "0x1828D1490")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x1700007A")]
		public Vector3 UpAxis
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x26ECB30", Offset = "0x26EB130", VA = "0x1826ECB30")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700007B")]
		public OperationFactory RepositionOperationFactory
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700007C")]
		public OperationFactory ExtrudeOperationFactory
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700007D")]
		public OperationFactory CancelperationFactory
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700007E")]
		public IVisualInteractionPointInstanceProvider VisualsProvider
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1487590", Offset = "0x1485B90", VA = "0x181487590")]
		public InteractionPointDefinition()
		{
		}

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _name;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _enabled;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private InteractionPointMode _mode;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _relativePosition;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 _forwardAxis;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 _upAxis;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private OperationFactory _repositionOperationFactory;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private OperationFactory _extrudeOperationFactory;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private OperationFactory _cancelOperationFactory;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private VisualInstanceProvider _visualInstanceProvider;
	}
}
