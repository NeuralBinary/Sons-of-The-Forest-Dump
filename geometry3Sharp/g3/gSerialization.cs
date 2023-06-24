using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000190 RID: 400
	[Token(Token = "0x2000190")]
	public static class gSerialization
	{
		// Token: 0x06000ACF RID: 2767 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x20041F0", Offset = "0x20027F0", VA = "0x1820041F0")]
		public static void Store(Vector2f v, BinaryWriter writer)
		{
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x2004250", Offset = "0x2002850", VA = "0x182004250")]
		public static void Restore(ref Vector2f v, BinaryReader reader)
		{
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x20042B0", Offset = "0x20028B0", VA = "0x1820042B0")]
		public static void Store(Vector2d v, BinaryWriter writer)
		{
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x2004310", Offset = "0x2002910", VA = "0x182004310")]
		public static void Restore(ref Vector2d v, BinaryReader reader)
		{
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x2004370", Offset = "0x2002970", VA = "0x182004370")]
		public static void Store(Vector3f v, BinaryWriter writer)
		{
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x20043E0", Offset = "0x20029E0", VA = "0x1820043E0")]
		public static void Restore(ref Vector3f v, BinaryReader reader)
		{
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x2004460", Offset = "0x2002A60", VA = "0x182004460")]
		public static void Store(Vector3d v, BinaryWriter writer)
		{
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x20044D0", Offset = "0x2002AD0", VA = "0x1820044D0")]
		public static void Restore(ref Vector3d v, BinaryReader reader)
		{
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x2004550", Offset = "0x2002B50", VA = "0x182004550")]
		public static void Store(Quaternionf q, BinaryWriter writer)
		{
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x20045E0", Offset = "0x2002BE0", VA = "0x1820045E0")]
		public static void Restore(ref Quaternionf q, BinaryReader reader)
		{
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x2004680", Offset = "0x2002C80", VA = "0x182004680")]
		public static void Store(Frame3f vFrame, BinaryWriter writer)
		{
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x20047B0", Offset = "0x2002DB0", VA = "0x1820047B0")]
		public static void Restore(ref Frame3f vFrame, BinaryReader reader)
		{
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x2004990", Offset = "0x2002F90", VA = "0x182004990")]
		public static void Store(AxisAlignedBox2d b, BinaryWriter writer)
		{
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x2004A60", Offset = "0x2003060", VA = "0x182004A60")]
		public static void Restore(ref AxisAlignedBox2d b, BinaryReader reader)
		{
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x2004B30", Offset = "0x2003130", VA = "0x182004B30")]
		public static void Store(List<int> values, BinaryWriter writer)
		{
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x2004BF0", Offset = "0x20031F0", VA = "0x182004BF0")]
		public static void Restore(List<int> values, BinaryReader reader)
		{
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x2004CE0", Offset = "0x20032E0", VA = "0x182004CE0")]
		public static void Store(List<float> values, BinaryWriter writer)
		{
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x2004DA0", Offset = "0x20033A0", VA = "0x182004DA0")]
		public static void Restore(List<float> values, BinaryReader reader)
		{
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x2004E90", Offset = "0x2003490", VA = "0x182004E90")]
		public static void Store(List<double> values, BinaryWriter writer)
		{
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x2004F50", Offset = "0x2003550", VA = "0x182004F50")]
		public static void Restore(List<double> values, BinaryReader reader)
		{
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x2005040", Offset = "0x2003640", VA = "0x182005040")]
		public static void Store(DCurve3 curve, BinaryWriter writer)
		{
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x2005250", Offset = "0x2003850", VA = "0x182005250")]
		public static void Restore(DCurve3 curve, BinaryReader reader)
		{
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x20053F0", Offset = "0x20039F0", VA = "0x1820053F0")]
		public static void Store(PolyLine2d polyline, BinaryWriter writer)
		{
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x2005580", Offset = "0x2003B80", VA = "0x182005580")]
		public static void Restore(PolyLine2d polyline, BinaryReader reader)
		{
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x2005650", Offset = "0x2003C50", VA = "0x182005650")]
		public static void Store(Polygon2d polygon, BinaryWriter writer)
		{
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x20057E0", Offset = "0x2003DE0", VA = "0x1820057E0")]
		public static void Restore(Polygon2d polygon, BinaryReader reader)
		{
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x2005940", Offset = "0x2003F40", VA = "0x182005940")]
		public static void Store(GeneralPolygon2d polygon, BinaryWriter writer)
		{
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x2005B40", Offset = "0x2004140", VA = "0x182005B40")]
		public static void Restore(GeneralPolygon2d polygon, BinaryReader reader)
		{
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x2005C80", Offset = "0x2004280", VA = "0x182005C80")]
		public static void Store(Segment2d segment, BinaryWriter writer)
		{
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x2005D30", Offset = "0x2004330", VA = "0x182005D30")]
		public static void Restore(ref Segment2d segment, BinaryReader reader)
		{
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x2005DE0", Offset = "0x20043E0", VA = "0x182005DE0")]
		public static void Store(Arc2d arc, BinaryWriter writer)
		{
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x2005EB0", Offset = "0x20044B0", VA = "0x182005EB0")]
		public static void Restore(ref Arc2d arc, BinaryReader reader)
		{
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x2005FC0", Offset = "0x20045C0", VA = "0x182005FC0")]
		public static void Store(Circle2d circle, BinaryWriter writer)
		{
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x2006050", Offset = "0x2004650", VA = "0x182006050")]
		public static void Restore(ref Circle2d circle, BinaryReader reader)
		{
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x2006120", Offset = "0x2004720", VA = "0x182006120")]
		public static void Store(ParametricCurveSequence2 sequence, BinaryWriter writer)
		{
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x20063E0", Offset = "0x20049E0", VA = "0x1820063E0")]
		public static void Restore(ref ParametricCurveSequence2 sequence, BinaryReader reader)
		{
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x2006540", Offset = "0x2004B40", VA = "0x182006540")]
		public static void Store(IParametricCurve2d curve, BinaryWriter writer)
		{
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x20069C0", Offset = "0x2004FC0", VA = "0x1820069C0")]
		public static void Restore(out IParametricCurve2d curve, BinaryReader reader)
		{
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x2007060", Offset = "0x2005660", VA = "0x182007060")]
		public static void Store(PlanarSolid2d solid, BinaryWriter writer)
		{
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x20072D0", Offset = "0x20058D0", VA = "0x1820072D0")]
		public static void Restore(PlanarSolid2d solid, BinaryReader reader)
		{
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x20074E0", Offset = "0x2005AE0", VA = "0x1820074E0")]
		public static void Store(DMesh3 mesh, BinaryWriter writer)
		{
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x2007720", Offset = "0x2005D20", VA = "0x182007720")]
		public static void Restore(DMesh3 mesh, BinaryReader reader)
		{
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x2007D20", Offset = "0x2006320", VA = "0x182007D20")]
		public static void Store(DVector<double> vec, BinaryWriter writer)
		{
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x2008030", Offset = "0x2006630", VA = "0x182008030")]
		public static void Restore(DVector<double> vec, BinaryReader reader)
		{
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x2008120", Offset = "0x2006720", VA = "0x182008120")]
		public static void Store(DVector<float> vec, BinaryWriter writer)
		{
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x2008430", Offset = "0x2006A30", VA = "0x182008430")]
		public static void Restore(DVector<float> vec, BinaryReader reader)
		{
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x2008520", Offset = "0x2006B20", VA = "0x182008520")]
		public static void Store(DVector<int> vec, BinaryWriter writer)
		{
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x2008830", Offset = "0x2006E30", VA = "0x182008830")]
		public static void Restore(DVector<int> vec, BinaryReader reader)
		{
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x2008920", Offset = "0x2006F20", VA = "0x182008920")]
		public static void Store(DVector<short> vec, BinaryWriter writer)
		{
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x2008C30", Offset = "0x2007230", VA = "0x182008C30")]
		public static void Restore(DVector<short> vec, BinaryReader reader)
		{
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x2008D10", Offset = "0x2007310", VA = "0x182008D10")]
		public static void Store(string s, BinaryWriter writer)
		{
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x2008DA0", Offset = "0x20073A0", VA = "0x182008DA0")]
		public static void Restore(ref string s, BinaryReader reader)
		{
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x2008E70", Offset = "0x2007470", VA = "0x182008E70")]
		public static void Store(string[] s, BinaryWriter writer)
		{
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x2008F90", Offset = "0x2007590", VA = "0x182008F90")]
		public static void Restore(ref string[] s, BinaryReader reader)
		{
		}

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		[FieldOffset(Offset = "0x0")]
		public static int DMesh3Version;
	}
}
