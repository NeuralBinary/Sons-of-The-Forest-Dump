using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	internal class MpbDisc : MetaMpb, IDashableMpb
	{
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x1700016E")]
		private List<float> dashOffset
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x1359C20", Offset = "0x1358220", VA = "0x181359C20", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x1700016F")]
		private List<float> dashShapeModifier
		{
			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x61C550", Offset = "0x61AB50", VA = "0x18061C550", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000170")]
		private List<float> dashSize
		{
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x2A3B6D0", Offset = "0x2A39CD0", VA = "0x182A3B6D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000171")]
		private List<float> dashSnap
		{
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x2A3B6E0", Offset = "0x2A39CE0", VA = "0x182A3B6E0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000172")]
		private List<float> dashSpace
		{
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x2A3B6F0", Offset = "0x2A39CF0", VA = "0x182A3B6F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000173")]
		private List<float> dashSpacing
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x120B640", Offset = "0x1209C40", VA = "0x18120B640", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000174")]
		private List<float> dashType
		{
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x28665B0", Offset = "0x2864BB0", VA = "0x1828665B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x2A3B700", Offset = "0x2A39D00", VA = "0x182A3B700", Slot = "5")]
		protected override void TransferShapeProperties()
		{
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x2A3B900", Offset = "0x2A39F00", VA = "0x182A3B900")]
		public MpbDisc()
		{
		}

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0xC0")]
		internal readonly List<float> alignment;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0xC8")]
		internal readonly List<float> angleEnd;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0xD0")]
		internal readonly List<float> angleStart;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0xD8")]
		internal readonly List<Vector4> colorInnerEnd;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0xE0")]
		internal readonly List<Vector4> colorOuterEnd;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0xE8")]
		internal readonly List<Vector4> colorOuterStart;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0xF0")]
		internal readonly List<float> radius;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0xF8")]
		internal readonly List<float> radiusSpace;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x100")]
		internal readonly List<float> roundCaps;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x108")]
		internal readonly List<float> scaleMode;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x110")]
		internal readonly List<float> thickness;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x118")]
		internal readonly List<float> thicknessSpace;
	}
}
