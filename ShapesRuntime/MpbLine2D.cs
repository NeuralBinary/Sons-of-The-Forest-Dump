using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	internal class MpbLine2D : MetaMpb, IDashableMpb
	{
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000175")]
		private List<float> dashOffset
		{
			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0xA3F220", Offset = "0xA3D820", VA = "0x180A3F220", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000176")]
		private List<float> dashShapeModifier
		{
			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0x8DF480", Offset = "0x8DDA80", VA = "0x1808DF480", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000177")]
		private List<float> dashSize
		{
			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x8DF4F0", Offset = "0x8DDAF0", VA = "0x1808DF4F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000178")]
		private List<float> dashSnap
		{
			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0x8DF560", Offset = "0x8DDB60", VA = "0x1808DF560", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000179")]
		private List<float> dashSpace
		{
			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x6913C0", Offset = "0x68F9C0", VA = "0x1806913C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x1700017A")]
		private List<float> dashSpacing
		{
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x1359C20", Offset = "0x1358220", VA = "0x181359C20", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x1700017B")]
		private List<float> dashType
		{
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x61C550", Offset = "0x61AB50", VA = "0x18061C550", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x2A3BF60", Offset = "0x2A3A560", VA = "0x182A3BF60", Slot = "5")]
		protected override void TransferShapeProperties()
		{
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x2A3C0A0", Offset = "0x2A3A6A0", VA = "0x182A3C0A0")]
		public MpbLine2D()
		{
		}

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0xC0")]
		internal readonly List<float> alignment;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0xC8")]
		internal readonly List<Vector4> colorEnd;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0xD0")]
		internal readonly List<Vector4> pointEnd;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0xD8")]
		internal readonly List<Vector4> pointStart;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0xE0")]
		internal readonly List<float> scaleMode;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0xE8")]
		internal readonly List<float> thickness;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0xF0")]
		internal readonly List<float> thicknessSpace;
	}
}
