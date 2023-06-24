using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200031B RID: 795
	[Token(Token = "0x200031B")]
	public class Cylinder3d
	{
		// Token: 0x06001ACB RID: 6859 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001ACB")]
		[Address(RVA = "0x1F31C00", Offset = "0x1F30200", VA = "0x181F31C00")]
		public Cylinder3d(Line3d axis, double radius, double height)
		{
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001ACC")]
		[Address(RVA = "0x1F31C30", Offset = "0x1F30230", VA = "0x181F31C30")]
		public Cylinder3d(Vector3d center, Vector3d axis, double radius, double height)
		{
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001ACD")]
		[Address(RVA = "0x1F31C80", Offset = "0x1F30280", VA = "0x181F31C80")]
		public Cylinder3d(Frame3f frame, double radius, double height, int nNormalAxis = 1)
		{
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001ACE")]
		[Address(RVA = "0x1F31DC0", Offset = "0x1F303C0", VA = "0x181F31DC0")]
		public Cylinder3d(double radius, double height)
		{
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x00013604 File Offset: 0x00011804
		[Token(Token = "0x170003FC")]
		public double Circumference
		{
			[Token(Token = "0x6001ACF")]
			[Address(RVA = "0x1F31E70", Offset = "0x1F30470", VA = "0x181F31E70")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x0001361C File Offset: 0x0001181C
		[Token(Token = "0x170003FD")]
		public double Diameter
		{
			[Token(Token = "0x6001AD0")]
			[Address(RVA = "0x1F31E80", Offset = "0x1F30480", VA = "0x181F31E80")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x00013634 File Offset: 0x00011834
		[Token(Token = "0x170003FE")]
		public double Volume
		{
			[Token(Token = "0x6001AD1")]
			[Address(RVA = "0x1F31E90", Offset = "0x1F30490", VA = "0x181F31E90")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x04000E0B RID: 3595
		[Token(Token = "0x4000E0B")]
		[FieldOffset(Offset = "0x10")]
		public Line3d Axis;

		// Token: 0x04000E0C RID: 3596
		[Token(Token = "0x4000E0C")]
		[FieldOffset(Offset = "0x40")]
		public double Radius;

		// Token: 0x04000E0D RID: 3597
		[Token(Token = "0x4000E0D")]
		[FieldOffset(Offset = "0x48")]
		public double Height;
	}
}
