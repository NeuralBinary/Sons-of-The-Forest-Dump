using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	public abstract class Operation
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000083")]
		public InteractionPoint InteractionPoint
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000084")]
		public BlueprintFace Face
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00002AEC File Offset: 0x00000CEC
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000085")]
		public bool AutoValidate
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00002B04 File Offset: 0x00000D04
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000086")]
		public bool SnapToTileGrid
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x9938E0", Offset = "0x991EE0", VA = "0x1809938E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x9C5820", Offset = "0x9C3E20", VA = "0x1809C5820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00002B1C File Offset: 0x00000D1C
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000087")]
		public bool CanSnapToStartPos
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x993970", Offset = "0x991F70", VA = "0x180993970")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x2B66130", Offset = "0x2B64730", VA = "0x182B66130")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00002B34 File Offset: 0x00000D34
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000088")]
		public bool DeleteOnCancel
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x2A99E50", Offset = "0x2A98450", VA = "0x182A99E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x2DA1460", Offset = "0x2D9FA60", VA = "0x182DA1460")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001F2 RID: 498
		[Token(Token = "0x60001F2")]
		public abstract bool Update(Transform aimTransform, out bool modifiedFace);

		// Token: 0x060001F3 RID: 499
		[Token(Token = "0x60001F3")]
		public abstract void Validate();

		// Token: 0x060001F4 RID: 500
		[Token(Token = "0x60001F4")]
		public abstract void Cancel();

		// Token: 0x060001F5 RID: 501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2DA1470", Offset = "0x2D9FA70", VA = "0x182DA1470")]
		protected void FaceCreated(BlueprintFace face)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2DA14C0", Offset = "0x2D9FAC0", VA = "0x182DA14C0")]
		protected void DestroyFace(BlueprintFace face)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2DA1520", Offset = "0x2D9FB20", VA = "0x182DA1520")]
		protected void FaceChanged(BlueprintFace face)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2DA1180", Offset = "0x2D9F780", VA = "0x182DA1180")]
		protected Operation()
		{
		}

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x10")]
		protected InteractionPoint _interactionPoint;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x18")]
		protected BlueprintFace _face;
	}
}
