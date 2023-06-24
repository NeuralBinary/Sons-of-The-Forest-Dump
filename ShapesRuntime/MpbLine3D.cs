using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	internal class MpbLine3D : MetaMpb, IDashableMpb
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x1700017C")]
		private List<float> dashOffset
		{
			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0xA3F1B0", Offset = "0xA3D7B0", VA = "0x180A3F1B0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x1700017D")]
		private List<float> dashShapeModifier
		{
			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0xA3F220", Offset = "0xA3D820", VA = "0x180A3F220", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x1700017E")]
		private List<float> dashSize
		{
			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x8DF480", Offset = "0x8DDA80", VA = "0x1808DF480", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x1700017F")]
		private List<float> dashSnap
		{
			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x8DF4F0", Offset = "0x8DDAF0", VA = "0x1808DF4F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000180")]
		private List<float> dashSpace
		{
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x8DF560", Offset = "0x8DDB60", VA = "0x1808DF560", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000181")]
		private List<float> dashSpacing
		{
			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x6913C0", Offset = "0x68F9C0", VA = "0x1806913C0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x17000182")]
		private List<float> dashType
		{
			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x1359C20", Offset = "0x1358220", VA = "0x181359C20", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x2A3C570", Offset = "0x2A3AB70", VA = "0x182A3C570", Slot = "5")]
		protected override void TransferShapeProperties()
		{
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x2A3C690", Offset = "0x2A3AC90", VA = "0x182A3C690")]
		public MpbLine3D()
		{
		}

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0xC0")]
		internal readonly List<Vector4> colorEnd;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0xC8")]
		internal readonly List<Vector4> pointEnd;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0xD0")]
		internal readonly List<Vector4> pointStart;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0xD8")]
		internal readonly List<float> scaleMode;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0xE0")]
		internal readonly List<float> thickness;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0xE8")]
		internal readonly List<float> thicknessSpace;
	}
}
