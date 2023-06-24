using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	internal class MpbTriangle : MetaMpb, IDashableMpb
	{
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001A0")]
		private List<float> dashOffset
		{
			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x8DF560", Offset = "0x8DDB60", VA = "0x1808DF560", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001A1")]
		private List<float> dashShapeModifier
		{
			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x6913C0", Offset = "0x68F9C0", VA = "0x1806913C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001A2")]
		private List<float> dashSize
		{
			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x1359C20", Offset = "0x1358220", VA = "0x181359C20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001A3")]
		private List<float> dashSnap
		{
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x61C550", Offset = "0x61AB50", VA = "0x18061C550", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001A4")]
		private List<float> dashSpace
		{
			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x2A3B6D0", Offset = "0x2A39CD0", VA = "0x182A3B6D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001A5")]
		private List<float> dashSpacing
		{
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x2A3B6E0", Offset = "0x2A39CE0", VA = "0x182A3B6E0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001A6")]
		private List<float> dashType
		{
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x2A3B6F0", Offset = "0x2A39CF0", VA = "0x182A3B6F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x2A3E8C0", Offset = "0x2A3CEC0", VA = "0x182A3E8C0", Slot = "5")]
		protected override void TransferShapeProperties()
		{
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x2A3EA70", Offset = "0x2A3D070", VA = "0x182A3EA70")]
		public MpbTriangle()
		{
		}

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0xC0")]
		internal readonly List<Vector4> a;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0xC8")]
		internal readonly List<Vector4> b;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0xD0")]
		internal readonly List<Vector4> c;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0xD8")]
		internal readonly List<Vector4> colorB;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0xE0")]
		internal readonly List<Vector4> colorC;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0xE8")]
		internal readonly List<float> hollow;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0xF0")]
		internal readonly List<float> roundness;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0xF8")]
		internal readonly List<float> scaleMode;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x100")]
		internal readonly List<float> thickness;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x108")]
		internal readonly List<float> thicknessSpace;
	}
}
