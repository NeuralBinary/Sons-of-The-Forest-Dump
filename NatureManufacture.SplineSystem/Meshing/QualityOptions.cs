using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Meshing
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public class QualityOptions
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00002DD8 File Offset: 0x00000FD8
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000073")]
		public double MaximumAngle
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x1240170", Offset = "0x123E770", VA = "0x181240170")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x1240180", Offset = "0x123E780", VA = "0x181240180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00002DF0 File Offset: 0x00000FF0
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000074")]
		public double MinimumAngle
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x5FD5E0", Offset = "0x5FBBE0", VA = "0x1805FD5E0")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x24D0860", Offset = "0x24CEE60", VA = "0x1824D0860")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00002E08 File Offset: 0x00001008
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000075")]
		public double MaximumArea
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000076")]
		public Func<ITriangle, double, bool> UserTest
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00002E20 File Offset: 0x00001020
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000077")]
		public bool VariableArea
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00002E38 File Offset: 0x00001038
		// (set) Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000078")]
		public int SteinerPoints
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x1D0C360", Offset = "0x1D0A960", VA = "0x181D0C360")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public QualityOptions()
		{
		}
	}
}
